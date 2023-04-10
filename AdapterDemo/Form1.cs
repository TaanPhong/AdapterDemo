
using AdapterDemo.Adaptee;
using AdapterDemo.Adapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdapterDemo
{
    public partial class AdapterDemo : DevExpress.XtraEditors.XtraForm
    {
        

        public AdapterDemo()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (teX1.Text.Trim() == "" || teX2.Text.Trim() == "" || teY2.Text.Trim() == "" || teY1.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ các tọa độ để thực hiện vẽ hình!", "", MessageBoxButtons.OK);
                return;
            }
            if (rbChuNhat.Checked == false && rbDoanThang.Checked == false && rbTron.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn hình cần vẽ!", "", MessageBoxButtons.OK);
                return;
            }
            int x1 = int.Parse(teX1.Text.Trim());
            int y1 = int.Parse(teY1.Text.Trim());
            int x2 = int.Parse(teX2.Text.Trim());
            int y2 = int.Parse(teY2.Text.Trim());

            lbTarget.Text = "Interface: Draw" + "\n \n" + "Method: Void Ve(Panel area, \nPen pen, int x1, "
                               + "int y1, \nint x2, int y2);";
            if(rbChuNhat.Checked == true)
            {
                lbClient.Text = "Draw draw;\ndraw = new HinhChuNhatAdapter\n(new HinhChuNhat());" + "\n" + "Method: draw.Ve(Panel area, Pen pen, \nint x1, "
                               + " int y1, int x2, int y2);";
                lbAdapter.Text = "HinhChuNhat hcn;\nHCNAdapter.Ve(Panel area, Pen pen, \nint x1, int y1, int x2, int y2);// Tại đây xử \nlý dữ liệu sử dụng đối tương hcn\ngọi phương thức " + "hcn.VeHinhChuNhat()";
                lbAdaptee.Text = "Class: HinhChuNhat;\n" + "Method: veHinhChuNhat(Panel area, \nPen pen, int x, "
                               + " int y, int width, int height);";
                Draw drawHCN = new HinhChuNhatAdapter(new HinhChuNhat());
                Pen pen = new Pen(Color.Red, 3);
                drawHCN.Ve(area, pen, x1, y1, x2, y2);
            }
            if(rbTron.Checked == true)
            {
                lbClient.Text = "Draw draw;\ndraw = new HinhTronAdapter\n(new HinhTron());" + "\n" + "Method: draw.Ve(Panel area, Pen pen, \nint x1, "
                               + " int y1, int x2, int y2);";
                lbAdapter.Text = "Kế thừ lại lớp HinhTron;\nHinhTronAdapter.Radius\n(int x1, int y1, int x2, int y2);// Tại đây tìm \nra bán kính \ngọi phương thức " + "this.VeHinhTron()";
                lbAdaptee.Text = "Class: HinhTron;\n" + "Method: veHinhTron(Panel area, \nPen pen, int x, "
                               + " int y, int r);";
                Pen pen = new Pen(Color.Red, 3);
                Draw hinhTron = new HinhTronAdapter();
                hinhTron.Ve(area, pen, x1, y1, x2, y2);
            }
            if (rbDoanThang.Checked == true)
            {
                lbClient.Text = "Draw draw;\ndraw = new DoanThangAdapter\n(new DoanThang());" + "\n" + "Method: draw.Ve(Panel area, Pen pen, \nint x1, "
                               + " int y1, int x2, int y2);";
                lbAdapter.Text = "DoanThang doanThang;\nDoanThangdapter.Ve(Panel area, Pen pen, \nint x1, int y1, int x2, int y2);// Tại đây xử \nlý dữ liệu sử dụng đối tương duongThang\ngọi phương thức " + "\nduongThang.VeDuongThang()";
                lbAdaptee.Text = "Class: DuongThang;\n" + "Method: veDuongThang(Panel area, \nPen pen, Point point1,"
                               + " Point point2);";
                Pen pen = new Pen(Color.Green, 3);
                Draw doanThang = new DuongThangAdapter(new Adaptee.DuongThang());
                doanThang.Ve(area, pen, x1, y1, x2, y2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = area.CreateGraphics();
            graphics.Clear(area.BackColor);
            graphics.Dispose();
            lbAdaptee.Text = "";
            lbAdapter.Text = "";
            lbClient.Text = "";
            lbTarget.Text = "";
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            
            lbX.Text = "x = " + e.X.ToString();
            lbY.Text = "y = " + e.Y.ToString();
        }

        private void lbY_Click(object sender, EventArgs e)
        {

        }

        private void Mouse_move(object sender, MouseEventArgs e)
        {
            //lbX.Text = "";
            //lbY.Text = "";
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            //lbX.Text = "";
            //lbY.Text = "";
        }

        private void m_m(object sender, MouseEventArgs e)
        {
            //lbX.Text = "";
            //lbY.Text = "";
        }
    }
}
