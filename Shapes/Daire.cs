namespace AlanHesaplama.Shapes
{
    public class Daire : IShape
    {
        public double Yaricap { get; set; }
        public Daire(double yaricap)
        {
            Yaricap = yaricap;
        }
        public double AlanHesaplama()
        {
            return Math.PI * Math.Pow(Yaricap, 2);
        }
        public double CevreHesaplama()
        {
            return 2 * Math.PI * Yaricap;
        }
    }
}
