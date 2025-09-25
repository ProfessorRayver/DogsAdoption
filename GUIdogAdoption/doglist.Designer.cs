namespace GUIdogAdoption
{
    partial class doglist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doglist));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Availablity = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Availablity });
            dataGridView1.Location = new Point(137, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 274);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Breed";
            Column2.Name = "Column2";
            // 
            // Availablity
            // 
            Availablity.HeaderText = "Availability";
            Availablity.Name = "Availablity";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(596, 29);
            button1.Name = "button1";
            button1.Size = new Size(128, 64);
            button1.TabIndex = 2;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(596, 363);
            button2.Name = "button2";
            button2.Size = new Size(128, 64);
            button2.TabIndex = 3;
            button2.Text = "REMOVE DOG";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(596, 283);
            button3.Name = "button3";
            button3.Size = new Size(128, 64);
            button3.TabIndex = 4;
            button3.Text = "ADOPT DOG";
            button3.UseVisualStyleBackColor = true;
            // 
            // doglist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "doglist";
            Text = "doglist";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Availablity;
        private Button button3;
    }
}