using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace KantineSystem__BETA.v01_
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        // SETTING  THE TEXT FIELD FOR THE LOGIN AND PASSWORD GUIDES FORM USER


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // ADDING THE LOGIN FIELDS FOR USERINPUT

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        // ADDING LOGIN AND ASSISTANCE BUTTONS

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "123" && PasswordBox.Text == "admin")
            {
                var mainForm = new MainScreen();
                mainForm.Show();
            }
            else
            {
                DialogResult FailedLogin = MessageBox.Show("Du har anvendt et forkert kodeord eller burger navn. Vil du prøve igen?", "Prøv igen", MessageBoxButtons.YesNo);

                if (FailedLogin == DialogResult.Yes)
                {
                }
                else
                {
                    MessageBox.Show("Du er nu logget helt af systemet.");
                }
            }
        }

        private void GetAssistanceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
