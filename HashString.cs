using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashstring1
{
    public partial class HashString : Form
    {
        public HashString()
        {
            InitializeComponent();
        }

        public String letters = "acdegilmnoprstuw";
        public const int multiplier = 37;
        public const int h0 = 7;

        public Int64 hash (String s) {
            Int64 h = h0;            
            for(Int32 i = 0; i < s.Length; i++) {
                h = (h * multiplier + letters.IndexOf(s[i]));
            }
            return h;
        }

        public String unhash(Int64 h)  {
            String result = "";
            Int64 hash = h;

            while(hash > multiplier) {
                result += letters[Convert.ToInt16(hash % multiplier)];                
                hash /= multiplier;
            }            
            
            return Reverse(result);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String letters = Convert.ToString(inputWord.Text);
            outputHash.Text = Convert.ToString(hash(letters));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputWord.Text = Convert.ToString(unhash(Convert.ToInt64(inputHash.Text)));
            
        }
    }
}
