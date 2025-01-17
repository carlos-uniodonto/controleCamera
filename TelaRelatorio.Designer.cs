﻿namespace Controle_Camera
{
    partial class TelaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorio));
            this.gb_tipoRel = new System.Windows.Forms.GroupBox();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.cb_tipoRel = new System.Windows.Forms.ComboBox();
            this.dg_relatorio = new System.Windows.Forms.DataGridView();
            this.ID_Camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gb_tipoRel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_tipoRel
            // 
            this.gb_tipoRel.Controls.Add(this.btn_gerar);
            this.gb_tipoRel.Controls.Add(this.cb_tipoRel);
            this.gb_tipoRel.Location = new System.Drawing.Point(33, 34);
            this.gb_tipoRel.Name = "gb_tipoRel";
            this.gb_tipoRel.Size = new System.Drawing.Size(1149, 100);
            this.gb_tipoRel.TabIndex = 0;
            this.gb_tipoRel.TabStop = false;
            this.gb_tipoRel.Text = "Tipo de relatorio";
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(440, 35);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(150, 36);
            this.btn_gerar.TabIndex = 1;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // cb_tipoRel
            // 
            this.cb_tipoRel.FormattingEnabled = true;
            this.cb_tipoRel.Items.AddRange(new object[] {
            "Aguardando Devolução",
            "Aguardando Envio para Manutenção"});
            this.cb_tipoRel.Location = new System.Drawing.Point(38, 40);
            this.cb_tipoRel.Name = "cb_tipoRel";
            this.cb_tipoRel.Size = new System.Drawing.Size(363, 28);
            this.cb_tipoRel.TabIndex = 0;
            // 
            // dg_relatorio
            // 
            this.dg_relatorio.AllowUserToAddRows = false;
            this.dg_relatorio.AllowUserToDeleteRows = false;
            this.dg_relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_relatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Camera,
            this.cro,
            this.marcar});
            this.dg_relatorio.Location = new System.Drawing.Point(39, 129);
            this.dg_relatorio.Name = "dg_relatorio";
            this.dg_relatorio.RowHeadersWidth = 62;
            this.dg_relatorio.RowTemplate.Height = 28;
            this.dg_relatorio.Size = new System.Drawing.Size(1149, 469);
            this.dg_relatorio.TabIndex = 1;
            // 
            // ID_Camera
            // 
            this.ID_Camera.HeaderText = "Id Camera";
            this.ID_Camera.MinimumWidth = 8;
            this.ID_Camera.Name = "ID_Camera";
            this.ID_Camera.Width = 150;
            // 
            // cro
            // 
            this.cro.HeaderText = "CRO";
            this.cro.MinimumWidth = 8;
            this.cro.Name = "cro";
            this.cro.Width = 150;
            // 
            // marcar
            // 
            this.marcar.HeaderText = "Marcar";
            this.marcar.MinimumWidth = 8;
            this.marcar.Name = "marcar";
            this.marcar.Width = 150;
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 632);
            this.Controls.Add(this.dg_relatorio);
            this.Controls.Add(this.gb_tipoRel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorio";
            this.Text = "TelaRelatorio";
            this.gb_tipoRel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_relatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_tipoRel;
        private System.Windows.Forms.ComboBox cb_tipoRel;
        private System.Windows.Forms.DataGridView dg_relatorio;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Camera;
        private System.Windows.Forms.DataGridViewTextBoxColumn cro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marcar;
    }
}