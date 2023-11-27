using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dongu_tamamlananakadar_1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           for( int a =0; a < 10;a++)
            { 
            
                MessageBox.Show("döngü calışıyor");
                if(a == 5)
                {
                    MessageBox.Show("donguyu durdur");
                    break;
                }
            }
        }
    }
}
