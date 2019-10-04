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
    public partial class Kredit : MetroFramework.Forms.MetroForm
    {
        YLib lib;

        public Kredit()
        {
            InitializeComponent();
            lib = new YLib();

            txtKtp.MaxLength = 16;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            lib.conn_open();
            lib.begintransaction();

            try
            {
                
                NameValueCollection nvc = new NameValueCollection();
                NameValueCollection key = new NameValueCollection();

                lib.addToNVC(key, "kontrakid", txtNoKontrak.Text);
                lib.addToNVC(key, "nama", txtNama.Text);
                lib.addToNVC(nvc, "ktp", txtKtp.Text);
                lib.addToNVC(nvc, "status_pernikahan", txtStatusPernikahan.Text);
                lib.addToNVC(nvc, "limit", txtLimit.Text);
                lib.addToNVC(nvc, "tenor", txtTenor.Text);
                lib.addToNVC(nvc, "bunga", txtBunga.Text);
                lib.addToNVC(nvc, "angsuran", txtAngsuran.Text);
                lib.addToNVC(nvc, "created_date", DateTime.Now.ToString("yyyy-MM-dd dd:mm:ss.fff"));
                lib.addToNVC(nvc, "created_by", "yusron");

                
                if (lib.saveNVC(key, nvc, "kredit") > 0)
                {
                    MessageBox.Show("Data disimpan!");

                    lib.executeNonQuery("exec sp_updateidinc 'kredit'");

                }

                lib.committransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lib.rollbackTransaction();
            }

            lib.conn_close();
        }

        private void Kredit_Load(object sender, EventArgs e)
        {
            txtNoKontrak.Text = "";
        }
    }
}
