using System;
using System.Windows.Forms;
using VetCommon;
using DogDataLogic;

namespace GUIdogAdoption
{
    public partial class doglist : Form
    {
        private static JsonFileDogDataService dataService = new JsonFileDogDataService();

        public doglist()
        {
            InitializeComponent();

            button1.Click += button1_Click; // EXIT
            button2.Click += button2_Click; // REMOVE DOG
            button3.Click += button3_Click; // ADOPT DOG
            this.Load += doglist_Load;
        }

        private void doglist_Load(object sender, EventArgs e)
        {
            RefreshDogList();
        }

        public void RefreshDogList()
        {
            dataGridView1.Rows.Clear();
            foreach (DogCommon dog in dataService.GetDogs())
            {
                dataGridView1.Rows.Add(dog.Name, dog.Breed, dog.Status);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        // REMOVE DOG
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a dog to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                RefreshDogList(); // Refresh the grid
            }
            else
            {
                MessageBox.Show("Dog not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ADOPT DOG
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a dog to adopt.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dogName = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(dogName))
            {
                MessageBox.Show("Could not determine the dog's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dog = dataService.GetDogs().Find(d => d.Name.Equals(dogName, StringComparison.OrdinalIgnoreCase));
            if (dog != null && dog.Status != "Adopted")
            {
                dog.Status = "Adopted";
                dataService.SaveToFile();
                MessageBox.Show($"{dogName} has been adopted.", "Adopted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDogList(); // Refresh the grid
            }
            else
            {
                MessageBox.Show("Dog not found or already adopted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

