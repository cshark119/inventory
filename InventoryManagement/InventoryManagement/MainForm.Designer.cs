
namespace InventoryManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            CLOSE = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            adminDashboard2 = new AdminDashboard();
            adminAddCategories1 = new AdminAddCategories();
            adminDashboard1 = new AdminDashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CLOSE);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 26);
            label1.TabIndex = 5;
            label1.Text = "Kitchen Inventory System";
            // 
            // CLOSE
            // 
            CLOSE.BackColor = Color.Maroon;
            CLOSE.Cursor = Cursors.Hand;
            CLOSE.FlatAppearance.BorderColor = Color.Black;
            CLOSE.FlatStyle = FlatStyle.Flat;
            CLOSE.ForeColor = SystemColors.ButtonHighlight;
            CLOSE.Location = new Point(1355, 12);
            CLOSE.Name = "CLOSE";
            CLOSE.Size = new Size(75, 23);
            CLOSE.TabIndex = 4;
            CLOSE.Text = "CLOSE";
            CLOSE.UseVisualStyleBackColor = false;
            CLOSE.Click += CLOSE_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 73);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 827);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(63, 107, 70);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 783);
            button5.Name = "button5";
            button5.Size = new Size(263, 32);
            button5.TabIndex = 15;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(63, 107, 70);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 456);
            button4.Name = "button4";
            button4.Size = new Size(263, 32);
            button4.TabIndex = 14;
            button4.Text = "Add Products";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(63, 107, 70);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 398);
            button3.Name = "button3";
            button3.Size = new Size(263, 32);
            button3.TabIndex = 13;
            button3.Text = "Add Category";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(63, 107, 70);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 343);
            button2.Name = "button2";
            button2.Size = new Size(263, 32);
            button2.TabIndex = 12;
            button2.Text = "Add Users";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(63, 107, 70);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 290);
            button1.Name = "button1";
            button1.Size = new Size(263, 32);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(119, 216);
            label4.Name = "label4";
            label4.Size = new Size(81, 26);
            label4.TabIndex = 11;
            label4.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(111, 26);
            label3.TabIndex = 2;
            label3.Text = "Welcome,";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, -36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 238);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 128);
            label2.Name = "label2";
            label2.Size = new Size(0, 40);
            label2.TabIndex = 9;
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminDashboard2);
            panel3.Controls.Add(AdminAddCategories1);
            panel3.Controls.Add(adminDashboard1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1152, 827);
            panel3.TabIndex = 2;
            // 
            // adminDashboard2
            // 
            adminDashboard2.Location = new Point(0, 0);
            adminDashboard2.Name = "adminDashboard2";
            adminDashboard2.Size = new Size(1152, 827);
            adminDashboard2.TabIndex = 2;
            // 
            // adminAddCategories1
            // 
            adminAddCategories1.Location = new Point(0, 0);
            adminAddCategories1.Name = "adminAddCategories1";
            adminAddCategories1.Size = new Size(1152, 827);
            adminAddCategories1.TabIndex = 1;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1152, 827);
            adminDashboard1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1442, 872);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button CLOSE;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Panel panel3;
        private AdminDashboard adminDashboard1;
        private AdminAddCategories adminAddCategories1;
        private AdminDashboard adminDashboard2;
        private Control AdminAddCategories1;
        private SizeF AutoScaleDimensions;
        private AutoScaleMode AutoScaleMode;
        private Color BackColor;
        private Size ClientSize;
        private FormBorderStyle FormBorderStyle;
        private string Name;
        private FormStartPosition StartPosition;
        private string Text;
    }
}