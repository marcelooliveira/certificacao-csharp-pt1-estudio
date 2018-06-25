using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ///ClienteEspecial cliente = new ClienteEspecial("Lucas Skywalker");
            ///cliente.FazerPedido(1, "Residencial", 1);
            
            ///cliente = new ClienteEspecial();
            ///cliente.FazerPedido(2, "Comercial");
            ///cliente.FazerPedido(3);
            
            /// As instruções a seguir produzem erros de compilação.
            /// Um argumento tem que ser fornecido para o primeiro parâmetro, e ele
            /// precisa ser um inteiro.
            ///cliente.FazerPedido("Residencial", 1);
            ///cliente.FazerPedido();
            
            /// Você não pode deixar um "buraco" nos argumentos
            ///cliente.FazerPedido(3, , 4);
            ///cliente.FazerPedido(3, 4);
            
            /// Você pode usar um argumento nomeado para fazer 
            /// a instrução anterior funcionar.
            ///cliente.FazerPedido(3, quantidade: 4);
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome)
        {
            this.nome = nome;
        }

        ///O primeiro parâmetro é obrigatório e não tem nenhum valor padrão associado a ele.
        ///Portanto, ele não é opcional. Tanto endereco quanto quantidade tem valores padrão
        ///associados. Eles são opcionais.
        public void FazerPedido(int produtoId, string endereco, int quantidade)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
