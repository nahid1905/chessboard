using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] whiteboard = new Button[32];
            Button[] blackboard = new Button[32];

            for (int setir=0 ; setir < 8; setir++)
            {
                if (setir % 2 == 0)
                {
                    for (int sut = 0; sut < 4; sut++)
                    {
                        whiteboard[sut] = new Button
                        {
                            Text = null,
                            BackColor = Color.White,
                            Width = 50,
                            Height = 50,
                            Left = sut * 100,
                            Top = setir * 50
                        };

                        Controls.Add(whiteboard[sut]);
                    }
                }
                else
                {
                    for (int sut = 1; sut < 5; sut++)
                    {
                        whiteboard[sut] = new Button
                        {
                            Text = null,
                            BackColor = Color.White,
                            Width = 50,
                            Height = 50,
                            Left = sut * 100 - 50,
                            Top = setir * 50
                        };

                        Controls.Add(whiteboard[sut]);
                    }
                }
            }

            for (int setir = 0; setir < 8; setir++)
            {
                if (setir % 2 == 0)
                {
                    for (int sut = 0; sut < 4; sut++)
                    {
                        blackboard[sut] = new Button
                        {
                            Text = null,
                            BackColor = Color.Black,
                            Width = 50,
                            Height = 50,
                            Left = sut * 100 + 50,
                            Top = setir * 50
                        };

                        Controls.Add(blackboard[sut]);
                    }
                }
                else
                {
                    for (int sut = 1; sut < 5; sut++)
                    {
                        blackboard[sut] = new Button
                        {
                            Text = null,
                            BackColor = Color.Black,
                            Width = 50,
                            Height = 50,
                            Left = sut * 100 - 100,
                            Top = setir * 50
                        };

                        Controls.Add(blackboard[sut]);
                    }
                }
            }


        }
    }
}
