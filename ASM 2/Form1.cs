using System.Xml.Linq;

namespace ASM_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please Enter your Name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsername.Focus();
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPassword.Focus();
            }
            else
            {
                if (username == "admin" && password == "123")
                {
                    Form2 MainForm = new Form2();
                    MainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect! Please Re_enter ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult checkcf = MessageBox.Show("DO YOU WANT TO EXIT THE PROCESS?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (checkcf == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Continue ...");
            }
        }
    }
}
