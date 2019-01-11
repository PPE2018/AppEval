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
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.Critères = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bttnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).BeginInit();
            this.SuspendLayout();
            // 
            // OffreCritere
            // 
            this.OffreCritere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffreCritere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Critères,
            this.Modifier});
            this.OffreCritere.Location = new System.Drawing.Point(35, 68);
            this.OffreCritere.Name = "OffreCritere";
            this.OffreCritere.Size = new System.Drawing.Size(343, 256);
            this.OffreCritere.TabIndex = 0;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(332, 30);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(30, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Offre";
            this.labelNom.UseWaitCursor = true;
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(70, 339);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(249, 46);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter un critère";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // Critères
            // 
            this.Critères.HeaderText = "Critères";
            this.Critères.Name = "Critères";
            this.Critères.ReadOnly = true;
            this.Critères.Width = 200;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // bttnSupprimer
            // 
            this.bttnSupprimer.Location = new System.Drawing.Point(503, 80);
            this.bttnSupprimer.Name = "bttnSupprimer";
            this.bttnSupprimer.Size = new System.Drawing.Size(260, 54);
            this.bttnSupprimer.TabIndex = 3;
            this.bttnSupprimer.Text = "Supprimer";
            this.bttnSupprimer.UseVisualStyleBackColor = true;
            this.bttnSupprimer.Click += new System.EventHandler(this.bttnSupprimer_Click);
            // 
            // OffreCritereDRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.OffreCritere);
            this.Name = "OffreCritereDRH";
            this.Text = "OffreDRH";
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OffreCritere;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Critères;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.Button bttnSupprimer;
    }
}