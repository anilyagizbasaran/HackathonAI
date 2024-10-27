using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidnowsFormsUI
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        IUserService _userService= new UserManager(new EfUserDal());

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Authenticate(new User
                {
                    UserName = tbxUserName.Text,
                    UserPassword = tbxPassword.Text
                });
            }
            catch (Exception exception)
            {

                if (exception.Message == "Login1")
                {
                    // Kullanıcı türü 1 için Form1'e geçiş
                    StudentMenuForm studentMenuForm = new StudentMenuForm();
                    studentMenuForm.Show();
                    this.Hide();
                }
                else if (exception.Message == "Login2")
                {
                    // Kullanıcı türü 2 için Form2'ye geçiş
                    TeacherMenuForm teacherMenuForm = new TeacherMenuForm();
                    teacherMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    // Diğer hata durumlarında kullanıcıya mesaj gösteriliyor
                    MessageBox.Show(exception.Message);
                }
            }
           
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
