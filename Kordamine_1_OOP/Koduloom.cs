using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
    abstract class Koduloom
    {
        public string nimi;
        public string varv;
        public enum sugu { isane,emane,
            Isane
        }
        public sugu loomaSugu;
        public double kaal;
        public int vanus;
        public string elav; //kui true siis elav; kui false, siis on surnud 

        public Koduloom()
        {
        }


        public Koduloom(string nimi, string varv,sugu loomaSugu, double kaal = 0.0, int vanus = 0, string elav = "---")
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;



        }
        public Koduloom(Koduloom loom) //kloonimiseks 
        {
            this.nimi = loom.nimi;
            this.varv = loom.varv;
            this.loomaSugu = loom.loomaSugu;
            this.kaal = loom.kaal;
            this.vanus = loom.vanus;
            this.elav = loom.elav;

        }
        public abstract void print_info();      
        public void muuda_Nimi(string uusNimi) { nimi = uusNimi; }
        public void muuda_Vanus(int uusVanus) { vanus = uusVanus; }
        public void muuda_Kaal(double uusKaal) { kaal = uusKaal; }
    }
}


