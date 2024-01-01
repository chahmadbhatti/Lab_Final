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



using labf;

public partial class MainWindow : Window
{
    private YourDatabaseContext dbContext;

    public MainWindow()
    {
        InitializeComponent();

        dbContext = new YourDatabaseContext();
        courseDataGrid.ItemsSource = dbContext.Courses.ToList();
        studentDataGrid.ItemsSource = dbContext.Students.ToList();
    }

    private void AddCourse_Click(object sender, RoutedEventArgs e)
    {
        string courseName = courseNameTextBox.Text;
        int credits = int.Parse(creditsTextBox.Text);
        courseDataGrid.ItemsSource = dbContext.Courses.ToList();
    }
}


