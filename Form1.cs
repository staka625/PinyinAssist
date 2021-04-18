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
    public partial class PinyinAssist : Form
    {
        public PinyinAssist()
        {
            InitializeComponent();
        }


        private void textBoxinput_TextChanged(object sender, EventArgs e)
        {
            string s = textBoxinput.Text;

            //aに関して置き換え
            s = s.Replace("a1", "ā");
            s = s.Replace("a2", "á");
            s = s.Replace("a3", "ǎ");
            s = s.Replace("a4", "à");

            //iに関して置き換え
            s = s.Replace("i1", "ī");
            s = s.Replace("i2", "í");
            s = s.Replace("i3", "ǐ");
            s = s.Replace("i4", "ì");

            //uに関して置き換え
            s = s.Replace("u1", "ū");
            s = s.Replace("u2", "ú");
            s = s.Replace("u3", "ǔ");
            s = s.Replace("u4", "ù");


            //eに関して置き換え
            s = s.Replace("e1", "ē");
            s = s.Replace("e2", "é");
            s = s.Replace("e3", "ě");
            s = s.Replace("e4", "è");

            //oに関して置き換え
            s = s.Replace("o1", "ō");
            s = s.Replace("o2", "ó");
            s = s.Replace("o3", "ǒ");
            s = s.Replace("o4", "ò");

            //üに関して置き換え
            s = s.Replace("v0", "ü");
            s = s.Replace("v1", "ǖ");
            s = s.Replace("v2", "ǘ");
            s = s.Replace("v3", "ǚ");
            s = s.Replace("v4", "ǜ");

            textBoxoutput.Text = s;
        }
    }
}
