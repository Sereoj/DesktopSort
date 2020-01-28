using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCopy1
{
    public interface IForm2
    {
        //Все методы, свойства и события будут отправлены в Presenter
    }



    public partial class Form2 : Form, IForm2
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        public bool[] Points;
        public void ParseCheckPoint()
        {


            Points = new bool[10] { false, false, false, false, false, false, false, false, false, false };
            if (checkBox1.Checked) { Points[0] = true; } else { Points[0] = false; }
            if (checkBox2.Checked) { Points[1] = true; } else { Points[1] = false; }
            if (checkBox3.Checked) { Points[2] = true; } else { Points[2] = false; }
            if (checkBox4.Checked) { Points[3] = true; } else { Points[3] = false; }
            if (checkBox5.Checked) { Points[4] = true; } else { Points[4] = false; }
            if (checkBox6.Checked) { Points[5] = true; } else { Points[5] = false; }
            if (checkBox7.Checked) { Points[6] = true; } else { Points[6] = false; }
            if (checkBox8.Checked) { Points[7] = true; } else { Points[7] = false; }
            if (checkBox9.Checked) { Points[8] = true; } else { Points[8] = false; }
            if (checkBox10.Checked) { Points[9] = true; } else { Points[9] = false; }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParseCheckPoint();
            int x = 0;
            foreach (bool bollen in Points)
            {
                x++;
                Console.WriteLine(bollen ?  $"{x} - true" : $"{x} - false");
            }
        }
    }
}
