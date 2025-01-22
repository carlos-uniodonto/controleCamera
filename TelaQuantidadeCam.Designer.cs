namespace Controle_Camera
{
    partial class TelaQuantidadeCam
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
            this.dg_quantidadeCam = new System.Windows.Forms.DataGridView();
            this.cameras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_quantidadeCam)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_quantidadeCam
            // 
            this.dg_quantidadeCam.AllowUserToAddRows = false;
            this.dg_quantidadeCam.AllowUserToDeleteRows = false;
            this.dg_quantidadeCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_quantidadeCam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_quantidadeCam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cameras,
            this.quantidade});
            this.dg_quantidadeCam.Location = new System.Drawing.Point(34, 41);
            this.dg_quantidadeCam.Name = "dg_quantidadeCam";
            this.dg_quantidadeCam.ReadOnly = true;
            this.dg_quantidadeCam.RowHeadersWidth = 62;
            this.dg_quantidadeCam.RowTemplate.Height = 28;
            this.dg_quantidadeCam.Size = new System.Drawing.Size(455, 329);
            this.dg_quantidadeCam.TabIndex = 0;
            // 
            // cameras
            // 
            this.cameras.HeaderText = "Cameras";
            this.cameras.MinimumWidth = 8;
            this.cameras.Name = "cameras";
            this.cameras.ReadOnly = true;
            this.cameras.Width = 150;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidades";
            this.quantidade.MinimumWidth = 8;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 150;
            // 
            // TelaQuantidadeCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 382);
            this.Controls.Add(this.dg_quantidadeCam);
            this.Name = "TelaQuantidadeCam";
            this.Text = "TelaQuantidadeCam";
            ((System.ComponentModel.ISupportInitialize)(this.dg_quantidadeCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_quantidadeCam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameras;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
    }
}