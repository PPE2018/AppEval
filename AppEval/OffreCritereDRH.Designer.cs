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
            this.dateTimePickerDateLimite = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCritere = new System.Windows.Forms.GroupBox();
            this.labelOfres = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.labelDateLimite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).BeginInit();
            this.groupBoxCritere.SuspendLayout();
            this.SuspendLayout();
            // 
            // OffreCritere
            // 
            this.OffreCritere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffreCritere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Critères});
            this.OffreCritere.Location = new System.Drawing.Point(6, 73);
            this.OffreCritere.Name = "OffreCritere";
            this.OffreCritere.Size = new System.Drawing.Size(249, 345);
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
            this.buttonAjouter.Location = new System.Drawing.Point(316, 248);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(98, 46);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter un critère";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // bttnSupprimer
            // 
            this.bttnSupprimer.Location = new System.Drawing.Point(316, 86);
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
            this.listBoxOffre.Location = new System.Drawing.Point(73, 22);
            this.listBoxOffre.Name = "listBoxOffre";
            this.listBoxOffre.Size = new System.Drawing.Size(160, 17);
            this.listBoxOffre.TabIndex = 4;
            // 
            // dateTimePickerDateLimite
            // 
            this.dateTimePickerDateLimite.Location = new System.Drawing.Point(349, 22);
            this.dateTimePickerDateLimite.Name = "dateTimePickerDateLimite";
            this.dateTimePickerDateLimite.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerDateLimite.TabIndex = 5;
            // 
            // groupBoxCritere
            // 
            this.groupBoxCritere.Controls.Add(this.labelDateLimite);
            this.groupBoxCritere.Controls.Add(this.labelOfres);
            this.groupBoxCritere.Controls.Add(this.dateTimePickerDateLimite);
            this.groupBoxCritere.Controls.Add(this.buttonModifier);
            this.groupBoxCritere.Controls.Add(this.bttnSupprimer);
            this.groupBoxCritere.Controls.Add(this.listBoxOffre);
            this.groupBoxCritere.Controls.Add(this.buttonAjouter);
            this.groupBoxCritere.Controls.Add(this.OffreCritere);
            this.groupBoxCritere.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCritere.Name = "groupBoxCritere";
            this.groupBoxCritere.Size = new System.Drawing.Size(517, 440);
            this.groupBoxCritere.TabIndex = 6;
            this.groupBoxCritere.TabStop = false;
            this.groupBoxCritere.Text = "Critères";
            // 
            // labelOfres
            // 
            this.labelOfres.AutoSize = true;
            this.labelOfres.Location = new System.Drawing.Point(6, 22);
            this.labelOfres.Name = "labelOfres";
            this.labelOfres.Size = new System.Drawing.Size(41, 13);
            this.labelOfres.TabIndex = 6;
            this.labelOfres.Text = "Offres :";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(316, 171);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(98, 46);
            this.buttonModifier.TabIndex = 4;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // labelDateLimite
            // 
            this.labelDateLimite.AutoSize = true;
            this.labelDateLimite.Location = new System.Drawing.Point(277, 22);
            this.labelDateLimite.Name = "labelDateLimite";
            this.labelDateLimite.Size = new System.Drawing.Size(66, 13);
            this.labelDateLimite.TabIndex = 7;
            this.labelDateLimite.Text = "Date Limite :";
            // 
            // OffreCritereDRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 497);
            this.Controls.Add(this.groupBoxCritere);
            this.Name = "OffreCritereDRH";
            this.Text = "OffreDRH";
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).EndInit();
            this.groupBoxCritere.ResumeLayout(false);
            this.groupBoxCritere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OffreCritere;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button bttnSupprimer;
        private System.Windows.Forms.ListBox listBoxOffre;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Critères;
        private System.Windows.Forms.GroupBox groupBoxCritere;
        private System.Windows.Forms.Label labelOfres;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label labelDateLimite;
    }
}