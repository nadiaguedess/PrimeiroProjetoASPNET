using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadadeDados;

namespace PrimeiroProjetoCamadas.cs
{
    class ClienteBLL
    {

        DAL objDAl = new DAL();


        public DataTable ListarClientes()
        {
            objDAl.Conectar();
            DataTable data = new DataTable();
            data = objDAl.RetDataTable("SELECT * FROM cliente;");
            return data;


        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public void InserirCliente()
        {
            objDAl.Conectar();
            string sql = String.Format("INSERT INTO CLIENTE(NOME,EMAIL, CPF, TELEFONE) VALUES('{0}','{1}','{2}','{3}')", Nome, Email, Cpf, Telefone);
            objDAl.ExecutarComandoSQL(sql);
        }
        public void Excluir()
        {
            objDAl.Conectar();
            string sql = String.Format("DELETE FROM CLIENTE WHERE ID ='{0}'", Id);
            objDAl.ExecutarComandoSQL(sql);
        }
        public void Alterar()
        {
            objDAl.Conectar();
            string sql = String.Format("UPDATE CLIENTE SET nome = '{0}', email= '{1}', cpf = '{2}',  telefone = '{3}' WHERE id = {4}", Nome, Email, Cpf, Telefone, Id);
            objDAl.ExecutarComandoSQL(sql);
        }
        public DataTable ListarCliente()
        {
            objDAl.Conectar();
            DataTable data = new DataTable();
            data = objDAl.RetDataTable("SELECT * FROM CLIENTE;");
            return data;


        }

    }
}
