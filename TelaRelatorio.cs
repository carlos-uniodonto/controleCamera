using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Camera
{
    public partial class TelaRelatorio : Form
    {
        public TelaRelatorio()
        {
            InitializeComponent();
            
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            dg_relatorio.Rows.Clear();
            int res = cb_tipoRel.SelectedIndex;
            if (res == 0)
            {
                dg_relatorio.Columns[2].DataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
                dg_relatorio.Rows.Add("String de teste", "coluna 2");
                
            }
            if (res == 1) 
            {
                dg_relatorio.Columns[2].DataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
                dg_relatorio.Rows.Add("String de teste 2", "coluna undefined");
            }

        }
    }
}
