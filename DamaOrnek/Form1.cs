using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)

            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                    for (int k = 0; k < buttons[i, j].Left; k=k+50)
                    {

                        buttons[i, j].BackColor = Color.Black;
                    }
                     
                  




                   
                    for (int m = 1; m < buttons.GetUpperBound(0); m = m + 2)
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }
                top += 50;
                left = 0;
            }
            
        }
    }
}
