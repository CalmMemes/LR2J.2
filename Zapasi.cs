using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2J
{
    class Zapasi
    {
        public String name;
        public String code;
        public String kachestvo;
        public String  proizvoditel;
        public Nalichie nalichie;
        public Enventories enventories;
    }

    public enum Nalichie { est, net}

    public enum Enventories { osnmat, detaly, vspommat, toplivo, othody}
}
