namespace CLAVIOMICA_INVENTORY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter your username and password.", "Login required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!AccountStore.Validate(username, password))
            {
                string message = AccountStore.HasAccount
                    ? "The username or password is incorrect."
                    : "No account exists yet. Select Register Here to create an account.";

                MessageBox.Show(message, "Unable to sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form3 dashboard = new();
            dashboard.FormClosed += (_, _) => ShowLoginForm();
            Hide();
            dashboard.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new();
            registerForm.FormClosed += (_, _) => ShowLoginForm();
            Hide();
            registerForm.Show();
        }

        private void ShowLoginForm()
        {
            textBox2.Clear();
            Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
