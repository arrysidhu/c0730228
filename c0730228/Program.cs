using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730228
{
    class Program
    {
        static void Main(String[]args)
        {

        }
    }
    class countryside
    {
        Village Alst;
        Village Maeland;
        Village Schenig;

        public void InitializeMap()
        {
            Village Alst = new Village();
            Alst.VillageName = "Alst";
            Village Maeland = new Village();
            Maeland.VillageName = "Maeland";
            Maeland.isAstrildeHere = true;
            Village Schenig = new Village();
            Schenig.VillageName = "Schenig";

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
        }


        public void WalkAround()
        {
             Village InitialVillage = this.Maeland;
        }

    }
} 
        class Village
        
        {
      public  Village PreviousVillage;
      public  Village NextVillage;
      public String VillageName;
      public  bool isAstrildeHere = false;
        public Village() { }
        }
  

