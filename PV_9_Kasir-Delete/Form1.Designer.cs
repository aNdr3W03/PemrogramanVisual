namespace PV_9_KasirDelete
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelHargaJual = new System.Windows.Forms.Label();
            this.labelHargaBeli = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelSatuan = new System.Windows.Forms.Label();
            this.labelDBTable = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.textBoxHargaBeli = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxSatuan = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 250);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(638, 250);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKodeBarang.Location = new System.Drawing.Point(12, 21);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(94, 18);
            this.labelKodeBarang.TabIndex = 1;
            this.labelKodeBarang.Text = "Kode Barang";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNamaBarang.Location = new System.Drawing.Point(297, 21);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(101, 18);
            this.labelNamaBarang.TabIndex = 2;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // labelHargaJual
            // 
            this.labelHargaJual.AutoSize = true;
            this.labelHargaJual.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHargaJual.Location = new System.Drawing.Point(12, 51);
            this.labelHargaJual.Name = "labelHargaJual";
            this.labelHargaJual.Size = new System.Drawing.Size(80, 18);
            this.labelHargaJual.TabIndex = 3;
            this.labelHargaJual.Text = "Harga Jual";
            // 
            // labelHargaBeli
            // 
            this.labelHargaBeli.AutoSize = true;
            this.labelHargaBeli.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHargaBeli.Location = new System.Drawing.Point(12, 81);
            this.labelHargaBeli.Name = "labelHargaBeli";
            this.labelHargaBeli.Size = new System.Drawing.Size(78, 18);
            this.labelHargaBeli.TabIndex = 6;
            this.labelHargaBeli.Text = "Harga Beli";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJumlah.Location = new System.Drawing.Point(297, 51);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(59, 18);
            this.labelJumlah.TabIndex = 5;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelSatuan
            // 
            this.labelSatuan.AutoSize = true;
            this.labelSatuan.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSatuan.Location = new System.Drawing.Point(297, 81);
            this.labelSatuan.Name = "labelSatuan";
            this.labelSatuan.Size = new System.Drawing.Size(55, 18);
            this.labelSatuan.TabIndex = 4;
            this.labelSatuan.Text = "Satuan";
            // 
            // labelDBTable
            // 
            this.labelDBTable.AutoSize = true;
            this.labelDBTable.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDBTable.Location = new System.Drawing.Point(13, 225);
            this.labelDBTable.Name = "labelDBTable";
            this.labelDBTable.Size = new System.Drawing.Size(206, 18);
            this.labelDBTable.TabIndex = 7;
            this.labelDBTable.Text = "DB: Kasir; Table: TBL_BARANG";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKodeBarang.Location = new System.Drawing.Point(110, 20);
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(150, 21);
            this.textBoxKodeBarang.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimpan.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(402, 130);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNamaBarang.Location = new System.Drawing.Point(402, 20);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(250, 21);
            this.textBoxNamaBarang.TabIndex = 2;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHargaJual.Location = new System.Drawing.Point(110, 50);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(150, 21);
            this.textBoxHargaJual.TabIndex = 3;
            // 
            // textBoxHargaBeli
            // 
            this.textBoxHargaBeli.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHargaBeli.Location = new System.Drawing.Point(110, 80);
            this.textBoxHargaBeli.Name = "textBoxHargaBeli";
            this.textBoxHargaBeli.Size = new System.Drawing.Size(150, 21);
            this.textBoxHargaBeli.TabIndex = 4;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJumlah.Location = new System.Drawing.Point(402, 50);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(150, 21);
            this.textBoxJumlah.TabIndex = 5;
            // 
            // textBoxSatuan
            // 
            this.textBoxSatuan.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSatuan.Location = new System.Drawing.Point(402, 80);
            this.textBoxSatuan.Name = "textBoxSatuan";
            this.textBoxSatuan.Size = new System.Drawing.Size(150, 21);
            this.textBoxSatuan.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(402, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHapus.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(512, 170);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 30);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxSatuan);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxHargaBeli);
            this.Controls.Add(this.textBoxHargaJual);
            this.Controls.Add(this.textBoxNamaBarang);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.textBoxKodeBarang);
            this.Controls.Add(this.labelDBTable);
            this.Controls.Add(this.labelHargaBeli);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelSatuan);
            this.Controls.Add(this.labelHargaJual);
            this.Controls.Add(this.labelNamaBarang);
            this.Controls.Add(this.labelKodeBarang);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private Label labelKodeBarang;
        private Label labelNamaBarang;
        private Label labelHargaJual;
        private Label labelHargaBeli;
        private Label labelJumlah;
        private Label labelSatuan;
        private Label labelDBTable;
        private TextBox textBoxKodeBarang;
        private Button btnSimpan;
        private TextBox textBoxNamaBarang;
        private TextBox textBoxHargaJual;
        private TextBox textBoxHargaBeli;
        private TextBox textBoxJumlah;
        private TextBox textBoxSatuan;
        private Button btnUpdate;
        private Button btnHapus;
    }
}