namespace Controle_Camera
{
    partial class TelaCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCamera));
            this.lbl_camera = new System.Windows.Forms.Label();
            this.txb_cro = new System.Windows.Forms.TextBox();
            this.txb_coop = new System.Windows.Forms.TextBox();
            this.gb_camera = new System.Windows.Forms.GroupBox();
            this.dg_historico = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_acoes = new System.Windows.Forms.GroupBox();
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.txb_obs = new System.Windows.Forms.TextBox();
            this.cb_acoes = new System.Windows.Forms.ComboBox();
            this.btn_trocar = new System.Windows.Forms.Button();
            this.lbl_cam = new System.Windows.Forms.Label();
            this.txb_cam = new System.Windows.Forms.TextBox();
            this.lbl_cro2 = new System.Windows.Forms.Label();
            this.txb_cro2 = new System.Windows.Forms.TextBox();
            this.gb_camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_historico)).BeginInit();
            this.gb_acoes.SuspendLayout();
            this.gb_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_camera
            // 
            this.lbl_camera.AutoSize = true;
            this.lbl_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_camera.Location = new System.Drawing.Point(6, 22);
            this.lbl_camera.Name = "lbl_camera";
            this.lbl_camera.Size = new System.Drawing.Size(196, 55);
            this.lbl_camera.TabIndex = 0;
            this.lbl_camera.Text = "Camera";
            // 
            // txb_cro
            // 
            this.txb_cro.Enabled = false;
            this.txb_cro.Location = new System.Drawing.Point(678, 19);
            this.txb_cro.Name = "txb_cro";
            this.txb_cro.Size = new System.Drawing.Size(92, 26);
            this.txb_cro.TabIndex = 3;
            // 
            // txb_coop
            // 
            this.txb_coop.Enabled = false;
            this.txb_coop.Location = new System.Drawing.Point(263, 51);
            this.txb_coop.Name = "txb_coop";
            this.txb_coop.Size = new System.Drawing.Size(507, 26);
            this.txb_coop.TabIndex = 4;
            // 
            // gb_camera
            // 
            this.gb_camera.Controls.Add(this.dg_historico);
            this.gb_camera.Controls.Add(this.lbl_camera);
            this.gb_camera.Controls.Add(this.txb_coop);
            this.gb_camera.Controls.Add(this.txb_cro);
            this.gb_camera.Location = new System.Drawing.Point(12, 12);
            this.gb_camera.Name = "gb_camera";
            this.gb_camera.Size = new System.Drawing.Size(776, 338);
            this.gb_camera.TabIndex = 5;
            this.gb_camera.TabStop = false;
            this.gb_camera.Text = "Camera";
            // 
            // dg_historico
            // 
            this.dg_historico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_historico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.localizacao});
            this.dg_historico.Location = new System.Drawing.Point(21, 99);
            this.dg_historico.Name = "dg_historico";
            this.dg_historico.RowHeadersWidth = 62;
            this.dg_historico.RowTemplate.Height = 28;
            this.dg_historico.Size = new System.Drawing.Size(749, 233);
            this.dg_historico.TabIndex = 5;
            // 
            // data
            // 
            this.data.HeaderText = "Data de Movimentação";
            this.data.MinimumWidth = 8;
            this.data.Name = "data";
            this.data.Width = 150;
            // 
            // localizacao
            // 
            this.localizacao.HeaderText = "Localização";
            this.localizacao.MinimumWidth = 8;
            this.localizacao.Name = "localizacao";
            this.localizacao.Width = 150;
            // 
            // gb_acoes
            // 
            this.gb_acoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_acoes.Controls.Add(this.gb_tipo);
            this.gb_acoes.Location = new System.Drawing.Point(14, 356);
            this.gb_acoes.Name = "gb_acoes";
            this.gb_acoes.Size = new System.Drawing.Size(768, 324);
            this.gb_acoes.TabIndex = 6;
            this.gb_acoes.TabStop = false;
            this.gb_acoes.Text = "Ações";
            // 
            // gb_tipo
            // 
            this.gb_tipo.Controls.Add(this.txb_obs);
            this.gb_tipo.Controls.Add(this.cb_acoes);
            this.gb_tipo.Controls.Add(this.btn_trocar);
            this.gb_tipo.Controls.Add(this.lbl_cam);
            this.gb_tipo.Controls.Add(this.txb_cam);
            this.gb_tipo.Controls.Add(this.lbl_cro2);
            this.gb_tipo.Controls.Add(this.txb_cro2);
            this.gb_tipo.Location = new System.Drawing.Point(14, 27);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(748, 270);
            this.gb_tipo.TabIndex = 7;
            this.gb_tipo.TabStop = false;
            this.gb_tipo.Text = "Tipo";
            // 
            // txb_obs
            // 
            this.txb_obs.Location = new System.Drawing.Point(209, 109);
            this.txb_obs.Multiline = true;
            this.txb_obs.Name = "txb_obs";
            this.txb_obs.Size = new System.Drawing.Size(397, 155);
            this.txb_obs.TabIndex = 8;
            // 
            // cb_acoes
            // 
            this.cb_acoes.FormattingEnabled = true;
            this.cb_acoes.Items.AddRange(new object[] {
            "TROCA DE CAMERA COM DEFEITO",
            "ENVIO PARA ACTIVEWARE",
            "RETORNO DA ACTIVEWARE",
            "RETORNO SEM CONSERTO",
            "DEVOLUÇÃO AO COOPERADO",
            "MOVIMENTAÇÃO MANUAL"});
            this.cb_acoes.Location = new System.Drawing.Point(6, 35);
            this.cb_acoes.Name = "cb_acoes";
            this.cb_acoes.Size = new System.Drawing.Size(727, 28);
            this.cb_acoes.TabIndex = 4;
            this.cb_acoes.SelectedIndexChanged += new System.EventHandler(this.cb_acoes_SelectedIndexChanged);
            // 
            // btn_trocar
            // 
            this.btn_trocar.Location = new System.Drawing.Point(612, 225);
            this.btn_trocar.Name = "btn_trocar";
            this.btn_trocar.Size = new System.Drawing.Size(121, 39);
            this.btn_trocar.TabIndex = 2;
            this.btn_trocar.Text = "Trocar";
            this.btn_trocar.UseVisualStyleBackColor = true;
            this.btn_trocar.Click += new System.EventHandler(this.btn_trocar_Click);
            // 
            // lbl_cam
            // 
            this.lbl_cam.AutoSize = true;
            this.lbl_cam.Location = new System.Drawing.Point(7, 147);
            this.lbl_cam.Name = "lbl_cam";
            this.lbl_cam.Size = new System.Drawing.Size(65, 20);
            this.lbl_cam.TabIndex = 6;
            this.lbl_cam.Text = "Camera";
            // 
            // txb_cam
            // 
            this.txb_cam.Location = new System.Drawing.Point(78, 141);
            this.txb_cam.Name = "txb_cam";
            this.txb_cam.Size = new System.Drawing.Size(125, 26);
            this.txb_cam.TabIndex = 3;
            // 
            // lbl_cro2
            // 
            this.lbl_cro2.AutoSize = true;
            this.lbl_cro2.Location = new System.Drawing.Point(7, 111);
            this.lbl_cro2.Name = "lbl_cro2";
            this.lbl_cro2.Size = new System.Drawing.Size(102, 20);
            this.lbl_cro2.TabIndex = 5;
            this.lbl_cro2.Text = "Para o CRO: ";
            // 
            // txb_cro2
            // 
            this.txb_cro2.Location = new System.Drawing.Point(115, 108);
            this.txb_cro2.Name = "txb_cro2";
            this.txb_cro2.Size = new System.Drawing.Size(88, 26);
            this.txb_cro2.TabIndex = 4;
            // 
            // TelaCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 692);
            this.Controls.Add(this.gb_acoes);
            this.Controls.Add(this.gb_camera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCamera";
            this.Text = "TelaCamera";
            this.gb_camera.ResumeLayout(false);
            this.gb_camera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_historico)).EndInit();
            this.gb_acoes.ResumeLayout(false);
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_camera;
        private System.Windows.Forms.TextBox txb_cro;
        private System.Windows.Forms.TextBox txb_coop;
        private System.Windows.Forms.GroupBox gb_camera;
        private System.Windows.Forms.GroupBox gb_acoes;
        private System.Windows.Forms.Label lbl_cro2;
        private System.Windows.Forms.TextBox txb_cro2;
        private System.Windows.Forms.TextBox txb_cam;
        private System.Windows.Forms.Button btn_trocar;
        private System.Windows.Forms.Label lbl_cam;
        private System.Windows.Forms.GroupBox gb_tipo;
        private System.Windows.Forms.TextBox txb_obs;
        private System.Windows.Forms.DataGridView dg_historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacao;
        private System.Windows.Forms.ComboBox cb_acoes;
    }
}