using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace E_Angsuran
{
    public partial class Bayar : MetroFramework.Forms.MetroForm
    {
        YLib lib;
        public Bayar()
        {
            InitializeComponent();
            lib = new YLib();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            lib.conn_open();

            try
            {
                lib.begintransaction();

                NameValueCollection nvc = new NameValueCollection();
                NameValueCollection key = new NameValueCollection();

                //lib.addToNVC(nvc,"",);


                lib.executeNonQuery("exec sp_updateidinc 'bayar'");
                lib.committransaction();
            }
            catch(Exception ex)
            {
                lib.rollbackTransaction();
                MessageBox.Show(ex.Message,"Perhatian",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            lib.conn_close();
        }

        private void Bayar_Load(object sender, EventArgs e)
        {
            lib.conn_open();

            try
            {
                DataTable dt = lib.getDataTable("SELECT dbo.genId('BAYAR')");

                txtIDBayar.Value = dt.Rows[0][0].ToString();
                txtIDBayar.ReadOnly = true;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lib.conn_close();
        }
        

        private void txtNoKontrak_btnClick(object sender, EventArgs e)
        {
            PopUpFindKontrak pfk = new PopUpFindKontrak();
            pfk.Show();
        }
    }
}
