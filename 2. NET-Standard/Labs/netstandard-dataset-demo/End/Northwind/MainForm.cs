using System;
using System.Windows.Forms;

namespace Northwind
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            textBox.Text = NorthwindDb.GetData();
        }
    }
}
