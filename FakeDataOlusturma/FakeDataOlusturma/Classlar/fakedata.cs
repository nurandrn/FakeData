
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataOlusturma.Classlar
{
    class FakeDataOlusturma
    {
        private List<string> _adlar = new List<string>();
        private List<string> _soyadlar = new List<string>();
        private List<string> _kitaplar = new List<string>();
        private List<Karma> _karmalar = new List<Karma>();


        public FakeDataOlusturma()
        {
            _adlar = AdlariGetir();
            _soyadlar = YazarlarıGetir();
            _kitaplar = KitaplariGetir();
        }

        public List<string> AdlariGetir()
        {
            List<string> adlar = new List<string>();
            adlar.Add("Nuran Dündar");
            adlar.Add("Sezgin Yağlı");
            adlar.Add("Anıl Durmuş");
            adlar.Add("Ali Taşpınar");
            adlar.Add("Doruk Kaya");
            foreach (string ad in adlar)
                _adlar.Add(ad);

            return _adlar;
        }
        public List<string> YazarlarıGetir()
        {
            List<string> soyadlar = new List<string>();
            soyadlar.Add("İskender Pala");
            soyadlar.Add("İskender Pala");
            soyadlar.Add("Victor Hugo");
            soyadlar.Add("Charles Dickens");
            soyadlar.Add("Şemseddin Sami");
            foreach (string soyad in soyadlar)
                _soyadlar.Add(soyad);

            return _soyadlar;
        }

        public List<string> KitaplariGetir()
        {
            List<string> kitaplar = new List<string>();
            kitaplar.Add("Katre-i Matem");
            kitaplar.Add("Babilde Ölüm İstanbulda Aşk");
            kitaplar.Add("Sefiller");
            kitaplar.Add("İki Şehrin Hikayesi");
            kitaplar.Add("Taaşuku Talat ve Fitnat");
            foreach (string kitap in kitaplar)
                _kitaplar.Add(kitap);

            return _kitaplar;
        }

        public List<Karma> KarmalariGetir(int karmaSayisi)
        {
            _karmalar.Clear();
            Random r = new Random();

            for (int i = 0; i < karmaSayisi; i++)
            {
                int rAd = r.Next(0, _adlar.Count);
                int rSoyad = r.Next(0, _soyadlar.Count);
                int rKitap = r.Next(0, _kitaplar.Count);

                Karma karma = new Karma();
                karma.ID = i;
                karma.OgrenciAdSoyadı = _adlar[rAd];
                karma.YazarAdıSoyadı = _soyadlar[rSoyad];
                karma.KitapAdi = _kitaplar[rKitap];
                _karmalar.Add(karma);
            }

            return _karmalar;
        }

        public class Karma
        {
            public int ID { get; set; }
            public string OgrenciAdSoyadı { get; set; }
            public string YazarAdıSoyadı { get; set; }
            public string KitapAdi { get; set; }
        }
    }
}
