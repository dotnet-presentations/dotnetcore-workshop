using System;
using System.Windows.Forms;
using Gps;

namespace App_Net461
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var geo = await GpsLocation.GetCoordinates();

            label1.Text = $"You're at ({geo.latitude:N2}, {geo.longitude:N2})";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
