using Dropdownsidebar.CustomControls;
using Final.Forms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class DashoardMain : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public DashoardMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorderBtn);

            Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void loadForm(object Form)
        {

            if (this.panelMenu.Controls.Count > 0)
                this.panelMenu.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(f);
            this.panelMenu.Tag = f;
            
            f.Show();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                currentIconChild.IconChar = currentBtn.IconChar;
                currentIconChild.IconColor = color;
                titleChildForm.Text = currentBtn.Text;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentIconChild.IconChar = IconChar.Home;
            currentIconChild.IconColor = Color.Gainsboro;
            titleChildForm.Text = "Directory";

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            loadForm(new Dashboard());
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ddStudent.Show(btnStudent, btnStudent.Width, 0);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ddReport.Show(btnReport, btnReport.Width, 0);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            ddBook.Show(btnBook, btnBook.Width, 0);

        }

        private void DashoardMain_Load(object sender, EventArgs e)
        {
            ddReport.IsMainMenu = false;
            ddStudent.IsMainMenu = false;
            ddBook.IsMainMenu = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void libDropDown2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void currentIconChild_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void miniIcon_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxIcon_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DashoardMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new IssueBookForm());
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ReturnBookForm());
        }

        private void ddBook_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new AddBookForm());
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new AddStudentForm());
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ViewStudentForm());
        }

        private void studentCompleteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new StudentReportForm());
        }

        private void bookCompleteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new BookReportForm());
        }
    }
}
