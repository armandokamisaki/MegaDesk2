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

        public int getWidth() { return width; }
        public int getDepth() { return depth; }
        public int getDrawersNum() { return drawersNum; }
        public DesktopMaterial getMaterial() { return material; }

        public void setWidth(int width) { this.width = width; }
        public void setDepth(int  depth) { this.depth = depth; }
        public void setDrawersNum(int drawersNum) { this.drawersNum = drawersNum; }
        public void setMaterial(DesktopMaterial material) { this.material = material; }

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
