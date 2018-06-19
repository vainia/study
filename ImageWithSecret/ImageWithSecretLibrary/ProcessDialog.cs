using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageWithSecretLibrary
{
    public partial class ProcessDialog : Form
    {
        public ProcessDialog()
        {
            InitializeComponent();
            this.buttonNext.DialogResult = DialogResult.OK;
            this.buttonSkip.DialogResult = DialogResult.Cancel;
        }
        
        public void SetData(int currentProgress, int x, int y, int rb, int gb, int bb, int ra, int ga, int ba) {
            this.Text = String.Format("Pixel Position X: {0}, Y: {1}", x, y);
            this.buttonRb.Text = Convert.ToString(rb, 2).PadLeft(8, '0');
            this.buttonRb.BackColor = Color.FromArgb(255, rb, 0, 0);
            this.buttonGb.Text = Convert.ToString(gb, 2).PadLeft(8, '0');
            this.buttonGb.BackColor = Color.FromArgb(255, 0, gb, 0);
            this.buttonBb.Text = Convert.ToString(bb, 2).PadLeft(8, '0');
            this.buttonBb.BackColor = Color.FromArgb(255, 0, 0, bb);
            this.buttonRa.Text = Convert.ToString(ra, 2).PadLeft(8, '0');
            this.buttonRa.BackColor = Color.FromArgb(255, ra, 0, 0);
            this.buttonGa.Text = Convert.ToString(ga, 2).PadLeft(8, '0');
            this.buttonGa.BackColor = Color.FromArgb(255, 0, ga, 0);
            this.buttonBa.Text = Convert.ToString(ba, 2).PadLeft(8, '0');
            this.buttonBa.BackColor = Color.FromArgb(255, 0, 0, ba);
            this.progressBar.Value = currentProgress;
        }
    }
}
