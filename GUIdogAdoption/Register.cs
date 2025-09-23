using System;
using System.Windows.Forms;
using VetCommon;

namespace GUIdogAdoption
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string breed = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(breed))
            {
                MessageBox.Show("Please enter both the dog's name and breed.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add to shared JSON data service
            DataServiceProvider.DogDataService.AddDog(new DogCommon { Name = name, Breed = breed, Status = "Available" });

            MessageBox.Show($"{name} ({breed}) has been registered for adoption.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
