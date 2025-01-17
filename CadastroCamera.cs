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
using System.ComponentModel.DataAnnotations;

namespace Controle_Camera
{
    public partial class CadastroCamera : Form
    {
        public CadastroCamera()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Camera.Unit camera = new Camera.Unit();
                camera.Id_Camera = txb_cam.Text.ToUpper();
                camera.Proprietario = txb_cro.Text;
                camera.Nome = txb_nome.Text;
                camera.Validacao();
                if (camera.BuscarCam(txb_cam.Text.ToUpper()) != null)
                {
                    MessageBox.Show("camera já existe! nenhuma camera será cadastrada!");
                    this.Close();
                    return;
                }

                ProprietarioCamera.Unit propri = new ProprietarioCamera.Unit();


                if (propri.BuscarProprietario(txb_cro.Text) == null)
                {

                    camera.IncluirCooperado();
                }
                else 
                {
                    MessageBox.Show("proprietario já cadastrado somente a camera será cadastrada!");
                }
                //camera.IncluirCooperado();
                camera.IncluirCamera();
                MessageBox.Show("camera cadastrada com sucesso!");
                this.Close();

            }
            catch (ValidationException ex) 
            {
                MessageBox.Show("Erro :" + ex.Message, "Controle de Cameras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Controle de Cameras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
