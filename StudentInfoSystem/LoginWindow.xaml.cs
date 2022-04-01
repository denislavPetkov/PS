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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            String username = UsernameTextBox.Text.ToString();
            String password = PasswordTextBox.Text.ToString();

            UserLogin.UserRoles userRole = UserLogin.LoginValidator.Authenticate(username, password, null);

            if (userRole == UserLogin.UserRoles.STUDENT)
            {
                Student student = StudentValidation.GetStudentDataByUser(UserLogin.LoginValidator.currentUser);
                new MainWindow(student).Show();
            }
            if (userRole == UserLogin.UserRoles.INSPECTOR)
            {
                new StudentListWindow(StudentData.TestStudents).Show();
            }
        }

        private void NoLoginButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
