using System;
using System.Windows.Forms;
using DogDataLogic;
using VetCommon;

namespace GUIdogAdoption
{
    public partial class doglist : Form
    {
        // Use the same static instance as in adoptDog to share data
        public static InMemoryDogDataService dataService = adoptDog.dataService;

        public doglist()
        {
            InitializeComponent();

            // Wire up the EXIT button event handler
            button1.Click += button1_Click;
            // Load data when the form is shown
            this.Load += doglist_Load;
        }

        private void doglist_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (DogCommon dog in dataService.GetDogs())
            {
                dataGridView1.Rows.Add(dog.Name, dog.Breed, dog.Status, dog.Owner);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a dog to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assumes the first column is the dog's name
            string dogName = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(dogName))
            {
                MessageBox.Show("Could not determine the dog's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool removed = dataService.RemoveDog(dogName);

            if (removed)
            {
                MessageBox.Show($"{dogName} has been removed.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh the grid
                doglist_Load(null, null);
            }
            else
            {
                MessageBox.Show("Dog not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
