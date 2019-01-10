namespace AppEval
{
    partial class AjoutCritere
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNomCritere = new System.Windows.Forms.TextBox();
            this.txtBoxCoeff = new System.Windows.Forms.TextBox();
            this.bttnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créer ou ajouter un critère :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du critère :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coefficient :";
            // 
            // txtBoxNomCritere
            // 
            this.txtBoxNomCritere.Location = new System.Drawing.Point(198, 128);
            this.txtBoxNomCritere.Name = "txtBoxNomCritere";
            this.txtBoxNomCritere.Size = new System.Drawing.Size(343, 20);
            this.txtBoxNomCritere.TabIndex = 3;
            // 
            // txtBoxCoeff
            // 
            this.txtBoxCoeff.Location = new System.Drawing.Point(191, 230);
            this.txtBoxCoeff.Name = "txtBoxCoeff";
            this.txtBoxCoeff.Size = new System.Drawing.Size(349, 20);
            this.txtBoxCoeff.TabIndex = 4;
            // 
            // bttnValider
            // 
            this.bttnValider.Location = new System.Drawing.Point(231, 331);
            this.bttnValider.Name = "bttnValider";
            this.bttnValider.Size = new System.Drawing.Size(249, 61);
            this.bttnValider.TabIndex = 5;
            this.bttnValider.Text = "Valider";
            this.bttnValider.UseVisualStyleBackColor = true;
            // 
            // AjoutCritere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnValider);
            this.Controls.Add(this.txtBoxCoeff);
            this.Controls.Add(this.txtBoxNomCritere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutCritere";
            this.Text = "AppEval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNomCritere;
        private System.Windows.Forms.TextBox txtBoxCoeff;
        private System.Windows.Forms.Button bttnValider;
    }
}

