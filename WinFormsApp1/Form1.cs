namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            agelabel.Visible = false;
            acceptpwlabel.Visible = false;
            acceptcodelabel.Visible = false;

            agetxtbox.KeyPress += Agetxtbox_KeyPress;

            pwtxtbox.PasswordChar = '*';
            cpwtxtbox.PasswordChar = '*';
        }

        private void Agetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void proccessbtn_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int birthYear;
            bool allValid = true;

            agelabel.Visible = true;
            acceptpwlabel.Visible = true;
            acceptcodelabel.Visible = true;

            bool validBirthYear = int.TryParse(agetxtbox.Text, out birthYear);

            if (!validBirthYear || birthYear > currentYear || birthYear < 1900)
            {
                agelabel.Text = "Age = Invalid birth year";
                agelabel.ForeColor = Color.Red;
                allValid = false;
            }
            else
            {
                int age = currentYear - birthYear;
                agelabel.Text = "Age = " + age;
                agelabel.ForeColor = Color.Green;
            }

            if (pwtxtbox.Text != cpwtxtbox.Text)
            {
                acceptpwlabel.Text = "Password does not match";
                acceptpwlabel.ForeColor = Color.Red;
                allValid = false;
            }
            else
            {
                acceptpwlabel.Text = "Password Accepted";
                acceptpwlabel.ForeColor = Color.Green;
            }

            if (groupcodetxtbox.Text == "UCC2025" &&
               (invitecodetxtbox.Text == "PROMO1225" || invitecodetxtbox.Text == "PROMO2025"))
            {
                acceptcodelabel.Text = "Code Accepted";
                acceptcodelabel.ForeColor = Color.Green;
            }
            else
            {
                acceptcodelabel.Text = "Invalid codes";
                acceptcodelabel.ForeColor = Color.Red;
                allValid = false;
            }

            if (allValid)
            {
                MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nametxtbox.Text = "";
                agetxtbox.Text = "";
                pwtxtbox.Text = "";
                cpwtxtbox.Text = "";
                groupcodetxtbox.Text = "";
                invitecodetxtbox.Text = "";

                agelabel.Visible = false;
                acceptpwlabel.Visible = false;
                acceptcodelabel.Visible = false;
            }
        }
    }
}
