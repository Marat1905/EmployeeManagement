using EmployeeManagement.Models;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeManagement.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для EmploeesView.xaml
    /// </summary>
    public partial class EmploeesView : Window
    {
        public EmploeesView()
        {
            InitializeComponent();
        }

        private void ListView_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if(item is null)
                return;

            var employee = item as Employee;
            MessageBox.Show(employee.FirstName);
        }
    }
}
