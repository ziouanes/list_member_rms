using Dapper;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_member_rms1
{
    public partial class Membres : DevExpress.XtraEditors.XtraForm
    {
        public Membres()
        {
            InitializeComponent();

            select_sigle();
            select_Province();
            select_Fonction();
            pictureEdit2.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;




        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (pictureEdit2 != null)
            {
            MessageBox.Show(pictureEdit2.EditValue.ToString());
            }
        }

        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {

        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;

            //enregistre
            if (e.Button == windowsUIButtonPanelMain.Buttons[0])
            {
                //try
                //{
                    if (textEditadress.Text == "" || textEditagence.Text == "" || textEditcin.Text == "" || textEditcontact.Text == "" || textEditdate.Text == "" || textEditemail.Text == "" || textEditfunction.Text == ""|| textEditnom.Text == "" || textEditnomar.Text == "" || textEditprenom.Text == "" || textEditprenomar.Text == "" || textEditprovince.Text == "" || textEditrib.Text == "" || textEditsigle.Text == "" )

                    {
                        XtraMessageBox.Show("champs obligatoires");

                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream();

                       // pictureEdit2.Image = Bitmap.FromFile(dialog.FileName);
                        //pictureEdit2.Image.Save(memory, ImageFormat.Png);
                        //byte[] b = memory.ToArray();

                        string sql = "INSERT INTO [dbo].[membre](CIN,PrenomF,NomF,Fonction,PrenomA,NomA,email,contact,Date_Naiss,Adresse,RIB,AGENCE,photos,Province,Sigle) VALUES(@CIN,@PrenomF,@NomF,@Fonction,@PrenomA,@NomA,@email,@contact,@Date_Naiss,@Adresse,@RIB,@AGENCE,@photos,@Province,@Sigle)";

                    Program.sql_cmd = new SqlCommand(sql, Program.sql_con);
                    Program.sql_cmd.Parameters.AddWithValue("@CIN", textEditcin.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@PrenomF", textEditprenom.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@NomF", textEditnom.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@Fonction", textEditfunction.EditValue);
                    Program.sql_cmd.Parameters.AddWithValue("@PrenomA", textEditprenomar.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@NomA", textEditnomar.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@email", textEditemail.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@contact", textEditcontact.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@Date_Naiss", textEditdate.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@Adresse", textEditadress.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@RIB", textEditrib.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@AGENCE", textEditagence.Text);
                    Program.sql_cmd.Parameters.AddWithValue("@photos", pictureEdit2.EditValue);
                    Program.sql_cmd.Parameters.AddWithValue("@Province", textEditprovince.EditValue);
                    Program.sql_cmd.Parameters.AddWithValue("@Sigle", textEditsigle.EditValue);




                    if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();
                            Program.sql_cmd.ExecuteNonQuery();
                            Program.sql_con.Close();
                        MessageBox.Show("done");
                      //  toastNotificationsManager1.ShowNotification("1d00270b-1651-4ed4-a139-bd59d5d8cf8e");
                    }
                //}
                //catch (Exception ex)
                //{
                //    XtraMessageBox.Show(ex.Message);
                //}
                //finally
                //{
                //    //this.Dispose();
                //}
            }
        }

        private void select_sigle()
        {
            try
            {



                

                    if (Program.sql_con.State == ConnectionState.Closed)
                        Program.sql_con.Open();

                    string query = $"select * from Sigle";

                    sigleBindingSource.DataSource = Program.sql_con.Query<_Sigle>(query, commandType: CommandType.Text);


                
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

        private void select_Fonction()
        {
            try
            {





                if (Program.sql_con.State == ConnectionState.Closed)
                    Program.sql_con.Open();

                string query = $"select * from Fonction";

                fonctionBindingSource.DataSource = Program.sql_con.Query<Fonction>(query, commandType: CommandType.Text);



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

        private void select_Province()
        {
            try
            {





                if (Program.sql_con.State == ConnectionState.Closed)
                    Program.sql_con.Open();

                string query = $"select * from Province";

                previnceBindingSource.DataSource = Program.sql_con.Query<prevince>(query, commandType: CommandType.Text);



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

        private void Membres_Load(object sender, EventArgs e)
        {
            textEditfunction.Properties.Buttons[1].Click += addper;
        }

        private void addper(object sender, EventArgs e)
        {
            Fonctionfrm person = new Fonctionfrm();
            person.ShowDialog();
            select_Fonction();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {//try
         //{
            
                MemoryStream memory = new MemoryStream();

            // pictureEdit2.Image = Bitmap.FromFile(dialog.FileName);
            //pictureEdit2.Image.Save(memory, ImageFormat.Png);
            //byte[] b = memory.ToArray();

            string sql = "INSERT INTO [dbo].[membre](CIN,PrenomF,NomF,Fonction,PrenomA,NomA,email,contact,Date_Naiss,Adresse,RIB,AGENCE,photos,Province,Sigle) VALUES(@CIN,@PrenomF,@NomF,@Fonction,@PrenomA,@NomA,@email,@contact,@Date_Naiss,@Adresse,@RIB,@AGENCE,@photos,@Province,@Sigle)";


            Program.sql_cmd = new SqlCommand(sql, Program.sql_con);
            Program.sql_cmd.Parameters.AddWithValue("@CIN", textEditcin.Text);
            Program.sql_cmd.Parameters.AddWithValue("@PrenomF", textEditprenom.Text);
            Program.sql_cmd.Parameters.AddWithValue("@NomF", textEditnom.Text);
            Program.sql_cmd.Parameters.AddWithValue("@Fonction", textEditfunction.EditValue);
            Program.sql_cmd.Parameters.AddWithValue("@PrenomA", textEditprenomar.Text);
            Program.sql_cmd.Parameters.AddWithValue("@NomA", textEditnomar.Text);
            Program.sql_cmd.Parameters.AddWithValue("@email", textEditemail.Text);
            Program.sql_cmd.Parameters.AddWithValue("@contact", textEditcontact.Text);
            Program.sql_cmd.Parameters.AddWithValue("@Date_Naiss", textEditdate.Text);
            Program.sql_cmd.Parameters.AddWithValue("@Adresse", textEditadress.Text);
            Program.sql_cmd.Parameters.AddWithValue("@RIB", textEditrib.Text);
            Program.sql_cmd.Parameters.AddWithValue("@AGENCE", textEditagence.Text);
            Program.sql_cmd.Parameters.AddWithValue("@photos", pictureEdit2.EditValue);
            Program.sql_cmd.Parameters.AddWithValue("@Province", textEditprovince.EditValue);
            Program.sql_cmd.Parameters.AddWithValue("@Sigle", textEditsigle.EditValue);



            if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();
            Program.sql_cmd.ExecuteNonQuery();
            Program.sql_con.Close();
            MessageBox.Show("done");

            //Program.sql_cmd.Parameters.Add("@Photos", SqlDbType.Image);
            //Program.sql_cmd.Parameters["@Photos"].SqlValue = pictureEdit2.EditValue;

            if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();
                Program.sql_cmd.ExecuteNonQuery();
                Program.sql_con.Close();
                MessageBox.Show("done");
                //  toastNotificationsManager1.ShowNotification("1d00270b-1651-4ed4-a139-bd59d5d8cf8e");
            
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    //this.Dispose();
            //}
        }
    }
}