using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Suplex.Security.AclModel;
using Suplex.Security.Principal;


namespace SuplexSampleApp
{
    public partial class MainDlg : Form
    {
        EmployeeDataAccessLayer _employeeDal = null;
        FileSystemDal _suplexDal = new FileSystemDal();
        FileSystemWatcher _filestoreWatcher;

        #region ctor
        public MainDlg()
        {
            InitializeComponent();
        }
        #endregion


        #region Connect to FileStore; Refresh Dal, Bindings
        /// <summary>
        /// Browse to a Suplex FileStore
        /// </summary>
        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if( dlgOpenSuplexFileStore.ShowDialog() == DialogResult.OK )
            {
                txtSuplexFileStorePath.Text = dlgOpenSuplexFileStore.FileName;
                InitFileConnection( txtSuplexFileStorePath.Text );

                cmbUsers.Focus();
            }
        }

        /// <summary>
        /// Allows the user to manually refresh the dialog, such as if the path was manually edited
        /// </summary>
        private void cmdRefreshNow_Click(object sender, EventArgs e)
        {
            if( File.Exists( txtSuplexFileStorePath.Text ) )
                InitFileConnection( txtSuplexFileStorePath.Text );
        }

        /// <summary>
        /// Initializes a file watcher on the Suplex file store; refreshes the dialog when the file changes
        /// </summary>
        /// <param name="filestorePath">The path to a Suplex FileStore</param>
        void InitFileConnection(string filestorePath)
        {
            string folder = Path.GetDirectoryName( filestorePath );
            string file = Path.GetFileName( filestorePath );
            _filestoreWatcher = new FileSystemWatcher( folder, file );
            _filestoreWatcher.Changed += FilestoreWatcher_Changed;
            _filestoreWatcher.EnableRaisingEvents = true;

            //Initial data load
            RefreshSuplex( filestorePath );
        }

        /// <summary>
        /// Attempts to open the file and refresh the dialog.
        /// </summary>
        void FilestoreWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            int attempts = 0;
            while( attempts++ < 5 )
                try
                {
                    RefreshSuplex( e.FullPath );
                    break;
                }
                catch { System.Threading.Thread.Sleep( 100 ); }
        }

        /// <summary>
        /// Loads the specified file into a Suplex FileSystemDal and refreshes the dialog
        /// </summary>
        /// <param name="filestorePath"></param>
        void RefreshSuplex(string filestorePath)
        {
            _suplexDal = FileSystemDal.LoadFromYamlFile( filestorePath );
            _employeeDal = new EmployeeDataAccessLayer( _suplexDal );

            this.UiThreadHelper( () => lstErrors.Items.Clear() );
            this.UiThreadHelper( () => cmbUsers.DataSource = new BindingSource( _suplexDal.Store.Users.OrderBy( u => u.Name ).ToList(), null ).DataSource );
        }
        #endregion



        #region Apply Security
        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentUser = ((User)cmbUsers.SelectedItem).Name;

            //set the "current user" on the Employees DAL
            _employeeDal.CurrentUser = currentUser;

            try
            {
                lstEmployees.DisplayMember = "Name";
                lstEmployees.Items.Clear();
                List<Employee> employees = _employeeDal.GetEmployees()?.OrderBy( emps => emps.Name ).ToList();
                if( employees != null )
                    foreach( Employee employee in employees )
                        lstEmployees.Items.Add( employee );
                else
                    lstEmployees.Items.Clear();
            }
            catch( Exception ex )
            {
                lstErrors.Items.Insert( 0, ex.Message );
            }

            //Evaluate the security information, starting from the top-most control
            SecureObject secureObject = (SecureObject)_suplexDal.EvalSecureObjectSecurity( "frmEditor", currentUser );

            ApplyRecursive( secureObject );

            //alternate, manual method (not preferred)
            //ApplyDirect( secureObject );
        }

        /// <summary>
        /// Brute-force permissioning - direct lookup of results with "known" translation of non-UI rights
        /// </summary>
        /// <param name="secureObject">A reference to the resolved/evaluated security object.</param>
        void ApplyDirect(SecureObject secureObject)
        {
            frmEditor.Visible = secureObject?.Security.Results.GetByTypeRight( UIRight.Visible ).AccessAllowed ?? false;
            lblEmployeeId.Visible = secureObject?.FindChild<SecureObject>( "txtId" ).Security.Results.GetByTypeRight( UIRight.Visible ).AccessAllowed ?? false;
            btnUpdate.Enabled = secureObject?.FindChild<SecureObject>( "btnCreate" ).Security.Results.GetByTypeRight( RecordRight.Insert ).AccessAllowed ?? false;
        }

        void ApplyRecursive(SecureObject secureObject)
        {
            frmEditor.ApplySecurity( secureObject );
        }
        #endregion


        #region form actions
        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Employee selected = (Employee)lstEmployees.SelectedItem;
                Employee employee = _employeeDal.GetEmployee( selected?.Id ?? 0 );
                if( employee != null )
                {
                    frmEditor.Tag = employee;
                    lblEmployeeId.Text = employee.Id.ToString();
                    txtName.Text = employee.Name;
                }
                else
                {
                    lblEmployeeId.Text = txtName.Text = string.Empty;
                }
            }
            catch( Exception ex )
            {
                lstErrors.Items.Insert( 0, ex.Message );
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if( frmEditor.Tag is Employee employee )
            {
                try
                {
                    employee.Name = txtName.Text;
                    Employee updated = _employeeDal.UpdateEmployee( employee );
                    if( updated != null )
                        lstEmployees.Items[lstEmployees.SelectedIndex] = updated;
                }
                catch( Exception ex )
                {
                    lstErrors.Items.Insert( 0, ex.Message );
                }
            }
        }
        #endregion
    }
}