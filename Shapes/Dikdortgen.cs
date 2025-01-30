namespace AlanHesaplama.Shapes
{
    public class Dikdortgen : IShape
    {
        public double UzunKenar { get; set; }
        public double KisaKenar { get; set; }
        public Dikdortgen(double uzunKenar, double kisaKenar)
        {
            UzunKenar = uzunKenar;
            KisaKenar = kisaKenar;
        }
        public double AlanHesaplama()
        {
            return UzunKenar * KisaKenar;
        }
        public double CevreHesaplama()
        {
            return 2 * (UzunKenar + KisaKenar);
        }
    }
}
