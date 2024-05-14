namespace LSPDomain
{
    public class FiguraGeometrica
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
