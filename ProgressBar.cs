using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___Wingo
{
    public partial class ProgressBar : Form
    {
        public int cant_msgs;
        public float onePercent;
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            progressBar_subiendo.Value= 0;
            onePercent = cant_msgs / 100.0f;
        }
    }
}
