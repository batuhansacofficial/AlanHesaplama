namespace AlanHesaplama.Shapes
{
    public class Kare : IShape
    {
        public double Kenar { get; set; }
        public Kare(double kenar)
        {
            Kenar = kenar;
        }
        public double AlanHesaplama()
        {
            return Math.Pow(Kenar, 2);
        }
        public double CevreHesaplama()
        {
            return 4 * Kenar;
        }
    }
}
