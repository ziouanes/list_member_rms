using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_member_rms1
{
    public partial class SituationFinal : DevExpress.XtraEditors.XtraForm
    {
        int idmember = 0;
        public SituationFinal(int id)
        {
            InitializeComponent();

            idmember = id;
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(lookUpEdit1.SelectedIndex!=-1)
            MessageBox.Show(lookUpEdit1.SelectedIndex.ToString());


             void RunStoredProc()
            {

                //MessageBox.Show(lastdate.ToString());
                //error here
                try
                {
                    if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();
                    SqlCommand cmd = new SqlCommand("dbo.suivi_delai", Program.sql_con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NewEtat", lookUpEdit1.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@id_member", idmember);

                    







                    cmd.ExecuteNonQuery();

                    this.Close();
                    toastNotificationsManager1.ShowNotification("1d64e869-4872-4e09-84cf-b39df09f0482");

                }
                finally
                {
                    if (Program.sql_con != null)
                    {
                        Program.sql_con.Close();
                    }
                    if (Program.db != null)
                    {
                        Program.db.Close();
                    }
                }
            }


        }

        private void SituationFinal_Load(object sender, EventArgs e)
        {

        }
    }
}