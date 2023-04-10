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
    public class DuongThangAdapter : Draw
    {
        private DuongThang duongThang;

        public DuongThangAdapter(DuongThang duongThang)
        {
            this.duongThang = duongThang;
        }

        public void Ve(Panel area, Pen pen, int x1, int y1, int x2, int y2)
        {
            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            duongThang.veDuongThang(area, pen, point1, point2);
        }
    }
}
