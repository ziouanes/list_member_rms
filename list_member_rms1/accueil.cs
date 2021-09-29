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
            select_Mession();
            select_etatBureau();
            select_etatCommissions();


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





                if (Program.sql_con.State == ConnectionState.Closed)
                    Program.sql_con.Open();

                string query = $"select * from membre";

                    membreBindingSource1.DataSource = Program.sql_con.Query<membre>(query, commandType: CommandType.Text);


                
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

        private void select_etatBureau()
        {
            try
            {





                if (Program.sql_con.State == ConnectionState.Closed)
                    Program.sql_con.Open();

                string query = $"select m.photos , CONCAT(m.PrenomF ,' ', m.NomF) as nomf , CONCAT(m.PrenomA ,' ', m.NomA) as nomA  , s.Parti , f.Fonction_Fr  , p.ProvinceFr    from Sigle s inner join  membre m on s.id = m.Sigle inner join Fonction f on f.id = m.Fonction inner join Province p on p.id = m.Province inner join Etat_Member e on m.id = e.membre_id  where e.type_member = 1";

                bureauBindingSource.DataSource = Program.sql_con.Query<membre>(query, commandType: CommandType.Text);



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

        private void select_etatCommissions()
        {
            try
            {





                if (Program.sql_con.State == ConnectionState.Closed)
                    Program.sql_con.Open();

                string query = $"select m.photos , CONCAT(m.PrenomF ,' ', m.NomF) as nomf , CONCAT(m.PrenomA ,' ', m.NomA) as nomA  , s.Parti , f.Fonction_Fr  , p.ProvinceFr  , e.type_member   from Sigle s inner join  membre m on s.id = m.Sigle inner join Fonction f on f.id = m.Fonction inner join Province p on p.id = m.Province inner join Etat_Member e on m.id = e.membre_id  where e.type_member != 1";

                commissionsBindingSource.DataSource = Program.sql_con.Query<membre>(query, commandType: CommandType.Text);



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

        private void gridControlmember_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var rowM = gridView1.FocusedRowHandle;

            string id;
            id = gridView1.GetRowCellValue(rowM, "id").ToString();

            if (rowM >= 0)
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            else
                popupMenu1.HidePopup();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row2 = gridView1.FocusedRowHandle;
            int id;
            string CIN;
            string PrenomF;
            string NomF;
            string Fonction_Fr;
            string PrenomA ;
            string NomA;
            string email;
            string contact;
            DateTime Date_Naiss;
            string Adresse;
            string RIB;
            string AGENCE;
            byte[] photos;
            string Sigle;
            string ProvinceFr;
            id = int.Parse(gridView1.GetRowCellValue(row2, "id").ToString());
            //CIN = gridView1.GetRowCellValue(row2, "CIN").ToString();
            //PrenomF = gridView1.GetRowCellValue(row2, "PrenomF").ToString();
            //NomF = gridView1.GetRowCellValue(row2, "NomF").ToString();
            //Fonction_Fr= gridView1.GetRowCellValue(row2, "Fonction_Fr").ToString();
            //PrenomA = gridView1.GetRowCellValue(row2, "PrenomA").ToString();
            //NomA = gridView1.GetRowCellValue(row2, "NomA").ToString();
            //Fonction_Ar= gridView1.GetRowCellValue(row2, "Fonction_Ar").ToString();
            //email= gridView1.GetRowCellValue(row2, "email").ToString();
            //contact= gridView1.GetRowCellValue(row2, "contact").ToString();
            //Date_Naiss= Convert.ToDateTime(gridView1.GetRowCellValue(row2, "Date_Naiss").ToString());
            //Adresse= gridView1.GetRowCellValue(row2, "Adresse").ToString();
            //RIB= gridView1.GetRowCellValue(row2, "RIB").ToString();
            //AGENCE= gridView1.GetRowCellValue(row2, "AGENCE").ToString();
            //photos=Convert.ToByte(gridView1.GetRowCellValue(row2, "photos"));
            //Sigle= gridView1.GetRowCellValue(row2, "Sigle").ToString();
            //ProvinceFr= gridView1.GetRowCellValue(row2, "ProvinceFr").ToString();

            Membres membres = new Membres(id);
            membres.ShowDialog();


            select_Mession();


        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row2 = gridView1.FocusedRowHandle;
            int id;
            id = int.Parse(gridView1.GetRowCellValue(row2, "id").ToString());

            SituationFinal situation = new SituationFinal(id);
            situation.ShowDialog();
            select_etatBureau();
            select_etatCommissions();

        }
    }
}