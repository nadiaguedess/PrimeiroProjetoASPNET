using CamadadeDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PrimeiroProjetoASPNET
{
    public class AcessorioBLL
    {
        DAL objDAl = new DAL();

        //atributos encapsulados


        private int Id;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        private string preco;

        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }


        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }



        //metodos
        public void Inserir()
        {
            objDAl.Conectar();
            string sql = String.Format("INSERT INTO acessorio (NOME, PRECO, MODELO) VALUES('{0}','{1}','{2}')", Nome, Preco, Modelo);
            objDAl.ExecutarComandoSQL(sql);
        }

        public void Alterar()
        {
            objDAl.Conectar();
            string sql = String.Format("UPDATE acessorio SET NOME = '{0}', PRECO = '{1}', MODELO= '{2}' WHERE ID = {3}", Nome, Preco, Modelo, Id);
            objDAl.ExecutarComandoSQL(sql);
        }

        public void Excluir()
        {
            objDAl.Conectar();
            string sql = String.Format("DELETE FROM acessorio WHERE ID ='{0}'", Id);
            objDAl.ExecutarComandoSQL(sql);

        }

        public DataTable ListarCarros()
        {
            objDAl.Conectar();
            DataTable data = new DataTable();
            data = objDAl.RetDataTable("SELECT * FROM acessorio;");
            return data;


        }
    }
}