namespace SensorVertebral.Dominio
{
    public class Dado
    {
        public double Percent { get; }
        public double Limite { get; }

        public Dado(double percent, double limite)
        {
            this.Percent = percent;
            this.Limite = limite;
        }

        public double PesoSuportado(double peso) => this.Limite - (this.Percent * peso) / 100;
    }
}
