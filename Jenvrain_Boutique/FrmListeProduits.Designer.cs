namespace Jenvrain_Boutique
{
    partial class FrmListeProduits
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
            this.dgvListeProduits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListeProduits
            // 
            this.dgvListeProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeProduits.Location = new System.Drawing.Point(52, 28);
            this.dgvListeProduits.Name = "dgvListeProduits";
            this.dgvListeProduits.Size = new System.Drawing.Size(660, 373);
            this.dgvListeProduits.TabIndex = 0;
            // 
            // FrmListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListeProduits);
            this.Name = "FrmListeProduits";
            this.Text = "FrmListeProduits";
            this.Load += new System.EventHandler(this.FrmListeProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeProduits;
    }
}