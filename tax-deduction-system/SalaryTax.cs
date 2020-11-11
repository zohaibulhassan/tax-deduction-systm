using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax_deduction_system
{

    public partial class SalaryTax : Form
    {
        public SalaryTax()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        int val = Convert.ToInt3.textBox1.text;
        public int TaxRates()
        {
            
            // 1
            if (val <= 600000) return 0;
            // 2
            if (val > 600000 && val <= 1200000)
            {
                int curr = val - 600000;
                return (curr * 5 / 100);
            }
            //3
            if (val > 1200000 && val <= 1800000)
            {
                int curr = val - 1200000;
                return (30000 + (curr * 10 / 100));
            }
            // 4
            if (val > 1800000 && val <= 2500000)
            {
                int curr = val - 1800000;
                return (90000 + (curr * 15 / 100));
            }
            // 5

            if (val > 2500000 && val <= 3500000)
            {
                int curr = val - 2500000;
                return (195000 + (curr * 17 / 100));
            }
            // 6

            if (val > 3500000 && val <= 5000000)
            {
                int curr = val - 3500000;
                return (370000 + (curr * 20 / 100));
            }

            // 7

            if (val > 5000000 && val <= 8000000)
            {
                int curr = val - 5000000;
                return (670000 + (curr * 22 / 100));
            }

            // 8

            if (val > 8000000 && val <= 12000000)
            {
                int curr = val - 8000000;
                return (1345000 + (curr * 25 / 100));
            }

            // 9

            if (val > 12000000 && val <= 30000000)
            {
                int curr = val - 12000000;
                return (2345000 + (curr * 27 / 100));
            }

            // 10

            if (val > 30000000 && val <= 50000000)
            {
                int curr = val - 30000000;
                return (7295000 + (curr * 30 / 100));
            }

            // 11

            if (val > 50000000 && val <= 75000000)
            {
                int curr = val - 50000000;
                return (13295000 + (curr * 32 / 100));
            }


            // 12

            if (val > 75000000)
            {
                int curr = val - 75000000;
                return (21420000 + (curr * 35 / 100));
            }
        }
        
        
    }
}
