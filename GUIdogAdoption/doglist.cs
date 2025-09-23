using System;
using System.Windows.Forms;
using VetCommon;

namespace GUIdogAdoption
{
    public partial class doglist : Form
    {
        public doglist()
        {
            InitializeComponent();

            button1.Click += button1_Click; // EXIT
            button2.Click += button2_Click; // ADOPT
            this.Load += doglist_Load;
        }

        private void doglist_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (DogCommon dog in DataServiceProvider.DogDataService.GetDogs())
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

            bool removed = DataServiceProvider.DogDataService.RemoveDog(dogName);
            if (removed)
            {
                MessageBox.Show($"{dogName} has been removed.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doglist_Load(null, null); // Refresh the grid
            }
            else
            {
                MessageBox.Show("Dog not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

            var dog = DataServiceProvider.DogDataService.GetDogs().Find(d => d.Name.Equals(dogName, StringComparison.OrdinalIgnoreCase));
            if (dog != null && dog.Status != "Adopted")
            {
                dog.Status = "Adopted";
                DataServiceProvider.DogDataService.SaveToFile();
                MessageBox.Show($"{dogName} has been adopted.", "Adopted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doglist_Load(null, null); // Refresh the grid
            }
            else
            {
                MessageBox.Show("Dog not found or already adopted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

