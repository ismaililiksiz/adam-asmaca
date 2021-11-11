using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adam_asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sehirler[0] = "İSTANBUL";
            sehirler[1] = "HAKKARİ";
            sehirler[2] = "MUĞLA";
            sehirler[3] = "MARDİN";
            sehirler[4] = "SİVAS";
            sehirler[5] = "ANKARA";
            sehirler[6] = "ANTALYA";
            sehirler[7] = "İZMİR";
            sehirler[8] = "SAMSUN";
            sehirler[9] = "TRABZON";
            
        }
        char[] alfabe = new char[29];
        string[] sehirler = new string[10];
        int sehir_uzunlugu;
        string sehirr;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int rastgelesehir = rastgele.Next(0, sehirler.Length);
            char[] alfabe = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
            sehirr = sehirler[rastgelesehir];


            for (int i = 0; i < alfabe.Length; i++)
            {
                Button btn = new Button();
                btn.Name = alfabe[i].ToString();
                btn.Text = alfabe[i].ToString();
                btn.Width = 32;
                btn.Height = 32;
                flowLayoutPanel1.Controls.Add(btn);
            }
            sehir_uzunlugu = sehirr.Length;
            for (int i = 0; i < sehirr.Length; i++)
            {
                TextBox txt = new TextBox();
                txt.Name = 
            }

            
        }
    }
}
