using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Camera_Biblioteca.Classes;


namespace Controle_Camera
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            lbl_resultado.Text = "";
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string busca = txt_busca.Text.ToUpper();
            dg_cam.Rows.Clear();
            
            Camera.Unit cam = new Camera.Unit();
            List<List<string>> resultado;
            if (string.IsNullOrEmpty(busca)) 
            {
                //var resultado = cam.BuscarCamera(busca).ToString();
                

                resultado = cam.BuscarTodasCameras();
                
                for (int i = 0; i < resultado.Count; i++ )
                {
                    //lb_cam.Items.Add(resultado[i][0] + " ; " + resultado[i][1]);
                    dg_cam.Rows.Add(resultado[i][0].ToString(), resultado[i][1].ToString(), resultado[i][2].ToString(), resultado[i][3].ToString());
                    
                }
                
            }
            else
            {
                resultado = cam.BuscarAlgumasCameras(busca);
                if(resultado.Count == 0)
                {
                    MessageBox.Show("Nenhuma camera ou cooperado encontrado para esta busca! " + busca);
                }
                for (int i = 0; i < resultado.Count; i++)
                {
                    //lb_cam.Items.Add(resultado[i][0] + " ; " + resultado[i][1]);
                    dg_cam.Rows.Add(resultado[i][0].ToString(), resultado[i][1].ToString(), resultado[i][2].ToString(), resultado[i][3].ToString());

                }
            }

            lbl_resultado.Text = resultado.Count.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            dg_cam.Rows.Clear();
            lbl_resultado.Text = "";
            txt_busca.Text = "";
        }

        private void btn_carregarSelecionado_Click(object sender, EventArgs e)
        {
            string busca = txt_busca.Text;
            if (dg_cam.RowCount == 0)
            {
                MessageBox.Show("Nenhuma camera seleconada!");
            }
            else
            {
                TelaCamera c = new TelaCamera();
                c.preencherTextBox(dg_cam.CurrentRow.Cells[0].Value.ToString(), dg_cam.CurrentRow.Cells[1].Value.ToString(), dg_cam.CurrentRow.Cells[2].Value.ToString());
                c.preencherDataGridView(dg_cam.CurrentRow.Cells[2].Value.ToString());
                c.ShowDialog();
            }
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastroCamera c = new CadastroCamera();
            c.ShowDialog(this);
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            TelaRelatorio r = new TelaRelatorio();
            r.ShowDialog(this);
        }
    }
}
