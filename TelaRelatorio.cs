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
    public partial class TelaRelatorio : Form
    {
        public TelaRelatorio()
        {
            InitializeComponent();
            lbl_quantidade.Text = "";
            
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            dg_relatorio.Rows.Clear();
            int res = cb_tipoRel.SelectedIndex;
            List<List<string>> resultado; 
            if (res == 0) 
            {
                //dg_relatorio.Columns[2].DataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
                MovimentacaoCamera camera = new MovimentacaoCamera();
                resultado = camera.BuscarCamRelatorio("DISPONÍVEL");
                lbl_quantidade.Text = resultado.Count.ToString();
                for (int i = 0; i < resultado.Count; i++)
                {
                    //lb_cam.Items.Add(resultado[i][0] + " ; " + resultado[i][1]);
                    dg_relatorio.Rows.Add(resultado[i][0].ToString(), resultado[i][1].ToString());

                }
                
                
            }
            if (res == 1) 
            {
                //dg_relatorio.Columns[2].DataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
                MovimentacaoCamera camera = new MovimentacaoCamera();
                resultado = camera.BuscarCamRelatorio("AGUARDANDO ENVIO");
                lbl_quantidade.Text = resultado.Count.ToString();
                for (int i = 0; i < resultado.Count; i++)
                {
                    //lb_cam.Items.Add(resultado[i][0] + " ; " + resultado[i][1]);
                    dg_relatorio.Rows.Add(resultado[i][0].ToString(), resultado[i][1].ToString());

                }
                
            }

        }
    }
}
