using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        { 
                    listBox1.Items.Remove(textBox1.Text);
            //refresh the buffer
                    listBox1.Items.Remove("spiderddken");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            listBox2.Items.Add(listBox1.SelectedItem);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items[listBox2.SelectedIndex] = textBox1.Text;
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text =(string) listBox2.SelectedItem;
        }

        private bool analyse(string tt1, string tt2)
        {
            int j = 0;
            for (int i = 0; i < tt1.Length; i++)
            {

                foreach (char c in tt2)
                {
                    if (i + j <= tt1.Length)
                        if (c == tt1[i + j])
                        {
                            j++;
                        }
                        else
                            j = 0;
                    if (j == tt2.Length)
                        return true;
                }
                j = 0;
            }
            return false;
        }
        private void ChercherLeMot(object sender, KeyEventArgs e)
        {
            //sauvgarde de la combolist dans un tableau 
             List<object> toto1 = new List<object>();

             foreach (object ll in comboBox1.Items)
             {
                 toto1.Add(ll);
                comboBox1.Items.Remove(ll);
            }
            //vider la combolist

             comboBox1.Items.Remove(toto1);

            //recherche des mot et les inserer dans la combo
           
            foreach (object tt in comboBox1.Items)
            {

                if (analyse(tt.ToString(), comboBox1.Text))
                {
                    
                    //MessageBox.Show(tt);
                    listBox1.Items.Add(tt);
                    
                }
            }
        }

        
    }


        
    }

