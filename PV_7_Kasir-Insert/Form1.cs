using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace PV_7_KasirInsert
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilBarang();
            Bersihkan();
        }

        void TampilBarang()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_BARANG", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_BARANG");
                dataGridView.DataSource = ds;
                dataGridView.DataMember = "TBL_BARANG";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        void Bersihkan()
        {
            textBoxKodeBarang.Text = "";
            textBoxNamaBarang.Text = "";
            textBoxHargaBeli.Text  = "";
            textBoxHargaJual.Text  = "";
            textBoxJumlah.Text     = "";
            textBoxSatuan.Text     = "";
        }

        /**************************************************
         * Membuat event Tombol "Simpan"
         **************************************************/

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            /**************************************************
             * Memeriksa apakah kolom Text kosong?
             **************************************************/

            if (textBoxKodeBarang.Text.Trim() == "" ||
                textBoxNamaBarang.Text.Trim() == "" ||
                textBoxHargaBeli.Text.Trim()  == "" ||
                textBoxHargaJual.Text.Trim()  == "" ||
                textBoxJumlah.Text.Trim()     == "" ||
                textBoxSatuan.Text.Trim()     == "")
            {
                MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
            }
            else
            {
                /**************************************************
                 * Simpan Data
                 **************************************************/
                
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("INSERT INTO TBL_BARANG VALUES ('"+textBoxKodeBarang.Text+"','" + textBoxNamaBarang.Text + "','" + textBoxHargaBeli.Text + "','" + textBoxHargaJual.Text + "','" + textBoxJumlah.Text + "','" + textBoxSatuan.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil!");
                    TampilBarang();
                    Bersihkan();
                }
                catch(Exception x)
                {
                    MessageBox.Show("Tidak dapat menyimpan data");
                }

                conn.Close();
            }

        }
    }
}
