using Suplex.Security.AclModel;
using System;
using System.Windows.Forms;

namespace SuplexSampleApp
{
    public static class UIExtensions
    {
        public static void UiThreadHelper(this Control control, Action code)
        {
            if( control.InvokeRequired )
                control.BeginInvoke( code );
            else
                code.Invoke();
        }

        public static void ApplySecurity(this Control control, ISecureObject secureObject)
        {
            if( secureObject == null )
            {
                control.Visible = false;
                return;
            }

            ISecureObject found = secureObject.UniqueName.Equals( control.Name, StringComparison.OrdinalIgnoreCase ) ?
                secureObject : secureObject.FindChild<ISecureObject>( control.Name );

            if( found != null && found.Security.Results.ContainsRightType( typeof( UIRight ) ) )
            {
                control.Visible = found.Security.Results.GetByTypeRight( UIRight.Visible ).AccessAllowed;
                control.Enabled = found.Security.Results.GetByTypeRight( UIRight.Enabled ).AccessAllowed;
                if( control is TextBox textBox )
                    textBox.ReadOnly = !found.Security.Results.GetByTypeRight( UIRight.Operate ).AccessAllowed;
            }

            if( control.HasChildren )
                foreach( Control child in control.Controls )
                    child.ApplySecurity( secureObject );
        }
    }
}