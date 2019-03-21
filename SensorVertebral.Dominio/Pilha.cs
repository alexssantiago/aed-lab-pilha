namespace SensorVertebral.Dominio
{
    public class Elemento
    {
        public Dado dado { get; }
        public Elemento prox { get; set; }

        public Elemento(Dado dado)
        {
            this.dado = dado;
        }
    }

    public class Pilha
    {
        Elemento topo;

        public Pilha()
        {
            this.topo = new Elemento(null);
        }

        public void Empilhar(Dado dado)
        {
            Elemento novo = new Elemento(dado);
            novo.prox = this.topo.prox;
            this.topo.prox = novo;
        }

        public Dado Desempilhar()
        {
            if (this.Vazia()) return null;

            Elemento aux = this.topo.prox;
            this.topo.prox = aux.prox;

            aux.prox = null;

            return aux.dado;
        }

        public bool Vazia()
        {
            return (this.topo == null);
        }

        public Elemento Consultar()
        {
            return this.topo.prox;
        }

    }
}
