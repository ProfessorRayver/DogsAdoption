namespace GUIdogAdoption
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
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewDogList_Click(object sender, EventArgs e)
        {
            doglist dogListForm = new doglist();
            dogListForm.Show();
            this.Hide();
        }

        
        private void RemoveList_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            exitThankyou exitForm = new exitThankyou();
            exitForm.Show();
            this.Hide();
        }
    }
}
