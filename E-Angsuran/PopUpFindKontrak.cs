using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Angsuran
{
    public partial class PopUpFindKontrak : MetroFramework.Forms.MetroForm
    {
        YLib lib;
        public PopUpFindKontrak()
        {
            InitializeComponent();
            lib = new YLib();
        }

        private void PopUpFindKontrak_Load(object sender, EventArgs e)
        {
            lib.conn_open();

            try
            {
               DataTable dt = lib.getDataTable("SELECT *FROM VW_KREDIT");

                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lib.conn_close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("No. Kontrak LIKE '%{0}%' OR Nama LIKE '%{0}%' OR No. Ktp LIKE '%{0}%'", txtSearch.Text);
            }
        }
    }
}
