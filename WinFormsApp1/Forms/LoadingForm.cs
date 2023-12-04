using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 569)
            {
                timer1.Stop();

                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}