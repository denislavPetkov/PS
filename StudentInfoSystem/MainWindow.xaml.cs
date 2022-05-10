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
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool executeOnChange = true;

        public MainWindow()
        {
            InitializeComponent();
            executeOnChange = true;
        }

        public MainWindow(UserLogin.Student currentStudent)
        {
            InitializeComponent();

            this.DataContext = currentStudent;

            var uriSource = new Uri(@"/StudentInfoSystem;component/Images/" + currentStudent.GetNames() + ".png", UriKind.Relative);
            studentPicture.Source = new BitmapImage(uriSource);

            firstName.IsEnabled = false;
            middleName.IsEnabled = false;
            lastName.IsEnabled = false;
       
            executeOnChange = false;
        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {   
            if (executeOnChange)
            SetStudentInformation();
        }

        private void MiddleName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (executeOnChange)
                SetStudentInformation();
        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (executeOnChange)
                SetStudentInformation();
        }

        private void SetStudentInformation()
        {
            UserLogin.Student currentStudent = GetStudent();

            if (currentStudent != null)
            {
                var uriSource = new Uri(@"/StudentInfoSystem;component/Images/" + currentStudent.GetNames() + ".png", UriKind.Relative);
                studentPicture.Source = new BitmapImage(uriSource);
            } else
            {
                // so we don't override the names in the form 
                currentStudent = new UserLogin.Student(firstName.Text, middleName.Text, lastName.Text);
                studentPicture.Source = null;
            }

            this.DataContext = currentStudent;
        }


        private UserLogin.Student GetStudent()
        {
            return UserLogin.StudentData.GetStudentByNames(firstName.Text, middleName.Text, lastName.Text);
        }

     
    }
}
