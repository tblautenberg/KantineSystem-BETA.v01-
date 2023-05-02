using System.Windows.Forms;

namespace KantineSystem__BETA.v01_
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        // ADDING THE DIFFRENT PRICES FOR MENUITEMS

        int MenuItem1Price = 30;
        int MenuItem2Price = 25;
        int MenuItem3Price = 15;
        int MenuItem4Price = 10;

        // TOTAL AMOUNT THAT SHOULD BE PAYIED (0 FOR REFERENCE)

        int amountToPay = 0;

        // DEFINING THE BUTTONS ON THE MAIN ORDERING SCREEN //
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            amountToPay += MenuItem1Price;
            DisplayMenuAdd.AppendText("Du har nu tilføjet 1x dagens ret til din menu.");
            DisplayMenuAdd.AppendText("\n");
            DisplayTotalAmount.Text = "Beløbet der skal betales: " + (amountToPay) + ",-";
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            amountToPay += MenuItem2Price;
            DisplayMenuAdd.AppendText("Du har nu tilføjet 1x salatbar til din menu.");
            DisplayMenuAdd.AppendText("\n");
            DisplayTotalAmount.Text = "Beløbet der skal betales: " + amountToPay + ",-";
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            amountToPay += MenuItem3Price;
            DisplayMenuAdd.AppendText("Du har nu tilføjet 1x smørrebrød til din menu.");
            DisplayMenuAdd.AppendText("\n");
            DisplayTotalAmount.Text = "Beløbet der skal betales: " + (amountToPay) + ",-";
        }

        private void MenuItem4_Click(object sender, EventArgs e)
        {
            amountToPay += MenuItem4Price;
            DisplayMenuAdd.AppendText("Du har nu tilføjet 1x sodavand til din menu.");
            DisplayMenuAdd.AppendText("\n");
            DisplayTotalAmount.Text = "Beløbet der skal betales: " + (amountToPay) + ",-";
        }

        private void MenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem8_Click(object sender, EventArgs e)
        {

        }

        // DEFINING THE TEXTBOXES THAT HOLDS THE ADD VALUE AND TOTAL VALUE

        private void DisplayMenuAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        // ADDING BUTTONS TO CONFIRM / CANCEL / LOGOUT OF THE APPLICATION
        private void ApproveOrder_Click(object sender, EventArgs e)
        {
            DialogResult Approve = MessageBox.Show("Vil du godkende bestillingen på " + amountToPay + ",- ?", "Godkend køb", MessageBoxButtons.YesNo);

            if (Approve == DialogResult.Yes)
            {
                MessageBox.Show("Dit køb er godkendt og trukket fra dit personalekort. Hav en god dag!");
            }
            else
            {
                MessageBox.Show("Dit køb er annuleret. Hav en god dag!");
                this.Close();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult LogOut = MessageBox.Show("Ønsker du at logge ud af systemet?", "Log ud", MessageBoxButtons.YesNo);

            if (LogOut == DialogResult.Yes)
            {
                MessageBox.Show("Du er nu logget ud af systemet");
                this.Close();
            }
            else
            {
                MessageBox.Show("Du kan nu vende tilbage til at anvende systemet. Dine tidligere oplysninger er gemt");
            }
        }

        private void RestartOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Din bestlling er nu slettet. Du er ikke logget ud, og kan bruge systemet som før");
            DisplayMenuAdd.Clear();
            DisplayTotalAmount.Clear();
            amountToPay = 0;
        }
    }
}