using bancoSistema;

namespace ClassListaDeContasCorrentes 
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null!;
        private int _proximaPosicao = 0;


        // Método construtor
        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }


        // Adiciona o objeto ContaCorrente, dentro da array _itens
        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;            
            _proximaPosicao++;
        }


        // Remove um
        public void Remover(ContaCorrente conta)
        {
            int indiceItem = -1;
            
            for (int i = 0; i < _proximaPosicao; i++)
            {

                if (_itens[i] == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null!;
        }


        //
        public void Exibir()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    Console.WriteLine($"Indíce: [{i}]: Nome da Conta: {_itens[i].Conta} - Número da agencia: {_itens[i].Numero_agencia}");
                }
            }
        }


        //
        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if (indice<0 || indice >=_proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }


        public int Tamanho
        {
            get {
                return _proximaPosicao;
            }
        }

        
        //
        public ContaCorrente this[int indice]
        {
            get {
                return (_itens[indice]);  
            }
        }


        //
        public void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine("Aumentando a capaciade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0;i < _itens.Length;i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }
    }
}