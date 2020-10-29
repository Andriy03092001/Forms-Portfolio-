using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class Portfolio : Form
    {
        public Portfolio()
        {
            InitializeComponent();
        }

        void showWorkDialog(string title, string description)
        {
            this.Visible = false;
            Work workForm = new Work(title, description);
            workForm.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showWorkDialog("Admin panel for BookService", "Description: Admin panel for BookService...");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showWorkDialog("Web studio", "Description: Web studio...");
        }
    }
}
