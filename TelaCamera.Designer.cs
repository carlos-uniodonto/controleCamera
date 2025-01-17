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
            this.gb_acoes = new System.Windows.Forms.GroupBox();
            this.cb_semConserto = new System.Windows.Forms.CheckBox();
            this.txb_obs = new System.Windows.Forms.TextBox();
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.rb_manual = new System.Windows.Forms.RadioButton();
            this.rb_retorno = new System.Windows.Forms.RadioButton();
            this.rb_devolucao = new System.Windows.Forms.RadioButton();
            this.rb_manutencao = new System.Windows.Forms.RadioButton();
            this.lbl_cam = new System.Windows.Forms.Label();
            this.lbl_cro2 = new System.Windows.Forms.Label();
            this.txb_cro2 = new System.Windows.Forms.TextBox();
            this.txb_cam = new System.Windows.Forms.TextBox();
            this.btn_trocar = new System.Windows.Forms.Button();
            this.dg_historico = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_camera.SuspendLayout();
            this.gb_acoes.SuspendLayout();
            this.gb_tipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_historico)).BeginInit();
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
            // gb_acoes
            // 
            this.gb_acoes.Controls.Add(this.cb_semConserto);
            this.gb_acoes.Controls.Add(this.txb_obs);
            this.gb_acoes.Controls.Add(this.gb_tipo);
            this.gb_acoes.Controls.Add(this.lbl_cam);
            this.gb_acoes.Controls.Add(this.lbl_cro2);
            this.gb_acoes.Controls.Add(this.txb_cro2);
            this.gb_acoes.Controls.Add(this.txb_cam);
            this.gb_acoes.Controls.Add(this.btn_trocar);
            this.gb_acoes.Location = new System.Drawing.Point(14, 356);
            this.gb_acoes.Name = "gb_acoes";
            this.gb_acoes.Size = new System.Drawing.Size(768, 204);
            this.gb_acoes.TabIndex = 6;
            this.gb_acoes.TabStop = false;
            this.gb_acoes.Text = "Ações";
            // 
            // cb_semConserto
            // 
            this.cb_semConserto.AutoSize = true;
            this.cb_semConserto.Location = new System.Drawing.Point(261, 119);
            this.cb_semConserto.Name = "cb_semConserto";
            this.cb_semConserto.Size = new System.Drawing.Size(137, 24);
            this.cb_semConserto.TabIndex = 9;
            this.cb_semConserto.Text = "Sem Conserto";
            this.cb_semConserto.UseVisualStyleBackColor = true;
            this.cb_semConserto.Visible = false;
            this.cb_semConserto.CheckedChanged += new System.EventHandler(this.cb_semConserto_CheckedChanged);
            // 
            // txb_obs
            // 
            this.txb_obs.Location = new System.Drawing.Point(473, 42);
            this.txb_obs.Multiline = true;
            this.txb_obs.Name = "txb_obs";
            this.txb_obs.Size = new System.Drawing.Size(267, 146);
            this.txb_obs.TabIndex = 8;
            // 
            // gb_tipo
            // 
            this.gb_tipo.Controls.Add(this.rb_manual);
            this.gb_tipo.Controls.Add(this.rb_retorno);
            this.gb_tipo.Controls.Add(this.rb_devolucao);
            this.gb_tipo.Controls.Add(this.rb_manutencao);
            this.gb_tipo.Location = new System.Drawing.Point(14, 27);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(223, 161);
            this.gb_tipo.TabIndex = 7;
            this.gb_tipo.TabStop = false;
            this.gb_tipo.Text = "Tipo";
            // 
            // rb_manual
            // 
            this.rb_manual.AutoSize = true;
            this.rb_manual.Location = new System.Drawing.Point(6, 116);
            this.rb_manual.Name = "rb_manual";
            this.rb_manual.Size = new System.Drawing.Size(193, 24);
            this.rb_manual.TabIndex = 3;
            this.rb_manual.TabStop = true;
            this.rb_manual.Text = "Movimentação Manual";
            this.rb_manual.UseVisualStyleBackColor = true;
            this.rb_manual.CheckedChanged += new System.EventHandler(this.rb_manual_CheckedChanged);
            // 
            // rb_retorno
            // 
            this.rb_retorno.AutoSize = true;
            this.rb_retorno.Location = new System.Drawing.Point(6, 86);
            this.rb_retorno.Name = "rb_retorno";
            this.rb_retorno.Size = new System.Drawing.Size(161, 24);
            this.rb_retorno.TabIndex = 2;
            this.rb_retorno.TabStop = true;
            this.rb_retorno.Text = "Retorno da Active";
            this.rb_retorno.UseVisualStyleBackColor = true;
            this.rb_retorno.CheckedChanged += new System.EventHandler(this.rb_retorno_CheckedChanged);
            // 
            // rb_devolucao
            // 
            this.rb_devolucao.AutoSize = true;
            this.rb_devolucao.Location = new System.Drawing.Point(6, 56);
            this.rb_devolucao.Name = "rb_devolucao";
            this.rb_devolucao.Size = new System.Drawing.Size(109, 24);
            this.rb_devolucao.TabIndex = 1;
            this.rb_devolucao.TabStop = true;
            this.rb_devolucao.Text = "Devolução";
            this.rb_devolucao.UseVisualStyleBackColor = true;
            this.rb_devolucao.CheckedChanged += new System.EventHandler(this.rb_devolucao_CheckedChanged);
            // 
            // rb_manutencao
            // 
            this.rb_manutencao.AutoSize = true;
            this.rb_manutencao.Location = new System.Drawing.Point(6, 26);
            this.rb_manutencao.Name = "rb_manutencao";
            this.rb_manutencao.Size = new System.Drawing.Size(123, 24);
            this.rb_manutencao.TabIndex = 0;
            this.rb_manutencao.TabStop = true;
            this.rb_manutencao.Text = "Manutenção";
            this.rb_manutencao.UseVisualStyleBackColor = true;
            this.rb_manutencao.CheckedChanged += new System.EventHandler(this.rb_manutencao_CheckedChanged);
            // 
            // lbl_cam
            // 
            this.lbl_cam.AutoSize = true;
            this.lbl_cam.Location = new System.Drawing.Point(243, 89);
            this.lbl_cam.Name = "lbl_cam";
            this.lbl_cam.Size = new System.Drawing.Size(65, 20);
            this.lbl_cam.TabIndex = 6;
            this.lbl_cam.Text = "Camera";
            // 
            // lbl_cro2
            // 
            this.lbl_cro2.AutoSize = true;
            this.lbl_cro2.Location = new System.Drawing.Point(243, 53);
            this.lbl_cro2.Name = "lbl_cro2";
            this.lbl_cro2.Size = new System.Drawing.Size(102, 20);
            this.lbl_cro2.TabIndex = 5;
            this.lbl_cro2.Text = "Para o CRO: ";
            // 
            // txb_cro2
            // 
            this.txb_cro2.Location = new System.Drawing.Point(351, 50);
            this.txb_cro2.Name = "txb_cro2";
            this.txb_cro2.Size = new System.Drawing.Size(88, 26);
            this.txb_cro2.TabIndex = 4;
            // 
            // txb_cam
            // 
            this.txb_cam.Location = new System.Drawing.Point(314, 83);
            this.txb_cam.Name = "txb_cam";
            this.txb_cam.Size = new System.Drawing.Size(125, 26);
            this.txb_cam.TabIndex = 3;
            // 
            // btn_trocar
            // 
            this.btn_trocar.Location = new System.Drawing.Point(247, 149);
            this.btn_trocar.Name = "btn_trocar";
            this.btn_trocar.Size = new System.Drawing.Size(192, 39);
            this.btn_trocar.TabIndex = 2;
            this.btn_trocar.Text = "Trocar";
            this.btn_trocar.UseVisualStyleBackColor = true;
            this.btn_trocar.Click += new System.EventHandler(this.btn_trocar_Click);
            // 
            // dg_historico
            // 
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
            // TelaCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.gb_acoes);
            this.Controls.Add(this.gb_camera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCamera";
            this.Text = "TelaCamera";
            this.gb_camera.ResumeLayout(false);
            this.gb_camera.PerformLayout();
            this.gb_acoes.ResumeLayout(false);
            this.gb_acoes.PerformLayout();
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_historico)).EndInit();
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
        private System.Windows.Forms.RadioButton rb_devolucao;
        private System.Windows.Forms.RadioButton rb_manutencao;
        private System.Windows.Forms.RadioButton rb_retorno;
        private System.Windows.Forms.RadioButton rb_manual;
        private System.Windows.Forms.TextBox txb_obs;
        private System.Windows.Forms.CheckBox cb_semConserto;
        private System.Windows.Forms.DataGridView dg_historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacao;
    }
}