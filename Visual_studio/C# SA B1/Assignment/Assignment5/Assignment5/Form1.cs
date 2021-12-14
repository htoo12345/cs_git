using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form                                                                               
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string comfirmPassword = txtComfirmPassword.Text;
            string genMale = chkMale.Text;
            string genFemale=chkFemale.Text;
            string phone = txtPhone.Text;
            string address=txtAddress.Text;

            InformationOfUserGUI userGUI= new InformationOfUserGUI();
            userGUI.Show();
        }
    }
}
