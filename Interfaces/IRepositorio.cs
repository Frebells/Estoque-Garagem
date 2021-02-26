using System.Collections.Generic;
using CadastroEstoque.Interfaces;

namespace CadastroEstoque.Interfaces
{
    public interface IRepositorio<T>
    {   
        List<T> Lista();
        T RetornaId(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}