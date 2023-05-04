using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
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

            // TRYING TO FIX CONNECTION STRING TO ADD USERNAME/PASSWORD TO MYSQL DATABASE


            // HERE ENDS THE WORK OF THE MYSQL BETA

            if (UsernameBox.Text == "Weronika" && PasswordBox.Text == "admin123")
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

        private void GetAssistanceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
