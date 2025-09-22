using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

            // Add to shared in-memory data service
            adoptDog.dataService.AddDog(new DogCommon { Name = name, Breed = breed });

            MessageBox.Show($"{name} ({breed}) has been registered for adoption.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally clear the fields
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }

} 
