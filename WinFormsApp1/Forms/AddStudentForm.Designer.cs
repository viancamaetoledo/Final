
namespace Final.Forms
{
    partial class AddStudentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 186);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(328, 224);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 1;
            label2.Text = "Student Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(328, 269);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 2;
            label3.Text = "Student Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(328, 308);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 3;
            label4.Text = "Student E-mail:";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(542, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 29);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(542, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 29);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(542, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 29);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(542, 344);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 29);
            textBox4.TabIndex = 7;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(706, 483);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 25;
            button3.Text = "CANCEL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(596, 483);
            button2.Name = "button2";
            button2.Size = new Size(104, 40);
            button2.TabIndex = 24;
            button2.Text = "REFRESH";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(485, 483);
            button1.Name = "button1";
            button1.Size = new Size(105, 40);
            button1.TabIndex = 23;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.BackgroundImage = Properties.Resources.Studentimage;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 231;
            iconPictureBox1.Location = new Point(85, 111);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(231, 355);
            iconPictureBox1.TabIndex = 26;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(542, 381);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 29);
            textBox5.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(328, 345);
            label5.Name = "label5";
            label5.Size = new Size(174, 23);
            label5.TabIndex = 27;
            label5.Text = "Student Contact #:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(375, 118);
            label6.Name = "label6";
            label6.Size = new Size(285, 45);
            label6.TabIndex = 29;
            label6.Text = "ADD STUDENT";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 607);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(iconPictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Button button2;
        private Button button1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
    }
}