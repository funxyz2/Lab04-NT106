using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_ltm_edited_
{
    public partial class Bai5_Source : Form
    {
        public Bai5_Source(string htmlContent)
        {
            InitializeComponent();
            rtbHtmlSource.Text = htmlContent;
        }

        private void Bai5_Source_Load(object sender, EventArgs e)
        {

        }
    }
}
