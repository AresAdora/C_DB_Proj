using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cheapskate.Forms
{
    public partial class Goal : Form
    {
        public Goal()
        {
            InitializeComponent();
        }

        private void monthCalendar1_BackColorChanged(object sender, EventArgs e)
        {
            Application.VisualStyleState = VisualStyleState.NoneEnabled;
        }

        private void monthCalendar1_EnabledChanged(object sender, EventArgs e)
        {
            Application.VisualStyleState = VisualStyleState.NoneEnabled;
        }
    }
}
