using DogDataLogic;
using VetCommon;
using System;
using System.Windows.Forms;

namespace GUIdogAdoption // DOG NAME SHOULD NOT BE ADDED AGAIN TO THE GRID, IT JUST NEEDED TO CHECK IF IT WAS EXIXSTING, IF YES IT WILL UPDATE THE OWNER NAME IN THE GRID.
{
    public partial class adoptDog : Form
    {
        public static InMemoryDogDataService dataService = new InMemoryDogDataService();

        public adoptDog()
        {
            InitializeComponent();
        }

        // EXIT button: return to home page and close this form
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        // ADOPT button: add new dog to in-memory data service
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string breed = textBox2.Text.Trim();
            string owner = textBox3?.Text.Trim() ?? ""; // If you have an owner textbox, otherwise set as needed

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(breed))
            {
                MessageBox.Show("Please enter both the dog's name and breed.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the dog already exists
            var existingDog = dataService.GetDogs().Find(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (existingDog != null)
            {
                // Update owner name
                existingDog.Owner = owner;
                MessageBox.Show($"Owner for {name} has been updated.", "Owner Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Add new dog
                dataService.AddDog(new DogCommon { Name = name, Breed = breed, Status = "Available", Owner = owner });
                MessageBox.Show($"{name} ({breed}) has been added for adoption.", "Adoption Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Optionally clear the fields
            textBox1.Text = "";
            textBox2.Text = "";
            if (textBox3 != null) textBox3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // No action needed
        }
    }
}
