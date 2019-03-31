namespace SensorVertebral.Dominio
{
    public class Elemento
    {
        public Dado Dado { get; }
        public Elemento Prox { get; set; }

        public Elemento(Dado dado)
        {
            this.Dado = dado;
        }
    }
}
