using Business.Abstract;
using Business.Concrete;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        IUserService _userService = new UserManager(new EfUserDal());
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            rdbStudent.Tag = 1;
            rdbTeacher.Tag = 2;
            LoadUser();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            _userService.Add(new User
            {
                UserName = tbxName.Text,
                UserPassword = tbxPassword.Text,
                UserDepartment = tbxDepartment.Text,
                UserType = sellectType
            });

            MessageBox.Show("Kullanıcı Eklendi!");
            LoadUser();
        }

        private void LoadUser()
        {
            dgwSignUp.DataSource = _userService.GetAll();
        }

        private int sellectType;
        private void rdbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStudent.Checked && rdbStudent != null)
            {
                sellectType = (int)rdbStudent.Tag;
            }
        }

        private void rdbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTeacher.Checked && rdbTeacher != null)
            {
                sellectType = (int)rdbTeacher.Tag;
            }
        }

        private void btnrRemove_Click(object sender, EventArgs e)
        {
            if (dgwSignUp.CurrentRow != null)
            {
                try
                {
                    _userService.Delete(new User
                    {
                       UserId = Convert.ToInt32(dgwSignUp.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    LoadUser();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }
}
