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
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using labf;

namespace labf


{
    public partial class StudentCoursesForm : Window
    {
        private ObservableCollection<StudentsForm> students;
        private ObservableCollection<MainWindow> courses;

        public StudentCoursesForm()
        {
            InitialzeComponent();

        }

        private void SearchStudentsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchStudentsTextBox.Text.ToLower();
            studentsDataGrid.ItemsSource = students
                .Where(s => s.StudentName.ToLower().Contains(searchText) ||
                            s.StudentId.ToLower().Contains(searchText))
                .ToList();
        }

        private void SearchCoursesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchCoursesTextBox.Text.ToLower();
            coursesDataGrid.ItemsSource = courses
                .Where(c => c.CourseName.ToLower().Contains(searchText) ||
                            c.CourseCode.ToLower().Contains(searchText))
                .ToList();
        }
    }
}
