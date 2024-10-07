using Admin.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.GUI.UC
{
    public partial class uc_dat_km : UserControl
    {
        String maphong;
        frm_thue_dat_phong frm;
        frmSystem frmsys;

        public uc_dat_km(String ma, frm_thue_dat_phong frm, frmSystem frmsys)
        {
            InitializeComponent();
            this.maphong = ma;
            this.frm = frm;
            this.frmsys = frmsys;
        }

        private void uc_dat_km_Load(object sender, EventArgs e)
        {
            
        }

        private void btndat_Click(object sender, EventArgs e)
        {
            BUS_thuedatphong.DAO.datphongkm(txtcus, txtcmnd, ngayden, maphong, frm);
        }
    }
}
