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
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OffreCritere)).BeginInit();
            this.SuspendLayout();
            // 
            // OffreCritere
            // 
            this.OffreCritere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffreCritere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Critères,
            this.Modifier,
            this.Supprimer});
            this.OffreCritere.Location = new System.Drawing.Point(131, 84);
            this.OffreCritere.Name = "OffreCritere";
            this.OffreCritere.Size = new System.Drawing.Size(466, 197);
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
            this.buttonAjouter.Location = new System.Drawing.Point(250, 330);
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
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // OffreCritereDRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}