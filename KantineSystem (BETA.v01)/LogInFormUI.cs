using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantineSystem__BETA.v01_
{
    public partial class LogInFormUI : Form
    {
        public LogInFormUI()
        {
            InitializeComponent();
        }

        // USERNAME AND PASSWORD BOX
        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        // LOGIN BUTTON


        // SQL FOR BUTTON

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Weronika" && PasswordText.Text == "admin123")
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
                    MessageBox.Show("Systemet vil nu lukke.");
                }
            }
        }
        // UNUSED EVENTS
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
