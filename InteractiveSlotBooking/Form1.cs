using System;
using System.Drawing;
using System.Windows.Forms;

namespace InteractiveSlotBooking
{
    public partial class Form1 : Form
    {
        private int soViTriDangChon = 0;
        private decimal giaMoiViTri = 100000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhungGio.Items.Add("Sáng - 100.000đ");
            cboKhungGio.Items.Add("Tối - 150.000đ");

            cboKhungGio.SelectedIndex = 0;

            Tao20ViTri();
            CapNhatThongKe();
        }

        private void Tao20ViTri()
        {
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();

                btn.Text = "Vị trí " + i;
                btn.Name = "btnViTri" + i;
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(5);
                btn.BackColor = Color.White;
                btn.Tag = "Trong";

                btn.Click += ViTri_Click;

                tableLayoutPanelViTri.Controls.Add(btn);
            }

            Button viTriDaDat1 = tableLayoutPanelViTri.Controls[4] as Button;
            Button viTriDaDat2 = tableLayoutPanelViTri.Controls[10] as Button;
            Button viTriDaDat3 = tableLayoutPanelViTri.Controls[16] as Button;

            viTriDaDat1.BackColor = Color.Red;
            viTriDaDat1.ForeColor = Color.White;
            viTriDaDat1.Tag = "DaDat";

            viTriDaDat2.BackColor = Color.Red;
            viTriDaDat2.ForeColor = Color.White;
            viTriDaDat2.Tag = "DaDat";

            viTriDaDat3.BackColor = Color.Red;
            viTriDaDat3.ForeColor = Color.White;
            viTriDaDat3.Tag = "DaDat";
        }

        private void ViTri_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            if (btn.Tag.ToString() == "DaDat")
            {
                MessageBox.Show(
                    "Vị trí này đã có người đặt hoặc đã bị khóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (btn.Tag.ToString() == "Trong")
            {
                btn.Tag = "DangChon";
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.Tag = "Trong";
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }

            CapNhatThongKe();
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhungGio.SelectedIndex == 0)
                giaMoiViTri = 100000;
            else
                giaMoiViTri = 150000;

            CapNhatThongKe();
        }

        private void CapNhatThongKe()
        {
            soViTriDangChon = 0;

            foreach (Control control in tableLayoutPanelViTri.Controls)
            {
                Button btn = control as Button;

                if (btn != null && btn.Tag != null &&
                    btn.Tag.ToString() == "DangChon")
                {
                    soViTriDangChon++;
                }
            }

            lblSoViTri.Text = "Số vị trí đang chọn: " + soViTriDangChon;

            decimal tongTien = soViTriDangChon * giaMoiViTri;

            lblTamTinh.Text = "Tạm tính tiền: " + tongTien.ToString("N0") + "đ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (soViTriDangChon == 0)
            {
                MessageBox.Show(
                    "Bạn chưa chọn vị trí nào!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xác nhận đặt " +
                soViTriDangChon + " vị trí không?",
                "Xác nhận đặt",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                foreach (Control control in tableLayoutPanelViTri.Controls)
                {
                    Button btn = control as Button;

                    if (btn != null && btn.Tag != null &&
                        btn.Tag.ToString() == "DangChon")
                    {
                        btn.Tag = "DaDat";
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                }

                MessageBox.Show(
                    "Đặt vị trí thành công!\n" +
                    "Số vị trí: " + soViTriDangChon + "\n" +
                    "Tổng tiền: " +
                    (soViTriDangChon * giaMoiViTri).ToString("N0") + "đ",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CapNhatThongKe();
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Control control in tableLayoutPanelViTri.Controls)
            {
                Button btn = control as Button;

                if (btn != null && btn.Tag != null &&
                    btn.Tag.ToString() == "DangChon")
                {
                    btn.Tag = "Trong";
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            CapNhatThongKe();
        }
    }
}