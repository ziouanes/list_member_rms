
namespace list_member_rms1
{
    partial class SituationFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(82, 182);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Enregistre";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "Collectivité Territoriale: ";
            this.lookUpEdit1.Location = new System.Drawing.Point(12, 12);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Items.AddRange(new object[] {
            "-",
            "Membres du Bureau ",
            "la Commission: Budget, finances et de la programmation",
            "la Commission: Développement économique, social et environnemental, de la formati" +
                "on professionnelle et de la formation ",
            "la Commission: l’Aménagement du territoire",
            "la Commission: Action culturelle ",
            "la Commission: Tourisme et de l\'artisanat",
            "la Commission: Coopération et de partenariat",
            "la Commission:  la femme, l’enfance et la jeunesse"});
            this.lookUpEdit1.Properties.NullText = "[EditValue is null]";
            this.lookUpEdit1.Properties.PopupSizeable = true;
            this.lookUpEdit1.Size = new System.Drawing.Size(259, 20);
            this.lookUpEdit1.TabIndex = 0;
            // 
            // SituationFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 268);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lookUpEdit1);
            this.Name = "SituationFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SituationFinal";
            this.Load += new System.EventHandler(this.SituationFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit lookUpEdit1;
    }
}