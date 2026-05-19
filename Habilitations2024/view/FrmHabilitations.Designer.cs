namespace Habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHabilitations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actualiser = new System.Windows.Forms.Button();
            this.absences = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbserv = new System.Windows.Forms.ComboBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.texttel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.textmail = new System.Windows.Forms.TextBox();
            this.service = new System.Windows.Forms.Label();
            this.textpre = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.textprenom = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.absence = new System.Windows.Forms.GroupBox();
            this.cbmot = new System.Windows.Forms.ComboBox();
            this.dtfin = new System.Windows.Forms.DateTimePicker();
            this.dtdebut = new System.Windows.Forms.DateTimePicker();
            this.supp = new System.Windows.Forms.Button();
            this.modfier = new System.Windows.Forms.Button();
            this.motif = new System.Windows.Forms.Label();
            this.Ajoutabsence = new System.Windows.Forms.Button();
            this.datefin = new System.Windows.Forms.Label();
            this.dgvabsenc = new System.Windows.Forms.DataGridView();
            this.datedebut = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.absence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvabsenc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actualiser);
            this.groupBox1.Controls.Add(this.absences);
            this.groupBox1.Controls.Add(this.supprimer);
            this.groupBox1.Controls.Add(this.Modifier);
            this.groupBox1.Controls.Add(this.dgvPersonnel);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.FrmHabilitations_Load);
            // 
            // actualiser
            // 
            resources.ApplyResources(this.actualiser, "actualiser");
            this.actualiser.Name = "actualiser";
            this.actualiser.UseVisualStyleBackColor = true;
            this.actualiser.Click += new System.EventHandler(this.actualiser_Click);
            // 
            // absences
            // 
            resources.ApplyResources(this.absences, "absences");
            this.absences.Name = "absences";
            this.absences.UseVisualStyleBackColor = true;
            // 
            // supprimer
            // 
            resources.ApplyResources(this.supprimer, "supprimer");
            this.supprimer.Name = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.Modifier, "Modifier");
            this.Modifier.Name = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.GridColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.dgvPersonnel, "dgvPersonnel");
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowTemplate.Height = 28;
            this.dgvPersonnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbserv);
            this.groupBox2.Controls.Add(this.Enregistrer);
            this.groupBox2.Controls.Add(this.Annuler);
            this.groupBox2.Controls.Add(this.texttel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tel);
            this.groupBox2.Controls.Add(this.textmail);
            this.groupBox2.Controls.Add(this.service);
            this.groupBox2.Controls.Add(this.textpre);
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.textprenom);
            this.groupBox2.Controls.Add(this.mail);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cmbserv
            // 
            this.cmbserv.FormattingEnabled = true;
            this.cmbserv.Items.AddRange(new object[] {
            resources.GetString("cmbserv.Items"),
            resources.GetString("cmbserv.Items1"),
            resources.GetString("cmbserv.Items2")});
            resources.ApplyResources(this.cmbserv, "cmbserv");
            this.cmbserv.Name = "cmbserv";
            // 
            // Enregistrer
            // 
            resources.ApplyResources(this.Enregistrer, "Enregistrer");
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.RosyBrown;
            this.Annuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.Annuler, "Annuler");
            this.Annuler.Name = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            // 
            // texttel
            // 
            resources.ApplyResources(this.texttel, "texttel");
            this.texttel.Name = "texttel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tel
            // 
            resources.ApplyResources(this.tel, "tel");
            this.tel.Name = "tel";
            this.tel.Click += new System.EventHandler(this.label3_Click);
            // 
            // textmail
            // 
            resources.ApplyResources(this.textmail, "textmail");
            this.textmail.Name = "textmail";
            // 
            // service
            // 
            resources.ApplyResources(this.service, "service");
            this.service.Name = "service";
            // 
            // textpre
            // 
            resources.ApplyResources(this.textpre, "textpre");
            this.textpre.Name = "textpre";
            // 
            // txtnom
            // 
            resources.ApplyResources(this.txtnom, "txtnom");
            this.txtnom.Name = "txtnom";
            // 
            // textprenom
            // 
            resources.ApplyResources(this.textprenom, "textprenom");
            this.textprenom.Name = "textprenom";
            this.textprenom.Click += new System.EventHandler(this.label2_Click);
            // 
            // mail
            // 
            resources.ApplyResources(this.mail, "mail");
            this.mail.Name = "mail";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // absence
            // 
            this.absence.Controls.Add(this.cbmot);
            this.absence.Controls.Add(this.dtfin);
            this.absence.Controls.Add(this.dtdebut);
            this.absence.Controls.Add(this.supp);
            this.absence.Controls.Add(this.modfier);
            this.absence.Controls.Add(this.motif);
            this.absence.Controls.Add(this.Ajoutabsence);
            this.absence.Controls.Add(this.datefin);
            this.absence.Controls.Add(this.dgvabsenc);
            this.absence.Controls.Add(this.datedebut);
            resources.ApplyResources(this.absence, "absence");
            this.absence.Name = "absence";
            this.absence.TabStop = false;
            // 
            // cbmot
            // 
            this.cbmot.FormattingEnabled = true;
            resources.ApplyResources(this.cbmot, "cbmot");
            this.cbmot.Name = "cbmot";
            // 
            // dtfin
            // 
            resources.ApplyResources(this.dtfin, "dtfin");
            this.dtfin.Name = "dtfin";
            // 
            // dtdebut
            // 
            resources.ApplyResources(this.dtdebut, "dtdebut");
            this.dtdebut.Name = "dtdebut";
            // 
            // supp
            // 
            this.supp.BackColor = System.Drawing.Color.RosyBrown;
            this.supp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.supp, "supp");
            this.supp.Name = "supp";
            this.supp.UseVisualStyleBackColor = false;
            this.supp.Click += new System.EventHandler(this.button3_Click);
            // 
            // modfier
            // 
            resources.ApplyResources(this.modfier, "modfier");
            this.modfier.Name = "modfier";
            this.modfier.UseVisualStyleBackColor = true;
            // 
            // motif
            // 
            resources.ApplyResources(this.motif, "motif");
            this.motif.Name = "motif";
            // 
            // Ajoutabsence
            // 
            resources.ApplyResources(this.Ajoutabsence, "Ajoutabsence");
            this.Ajoutabsence.Name = "Ajoutabsence";
            this.Ajoutabsence.UseVisualStyleBackColor = true;
            // 
            // datefin
            // 
            resources.ApplyResources(this.datefin, "datefin");
            this.datefin.Name = "datefin";
            // 
            // dgvabsenc
            // 
            this.dgvabsenc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvabsenc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvabsenc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvabsenc, "dgvabsenc");
            this.dgvabsenc.Name = "dgvabsenc";
            this.dgvabsenc.RowTemplate.Height = 28;
            this.dgvabsenc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // datedebut
            // 
            resources.ApplyResources(this.datedebut, "datedebut");
            this.datedebut.Name = "datedebut";
            this.datedebut.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FrmHabilitations
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.absence);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHabilitations";
            this.Load += new System.EventHandler(this.FrmHabilitations_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.absence.ResumeLayout(false);
            this.absence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvabsenc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button actualiser;
        private System.Windows.Forms.Button absences;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox textpre;
        private System.Windows.Forms.TextBox texttel;
        private System.Windows.Forms.Label textprenom;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.TextBox textmail;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.GroupBox absence;
        private System.Windows.Forms.DataGridView dgvabsenc;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.Button modfier;
        private System.Windows.Forms.Button Ajoutabsence;
        private System.Windows.Forms.Label datedebut;
        private System.Windows.Forms.Label datefin;
        private System.Windows.Forms.Label motif;
        private System.Windows.Forms.DateTimePicker dtfin;
        private System.Windows.Forms.DateTimePicker dtdebut;
        private System.Windows.Forms.ComboBox cbmot;
        private System.Windows.Forms.ComboBox cmbserv;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

