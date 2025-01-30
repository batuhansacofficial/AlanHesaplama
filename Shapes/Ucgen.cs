namespace AlanHesaplama.Shapes
{
    public class Ucgen : IShape
    {
        public double Kenar { get; set; }
        public double Kenar2 { get; set; }
        public double Kenar3 { get; set; }
        public Ucgen(double kenar, double kenar2, double kenar3)
        {
            Kenar = kenar;
            Kenar2 = kenar2;
            Kenar3 = kenar3;
        }
        public double AlanHesaplama()
        {
            double k = (Kenar + Kenar2 + Kenar3) / 2;
            return Math.Sqrt(k * (k - Kenar) * (k - Kenar2) * (k - Kenar3));
        }

        public double CevreHesaplama()
        {
            return (Kenar + Kenar2 + Kenar3);
        }
    }
}
