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
    public partial class Work : Form
    {
        public Work(string title, string description)
        {
            InitializeComponent();
            this.lTitle.Text = title;
            this.lDescription.Text = description;
        }

        private void Work_Load(object sender, EventArgs e)
        {

        }
    }
}
