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
    public partial class TelaQuantidadeCam : Form
    {
        public TelaQuantidadeCam()
        {
            InitializeComponent();
            Camera.Unit cam = new Camera.Unit();
            List<List<string>> resultado;
            resultado = cam.BuscarQuantidade();
            for (int i = 0; i < resultado.Count; i++)
            {
                dg_quantidadeCam.Rows.Add(resultado[i][0].ToString(), resultado[i][1].ToString());
            }
        }
    }
}
