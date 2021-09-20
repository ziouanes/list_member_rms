using Dapper;
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
    public partial class accueil : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public accueil()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Membres mb = new Membres();
            mb.ShowDialog();

        }

        private void accueil_Load(object sender, EventArgs e)
        {

        }

        private void select_Mession()
        {
            try
            {


                using (SqlConnection sql_con = new SqlConnection(@"server =192.168.100.92;database = simpleDatabase ; user id = log1; password=P@ssword1965** ;MultipleActiveResultSets = True;"))

                {

                    if (sql_con.State == ConnectionState.Closed)
                        sql_con.Open();

                    string query = $"select * from membre";

                    membreBindingSource.DataSource = sql_con.Query<membre>(query, commandType: CommandType.Text);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //this.Dispose();
            }
        }
    }
}