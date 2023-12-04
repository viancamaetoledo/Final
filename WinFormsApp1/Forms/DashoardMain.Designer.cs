namespace WinFormsApp1.Forms
{
    partial class DashoardMain
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnReport = new FontAwesome.Sharp.IconButton();
            btnBook = new FontAwesome.Sharp.IconButton();
            btnStudent = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            exitIcon = new FontAwesome.Sharp.IconPictureBox();
            maxIcon = new FontAwesome.Sharp.IconPictureBox();
            miniIcon = new FontAwesome.Sharp.IconPictureBox();
            titleChildForm = new Label();
            currentIconChild = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            ddBook = new Dropdownsidebar.CustomControls.LibDropDown(components);
            addBookToolStripMenuItem = new ToolStripMenuItem();
            issueBookToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            ddStudent = new Dropdownsidebar.CustomControls.LibDropDown(components);
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentToolStripMenuItem = new ToolStripMenuItem();
            ddReport = new Dropdownsidebar.CustomControls.LibDropDown(components);
            studentCompleteReportToolStripMenuItem = new ToolStripMenuItem();
            bookCompleteReportToolStripMenuItem = new ToolStripMenuItem();
            panelMenu = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miniIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentIconChild).BeginInit();
            ddBook.SuspendLayout();
            ddStudent.SuspendLayout();
            ddReport.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 39, 60);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 667);
            panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.Gainsboro;
            btnReport.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            btnReport.IconColor = Color.Gainsboro;
            btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReport.Location = new Point(0, 380);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(10, 0, 0, 0);
            btnReport.Size = new Size(175, 60);
            btnReport.TabIndex = 4;
            btnReport.Text = "Report";
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnBook
            // 
            btnBook.Dock = DockStyle.Top;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.ForeColor = Color.Gainsboro;
            btnBook.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            btnBook.IconColor = Color.Gainsboro;
            btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBook.Location = new Point(0, 320);
            btnBook.Name = "btnBook";
            btnBook.Padding = new Padding(10, 0, 5, 0);
            btnBook.Size = new Size(175, 60);
            btnBook.TabIndex = 3;
            btnBook.Text = "Book";
            btnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnStudent
            // 
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.Gainsboro;
            btnStudent.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            btnStudent.IconColor = Color.Gainsboro;
            btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudent.Location = new Point(0, 260);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(10, 0, 5, 0);
            btnStudent.Size = new Size(175, 60);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            btnDashboard.IconColor = Color.Gainsboro;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.Location = new Point(0, 200);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 5, 0);
            btnDashboard.Size = new Size(175, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 200);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(34, 143);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 1;
            label1.Text = "Hello, User!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Final.Properties.Resources.icons8_library_100px;
            pictureBox1.Location = new Point(34, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 98);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 39, 60);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(titleChildForm);
            panel3.Controls.Add(currentIconChild);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(175, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 50);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(exitIcon);
            panel5.Controls.Add(maxIcon);
            panel5.Controls.Add(miniIcon);
            panel5.Location = new Point(744, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(94, 29);
            panel5.TabIndex = 0;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Cursor = Cursors.Hand;
            exitIcon.Dock = DockStyle.Left;
            exitIcon.ForeColor = Color.Gainsboro;
            exitIcon.IconChar = FontAwesome.Sharp.IconChar.X;
            exitIcon.IconColor = Color.Gainsboro;
            exitIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitIcon.IconSize = 29;
            exitIcon.Location = new Point(64, 0);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(32, 29);
            exitIcon.TabIndex = 5;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // maxIcon
            // 
            maxIcon.BackColor = Color.Transparent;
            maxIcon.Cursor = Cursors.Hand;
            maxIcon.Dock = DockStyle.Left;
            maxIcon.ForeColor = Color.Gainsboro;
            maxIcon.IconChar = FontAwesome.Sharp.IconChar.Square;
            maxIcon.IconColor = Color.Gainsboro;
            maxIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maxIcon.IconSize = 29;
            maxIcon.Location = new Point(32, 0);
            maxIcon.Name = "maxIcon";
            maxIcon.Size = new Size(32, 29);
            maxIcon.TabIndex = 4;
            maxIcon.TabStop = false;
            maxIcon.Click += maxIcon_Click;
            // 
            // miniIcon
            // 
            miniIcon.BackColor = Color.Transparent;
            miniIcon.Cursor = Cursors.Hand;
            miniIcon.Dock = DockStyle.Left;
            miniIcon.ForeColor = Color.Gainsboro;
            miniIcon.IconChar = FontAwesome.Sharp.IconChar.Minus;
            miniIcon.IconColor = Color.Gainsboro;
            miniIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            miniIcon.IconSize = 29;
            miniIcon.Location = new Point(0, 0);
            miniIcon.Name = "miniIcon";
            miniIcon.Size = new Size(32, 29);
            miniIcon.TabIndex = 3;
            miniIcon.TabStop = false;
            miniIcon.Click += miniIcon_Click;
            // 
            // titleChildForm
            // 
            titleChildForm.AutoSize = true;
            titleChildForm.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleChildForm.ForeColor = Color.Gainsboro;
            titleChildForm.Location = new Point(66, 23);
            titleChildForm.Name = "titleChildForm";
            titleChildForm.Size = new Size(118, 24);
            titleChildForm.TabIndex = 1;
            titleChildForm.Text = "Directory";
            // 
            // currentIconChild
            // 
            currentIconChild.BackColor = Color.Transparent;
            currentIconChild.ForeColor = Color.Gainsboro;
            currentIconChild.IconChar = FontAwesome.Sharp.IconChar.ParachuteBox;
            currentIconChild.IconColor = Color.Gainsboro;
            currentIconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            currentIconChild.IconSize = 45;
            currentIconChild.Location = new Point(15, 7);
            currentIconChild.Name = "currentIconChild";
            currentIconChild.Size = new Size(45, 47);
            currentIconChild.TabIndex = 0;
            currentIconChild.TabStop = false;
            currentIconChild.Click += currentIconChild_Click;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = Color.Gainsboro;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(175, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(841, 10);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // ddBook
            // 
            ddBook.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ddBook.IsMainMenu = false;
            ddBook.Items.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, issueBookToolStripMenuItem, returnBookToolStripMenuItem });
            ddBook.MenuItemHeight = 55;
            ddBook.MenuItemTextColor = Color.Empty;
            ddBook.Name = "ddBook";
            ddBook.PrimaryColor = Color.Empty;
            ddBook.Size = new Size(178, 76);
            ddBook.Opening += ddBook_Opening;
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Image = Final.Properties.Resources.bookicon;
            addBookToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(177, 24);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // issueBookToolStripMenuItem
            // 
            issueBookToolStripMenuItem.Image = Final.Properties.Resources.bookicon;
            issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            issueBookToolStripMenuItem.Size = new Size(177, 24);
            issueBookToolStripMenuItem.Text = "Issue Book";
            issueBookToolStripMenuItem.Click += issueBookToolStripMenuItem_Click;
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Image = Final.Properties.Resources.bookicon;
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(177, 24);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // ddStudent
            // 
            ddStudent.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ddStudent.IsMainMenu = false;
            ddStudent.Items.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentToolStripMenuItem });
            ddStudent.MenuItemHeight = 55;
            ddStudent.MenuItemTextColor = Color.Empty;
            ddStudent.Name = "ddStudent";
            ddStudent.PrimaryColor = Color.Empty;
            ddStudent.Size = new Size(187, 52);
            ddStudent.Opening += libDropDown2_Opening;
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = Final.Properties.Resources.studenticon;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(186, 24);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentToolStripMenuItem
            // 
            viewStudentToolStripMenuItem.Image = Final.Properties.Resources.studenticon;
            viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            viewStudentToolStripMenuItem.Size = new Size(186, 24);
            viewStudentToolStripMenuItem.Text = "View Student";
            viewStudentToolStripMenuItem.Click += viewStudentToolStripMenuItem_Click;
            // 
            // ddReport
            // 
            ddReport.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ddReport.IsMainMenu = false;
            ddReport.Items.AddRange(new ToolStripItem[] { studentCompleteReportToolStripMenuItem, bookCompleteReportToolStripMenuItem });
            ddReport.MenuItemHeight = 55;
            ddReport.MenuItemTextColor = Color.Empty;
            ddReport.Name = "ddReport";
            ddReport.PrimaryColor = Color.Empty;
            ddReport.Size = new Size(286, 52);
            // 
            // studentCompleteReportToolStripMenuItem
            // 
            studentCompleteReportToolStripMenuItem.Image = Final.Properties.Resources.reporticon;
            studentCompleteReportToolStripMenuItem.Name = "studentCompleteReportToolStripMenuItem";
            studentCompleteReportToolStripMenuItem.Size = new Size(285, 24);
            studentCompleteReportToolStripMenuItem.Text = "Student Complete Report";
            studentCompleteReportToolStripMenuItem.Click += studentCompleteReportToolStripMenuItem_Click;
            // 
            // bookCompleteReportToolStripMenuItem
            // 
            bookCompleteReportToolStripMenuItem.Image = Final.Properties.Resources.reporticon;
            bookCompleteReportToolStripMenuItem.Name = "bookCompleteReportToolStripMenuItem";
            bookCompleteReportToolStripMenuItem.Size = new Size(285, 24);
            bookCompleteReportToolStripMenuItem.Text = "Book Complete Report";
            bookCompleteReportToolStripMenuItem.Click += bookCompleteReportToolStripMenuItem_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(175, 60);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(841, 607);
            panelMenu.TabIndex = 3;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // DashoardMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 667);
            Controls.Add(panelMenu);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "DashoardMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashoardMain";
            Load += DashoardMain_Load;
            MouseDown += DashoardMain_MouseDown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)miniIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentIconChild).EndInit();
            ddBook.ResumeLayout(false);
            ddStudent.ResumeLayout(false);
            ddReport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnBook;
        private FontAwesome.Sharp.IconButton btnStudent;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Dropdownsidebar.CustomControls.LibDropDown ddBook;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem issueBookToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private Dropdownsidebar.CustomControls.LibDropDown ddStudent;
        private Dropdownsidebar.CustomControls.LibDropDown ddReport;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentToolStripMenuItem;
        private ToolStripMenuItem studentCompleteReportToolStripMenuItem;
        private ToolStripMenuItem bookCompleteReportToolStripMenuItem;
        private Panel panelMenu;
        private Label titleChildForm;
        private FontAwesome.Sharp.IconPictureBox currentIconChild;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox exitIcon;
        private FontAwesome.Sharp.IconPictureBox maxIcon;
        private FontAwesome.Sharp.IconPictureBox miniIcon;
    }
}