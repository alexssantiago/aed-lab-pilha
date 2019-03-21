namespace SensorVertebral.Dominio
{
    public class Dado
    {
        public double percent { get; set; }
        public double limite { get; set; }

        public Dado(double percent, double limite)
        {
            this.percent = percent;
            this.limite = limite;
        }

        public double LimiteSuportado(double peso)
        {
            return this.limite - (this.percent * peso) / 100;
        }
    }
}
