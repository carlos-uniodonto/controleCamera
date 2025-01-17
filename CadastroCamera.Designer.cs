namespace Controle_Camera
{
    partial class CadastroCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCamera));
            this.gb_cadastro = new System.Windows.Forms.GroupBox();
            this.txb_cam = new System.Windows.Forms.TextBox();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_cro = new System.Windows.Forms.TextBox();
            this.lbl_cam = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cro = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.gb_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_cadastro
            // 
            this.gb_cadastro.Controls.Add(this.txb_cam);
            this.gb_cadastro.Controls.Add(this.txb_nome);
            this.gb_cadastro.Controls.Add(this.txb_cro);
            this.gb_cadastro.Controls.Add(this.lbl_cam);
            this.gb_cadastro.Controls.Add(this.lbl_nome);
            this.gb_cadastro.Controls.Add(this.lbl_cro);
            this.gb_cadastro.Location = new System.Drawing.Point(27, 29);
            this.gb_cadastro.Name = "gb_cadastro";
            this.gb_cadastro.Size = new System.Drawing.Size(325, 213);
            this.gb_cadastro.TabIndex = 0;
            this.gb_cadastro.TabStop = false;
            this.gb_cadastro.Text = "Cadastrar Nova Camera";
            // 
            // txb_cam
            // 
            this.txb_cam.Location = new System.Drawing.Point(95, 119);
            this.txb_cam.Name = "txb_cam";
            this.txb_cam.Size = new System.Drawing.Size(186, 26);
            this.txb_cam.TabIndex = 5;
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(95, 80);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(186, 26);
            this.txb_nome.TabIndex = 4;
            // 
            // txb_cro
            // 
            this.txb_cro.Location = new System.Drawing.Point(95, 48);
            this.txb_cro.Name = "txb_cro";
            this.txb_cro.Size = new System.Drawing.Size(186, 26);
            this.txb_cro.TabIndex = 3;
            // 
            // lbl_cam
            // 
            this.lbl_cam.AutoSize = true;
            this.lbl_cam.Location = new System.Drawing.Point(17, 125);
            this.lbl_cam.Name = "lbl_cam";
            this.lbl_cam.Size = new System.Drawing.Size(73, 20);
            this.lbl_cam.TabIndex = 2;
            this.lbl_cam.Text = "Camera :";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(17, 84);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(59, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome :";
            // 
            // lbl_cro
            // 
            this.lbl_cro.AutoSize = true;
            this.lbl_cro.Location = new System.Drawing.Point(17, 49);
            this.lbl_cro.Name = "lbl_cro";
            this.lbl_cro.Size = new System.Drawing.Size(52, 20);
            this.lbl_cro.TabIndex = 0;
            this.lbl_cro.Text = "CRO :";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(358, 206);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(136, 36);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // CadastroCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 254);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.gb_cadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCamera";
            this.Text = "CadastroCamera";
            this.gb_cadastro.ResumeLayout(false);
            this.gb_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cadastro;
        private System.Windows.Forms.TextBox txb_cam;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_cro;
        private System.Windows.Forms.Label lbl_cam;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cro;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}