namespace AppEval
{
    partial class OffreCritereDRH
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
            this.OffreCritere = new System.Windows.Forms.DataGridView();
            this.Critères = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.bttnSupprimer = new System.Windows.Forms.Button();
            this.listBoxOffre = new System.Windows.Forms.ListBox();
            this.dateTimePickeDateLimite = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCritere = new System.Windows.Forms.GroupBox();
            this.listBoxOffreID = new System.Windows.Forms.ListBox();
            this.buttonAjouterDate = new System.Windows.Forms.Button();
            this.labelOfres = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.labelDateLimite = new System.Windows.Forms.Label();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Valider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoeff = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxModifierCritere = new System.Windows.Forms.GroupBox();
            this.buttonModifierCritere = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCoeff = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).BeginInit();
            this.groupBoxCritere.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxModifierCritere.SuspendLayout();
            this.SuspendLayout();
            // 
            // OffreCritere
            // 
            this.OffreCritere.AllowUserToAddRows = false;
            this.OffreCritere.AllowUserToDeleteRows = false;
            this.OffreCritere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffreCritere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Critères});
            this.OffreCritere.Location = new System.Drawing.Point(243, 79);
            this.OffreCritere.Name = "OffreCritere";
            this.OffreCritere.Size = new System.Drawing.Size(267, 342);
            this.OffreCritere.TabIndex = 0;
            // 
            // Critères
            // 
            this.Critères.HeaderText = "Critères";
            this.Critères.Name = "Critères";
            this.Critères.ReadOnly = true;
            this.Critères.Width = 200;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(544, 109);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(98, 50);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter un critère";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // bttnSupprimer
            // 
            this.bttnSupprimer.Location = new System.Drawing.Point(544, 258);
            this.bttnSupprimer.Name = "bttnSupprimer";
            this.bttnSupprimer.Size = new System.Drawing.Size(98, 46);
            this.bttnSupprimer.TabIndex = 3;
            this.bttnSupprimer.Text = "Supprimer";
            this.bttnSupprimer.UseVisualStyleBackColor = true;
            this.bttnSupprimer.Click += new System.EventHandler(this.bttnSupprimer_Click);
            // 
            // listBoxOffre
            // 
            this.listBoxOffre.FormattingEnabled = true;
            this.listBoxOffre.Location = new System.Drawing.Point(9, 79);
            this.listBoxOffre.Name = "listBoxOffre";
            this.listBoxOffre.Size = new System.Drawing.Size(167, 342);
            this.listBoxOffre.TabIndex = 4;
            this.listBoxOffre.SelectedIndexChanged += new System.EventHandler(this.listBoxOffre_SelectedIndexChanged);
            // 
            // dateTimePickeDateLimite
            // 
            this.dateTimePickeDateLimite.Location = new System.Drawing.Point(34, 70);
            this.dateTimePickeDateLimite.Name = "dateTimePickeDateLimite";
            this.dateTimePickeDateLimite.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickeDateLimite.TabIndex = 5;
            // 
            // groupBoxCritere
            // 
            this.groupBoxCritere.Controls.Add(this.listBoxOffreID);
            this.groupBoxCritere.Controls.Add(this.buttonAjouterDate);
            this.groupBoxCritere.Controls.Add(this.labelOfres);
            this.groupBoxCritere.Controls.Add(this.buttonModifier);
            this.groupBoxCritere.Controls.Add(this.bttnSupprimer);
            this.groupBoxCritere.Controls.Add(this.listBoxOffre);
            this.groupBoxCritere.Controls.Add(this.buttonAjouter);
            this.groupBoxCritere.Controls.Add(this.OffreCritere);
            this.groupBoxCritere.Location = new System.Drawing.Point(12, 22);
            this.groupBoxCritere.Name = "groupBoxCritere";
            this.groupBoxCritere.Size = new System.Drawing.Size(662, 610);
            this.groupBoxCritere.TabIndex = 6;
            this.groupBoxCritere.TabStop = false;
            this.groupBoxCritere.Text = "Critères";
            // 
            // listBoxOffreID
            // 
            this.listBoxOffreID.FormattingEnabled = true;
            this.listBoxOffreID.Location = new System.Drawing.Point(14, 444);
            this.listBoxOffreID.Name = "listBoxOffreID";
            this.listBoxOffreID.Size = new System.Drawing.Size(176, 108);
            this.listBoxOffreID.TabIndex = 8;
            this.listBoxOffreID.Visible = false;
            // 
            // buttonAjouterDate
            // 
            this.buttonAjouterDate.Location = new System.Drawing.Point(544, 326);
            this.buttonAjouterDate.Name = "buttonAjouterDate";
            this.buttonAjouterDate.Size = new System.Drawing.Size(98, 46);
            this.buttonAjouterDate.TabIndex = 7;
            this.buttonAjouterDate.Text = "Ajouter une date ";
            this.buttonAjouterDate.UseVisualStyleBackColor = true;
            this.buttonAjouterDate.Click += new System.EventHandler(this.buttonAjouterDate_Click);
            // 
            // labelOfres
            // 
            this.labelOfres.AutoSize = true;
            this.labelOfres.Location = new System.Drawing.Point(6, 46);
            this.labelOfres.Name = "labelOfres";
            this.labelOfres.Size = new System.Drawing.Size(41, 13);
            this.labelOfres.TabIndex = 6;
            this.labelOfres.Text = "Offres :";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(544, 187);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(98, 46);
            this.buttonModifier.TabIndex = 4;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // labelDateLimite
            // 
            this.labelDateLimite.AutoSize = true;
            this.labelDateLimite.Location = new System.Drawing.Point(68, 36);
            this.labelDateLimite.Name = "labelDateLimite";
            this.labelDateLimite.Size = new System.Drawing.Size(66, 13);
            this.labelDateLimite.TabIndex = 7;
            this.labelDateLimite.Text = "Date Limite :";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.groupBox1);
            this.groupBoxDate.Controls.Add(this.buttonValider);
            this.groupBoxDate.Controls.Add(this.labelDateLimite);
            this.groupBoxDate.Controls.Add(this.dateTimePickeDateLimite);
            this.groupBoxDate.Location = new System.Drawing.Point(680, 22);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(208, 159);
            this.groupBoxDate.TabIndex = 8;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Date :";
            this.groupBoxDate.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Valider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCoeff);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Location = new System.Drawing.Point(0, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un Critère";
            // 
            // Valider
            // 
            this.Valider.AutoSize = true;
            this.Valider.Location = new System.Drawing.Point(60, 116);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(50, 13);
            this.Valider.TabIndex = 7;
            this.Valider.Text = "Message";
            this.Valider.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coefficient :";
            // 
            // txtCoeff
            // 
            this.txtCoeff.Location = new System.Drawing.Point(91, 76);
            this.txtCoeff.Name = "txtCoeff";
            this.txtCoeff.Size = new System.Drawing.Size(100, 20);
            this.txtCoeff.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(91, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(63, 120);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(84, 29);
            this.buttonValider.TabIndex = 10;
            this.buttonValider.Text = "Valider Date";
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click_1);
            // 
            // groupBoxModifierCritere
            // 
            this.groupBoxModifierCritere.Controls.Add(this.buttonModifierCritere);
            this.groupBoxModifierCritere.Controls.Add(this.label4);
            this.groupBoxModifierCritere.Controls.Add(this.label5);
            this.groupBoxModifierCritere.Controls.Add(this.textBoxCoeff);
            this.groupBoxModifierCritere.Controls.Add(this.textBoxNom);
            this.groupBoxModifierCritere.Location = new System.Drawing.Point(680, 258);
            this.groupBoxModifierCritere.Name = "groupBoxModifierCritere";
            this.groupBoxModifierCritere.Size = new System.Drawing.Size(208, 143);
            this.groupBoxModifierCritere.TabIndex = 9;
            this.groupBoxModifierCritere.TabStop = false;
            this.groupBoxModifierCritere.Text = "Modifier Critère";
            this.groupBoxModifierCritere.Visible = false;
            // 
            // buttonModifierCritere
            // 
            this.buttonModifierCritere.Location = new System.Drawing.Point(63, 117);
            this.buttonModifierCritere.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifierCritere.Name = "buttonModifierCritere";
            this.buttonModifierCritere.Size = new System.Drawing.Size(105, 19);
            this.buttonModifierCritere.TabIndex = 0;
            this.buttonModifierCritere.Text = "Modifier Critère";
            this.buttonModifierCritere.Click += new System.EventHandler(this.buttonModifierCritere_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Coefficient :";
            // 
            // textBoxCoeff
            // 
            this.textBoxCoeff.Location = new System.Drawing.Point(91, 76);
            this.textBoxCoeff.Name = "textBoxCoeff";
            this.textBoxCoeff.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoeff.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(91, 39);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // OffreCritereDRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 644);
            this.Controls.Add(this.groupBoxModifierCritere);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxCritere);
            this.Name = "OffreCritereDRH";
            this.Text = "OffreDRH";
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).EndInit();
            this.groupBoxCritere.ResumeLayout(false);
            this.groupBoxCritere.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxModifierCritere.ResumeLayout(false);
            this.groupBoxModifierCritere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OffreCritere;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button bttnSupprimer;
        private System.Windows.Forms.ListBox listBoxOffre;
        private System.Windows.Forms.DateTimePicker dateTimePickeDateLimite;
        private System.Windows.Forms.GroupBox groupBoxCritere;
        private System.Windows.Forms.Label labelOfres;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label labelDateLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Critères;
        private System.Windows.Forms.Button buttonAjouterDate;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Button buttonValider;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoeff;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox groupBoxModifierCritere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCoeff;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonModifierCritere;
        private System.Windows.Forms.ListBox listBoxOffreID;
    }
}