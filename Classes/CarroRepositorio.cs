using System;
using System.Collections.Generic;
using CadastroEstoque.Interfaces;

namespace CadastroEstoque
{
    public class CarroRepositorio : IRepositorio<CRUDItens>
    {
        private List<CRUDItens> listacarro = new List<CRUDItens>();
        public void Atualiza(int id, CRUDItens objeto)
        {
            listacarro[id] = objeto;
        }
        public void Exclui(int id)
        {
            listacarro[id].SemEstoque();
        }

        public void Insere(CRUDItens objeto)
        {
            listacarro.Add(objeto);
        }

        public List<CRUDItens> List()
        {
            return listacarro;
        }

        public int ProximoId()
        {
            return listacarro.Count;
        }

        public CRUDItens RetornaId(int id)
        {
            return listacarro[id];
        }
    }
}
    