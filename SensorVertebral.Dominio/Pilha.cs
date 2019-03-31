using System;

namespace SensorVertebral.Dominio
{
    public class Pilha
    {
        Elemento Topo;
        public double Peso { get; private set; }

        public Pilha()
        {
            this.Topo = new Elemento(null);

            Random randNum = new Random();
            for (int i = 0; i <= 24; i++)
            {
                Dado vertebra = new Dado(randNum.Next(4, 15), randNum.Next(1, 9));
                this.Empilhar(vertebra);
            }
        }

        public void Empilhar(Dado dado)
        {
            Elemento novo = new Elemento(dado);
            novo.Prox = this.Topo.Prox;
            this.Topo.Prox = novo;
        }

        public void InserirPeso(double peso)
        {
            this.Peso += peso;
            double suportado = 0;
            Elemento aux = this.Topo;

            while (aux.Prox != null)
            {
                if (suportado < 0)
                    suportado = aux.Prox.Dado.PesoSuportado(this.Peso + suportado);
                else
                    suportado = aux.Prox.Dado.PesoSuportado(this.Peso);

                aux = aux.Prox;
            }
        }

        public Dado Desempilhar()
        {
            if (this.Vazia()) return null;

            Elemento aux = this.Topo.Prox;
            this.Topo.Prox = aux.Prox;

            aux.Prox = null;

            return aux.Dado;
        }

        public bool Vazia() => (this.Topo == null);

        public Elemento Consultar() => this.Topo.Prox;

        public double VerificaLimite()
        {
            Elemento atual;
            double limite = 0;
            int vert = 0;
            atual = this.Consultar().Prox;

            while (atual != null)
            {
                limite += atual.Dado.Limite;
                atual = atual.Prox;
                vert++;
            }

            return limite;
        }

        public bool LimiteSuportaPeso() => this.VerificaLimite() > this.Peso;
    }
}
