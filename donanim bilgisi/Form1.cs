using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donanim_bilgisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstTumparcalar.Items.Count; i++)
            {
                if (lstTumparcalar.Items[i].ToString()=="hoparlör"||
                    lstTumparcalar.Items[i].ToString()=="mikrofon"||
                    lstTumparcalar.Items[i].ToString()=="monitör"||
                    lstTumparcalar.Items[i].ToString() == "klavye")
                {
                    lstDisdonanim.Items.Add(lstTumparcalar.Items[i]);
                }
                else
                {
                    lstİçdonanim.Items.Add(lstTumparcalar.Items[i]);
                }
            }
        }
    }
}
