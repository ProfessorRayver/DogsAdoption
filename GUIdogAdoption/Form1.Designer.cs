namespace GUIdogAdoption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            RegisterDog = new Button();
            ViewDogList = new Button();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RegisterDog
            // 
            RegisterDog.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterDog.Location = new Point(329, 195);
            RegisterDog.Name = "RegisterDog";
            RegisterDog.Size = new Size(145, 55);
            RegisterDog.TabIndex = 1;
            RegisterDog.Text = "Register Dog";
            RegisterDog.UseVisualStyleBackColor = true;
            RegisterDog.Click += button1_Click;
            // 
            // ViewDogList
            // 
            ViewDogList.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewDogList.Location = new Point(329, 280);
            ViewDogList.Name = "ViewDogList";
            ViewDogList.Size = new Size(145, 55);
            ViewDogList.TabIndex = 2;
            ViewDogList.Text = "View Dog List";
            ViewDogList.UseVisualStyleBackColor = true;
            ViewDogList.Click += ViewDogList_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(329, 363);
            Exit.Name = "Exit";
            Exit.Size = new Size(145, 55);
            Exit.TabIndex = 5;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(ViewDogList);
            Controls.Add(RegisterDog);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button RegisterDog;
        private Button ViewDogList;
        private Button Exit;
    }
}
