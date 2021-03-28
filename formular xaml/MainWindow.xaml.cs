using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace formular_xaml
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Employee> list = new List<Employee>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add(new Employee(name.Text, surname.Text, Convert.ToInt32(year.Text), (Employee.education)level.SelectedIndex, job.Text, Convert.ToInt32(salary.Text)));
        }
    }
    class Person
    {
        public string name;
        public string surname;
        public int yearBirth;

        public Person() { }
        public Person(string Name, string Surname, int year)
        {
            name = Name;
            surname = Surname;
            yearBirth = year;
        }
    }

    class Employee : Person
    {
        public enum education { zakladni, stredni, vyssi }
        public education vzdelani;
        public string job;
        public int salary;
        public Employee() { }
        public Employee(string name, string surname, int year, education Education, string Job, int Salary) : base(name, surname, year)
        {
            vzdelani = Education;
            job = Job;
            salary = Salary;
        }
    }

}
