namespace Controle_Camera
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.gb_acao = new System.Windows.Forms.GroupBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_carregarSelecionado = new System.Windows.Forms.Button();
            this.lbl_cro = new System.Windows.Forms.Label();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.gb_buscaCamera = new System.Windows.Forms.GroupBox();
            this.dg_cam = new System.Windows.Forms.DataGridView();
            this.CRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIZACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_quantCam = new System.Windows.Forms.Button();
            this.gb_acao.SuspendLayout();
            this.gb_buscaCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cam)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_acao
            // 
            this.gb_acao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_acao.Controls.Add(this.bt_quantCam);
            this.gb_acao.Controls.Add(this.lbl_resultado);
            this.gb_acao.Controls.Add(this.lbl_quantidade);
            this.gb_acao.Controls.Add(this.btn_limpar);
            this.gb_acao.Controls.Add(this.btn_relatorio);
            this.gb_acao.Controls.Add(this.btn_cadastrar);
            this.gb_acao.Controls.Add(this.btn_carregarSelecionado);
            this.gb_acao.Location = new System.Drawing.Point(1261, 25);
            this.gb_acao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_acao.Name = "gb_acao";
            this.gb_acao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_acao.Size = new System.Drawing.Size(214, 552);
            this.gb_acao.TabIndex = 1;
            this.gb_acao.TabStop = false;
            this.gb_acao.Text = "Ações";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(55, 438);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(113, 40);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "label1";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(58, 407);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(92, 20);
            this.lbl_quantidade.TabIndex = 4;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(8, 328);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(196, 49);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.Location = new System.Drawing.Point(8, 210);
            this.btn_relatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(196, 49);
            this.btn_relatorio.TabIndex = 2;
            this.btn_relatorio.Text = "Relatorio";
            this.btn_relatorio.UseVisualStyleBackColor = true;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(8, 152);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(196, 49);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "Cadastrar Novo";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_carregarSelecionado
            // 
            this.btn_carregarSelecionado.Location = new System.Drawing.Point(8, 93);
            this.btn_carregarSelecionado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_carregarSelecionado.Name = "btn_carregarSelecionado";
            this.btn_carregarSelecionado.Size = new System.Drawing.Size(191, 49);
            this.btn_carregarSelecionado.TabIndex = 0;
            this.btn_carregarSelecionado.Text = "Carregar Selecionado";
            this.btn_carregarSelecionado.UseVisualStyleBackColor = true;
            this.btn_carregarSelecionado.Click += new System.EventHandler(this.btn_carregarSelecionado_Click);
            // 
            // lbl_cro
            // 
            this.lbl_cro.AutoSize = true;
            this.lbl_cro.Location = new System.Drawing.Point(9, 54);
            this.lbl_cro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cro.Name = "lbl_cro";
            this.lbl_cro.Size = new System.Drawing.Size(240, 20);
            this.lbl_cro.TabIndex = 0;
            this.lbl_cro.Text = "Digite o CRO ou cod. da Camera";
            // 
            // txt_busca
            // 
            this.txt_busca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busca.Location = new System.Drawing.Point(261, 46);
            this.txt_busca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(727, 26);
            this.txt_busca.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(996, 29);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(219, 45);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // gb_buscaCamera
            // 
            this.gb_buscaCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_buscaCamera.Controls.Add(this.dg_cam);
            this.gb_buscaCamera.Controls.Add(this.btn_buscar);
            this.gb_buscaCamera.Controls.Add(this.txt_busca);
            this.gb_buscaCamera.Controls.Add(this.lbl_cro);
            this.gb_buscaCamera.Location = new System.Drawing.Point(21, 25);
            this.gb_buscaCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_buscaCamera.Name = "gb_buscaCamera";
            this.gb_buscaCamera.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_buscaCamera.Size = new System.Drawing.Size(1232, 552);
            this.gb_buscaCamera.TabIndex = 0;
            this.gb_buscaCamera.TabStop = false;
            this.gb_buscaCamera.Text = "Buscar dados da camera";
            // 
            // dg_cam
            // 
            this.dg_cam.AllowUserToAddRows = false;
            this.dg_cam.AllowUserToDeleteRows = false;
            this.dg_cam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CRO,
            this.proprietario,
            this.Id_camera,
            this.LOCALIZACAO,
            this.observacao});
            this.dg_cam.Location = new System.Drawing.Point(13, 117);
            this.dg_cam.Name = "dg_cam";
            this.dg_cam.ReadOnly = true;
            this.dg_cam.RowHeadersWidth = 62;
            this.dg_cam.RowTemplate.Height = 28;
            this.dg_cam.Size = new System.Drawing.Size(1202, 420);
            this.dg_cam.TabIndex = 5;
            // 
            // CRO
            // 
            this.CRO.HeaderText = "CRO";
            this.CRO.MinimumWidth = 8;
            this.CRO.Name = "CRO";
            this.CRO.ReadOnly = true;
            this.CRO.Width = 60;
            // 
            // proprietario
            // 
            this.proprietario.HeaderText = "Proprietario";
            this.proprietario.MinimumWidth = 8;
            this.proprietario.Name = "proprietario";
            this.proprietario.ReadOnly = true;
            this.proprietario.Width = 300;
            // 
            // Id_camera
            // 
            this.Id_camera.HeaderText = "Carmera";
            this.Id_camera.MinimumWidth = 8;
            this.Id_camera.Name = "Id_camera";
            this.Id_camera.ReadOnly = true;
            // 
            // LOCALIZACAO
            // 
            this.LOCALIZACAO.HeaderText = "LOCAL";
            this.LOCALIZACAO.MinimumWidth = 20;
            this.LOCALIZACAO.Name = "LOCALIZACAO";
            this.LOCALIZACAO.ReadOnly = true;
            this.LOCALIZACAO.Width = 180;
            // 
            // observacao
            // 
            this.observacao.HeaderText = "Observação";
            this.observacao.MinimumWidth = 8;
            this.observacao.Name = "observacao";
            this.observacao.ReadOnly = true;
            this.observacao.Width = 150;
            // 
            // bt_quantCam
            // 
            this.bt_quantCam.Location = new System.Drawing.Point(10, 269);
            this.bt_quantCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_quantCam.Name = "bt_quantCam";
            this.bt_quantCam.Size = new System.Drawing.Size(196, 49);
            this.bt_quantCam.TabIndex = 6;
            this.bt_quantCam.Text = "Quantidade por camera";
            this.bt_quantCam.UseVisualStyleBackColor = true;
            this.bt_quantCam.Click += new System.EventHandler(this.bt_quantCam_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 631);
            this.Controls.Add(this.gb_acao);
            this.Controls.Add(this.gb_buscaCamera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.gb_acao.ResumeLayout(false);
            this.gb_acao.PerformLayout();
            this.gb_buscaCamera.ResumeLayout(false);
            this.gb_buscaCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_acao;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_carregarSelecionado;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_cro;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox gb_buscaCamera;
        private System.Windows.Forms.DataGridView dg_cam;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_camera;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIZACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.Button bt_quantCam;
    }
}

