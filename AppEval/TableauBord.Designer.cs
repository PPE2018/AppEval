﻿namespace AppEval
{
    partial class TableauBord
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTableauBord = new System.Windows.Forms.GroupBox();
            this.dataGridViewTableauBord = new System.Windows.Forms.DataGridView();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.Evaluateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note_Moyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTableauBord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableauBord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tableau de bord";
            // 
            // groupBoxTableauBord
            // 
            this.groupBoxTableauBord.Controls.Add(this.dataGridViewTableauBord);
            this.groupBoxTableauBord.Location = new System.Drawing.Point(51, 83);
            this.groupBoxTableauBord.Name = "groupBoxTableauBord";
            this.groupBoxTableauBord.Size = new System.Drawing.Size(404, 297);
            this.groupBoxTableauBord.TabIndex = 1;
            this.groupBoxTableauBord.TabStop = false;
            this.groupBoxTableauBord.Text = "Tableau";
            // 
            // dataGridViewTableauBord
            // 
            this.dataGridViewTableauBord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableauBord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evaluateur,
            this.Note_Moyenne});
            this.dataGridViewTableauBord.Location = new System.Drawing.Point(27, 19);
            this.dataGridViewTableauBord.Name = "dataGridViewTableauBord";
            this.dataGridViewTableauBord.ReadOnly = true;
            this.dataGridViewTableauBord.Size = new System.Drawing.Size(348, 252);
            this.dataGridViewTableauBord.TabIndex = 0;
            this.dataGridViewTableauBord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTableauBord_CellContentClick);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(191, 404);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(117, 33);
            this.buttonFermer.TabIndex = 2;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Evaluateur
            // 
            this.Evaluateur.Frozen = true;
            this.Evaluateur.HeaderText = "Evaluateur";
            this.Evaluateur.Name = "Evaluateur";
            this.Evaluateur.ReadOnly = true;
            // 
            // Note_Moyenne
            // 
            this.Note_Moyenne.Frozen = true;
            this.Note_Moyenne.HeaderText = "Note_Moyenne";
            this.Note_Moyenne.Name = "Note_Moyenne";
            this.Note_Moyenne.ReadOnly = true;
            // 
            // TableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 464);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.groupBoxTableauBord);
            this.Controls.Add(this.label1);
            this.Name = "TableauBord";
            this.Text = "TableauBord";
            this.groupBoxTableauBord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableauBord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTableauBord;
        private System.Windows.Forms.DataGridView dataGridViewTableauBord;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note_Moyenne;
    }
}