using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_member_rms1
{
    public partial class send_sms : DevExpress.XtraEditors.XtraForm
    {
        public send_sms()
        {
            InitializeComponent();
        }

        public static int HasArabicGlyphs(string text)
        {
            char[] glyphs = text.ToCharArray();
            foreach (char glyph in glyphs)
            {
                if (glyph >= 0x600 && glyph <= 0x6ff) return 1;
                if (glyph >= 0x750 && glyph <= 0x77f) return 1;
                if (glyph >= 0xfb50 && glyph <= 0xfc3f) return 1;
                if (glyph >= 0xfe70 && glyph <= 0xfefc) return 1;
            }
            return 0;
        }

        int _countchar = 0;

            int k;
        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
                string abc = memoEdit1.Text;

                double Count = 0;
                foreach (char glyph in abc)
                {
                    if ((glyph >= 0x600 && glyph <= 0x6ff) || (glyph >= 0x750 && glyph <= 0x77f) || (glyph >= 0xfb50 && glyph <= 0xfc3f) || (glyph >= 0xfe70 && glyph <= 0xfefc))

                    {
                        Count += 2.7;
                    }
                    else
                    {
                        Count += 1;
                    }
                }

                k = (int)Count;
                labelCHAR.Text = k.ToString();

            if (Count > 160)
            {
                MessageBox.Show("limite de sms !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelCHAR.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
          


            }
            else
            {
                labelCHAR.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }

               
                
            //}
            //else
            //{
            //   

            //    MessageBox.Show("limite de sms !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

        }
    }
}