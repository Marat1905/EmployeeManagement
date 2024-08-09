using EmployeeManagement.Data.Repository;
using EmployeeManagement.Models;
using System.Collections.ObjectModel;

namespace EmployeeManagement.ViewModels
{
    public class EmployeesViewModel
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeesViewModel()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public ObservableCollection<Employee> Employees { get { return new ObservableCollection<Employee>(_employeeRepository.GetAll()); } }
    }
}
