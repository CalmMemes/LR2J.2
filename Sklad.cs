using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2J
{
    class Sklad
    {
        private readonly Dictionary<Zapasi, List<Polzovatel>> zapasi = new Dictionary<Zapasi, List<Polzovatel>>();
        private Sklad()
        {
        }

        public static Sklad Initialisation()
        {
            var res = new Sklad();
            var novi = new Zapasi
            {
                name = "tiplivo",
                proizvoditel = "gazprom",
                code = "001",
                nalichie = Nalichie.est,
                enventories = Enventories.toplivo
            };

            res.zapasi.Add(novi, new List<Polzovatel>());
            novi = new Zapasi
            {
                name = "detaly",
                proizvoditel = "lada",
                code = "002",
                nalichie = Nalichie.net,
                enventories = Enventories.detaly
            };
            res.zapasi.Add(novi, new List<Polzovatel>());

            return res;
        }

        public void PokupkaZapasi(String codeZapasi, Polzovatel polzovatel)
        {
            var res = (from ob in zapasi where ob.Key.code == codeZapasi select ob).ToList();

            if (res.Count > 0)
            {
                if (res[0].Key.nalichie == Nalichie.est)
                {
                    res[0].Key.nalichie = Nalichie.net;
                    res[0].Value.Add(polzovatel);
                    Console.WriteLine("Покупка запаса зафиксирована. ");

                }
                else
                    Console.WriteLine("Запасов нет на складе.");

            }
            else
                Console.WriteLine("Покупка запаса зафиксирована. ");
        }

        public void VozvratBraka(Polzovatel polzovatel)
        {
            Console.WriteLine("Функция не реализована!!!");
        }

        public void Assortiment()
        {
            foreach(var zapasi in zapasi.Keys)
            {
                Console.WriteLine(zapasi.name + "\n" + zapasi.proizvoditel);
            }
        }
    }
}
