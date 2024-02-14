using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenúPrincipal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Azul")
            {
                textBox1.ForeColor = System.Drawing.Color.Blue;
                button1.ForeColor = System.Drawing.Color.Blue;
                button2.ForeColor = System.Drawing.Color.Blue;
                button3.ForeColor = System.Drawing.Color.Blue;
                button4.ForeColor = System.Drawing.Color.Blue;
                button5.ForeColor = System.Drawing.Color.Blue;
                button6.ForeColor = System.Drawing.Color.Blue;
                button7.ForeColor = System.Drawing.Color.Blue;
                button8.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                if (comboBox1.Text == "Amarillo")
                {
                    textBox1.ForeColor = System.Drawing.Color.Yellow;
                    button1.ForeColor = System.Drawing.Color.Yellow;
                    button2.ForeColor = System.Drawing.Color.Yellow;
                    button3.ForeColor = System.Drawing.Color.Yellow;
                    button4.ForeColor = System.Drawing.Color.Yellow;
                    button5.ForeColor = System.Drawing.Color.Yellow;
                    button6.ForeColor = System.Drawing.Color.Yellow;
                    button7.ForeColor = System.Drawing.Color.Yellow;
                    button8.ForeColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    if (comboBox1.Text == "Naranja")
                    {
                        textBox1.ForeColor = System.Drawing.Color.Orange;
                        button1.ForeColor = System.Drawing.Color.Orange;
                        button2.ForeColor = System.Drawing.Color.Orange;
                        button3.ForeColor = System.Drawing.Color.Orange;
                        button4.ForeColor = System.Drawing.Color.Orange;
                        button5.ForeColor = System.Drawing.Color.Orange;
                        button6.ForeColor = System.Drawing.Color.Orange;
                        button7.ForeColor = System.Drawing.Color.Orange;
                        button8.ForeColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        if (comboBox1.Text == "Verde")
                        {
                            textBox1.ForeColor = System.Drawing.Color.Green;
                            button1.ForeColor = System.Drawing.Color.Green;
                            button2.ForeColor = System.Drawing.Color.Green;
                            button3.ForeColor = System.Drawing.Color.Green;
                            button4.ForeColor = System.Drawing.Color.Green;
                            button5.ForeColor = System.Drawing.Color.Green;
                            button6.ForeColor = System.Drawing.Color.Green;
                            button7.ForeColor = System.Drawing.Color.Green;
                            button8.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            if (comboBox1.Text == "Blanco")
                            {
                                textBox1.ForeColor = System.Drawing.Color.White;
                                button1.ForeColor = System.Drawing.Color.White;
                                button2.ForeColor = System.Drawing.Color.White;
                                button3.ForeColor = System.Drawing.Color.White;
                                button4.ForeColor = System.Drawing.Color.White;
                                button5.ForeColor = System.Drawing.Color.White;
                                button6.ForeColor = System.Drawing.Color.White;
                                button7.ForeColor = System.Drawing.Color.White;
                                button8.ForeColor = System.Drawing.Color.White;
                            }
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Azul")
            {
                textBox1.BackColor = Color.Blue;
            }
            else
            {
                if (comboBox1.Text == "Amarillo")
                {
                    textBox1.BackColor = Color.Yellow;
                }
                else
                {
                    if (comboBox1.Text == "Naranja")
                    {
                        textBox1.BackColor = Color.Orange;
                    }
                    else
                    {
                        if (comboBox1.Text == "Verde")
                        {
                            textBox1.BackColor = Color.Green;
                        }
                        else
                        {
                            if (comboBox1.Text == "Blanco")
                            {
                                textBox1.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String t = this.textBox2.Text;
            this.textBox1.Text = t;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}