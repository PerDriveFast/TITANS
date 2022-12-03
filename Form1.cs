using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TITANS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl uc)
        {
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panel2.Controls.Add(uc);
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var color = Color.FromArgb(255,255,255) ;

            bttaidulieu.FillColor = Color.FromArgb(25, 118, 210);
            btsolieu.FillColor = color;
            btquanly.FillColor = Color.FromArgb(25, 118, 210);
            btcaidat.FillColor = Color.FromArgb(25, 118, 210);


            frmSoLieu frm = new frmSoLieu();
            addUserControl(frm);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var color = Color.FromArgb(255, 255, 255);
            bttaidulieu.FillColor = color;
            btsolieu.FillColor = Color.FromArgb(25, 118, 210);
            btquanly.FillColor = Color.FromArgb(25, 118, 210);
            btcaidat.FillColor = Color.FromArgb(25, 118, 210);

            frmTaiSoLieu frm = new frmTaiSoLieu();
            addUserControl(frm);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var color = Color.FromArgb(255, 255, 255);
            btquanly.FillColor = color;
            btsolieu.FillColor = Color.FromArgb(25, 118, 210);
            bttaidulieu.FillColor = Color.FromArgb(25, 118, 210);
            btcaidat.FillColor = Color.FromArgb(25, 118, 210);
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            addUserControl(frm);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var color = Color.FromArgb(255, 255, 255);
            btcaidat.FillColor = color;
            btsolieu.FillColor = Color.FromArgb(25, 118, 210);
            bttaidulieu.FillColor = Color.FromArgb(25, 118, 210);
            btquanly.FillColor = Color.FromArgb(25, 118, 210);
            frmDoiMK frm = new frmDoiMK();
            addUserControl(frm);
        }


    }
}
