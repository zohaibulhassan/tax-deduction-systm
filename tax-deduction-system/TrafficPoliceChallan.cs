using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace tax_deduction_system
{
    public partial class TrafficPoliceChallan : Form
    {
        public TrafficPoliceChallan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "200";
                label2.Text = "300";
                label3.Text = "300";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = "200";
                label2.Text = "300";
                label3.Text = "500";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label1.Text = "300";
                label2.Text = "500";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label1.Text = "200";
                label2.Text = "300";
                label3.Text = "500";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "750";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "750";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "750";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                label1.Text = "000";
                label2.Text = "500";
                label3.Text = "500";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                label1.Text = "000";
                label2.Text = "500";
                label3.Text = "750";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                label1.Text = "300";
                label2.Text = "000";
                label3.Text = "000";
            }

            else if (comboBox1.SelectedIndex == 11)
            {
                label1.Text = "300";
                label2.Text = "500";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                label1.Text = "200";
                label2.Text = "000";
                label3.Text = "000";
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                label1.Text = "000";
                label2.Text = "500";
                label3.Text = "750";
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 16)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 17)
            {
                label1.Text = "200";
                label2.Text = "200";
                label3.Text = "750";
            }
            else if (comboBox1.SelectedIndex == 18)
            {
                label1.Text = "000";
                label2.Text = "500";
                label3.Text = "000";
            }
            else if (comboBox1.SelectedIndex == 19)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 20)
            {
                label1.Text = "000";
                label2.Text = "000";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 21)
            {
                label1.Text = "000";
                label2.Text = "000";
                label3.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 21)
            {
                label1.Text = "200";
                label2.Text = "500";
                label3.Text = "1000";
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SalaryTax a = new SalaryTax();
            a.Show();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            comboBox1.Text = "Select One";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        e.Graphics.DrawImage(bitmap, 0, 0);     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
    }
}
