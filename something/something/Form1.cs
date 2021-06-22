using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace something
{
    public partial class Form1 : Form
    {
        //hàm 
        private bool laSoNgTo(int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0) { return false; }
            }
            return true;
        }
        private void textboxSwap(TextBox a, TextBox b){
            String temp;
            temp = a.Text;
            a.Text = b.Text;
            b.Text = temp;
            /*TextBox tam = new TextBox();
            tam = a;
            a = new TextBox();
            a = b;
            b = new TextBox();
            b = tam;*/
            }
        //

        public Form1()
        {
            InitializeComponent();
        }

        // biến toàn cục 
        List<TextBox> TBGroup = new List<TextBox>();
        int dem,max,min;
        //

        private void xoaBt_Click(object sender, EventArgs e)
        {

            MainPanel.Controls.Clear();
            TBGroup.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int total = Int32.Parse(TBGroup[1].Text) + Int32.Parse(TBGroup[2].Text);
            
            label1.Text = total.ToString();
            
        }
        private void OKBt_Click(object sender, EventArgs e)
        {
            
            Random rd = new Random();
            string so = textBox1.Text;
            dem = Int32.Parse(so);
            MainPanel.Controls.Clear();
            TBGroup.Clear();

            for (int i = 0; i < dem; i++)
            {
                TextBox TBtam = new TextBox();
                TBtam.Text = "" + rd.Next(0, 50);
                TBtam.Height = textBox1.Height; TBtam.Width = textBox1.Width;
                TBGroup.Add(TBtam);
                MainPanel.Controls.Add(TBtam);
            }

        }

        private void SoChanBt_Click(object sender, EventArgs e)
        {
            string so;
            TextBox tam = new TextBox();
            tam.BackColor = Color.Aqua;        
            for(int i=0 ; i<dem ; i++)
            {
                TBGroup[i].BackColor = Color.White;
                so = TBGroup[i].Text;
                int num = int.Parse(so) ;
                if((num % 2) == 0)
                {
                    TBGroup[i].BackColor = tam.BackColor;     

                }
            }
        }

        private void findMin_Click(object sender, EventArgs e)
        {
            min = Int16.Parse(TBGroup[0].Text);
            int num;
            for (int i = 1; i < dem; i++)
            {
                num = Int16.Parse(TBGroup[i].Text);
                if (min > num)
                {
                    min = num;
                }
            }
            for (int i = 0; i < dem; i++)
            {
                TBGroup[i].BackColor = Color.White;
                num = Int16.Parse(TBGroup[i].Text);
                if (min == num)
                {
                    TBGroup[i].BackColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timSoNgTo_Click(object sender, EventArgs e)
        {
            int num;
            for (int i = 0; i < dem; i++)
            {
                TBGroup[i].BackColor = Color.White;
                num = Int16.Parse(TBGroup[i].Text);
                if (laSoNgTo(num))
                {
                    TBGroup[i].BackColor = Color.Crimson;
                }
            }
        }

        private void SortBt_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < dem-1; i++)
            {
                
                for(int j = i + 1; j < dem ; j++)
                {
                    int num1 = Int16.Parse(TBGroup[i].Text);
                    int num2 = Int16.Parse(TBGroup[j].Text);
                    if (num1 > num2) textboxSwap(TBGroup[j], TBGroup[i]);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                int num;
                for(int i = 0; i < dem; i++)
                {
                     num = Int32.Parse(TBGroup[i].Text);
                    if (num == 0) { TBGroup[i].Visible = true; } else {
                        if ((num % 3 == 0) && (num % 5 == 0))
                        {
                            TBGroup[i].Visible = false;
                        }
                    }
                   
                }
            }
            else
            {
                for (int i = 0; i < dem; i++)
                {
                    
                    {
                        TBGroup[i].Visible = true;
                    }
                }
            }
        }

      

        private void findMax_Click(object sender, EventArgs e)
        {
            max = Int16.Parse(TBGroup[0].Text);
            int num;
            for(int i = 1; i < dem; i++)
            {
                num = Int16.Parse(TBGroup[i].Text);
                if (max < num)
                {
                    max = num;
                }
            }
            for (int i = 0; i < dem; i++)
            {
                TBGroup[i].BackColor = Color.White;
                num = Int16.Parse(TBGroup[i].Text);
                if (max == num)
                {
                    TBGroup[i].BackColor = Color.Blue;
                }
            }
        }
    }
}
