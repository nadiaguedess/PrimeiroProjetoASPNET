using PrimeiroProjetoCamadas.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimeiroProjetoASPNET
{
    public partial class cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        ClienteBLL objCliente = new ClienteBLL();

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
               /* try
                {*/
                    objCliente.Nome = txtnome.Text;
                    objCliente.Email = txtemail.Text;
                    objCliente.Cpf = txtcpf.Text;
                    objCliente.Telefone = txttelefone.Text;

                    //Estamos preenchendo os atributos com os dados do usuário            
                  if (txtid.Text == "")
                    {
                        objCliente.InserirCliente();
                    }
                    else
                    {
                        objCliente.Id = int.Parse(txtid.Text);
                        objCliente.Alterar();
                    }

                    Limpar();
                    CarregarGrid();
               // }
               
               /* catch (Exception ex)
                {
                    
                CF}*/
            }

        public void Limpar()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtcpf.Text = "";
            txtemail.Text = "";
            txttelefone.Text = "";
           
        }
        private void CarregarGrid()
        {
            GridCliente.DataSource = objCliente.ListarCliente();
            GridCliente.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           /* try
            {*/
                if (txtid.Text != "")
                {

                    objCliente.Id = int.Parse(txtid.Text);
                    objCliente.Excluir();
                        CarregarGrid();
                        Limpar();
                    
                }
           // }
           /* catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        protected void Button3_Click(object sender, EventArgs e)
        {


            objCliente.Id = int.Parse(txtid.Text);
            objCliente.Alterar();
                           
                            CarregarGrid();
	                           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtid.Text = GridCliente.SelectedRow.Cells[1].Text;
            txtnome.Text = GridCliente.SelectedRow.Cells[2].Text;
            txtemail.Text = GridCliente.SelectedRow.Cells[3].Text;
            txtcpf.Text = GridCliente.SelectedRow.Cells[4].Text;
            txttelefone.Text = GridCliente.SelectedRow.Cells[5].Text;
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Limpar();
        }



        }
    }
