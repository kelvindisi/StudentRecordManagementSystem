using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using StudentRecordManagementSystem.Exceptions;
using DataAccess;
using DataAccess.Models;

namespace StudentRecordManagementSystem
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new 
                ColorScheme(Primary.Blue900, Primary.Blue700, 
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                StaffAuthModel staff;
                validateUserInput();
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                staff = StaffAuthenticationManager.loginStaff(email, password);
                MainForm main = new MainForm();
                main.staff = staff;
                main.loginForm = this;
                this.Hide();
                main.Show();
            }catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void validateUserInput()
        {
            if (txtEmail.Text.Length < 5)
                throw new InvalidInputException("email");
            if (txtPassword.Text.Length < 4)
                throw new InvalidInputException("Password", 4);
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void clearInput()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}
