﻿namespace AppEval
{
    partial class EvaluationRH
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
            this.tableauEvaluation = new System.Windows.Forms.DataGridView();
            this.Criteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBonusMalus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.libNote = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listeOffres = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listeCandidats = new System.Windows.Forms.ListBox();
            this.bttnReunion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableauEvaluation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableauEvaluation
            // 
            this.tableauEvaluation.AllowUserToAddRows = false;
            this.tableauEvaluation.AllowUserToDeleteRows = false;
            this.tableauEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauEvaluation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criteres,
            this.Coefficient,
            this.Note});
            this.tableauEvaluation.Location = new System.Drawing.Point(6, 19);
            this.tableauEvaluation.Name = "tableauEvaluation";
            this.tableauEvaluation.Size = new System.Drawing.Size(662, 185);
            this.tableauEvaluation.TabIndex = 0;
            this.tableauEvaluation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauEvaluation_CellContentClick_1);
            // 
            // Criteres
            // 
            this.Criteres.HeaderText = "Critères";
            this.Criteres.Name = "Criteres";
            this.Criteres.ReadOnly = true;
            this.Criteres.Width = 200;
            // 
            // Coefficient
            // 
            this.Coefficient.HeaderText = "Coefficient";
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.ReadOnly = true;
            this.Coefficient.Width = 200;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.Width = 200;
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(6, 234);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(652, 68);
            this.txtCommentaire.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Commentaire :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBonusMalus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tableauEvaluation);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCommentaire);
            this.groupBox1.Location = new System.Drawing.Point(421, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 384);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluer";
            // 
            // txtBonusMalus
            // 
            this.txtBonusMalus.Location = new System.Drawing.Point(129, 322);
            this.txtBonusMalus.Name = "txtBonusMalus";
            this.txtBonusMalus.Size = new System.Drawing.Size(100, 20);
            this.txtBonusMalus.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bonus/Malus (-10/+10) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Note Finale :";
            // 
            // libNote
            // 
            this.libNote.AutoSize = true;
            this.libNote.Location = new System.Drawing.Point(78, 28);
            this.libNote.Name = "libNote";
            this.libNote.Size = new System.Drawing.Size(28, 13);
            this.libNote.TabIndex = 6;
            this.libNote.Text = "note";
            this.libNote.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listeOffres);
            this.groupBox4.Location = new System.Drawing.Point(23, 32);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(169, 374);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Offres";
            // 
            // listeOffres
            // 
            this.listeOffres.FormattingEnabled = true;
            this.listeOffres.Location = new System.Drawing.Point(14, 17);
            this.listeOffres.Margin = new System.Windows.Forms.Padding(2);
            this.listeOffres.Name = "listeOffres";
            this.listeOffres.Size = new System.Drawing.Size(134, 342);
            this.listeOffres.TabIndex = 8;
            this.listeOffres.SelectedIndexChanged += new System.EventHandler(this.listeOffres_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listeCandidats);
            this.groupBox2.Location = new System.Drawing.Point(225, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(169, 374);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Candidats";
            // 
            // listeCandidats
            // 
            this.listeCandidats.FormattingEnabled = true;
            this.listeCandidats.Location = new System.Drawing.Point(20, 17);
            this.listeCandidats.Margin = new System.Windows.Forms.Padding(2);
            this.listeCandidats.Name = "listeCandidats";
            this.listeCandidats.Size = new System.Drawing.Size(134, 342);
            this.listeCandidats.TabIndex = 8;
            this.listeCandidats.SelectedIndexChanged += new System.EventHandler(this.listeCandidats_SelectedIndexChanged);
            // 
            // bttnReunion
            // 
            this.bttnReunion.Location = new System.Drawing.Point(144, 58);
            this.bttnReunion.Name = "bttnReunion";
            this.bttnReunion.Size = new System.Drawing.Size(118, 35);
            this.bttnReunion.TabIndex = 12;
            this.bttnReunion.Text = "Tableau de bord";
            this.bttnReunion.UseVisualStyleBackColor = true;
            this.bttnReunion.Click += new System.EventHandler(this.bttnReunion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttnReunion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.libNote);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(421, 411);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(678, 108);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Résultats";
            // 
            // EvaluationRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "EvaluationRH";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.EvaluationRH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauEvaluation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauEvaluation;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label libNote;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBonusMalus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listeOffres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listeCandidats;
        private System.Windows.Forms.Button bttnReunion;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}