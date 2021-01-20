using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimeiroProjetoASPNET
{
    public partial class Acessorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        AcessorioBLL objBLL = new AcessorioBLL();

        private void CarregarGrid()
        {
            GridAcessorios.DataSource = objBLL.ListarCarros();
            GridAcessorios.DataBind();

        }

        protected void btngravar_Click(object sender, EventArgs e)
        {       

            /*  try
                {*/
                    objBLL.Nome = txtnome.Text;
                    objBLL.Preco = txtpreco.Text;
                    objBLL.Modelo = txtmodelo.Text;



                    if (txtid.Text == "")
                    {
                        objBLL.Inserir();

                    }
                    else
                    {
                        objBLL.Id1 = int.Parse(txtid.Text);
                        objBLL.Alterar();
                    }
                    CarregarGrid();
                //}


              /*  catch (Exception ex)
                {
                    MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
           
        }

        private void Limpar()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtpreco.Text = "";
            txtmodelo.Text = "";
            txtnome.Focus();
        }

        protected void btnexcluir_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                if (txtid.Text != "")
                {
                    
                        objBLL.Id1 = int.Parse(txtid.Text);
                        objBLL.Excluir();
                        CarregarGrid();
                        Limpar();
                    }
                
          //  }
          /*  catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            
        }

        protected void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void GridAcessorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtid.Text = GridAcessorios.SelectedRow.Cells[1].Text;
            txtnome.Text = GridAcessorios.SelectedRow.Cells[2].Text;
            txtpreco.Text = GridAcessorios.SelectedRow.Cells[3].Text;
            txtmodelo.Text = GridAcessorios.SelectedRow.Cells[4].Text;
            
        }
    }
}