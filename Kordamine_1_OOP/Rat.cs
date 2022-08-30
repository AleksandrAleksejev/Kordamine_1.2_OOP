using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
     class Rat: Koduloom
    {
        public string toug;
        public Rat(string toug,string nimi,string varv,double kaal ,sugu loomasugu,int vanus, string elav) :base(nimi,varv, loomaSugu ,kaal,vanus, elav)
        {
            this.toug = toug;
        }
        public override void print_info()
        {
            
                
            
               Console.WriteLine("{0} {1} {2} ta on  {3} ja tema kaal on  {4} ja ta on  {5} aastat vana ja se on{6} ", elav, varv, nimi, loomaSugu, kaal, vanus,toug);
            
            }
        }
    }
    

