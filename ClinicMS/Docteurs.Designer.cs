
namespace ClinicMS
{
    partial class Docteurs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docteurs));
            this.Specialite = new System.Windows.Forms.TextBox();
            this.Departement = new System.Windows.Forms.TextBox();
            this.DateAmbauche = new System.Windows.Forms.DateTimePicker();
            this.D_Email = new System.Windows.Forms.TextBox();
            this.D_Adresse = new System.Windows.Forms.TextBox();
            this.D_Telephone = new System.Windows.Forms.TextBox();
            this.D_Prenom = new System.Windows.Forms.TextBox();
            this.D_Nom = new System.Windows.Forms.TextBox();
            this.D_Cin = new System.Windows.Forms.TextBox();
            this.d_embauche_label = new System.Windows.Forms.Label();
            this.d_specialite_label = new System.Windows.Forms.Label();
            this.d_dep_label = new System.Windows.Forms.Label();
            this.d_email_label = new System.Windows.Forms.Label();
            this.d_address_label = new System.Windows.Forms.Label();
            this.d_phone_label = new System.Windows.Forms.Label();
            this.d_prenom_label = new System.Windows.Forms.Label();
            this.d_nom_label = new System.Windows.Forms.Label();
            this.d_id_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.doc_id_searchbox = new System.Windows.Forms.TextBox();
            this.Gradelbl = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.TextBox();
            this.dataSet1 = new ClinicMS.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titlelabel = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Specialite
            // 
            this.Specialite.Location = new System.Drawing.Point(739, 456);
            this.Specialite.Name = "Specialite";
            this.Specialite.Size = new System.Drawing.Size(149, 20);
            this.Specialite.TabIndex = 98;
            // 
            // Departement
            // 
            this.Departement.Location = new System.Drawing.Point(739, 412);
            this.Departement.Name = "Departement";
            this.Departement.Size = new System.Drawing.Size(149, 20);
            this.Departement.TabIndex = 97;
            // 
            // DateAmbauche
            // 
            this.DateAmbauche.Location = new System.Drawing.Point(739, 502);
            this.DateAmbauche.Name = "DateAmbauche";
            this.DateAmbauche.Size = new System.Drawing.Size(149, 20);
            this.DateAmbauche.TabIndex = 96;
            // 
            // D_Email
            // 
            this.D_Email.Location = new System.Drawing.Point(739, 322);
            this.D_Email.Name = "D_Email";
            this.D_Email.Size = new System.Drawing.Size(149, 20);
            this.D_Email.TabIndex = 94;
            // 
            // D_Adresse
            // 
            this.D_Adresse.Location = new System.Drawing.Point(739, 279);
            this.D_Adresse.Name = "D_Adresse";
            this.D_Adresse.Size = new System.Drawing.Size(149, 20);
            this.D_Adresse.TabIndex = 93;
            // 
            // D_Telephone
            // 
            this.D_Telephone.Location = new System.Drawing.Point(739, 235);
            this.D_Telephone.Name = "D_Telephone";
            this.D_Telephone.Size = new System.Drawing.Size(149, 20);
            this.D_Telephone.TabIndex = 92;
            // 
            // D_Prenom
            // 
            this.D_Prenom.Location = new System.Drawing.Point(739, 191);
            this.D_Prenom.Name = "D_Prenom";
            this.D_Prenom.Size = new System.Drawing.Size(149, 20);
            this.D_Prenom.TabIndex = 91;
            // 
            // D_Nom
            // 
            this.D_Nom.Location = new System.Drawing.Point(739, 150);
            this.D_Nom.Name = "D_Nom";
            this.D_Nom.Size = new System.Drawing.Size(149, 20);
            this.D_Nom.TabIndex = 90;
            // 
            // D_Cin
            // 
            this.D_Cin.Location = new System.Drawing.Point(739, 108);
            this.D_Cin.Name = "D_Cin";
            this.D_Cin.Size = new System.Drawing.Size(149, 20);
            this.D_Cin.TabIndex = 89;
            // 
            // d_embauche_label
            // 
            this.d_embauche_label.AutoSize = true;
            this.d_embauche_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_embauche_label.Location = new System.Drawing.Point(607, 501);
            this.d_embauche_label.Name = "d_embauche_label";
            this.d_embauche_label.Size = new System.Drawing.Size(135, 20);
            this.d_embauche_label.TabIndex = 88;
            this.d_embauche_label.Text = "Date d\'embauche:";
            // 
            // d_specialite_label
            // 
            this.d_specialite_label.AutoSize = true;
            this.d_specialite_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_specialite_label.Location = new System.Drawing.Point(607, 456);
            this.d_specialite_label.Name = "d_specialite_label";
            this.d_specialite_label.Size = new System.Drawing.Size(79, 20);
            this.d_specialite_label.TabIndex = 86;
            this.d_specialite_label.Text = "Spécialité:";
            // 
            // d_dep_label
            // 
            this.d_dep_label.AutoSize = true;
            this.d_dep_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_dep_label.Location = new System.Drawing.Point(607, 412);
            this.d_dep_label.Name = "d_dep_label";
            this.d_dep_label.Size = new System.Drawing.Size(106, 20);
            this.d_dep_label.TabIndex = 85;
            this.d_dep_label.Text = "Département:";
            // 
            // d_email_label
            // 
            this.d_email_label.AutoSize = true;
            this.d_email_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_email_label.Location = new System.Drawing.Point(607, 321);
            this.d_email_label.Name = "d_email_label";
            this.d_email_label.Size = new System.Drawing.Size(51, 20);
            this.d_email_label.TabIndex = 84;
            this.d_email_label.Text = "Email:";
            // 
            // d_address_label
            // 
            this.d_address_label.AutoSize = true;
            this.d_address_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_address_label.Location = new System.Drawing.Point(607, 279);
            this.d_address_label.Name = "d_address_label";
            this.d_address_label.Size = new System.Drawing.Size(69, 20);
            this.d_address_label.TabIndex = 83;
            this.d_address_label.Text = "Adresse:";
            // 
            // d_phone_label
            // 
            this.d_phone_label.AutoSize = true;
            this.d_phone_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_phone_label.Location = new System.Drawing.Point(607, 234);
            this.d_phone_label.Name = "d_phone_label";
            this.d_phone_label.Size = new System.Drawing.Size(84, 20);
            this.d_phone_label.TabIndex = 82;
            this.d_phone_label.Text = "Telephone:";
            // 
            // d_prenom_label
            // 
            this.d_prenom_label.AutoSize = true;
            this.d_prenom_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_prenom_label.Location = new System.Drawing.Point(607, 191);
            this.d_prenom_label.Name = "d_prenom_label";
            this.d_prenom_label.Size = new System.Drawing.Size(68, 20);
            this.d_prenom_label.TabIndex = 81;
            this.d_prenom_label.Text = "Prénom:";
            // 
            // d_nom_label
            // 
            this.d_nom_label.AutoSize = true;
            this.d_nom_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_nom_label.Location = new System.Drawing.Point(607, 150);
            this.d_nom_label.Name = "d_nom_label";
            this.d_nom_label.Size = new System.Drawing.Size(48, 20);
            this.d_nom_label.TabIndex = 80;
            this.d_nom_label.Text = "Nom:";
            // 
            // d_id_label
            // 
            this.d_id_label.AutoSize = true;
            this.d_id_label.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_id_label.Location = new System.Drawing.Point(607, 108);
            this.d_id_label.Name = "d_id_label";
            this.d_id_label.Size = new System.Drawing.Size(39, 20);
            this.d_id_label.TabIndex = 79;
            this.d_id_label.Text = "CIN:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 368);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.Location = new System.Drawing.Point(739, 551);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(116, 50);
            this.deletebtn.TabIndex = 77;
            this.deletebtn.Text = "Supprimer";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click_1);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("updatebtn.Image")));
            this.updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.Location = new System.Drawing.Point(625, 551);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(102, 50);
            this.updatebtn.TabIndex = 76;
            this.updatebtn.Text = "Editer";
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Doctor ID";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // doc_id_searchbox
            // 
            this.doc_id_searchbox.Location = new System.Drawing.Point(164, 144);
            this.doc_id_searchbox.Name = "doc_id_searchbox";
            this.doc_id_searchbox.Size = new System.Drawing.Size(116, 20);
            this.doc_id_searchbox.TabIndex = 74;
            this.doc_id_searchbox.TextChanged += new System.EventHandler(this.doc_id_searchbox_TextChanged_1);
            // 
            // Gradelbl
            // 
            this.Gradelbl.AutoSize = true;
            this.Gradelbl.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gradelbl.Location = new System.Drawing.Point(607, 368);
            this.Gradelbl.Name = "Gradelbl";
            this.Gradelbl.Size = new System.Drawing.Size(55, 20);
            this.Gradelbl.TabIndex = 99;
            this.Gradelbl.Text = "Grade:";
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(739, 368);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(149, 20);
            this.Grade.TabIndex = 100;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // titlelabel
            // 
            this.titlelabel.AutoEllipsis = false;
            this.titlelabel.CursorType = null;
            this.titlelabel.Font = new System.Drawing.Font(".", 26.25F, System.Drawing.FontStyle.Bold);
            this.titlelabel.ForeColor = System.Drawing.Color.Black;
            this.titlelabel.Location = new System.Drawing.Point(47, 21);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titlelabel.Size = new System.Drawing.Size(326, 47);
            this.titlelabel.TabIndex = 101;
            this.titlelabel.Text = "Consulter Docteurs";
            this.titlelabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.titlelabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Docteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Gradelbl);
            this.Controls.Add(this.Specialite);
            this.Controls.Add(this.Departement);
            this.Controls.Add(this.DateAmbauche);
            this.Controls.Add(this.D_Email);
            this.Controls.Add(this.D_Adresse);
            this.Controls.Add(this.D_Telephone);
            this.Controls.Add(this.D_Prenom);
            this.Controls.Add(this.D_Nom);
            this.Controls.Add(this.D_Cin);
            this.Controls.Add(this.d_embauche_label);
            this.Controls.Add(this.d_specialite_label);
            this.Controls.Add(this.d_dep_label);
            this.Controls.Add(this.d_email_label);
            this.Controls.Add(this.d_address_label);
            this.Controls.Add(this.d_phone_label);
            this.Controls.Add(this.d_prenom_label);
            this.Controls.Add(this.d_nom_label);
            this.Controls.Add(this.d_id_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doc_id_searchbox);
            this.Name = "Docteurs";
            this.Size = new System.Drawing.Size(907, 619);
            this.Load += new System.EventHandler(this.Docteurs_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Specialite;
        private System.Windows.Forms.TextBox Departement;
        private System.Windows.Forms.DateTimePicker DateAmbauche;
        private System.Windows.Forms.TextBox D_Email;
        private System.Windows.Forms.TextBox D_Adresse;
        private System.Windows.Forms.TextBox D_Telephone;
        private System.Windows.Forms.TextBox D_Prenom;
        private System.Windows.Forms.TextBox D_Nom;
        private System.Windows.Forms.TextBox D_Cin;
        private System.Windows.Forms.Label d_embauche_label;
        private System.Windows.Forms.Label d_specialite_label;
        private System.Windows.Forms.Label d_dep_label;
        private System.Windows.Forms.Label d_email_label;
        private System.Windows.Forms.Label d_address_label;
        private System.Windows.Forms.Label d_phone_label;
        private System.Windows.Forms.Label d_prenom_label;
        private System.Windows.Forms.Label d_nom_label;
        private System.Windows.Forms.Label d_id_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox doc_id_searchbox;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.Label Gradelbl;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private Bunifu.UI.WinForms.BunifuLabel titlelabel;
    }
}
