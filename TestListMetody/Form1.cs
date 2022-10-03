using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListMetody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void prepis1(List<char> znaky,ListBox listbox1)
        {
            char[] a = znaky.ToArray();
            
            foreach(char b in a)
            {
                
                listBox1.Items.Add(b);
            }
            

        }
        string abeceda = "abcdefghijklmnopqrstuvwxyz";
        string cisla = "1234567890";
        Random rng = new Random();
        List<char> znaky = new List<char>();
        string[] pismena = new string[100];
        int[] cisilka = new int[100];
        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            znaky.Clear();
            short a = (short)numericUpDown1.Value;
            string[] veta = new string[a];
            
            for (int i = 0; i < a; i++)
            {

                char znak = Convert.ToChar(rng.Next(31, 127));
                veta[i] = znak.ToString();
                
                znaky.Add(znak);
               

            }
          prepis1(znaky, listBox1);

            string mezery="";
            foreach(string c in veta)
            {
                mezery = mezery + c;
                
            }
            mezery = mezery.Trim();
            mezery = mezery.Replace(" ", "");
            textBox1.Text = mezery;

            
          
               
                int o = 0;
                foreach (string pismeno in veta)
                {

                    
                    if(pismeno.Contains(abeceda))
                    {
                        
                        pismena[o] = pismeno;
                            o++;
                       
                        
                    }
                    else
                    {
                       
                        if(pismeno.Contains(cisla))
                        {
                       
                            listBox2.Items.Add(pismeno);
                        }
                    }
                        
                        
                    
                    
                
                
            }
          if(veta.Contains(cisla))
           {
                int i = 0;
                foreach (string cislo in veta)
                {
                    
                    cisilka[i] = Convert.ToInt32(cislo);
                    i++;
                }
                
           }
            
        }
    }
}
