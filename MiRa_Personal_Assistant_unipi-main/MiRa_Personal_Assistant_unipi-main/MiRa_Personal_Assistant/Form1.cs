using System.Diagnostics;

namespace MiRa_Personal_Assistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            Shoe_store shoe = new Shoe_store();
            shoe.Show();
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"C:\Users\diokt\OneDrive\Desktop\MiRa_Personal_Assistant\MiRa_MANUAL_HTML\index.html", UseShellExecute = true });

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://en.wikipedia.org/wiki/MIT_License", UseShellExecute = true });
            Process.Start(new ProcessStartInfo { FileName = @"C:\", UseShellExecute = true });

        }
    }
}