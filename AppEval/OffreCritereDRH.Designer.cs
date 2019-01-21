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
            this.buttonAjouterDate = new System.Windows.Forms.Button();
            this.labelOfres = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.labelDateLimite = new System.Windows.Forms.Label();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.buttonValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).BeginInit();
            this.groupBoxCritere.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
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
            this.OffreCritere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OffreCritere_CellContentClick);
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
            this.dateTimePickeDateLimite.ValueChanged += new System.EventHandler(this.dateTimePickeDateLimite_ValueChanged);
            // 
            // groupBoxCritere
            // 
            this.groupBoxCritere.Controls.Add(this.buttonAjouterDate);
            this.groupBoxCritere.Controls.Add(this.labelOfres);
            this.groupBoxCritere.Controls.Add(this.buttonModifier);
            this.groupBoxCritere.Controls.Add(this.bttnSupprimer);
            this.groupBoxCritere.Controls.Add(this.listBoxOffre);
            this.groupBoxCritere.Controls.Add(this.buttonAjouter);
            this.groupBoxCritere.Controls.Add(this.OffreCritere);
            this.groupBoxCritere.Location = new System.Drawing.Point(12, 22);
            this.groupBoxCritere.Name = "groupBoxCritere";
            this.groupBoxCritere.Size = new System.Drawing.Size(662, 441);
            this.groupBoxCritere.TabIndex = 6;
            this.groupBoxCritere.TabStop = false;
            this.groupBoxCritere.Text = "Critères";
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
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(60, 110);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(94, 27);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // OffreCritereDRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 503);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxCritere);
            this.Name = "OffreCritereDRH";
            this.Text = "OffreDRH";
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).EndInit();
            this.groupBoxCritere.ResumeLayout(false);
            this.groupBoxCritere.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
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
    }
}