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
    public partial class SituationFinal : DevExpress.XtraEditors.XtraForm
    {
        public SituationFinal(int id)
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(lookUpEdit1.SelectedIndex!=-1)
            MessageBox.Show(lookUpEdit1.SelectedIndex.ToString());
        }

        private void SituationFinal_Load(object sender, EventArgs e)
        {

        }
    }
}