using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer_0
{
    public partial class Sound : UserControl
    {
        public Sound()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            if (trackBar1.Value == 0)
            {
                button1.BackColor = Color.WhiteSmoke;
            }
            else
            {
                button1.BackColor = Color.Yellow;
            }
        }
    }
}
