using AlanHesaplama.Shapes;

namespace AlanHesaplama.Services
{
    public class Calculator
    {
        public void Hesaplama()
        {
            Console.Write("Bir geometrik şekil seçin => Daire | Kare | Üçgen | Dikdörtgen: ");
            string shapeType = Console.ReadLine()?.ToLower();

            IShape shape = null;

            switch (shapeType)
            {
                case "daire":
                    shape = DaireOlusturma();
                    break;
                case "dikdörtgen":
                    shape = DikdortgenOlusturma();
                    break;
                case "üçgen":
                    shape = UcgenOlusturma();
                    break;
                case "kare":
                    shape = KareOlusturma();
                    break;
                default:
                    Console.WriteLine("Geçersiz şekil ismi.");
                    return;
            }

            Console.Write("Bir hesaplama türü seçiniz => Alan | Çevre: ");
            string operation = Console.ReadLine()?.ToLower();

            switch (operation)
            {
                case "alan":
                    Console.WriteLine($"Alan: {shape.AlanHesaplama():F2}");
                    break;
                case "çevre":
                    Console.WriteLine($"Çevre: {shape.CevreHesaplama():F2}");
                    break;
                default:
                    Console.WriteLine("Geçersiz hesaplama türü.");
                    break;
            }
        }
        private Daire DaireOlusturma()
        {
            Console.Write("Yarıçap giriniz: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());
            return new Daire(yaricap);
        }
        private Dikdortgen DikdortgenOlusturma()
        {
            Console.Write("Uzun kenarı giriniz: ");
            double uzunKenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kısa kenarı giriniz: ");
            double kisaKenar = Convert.ToDouble(Console.ReadLine());
            return new Dikdortgen(uzunKenar, kisaKenar);
        }
        private Ucgen UcgenOlusturma()
        {
            Console.Write("Birinci kenar uzunluğunu giriniz: ");
            double kenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci kenar uzunluğunu giriniz: ");
            double kenar2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü kenar uzunluğunu giriniz: ");
            double kenar3 = Convert.ToDouble(Console.ReadLine());
            return new Ucgen(kenar, kenar2, kenar3);
        }
        private Kare KareOlusturma()
        {
            Console.Write("Kenar uzunluğu giriniz: ");
            double kenar = Convert.ToDouble(Console.ReadLine());
            return new Kare(kenar);
        }
    }
}
