using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Desk_Kamisaki
{
    public class Desk
    {
        
        //Properties
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawersNum { get; set; }

        public DesktopMaterial DeskMaterial { get; set; }
        
    }
    public enum DesktopMaterial
    {
        Oak=200,
        Laminate=100,
        Pine=50,
        Rosewwod=300,
        Veneer=125
    }

    

}
