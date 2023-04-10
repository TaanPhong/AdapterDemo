using AdapterDemo.Adaptee;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDemo.Adapter
{
    public class HinhTronAdapter : HinhTron, Draw
    {

        public void Ve(Panel area, Pen pen, int x1, int y1, int x2, int y2)
        {
            int diameter = radius(x1, y1, x2, y2) * 2;
            int x = XacDinhTamToaDoX(x1, diameter / 2);
            int y = XacDinhTamToaDoY(y1, diameter / 2);
            this.veHinhTron(area, pen, x, y, diameter);
        }

        public int XacDinhTamToaDoX(int x1, int banKinh)
        {
            
            return x1 - banKinh;
        }

        public int XacDinhTamToaDoY(int y1, int banKinh)
        {
            return y1 - banKinh;
        }

        public int radius(int x1, int y1, int x2, int y2)
        {
            int r = (int)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return r;
        }
    }
}
