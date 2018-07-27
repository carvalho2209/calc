namespace Calculadora
{
    public class Calculadora
    {
        public double Largura { get; set; }
        public double Profundidade { get; set; }
        public double AreaParedes { get; set; }
        public double AreaTeto { get; set; }

        private const double Altura = 2.9;

        public double CalcularAreaParedes
            (double largura, double profundidade)
        {
            AreaParedes = 2 * (largura + profundidade) * Altura;
            return AreaParedes;
        }

        public double CalcularAreaTeto(double largura,
            double profundidade)
        {
            AreaTeto = largura * profundidade;
            return AreaTeto;
        }

        public double CalcularLitragemNecessaria()
        {
            return (AreaParedes + AreaTeto) / 10;
        }
    }
}
