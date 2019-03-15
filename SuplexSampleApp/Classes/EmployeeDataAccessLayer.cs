using System;
using System.Linq;
using System.Collections.Generic;

using Suplex.Security.DataAccess;
using Suplex.Security.AclModel;

namespace SuplexSampleApp
{
    /// <summary>
    /// Sample DAL to show security implementation.
    /// </summary>
    public class EmployeeDataAccessLayer
    {
        ISuplexDal _suplexDal = null;
        List<Employee> _employees = null;

        public EmployeeDataAccessLayer(ISuplexDal suplexDal)
        {
            //init Suplex DAL instance
            _suplexDal = suplexDal;

            //create some Employees
            _employees = new List<Employee>
            {
                { new Employee( 1 ) { Name = "Irma Tahnee" } },
                { new Employee( 2 ) { Name = "Cat Maxwell" } },
                { new Employee( 3 ) { Name = "Krystelle Padma" } },
                { new Employee( 4 ) { Name = "Louis Zola" } },
                { new Employee( 5 ) { Name = "Esmaralda Grahame" } }
            };
        }

        /// <summary>
        /// "Current user context" - normally this would be pulled from the environment as a local or web current user context
        /// </summary>
        public string CurrentUser { get; set; }

        /// <summary>
        /// Utility method to validate security access for a given right on Employee records
        /// </summary>
        /// <param name="recordRight">The right for which to validate access</param>
        void HasAccessOrException(RecordRight recordRight)
        {
            //Look up security information by SecureObject->UniqueName => "EmployeeRecords" for the CurrentUser
            SecureObject employeeSecurity = (SecureObject)_suplexDal.EvalSecureObjectSecurity( "EmployeeRecords", CurrentUser );

            //Assess AccessAllowed, throw Exception if no rights
            if( !employeeSecurity.Security.Results.GetByTypeRight( recordRight ).AccessAllowed )
                throw new Exception( $"You do not have rights to {recordRight} Employee records." );
        }

        /// <summary>
        /// Get the Employees list
        /// </summary>
        /// <param name="filter">Optional Name filter</param>
        /// <returns>All or matching Employees</returns>
        public List<Employee> GetEmployees(string filter = null)
        {
            //Check for access rights, throws exception if denied
            HasAccessOrException( RecordRight.List );

            if( !string.IsNullOrWhiteSpace( filter ) )
                return _employees.FindAll( e => e.Name.Contains( filter ) );
            else
                return _employees;
        }

        /// <summary>
        /// Get an Employee by Id
        /// </summary>
        /// <param name="id">The Employee Id to find</param>
        /// <returns>The Employee record if found, or null</returns>
        public Employee GetEmployee(int id)
        {
            //Check for access rights, throws exception if denied
            HasAccessOrException( RecordRight.Select );

            return _employees.FirstOrDefault( e => e.Id == id );
        }

        /// <summary>
        /// Create a new Employee record and insert it in the store
        /// </summary>
        /// <param name="name">The Name for the new Employee</param>
        /// <returns>The new Employee record, initialized with an Id</returns>
        public Employee CreateEmployee(string name)
        {
            //Check for access rights, throws exception if denied
            HasAccessOrException( RecordRight.Insert );

            int id = _employees?.Count > 0 ? _employees[_employees.Count].Id : 0;

            Employee emp = new Employee( ++id ) { Name = name };
            _employees.Add( emp );

            return emp;
        }

        /// <summary>
        /// Finds Employee by Id and updates the fields
        /// </summary>
        /// <param name="emp">The Employee record to find (by Id)</param>
        /// <returns>The updated Employee record if found, or null</returns>
        public Employee UpdateEmployee(Employee emp)
        {
            //Check for access rights, throws exception if denied
            HasAccessOrException( RecordRight.Update );

            if( emp == null )
                return null;

            Employee found = _employees.FirstOrDefault( e => e.Id == emp.Id );
            if( found != null )
                found.Name = emp.Name;

            return found;
        }

        /// <summary>
        /// Delete an Employee record by Id
        /// </summary>
        /// <param name="id">The Employee Id to find</param>
        /// <returns>True if Employee is found, false otherwise</returns>
        public bool DeleteEmployee(int id)
        {
            //Check for access rights, throws exception if denied
            HasAccessOrException( RecordRight.Delete );

            if( id <= 0 )
                return false;

            int index = _employees.FindIndex( e => e.Id == id );
            if( index > 0 )
                _employees.RemoveAt( index );

            return index > 0;
        }
    }
}