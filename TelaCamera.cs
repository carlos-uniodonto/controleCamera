using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Camera_Biblioteca.Classes;

namespace Controle_Camera
{
    public partial class TelaCamera : Form
    {


        public TelaCamera()
        {
            InitializeComponent();
            txb_cro2.Enabled = false;
            txb_cro2.Text = "00002";
            cb_acoes.Text = "TROCA DE CAMERA COM DEFEITO";

        }

        public void preencherTextBox(string cro, string coop, string cam)
        {
            lbl_camera.Text = cam;
            txb_coop.Text = coop;
            txb_cro.Text = cro;
        }

        public void preencherDataGridView(string cam) 
        {
            MovimentacaoCamera hist = new MovimentacaoCamera();
            List<List<string>> Historico = new List<List<string>>();
            Historico = hist.BuscarHistorico(cam);
            if (Historico.Count == 0)
            {
                dg_historico.Rows.Add(cam, "nenhuma movimentação");
            }
            else 
            {
                for (int i = 0; i < Historico.Count; i++)
                {
                    dg_historico.Rows.Add(Historico[i][0].ToString(), Historico[i][1].ToString());
                }
            }
        }

        private void btn_trocar_Click(object sender, EventArgs e)
        {
            if (cb_acoes.Text == "RETORNO DA ACTIVEWARE" || cb_acoes.Text == "MOVIMENTAÇÃO MANUAL" || cb_acoes.Text == "ENVIO PARA ACTIVEWARE" || cb_acoes.Text == "RETORNO SEM CONSERTO")
            {
                MovimentacaoCamera mov = new MovimentacaoCamera();
                mov.CAMERA_ID = lbl_camera.Text;
                mov.PROPRIETARIO_EMPRESTADOR_CRO = txb_cro.Text;
                mov.DATA_MOVIMENTACAO = "SYSDATE";
                mov.OBSERVACAO = txb_obs.Text;
                mov.LOCALIZACAO = txb_cro2.Text;
                mov.IncluirMovimentacao();
            }
            else
            {
                if(txb_cam.Text == "")
                {
                    MessageBox.Show("Uma camera da uniodonto deve ser informada");
                    return;
                }
                else if(cb_acoes.Text == "DEVOLUÇÃO AO COOPERADO")
                {
                    MovimentacaoCamera mov = new MovimentacaoCamera();
                    mov.CAMERA_ID = lbl_camera.Text;
                    mov.PROPRIETARIO_EMPRESTADOR_CRO = txb_cro2.Text;
                    mov.DATA_MOVIMENTACAO = "SYSDATE";
                    mov.OBSERVACAO = txb_obs.Text;
                    mov.LOCALIZACAO = txb_cro2.Text;
                    mov.IncluirMovimentacao();

                    MovimentacaoCamera mov2 = new MovimentacaoCamera();
                    mov2.CAMERA_ID = txb_cam.Text;
                    mov2.PROPRIETARIO_EMPRESTADOR_CRO = "12345";
                    mov2.DATA_MOVIMENTACAO = "SYSDATE";
                    mov2.OBSERVACAO = "camera devolvida do " + txb_cro.Text;
                    mov2.LOCALIZACAO = "12345";
                    mov2.IncluirMovimentacao();
                }
                else if (cb_acoes.Text == "TROCA DE CAMERA COM DEFEITO")
                {
                    MovimentacaoCamera mov = new MovimentacaoCamera();
                    mov.CAMERA_ID = lbl_camera.Text;
                    mov.PROPRIETARIO_EMPRESTADOR_CRO = txb_cro2.Text;
                    mov.DATA_MOVIMENTACAO = "SYSDATE";
                    mov.OBSERVACAO = txb_obs.Text;
                    mov.LOCALIZACAO = txb_cro2.Text;
                    mov.IncluirMovimentacao();

                    MovimentacaoCamera mov2 = new MovimentacaoCamera();
                    mov2.CAMERA_ID = txb_cam.Text.ToUpper();
                    mov2.PROPRIETARIO_EMPRESTADOR_CRO = txb_cro.Text;
                    mov2.DATA_MOVIMENTACAO = "SYSDATE";
                    mov2.OBSERVACAO = "camera emprestada para o " + txb_cro.Text;
                    mov2.LOCALIZACAO = txb_cro.Text;
                    mov2.IncluirMovimentacao();
                }


            }
            // movimentando a camera com defeito do cooperado
           
            

            MessageBox.Show("Troca realizada com sucesso!");

        }

        private void cb_acoes_SelectedIndexChanged(object sender, EventArgs e)
        {

            string resposta = cb_acoes.Text;
            switch (resposta) 
            {
                case "DEVOLUÇÃO AO COOPERADO" :
                    txb_cro2.Text = txb_cro.Text;
                    txb_cro2.Enabled = false;
                    txb_cam.Visible = true;
                    lbl_cam.Visible = true;
                    break;

                case "TROCA DE CAMERA COM DEFEITO":
                    txb_cro2.Text = "00002";
                    txb_cro2.Enabled = false;
                    txb_cam.Visible = true;
                    lbl_cam.Visible = true;
                    break;

                case "ENVIO PARA ACTIVEWARE":
                    txb_cro2.Text = "00000";
                    txb_cro2.Enabled = false;
                    txb_cam.Visible = false;
                    lbl_cam.Visible = false;
                    break;

                case "RETORNO DA ACTIVEWARE":
                    txb_cro2.Text = "00003";
                    txb_cro2.Enabled = false;
                    txb_cam.Visible = false;
                    lbl_cam.Visible = false;
                    break;

                case "RETORNO SEM CONSERTO":
                    txb_cro2.Text = "00001";
                    txb_cro2.Enabled = false;
                    txb_cam.Visible = false;
                    lbl_cam.Visible = false;
                    break;

                case "MOVIMENTAÇÃO MANUAL":
                    txb_cro2.Text = "";
                    txb_cro2.Enabled = true;                   
                    txb_cam.Visible = false;
                    lbl_cam.Visible = false;                   
                    break ;
                    
            }
        }
    }
}
