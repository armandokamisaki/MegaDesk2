using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Desk_Kamisaki
{
    internal class Desk
    {
        private int width;
        private int depth;
        private int drawersNum;
        DesktopMaterial material;

        public Desk(int width, int depth, int drawersNum, DesktopMaterial material) {
            this.width = width;
            this.depth = depth;
            this.drawersNum = drawersNum;
            this.material = material;
        }

        public int GetWidth() { return width; }
        public int GetDepth() { return depth; }
        public int GetDrawersNum() { return drawersNum; }
        public DesktopMaterial GetMaterial() { return material; }

        public void SetWidth(int width) { this.width = width; }
        public void SetDepth(int  depth) { this.depth = depth; }
        public void SetDrawersNum(int drawersNum) { this.drawersNum = drawersNum; }
        public void SetMaterial(DesktopMaterial material) { this.material = material; }

    }
    enum DesktopMaterial
    {
        Oak=200,
        Laminate=100,
        Pine=50,
        Rosewwod=300,
        Veneer=125
    }
}
