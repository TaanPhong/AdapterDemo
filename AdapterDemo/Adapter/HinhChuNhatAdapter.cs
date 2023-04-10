using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDemo.Adapter
{
    public class HinhChuNhatAdapter : Draw
    {
        private HinhChuNhat hcn;

        public HinhChuNhatAdapter(HinhChuNhat hinhChuNhat)
        {
            this.hcn = hinhChuNhat;
        }

        public void Ve(Panel area, Pen pen, int x1, int y1, int x2, int y2)
        {
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            int width = Math.Abs(x1 - x2);
            int height = Math.Abs(y1 - y2);
            hcn.hinhChuNhatDaw(area, pen, x, y, width, height);
        }
    }
}
