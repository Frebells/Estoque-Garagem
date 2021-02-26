using System;

namespace CadastroEstoque
{
    public class CRUDItens : EntidadeBase
    {
        public CRUDItens(Marca marca, string modelo, int ano, bool emEstoque)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.EmEstoque = false;

        }
        private Marca Marca { get; set; }

        private string Modelo { get; set; }

        private string Cor { get; set; }

        private int Ano { get; set; }
        private bool EmEstoque { get; set; }

        public CRUDItens(int id, Marca marca, string modelo, string cor, int ano)
        {
            this.Id = id;
            this.Marca = marca;
            this.Cor = cor;
            this.Modelo = modelo;
            this.Ano = ano;
            this.EmEstoque = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Marca: " + this.Marca + Environment.NewLine;
            retorno += "Modelo: " + this.Cor + Environment.NewLine;
            retorno += "Cor: " + this.Modelo + Environment.NewLine;
            retorno += "Ano:" + this.Ano + Environment.NewLine;
            retorno += "Excluido" + this.EmEstoque;
            return retorno;
        }

        public string retornaModelo()
        {
            return this.Modelo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public void SemEstoque()
        {
            this.EmEstoque = true;
        }
    }
}