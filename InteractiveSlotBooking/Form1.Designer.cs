namespace InteractiveSlotBooking
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblSoViTri;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Label lblKhungGio;

        private System.Windows.Forms.ComboBox cboKhungGio;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelViTri;

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuyChon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblSoViTri = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.lblKhungGio = new System.Windows.Forms.Label();

            this.cboKhungGio = new System.Windows.Forms.ComboBox();

            this.tableLayoutPanelViTri = new System.Windows.Forms.TableLayoutPanel();

            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyChon = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Bold);

            this.lblTieuDe.Location = new System.Drawing.Point(250, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(300, 37);
            this.lblTieuDe.Text = "SƠ ĐỒ CHỌN VỊ TRÍ";

            // 
            // lblKhungGio
            // 
            this.lblKhungGio.AutoSize = true;
            this.lblKhungGio.Location = new System.Drawing.Point(35, 75);
            this.lblKhungGio.Name = "lblKhungGio";
            this.lblKhungGio.Size = new System.Drawing.Size(80, 20);
            this.lblKhungGio.Text = "Khung giờ:";

            // 
            // cboKhungGio
            // 
            this.cboKhungGio.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboKhungGio.Location = new System.Drawing.Point(125, 72);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(220, 28);
            this.cboKhungGio.TabIndex = 0;

            this.cboKhungGio.SelectedIndexChanged +=
                new System.EventHandler(this.cboKhungGio_SelectedIndexChanged);

            // 
            // tableLayoutPanelViTri
            // 
            this.tableLayoutPanelViTri.ColumnCount = 5;
            this.tableLayoutPanelViTri.RowCount = 4;

            this.tableLayoutPanelViTri.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 20F));

            this.tableLayoutPanelViTri.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 20F));

            this.tableLayoutPanelViTri.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 20F));

            this.tableLayoutPanelViTri.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 20F));

            this.tableLayoutPanelViTri.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 20F));

            this.tableLayoutPanelViTri.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));

            this.tableLayoutPanelViTri.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));

            this.tableLayoutPanelViTri.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));

            this.tableLayoutPanelViTri.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));

            this.tableLayoutPanelViTri.Location =
                new System.Drawing.Point(35, 120);

            this.tableLayoutPanelViTri.Name =
                "tableLayoutPanelViTri";

            this.tableLayoutPanelViTri.Size =
                new System.Drawing.Size(730, 330);

            this.tableLayoutPanelViTri.TabIndex = 1;

            // 
            // lblSoViTri
            // 
            this.lblSoViTri.AutoSize = true;
            this.lblSoViTri.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblSoViTri.Location =
                new System.Drawing.Point(35, 475);

            this.lblSoViTri.Name = "lblSoViTri";
            this.lblSoViTri.Size = new System.Drawing.Size(200, 23);
            this.lblSoViTri.Text = "Số vị trí đang chọn: 0";

            // 
            // lblTamTinh
            // 
            this.lblTamTinh.AutoSize = true;
            this.lblTamTinh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblTamTinh.Location =
                new System.Drawing.Point(300, 475);

            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(200, 23);
            this.lblTamTinh.Text = "Tạm tính tiền: 0đ";

            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location =
                new System.Drawing.Point(535, 465);

            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size =
                new System.Drawing.Size(110, 40);

            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận đặt";
            this.btnXacNhan.UseVisualStyleBackColor = true;

            this.btnXacNhan.Click +=
                new System.EventHandler(this.btnXacNhan_Click);

            // 
            // btnHuyChon
            // 
            this.btnHuyChon.Location =
                new System.Drawing.Point(655, 465);

            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size =
                new System.Drawing.Size(110, 40);

            this.btnHuyChon.TabIndex = 3;
            this.btnHuyChon.Text = "Hủy chọn tất cả";
            this.btnHuyChon.UseVisualStyleBackColor = true;

            this.btnHuyChon.Click +=
                new System.EventHandler(this.btnHuyChon_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 530);

            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblKhungGio);
            this.Controls.Add(this.cboKhungGio);
            this.Controls.Add(this.tableLayoutPanelViTri);
            this.Controls.Add(this.lblSoViTri);
            this.Controls.Add(this.lblTamTinh);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuyChon);

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Interactive Slot Booking";

            this.Load +=
                new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}