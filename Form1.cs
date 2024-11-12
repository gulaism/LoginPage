namespace LoginPage
{
    public partial class Form1 : Form
    {
        private List<User> users;
        public Form1()
        {
            InitializeComponent();

            users = new List<User>
            {
                new User("john_doe", "password123", "Admin"),
                new User("jane_smith", "mypassword", "User"),
                new User("bob_jones", "securepass", "User")
            };
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.White;
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.Gray;
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.White;
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Gray;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }

        private void Authenticateuser()
        {
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("Both username and password are required");
                }

                User user = null;
                foreach (var u in users)
                {
                    if (u.Username == username && u.Password == password)
                    {
                        user = u;
                        break; // Exit loop once a match is found
                    }
                }


                if (user != null)
                {
                    MessageBox.Show($"Welcome, {user.Role}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authenticateuser();
        }
    }
}
