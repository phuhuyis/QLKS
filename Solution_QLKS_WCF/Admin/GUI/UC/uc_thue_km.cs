using Admin.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.GUI.UC
{
    public partial class uc_thue_km : UserControl
    {
        String maphong;
        frm_thue_dat_phong frm;
        frmSystem frmsys;

        public uc_thue_km(String ma, frm_thue_dat_phong frm, frmSystem frmsys)
        {
            InitializeComponent();
            this.maphong = ma;
            this.frm = frm;
            this.frmsys = frmsys;
        }

        private void uc_thue_km_Load(object sender, EventArgs e)
        {

        }

        private void btnthue_Click(object sender, EventArgs e)
        {
            BUS_thuedatphong.DAO.thuephongkm(namecus, cmnd, maphong, frmsys.user, frm);
        }
    }
}
