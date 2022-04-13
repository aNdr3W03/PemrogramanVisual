# Pemrograman Visual
#### Tugas Mata Kuliah Pemrograman Visual
#### Dosen Pengampu: T. Henny Febriana Harumy, S.Kom., M.Kom.
#### Tahun Ajaran: Genap 2020/2021
#### Ilmu Komputer - Universitas Sumatera Utara

# 
**Nama: Andrew Benedictus Jamesie**  
**NIM: 201401035**  
**Kom: A**  

# 
# Table of Contents
| Pertemuan | Keterangan | Project File |
|:---------:|:----------:|:------------|
| 13 | [TextBox Validation](#pertemuan-13-textbox-validation-database-sql-server-dengan-c "TextBox Validation, Database SQL Server dengan C#")       | [[PV_13_Kasir-TextBoxValidation]](/PV_13_Kasir-TextBoxValidation "Project File") |
| 12 | [Kode Barang Otomatis](#pertemuan-12-kode-barang-otomatis-database-sql-server-dengan-c "Kode Barang Otomatis, Database SQL Server dengan C#") | [[PV_12_Kasir-KodeAutomatic]](/PV_12_Kasir-KodeAutomatic "Project File") |
| 11 | [ComboBox Satuan](#pertemuan-11-combobox-satuan-database-sql-server-dengan-c "ComboBox, Database SQL Server dengan C#")                       | [[PV_11_Kasir-ComboBox]](/PV_11_Kasir-ComboBox "Project File") |
| 10 | [Search Data](#pertemuan-10-search-data-database-sql-server-dengan-c "Search Data, Database SQL Server dengan C#")                            | [[PV_10_Kasir-Search]](/PV_10_Kasir-Search "Project File") |
| 9  | [Delete Data](#pertemuan-9-delete-data-database-sql-server-dengan-c "Delete Data, Database SQL Server dengan C#")                             | [[PV_9_Kasir-Delete]](/PV_9_Kasir-Delete "Project File") |
| 8  | [Edit & Update Data](#pertemuan-8-edit-dan-update-data-database-sql-server-dengan-c "Edit dan Update Data, Database SQL Server dengan C#")    | [[PV_8_Kasir-EditUpdate]](/PV_8_Kasir-EditUpdate "Project File") |
| 7  | [Insert Data](#pertemuan-7-insert-data-database-sql-server-dengan-c "Insert Data, Database SQL Server dengan C#")                             | [[PV_7_Kasir-Insert]](/PV_7_Kasir-Insert "Project File") |
| 6  | [Koneksi Database](#pertemuan-6-koneksi-database-sql-server-dengan-c "Koneksi Database SQL Server dengan C#")                                 | [[PV_6_Kasir]](/PV_6_Kasir "Project File") |
| 5  | [Kalkulator Sederhana](#pertemuan-5-membuat-kalkulator-sederhana "Membuat Kalkulator Sederhana")                                              | [[PV_5_Kalkulator]](/PV_5_Kalkulator "Project File") |
| 4  | [PV Sederhana](#pertemuan-4-pemrograman-visual-sederhana "Pemrograman Visual Sederhana dengan SharpDevelop")                                  | [[PV_4_ButtonMessageBox]](/PV_4_ButtonMessageBox "Project File") <br/> [[PV_4_ButtonNama]](/PV_4_ButtonNama "Project File") |
| 3  | [SharpDevelop](#pertemuan-3-pengenalan-sharpdevelop "Pengenalan SharpDevelop")                                                                | [[PV_3_Tugas1]](/PV_3_Tugas1 "Project File") <br/> [[PV_2_Tugas1_2]](/PV_2_Tugas1_2 "Project File") <br/> [[PV_2_Tugas1_1]](/PV_2_Tugas1_1 "Project File") |

<!-- https://stackoverflow.com/questions/46621765/can-i-merge-table-rows-in-markdown -->

<!--
Pertemuan 13
[TextBox Validation](#pertemuan-13-textbox-validation-database-sql-server-dengan-c "TextBox Validation, Database SQL Server dengan C#")
[[PV_13_Kasir-TextBoxValidation]](/PV_13_Kasir-TextBoxValidation "Project File")

Pertemuan 12
[Kode Barang Otomatis](#pertemuan-12-kode-barang-otomatis-database-sql-server-dengan-c "Kode Barang Otomatis, Database SQL Server dengan C#")
[[PV_12_Kasir-KodeAutomatic]](/PV_12_Kasir-KodeAutomatic "Project File")

Pertemuan 11
[ComboBox Satuan](#pertemuan-11-combobox-satuan-database-sql-server-dengan-c "ComboBox, Database SQL Server dengan C#")
[[PV_11_Kasir-ComboBox]](/PV_11_Kasir-ComboBox "Project File")

Pertemuan 10
[Search Data](#pertemuan-10-search-data-database-sql-server-dengan-c "Search Data, Database SQL Server dengan C#")
[[PV_10_Kasir-Search]](/PV_10_Kasir-Search "Project File")

Pertemuan 9
[Delete Data](#pertemuan-9-delete-data-database-sql-server-dengan-c "Delete Data, Database SQL Server dengan C#")
[[PV_9_Kasir-Delete]](/PV_9_Kasir-Delete "Project File")

Pertemuan 8
[Edit & Update Data](#pertemuan-8-edit-dan-update-data-database-sql-server-dengan-c "Edit dan Update Data, Database SQL Server dengan C#")
[[PV_8_Kasir-EditUpdate]](/PV_8_Kasir-EditUpdate "Project File")

Pertemuan 7
[Insert Data](#pertemuan-7-insert-data-database-sql-server-dengan-c "Insert Data, Database SQL Server dengan C#")
[[PV_7_Kasir-Insert]](/PV_7_Kasir-Insert "Project File")

Pertemuan 6
[Koneksi Database](#pertemuan-6-koneksi-database-sql-server-dengan-c "Koneksi Database SQL Server dengan C#")
[[PV_6_Kasir]](/PV_6_Kasir "Project File")

Pertemuan 5
[Kalkulator Sederhana](#pertemuan-5-membuat-kalkulator-sederhana "Membuat Kalkulator Sederhana")
[[PV_5_Kalkulator]](/PV_5_Kalkulator "Project File")

Pertemuan 4
[PV Sederhana](#pertemuan-4-pemrograman-visual-sederhana "Pemrograman Visual Sederhana dengan SharpDevelop")
[[PV_4_ButtonMessageBox]](/PV_4_ButtonMessageBox "Project File")
[[PV_4_ButtonNama]](/PV_4_ButtonNama "Project File")

Pertemuan 3
[SharpDevelop](#pertemuan-3-pengenalan-sharpdevelop "Pengenalan SharpDevelop")
[[PV_3_Tugas1]](/PV_3_Tugas1 "Project File")
[[PV_2_Tugas1_2]](/PV_2_Tugas1_2 "Project File")
[[PV_2_Tugas1_1]](/PV_2_Tugas1_1 "Project File")
-->

# 
# Pertemuan 13 (TextBox Validation, Database SQL Server dengan C#)
**PV_13_Kasir-TextBoxValidation**
> - Project ini merupakan program untuk menampilkan data yang sudah ada di _database_, yaitu tabel **TBL_BARANG**, dan menampilkannya ke dalam tabel **DataGridView**. Pada bagian isian `Harga Jual`, `Harga Beli`, dan `Jumlah`, tidak bisa dilakukan _input_ selain angka (huruf, simbol), **hanya bisa diisi dengan angka** (_`number only`_). Sehingga mengurangi kesalahan yang mungkin akan dilakukan oleh _user_ (_human error_) dalam melakukan _input_ data. Hal ini akan meningkatkan kualitas aplikasi dari aspek _Control_ dan _Robustness_ dalam HCI (_Human Computer Intereaction_) dan UX (_User Experience_), sehingga _user_ tidak akan mungkin bisa salah memasukkan format _input_ "Harga Jual", "Harga Beli", dan "Jumlah" secara teknis.
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **TextBox Validation for "Harga Jual", "Harga Beli", "Jumlah" in Application (Kasir)**
> ![Screenshot Tugas Pertemuan 13](Screenshot/%5BPV%5D%20-%20%5B13%5D%20Screenshot%201.png)

# 
# Pertemuan 12 (Kode Barang Otomatis, Database SQL Server dengan C#)
**PV_12_Kasir-KodeAutomatic**
> - Project ini merupakan program untuk menampilkan data yang sudah ada di _database_, yaitu tabel **TBL_BARANG**, dan menampilkannya ke dalam tabel **DataGridView**. Pada bagian isian `Kode Barang`, _user_ tidak perlu mengetikkan kode barang lagi, tetapi sudah ditambahkan `fitur memasukkan Kode Barang secara otomatis` menggunakan perhitungan _string_ BRG + urutan kode barang sebelumnya (yang terakhir). Hal ini bertujuan agar mempermudah _user_ dalam melakukan _input_ data, sehingga aplikasi menjadi lebih efektif dan efisien, serta _user-friendly_ dalam meningkatkan kualitas aplikasi dari aspek _Task Compatibility_ dalam HCI (_Human Computer Intereaction_) dan UX (_User Experience_).
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **Automatic "Kode Barang" in Application (Kasir)**
> ![Screenshot Tugas Pertemuan 12](Screenshot/%5BPV%5D%20-%20%5B12%5D%20Screenshot%201.png)

# 
# Pertemuan 11 (ComboBox Satuan, Database SQL Server dengan C#)
**PV_11_Kasir-ComboBox**
> - Project ini merupakan program untuk menampilkan data yang sudah ada di _database_, yaitu tabel **TBL_BARANG**, dan menampilkannya ke dalam tabel **DataGridView**. Pada bagian isian `Satuan`, _user_ tidak perlu mengetikkan satuan barang lagi, tetapi sudah ditambahkan fitur berupa `ComboBox` yang akan menampilkan **daftar _dropdown_ dari satuan** yang tersedia. Hal ini bertujuan agar mempermudah _user_ dalam melakukan _input_ data, sehingga aplikasi menjadi lebih efektif dan efisien, serta _user-friendly_ dalam meningkatkan kualitas aplikasi dari aspek _Task Compatibility_ dalam HCI (_Human Computer Intereaction_) dan UX (_User Experience_).
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **ComboBox "Satuan" in Application (Kasir)**
> ![Screenshot Tugas Pertemuan 11](Screenshot/%5BPV%5D%20-%20%5B11%5D%20Screenshot%201.png)

# 
# Pertemuan 10 (Search Data, Database SQL Server dengan C#)
**PV_10_Kasir-Search**
> - Project ini merupakan program untuk menampilkan data yang sudah ada di _database_, yaitu tabel **TBL_BARANG**, dan menampilkannya ke dalam tabel **DataGridView**, serta _user_ dapat melakukan **_search_ atau pencarian data** dengan mengetikkan kata kunci atau _keyword_ Kode Barang ataupun Nama Barang di kolom `TextBox Pencarian Kode/Nama Barang`. Fitur ini bertujuan untuk mempermudah _user_ dalam mencari data dengan kata kunci dari Kode Barang ataupun Nama Barang yang ingin dicari, sehingga pekerjaan yang dilakukan _user_ menjadi lebih cepat, efektif, dan efisien, tanpa harus mencari satu per satu kode atau nama barang di dalam tabel. Hal ini akan meningkatkan kualitas aplikai dari aspek _Task Compatibility_ dalam HCI (_Human Computer Intereaction_) dan UX (_User Experience_).
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **Search Data in Table (TBL_BARANG) in Application (Kasir)**
> ![Screenshot Tugas Pertemuan 10](Screenshot/%5BPV%5D%20-%20%5B10%5D%20Screenshot%201.png)

# 
# Pertemuan 9 (Delete Data, Database SQL Server dengan C#)
**PV_9_Kasir-Delete**
> - Project ini merupakan program untuk menampilkan data yang sudah ada di _database_, yaitu tabel **TBL_BARANG**, dan menampilkannya ke dalam tabel **DataGridView**, serta _user_ dapat melakukan **_delete_ atau hapus data** dengan menekan tombol `Delete`.
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **Delete Data to Table (TBL_BARANG) in Application (Kasir)**
> ![Screenshot Tugas Pertemuan 9](Screenshot/%5BPV%5D%20-%20%5B9%5D%20Screenshot%201.png)

# 
# Pertemuan 8 (Edit dan Update Data, Database SQL Server dengan C#)
**PV_8_Kasir-EditUpdate**
> - Project ini merupakan program untuk menampilkan data yang sudah ada di _database_, yaitu tabel **TBL_BARANG**, dan menampilkannya ke dalam tabel **DataGridView**, serta _user_ dapat melakukan **_edit_ dan _update_ data** dengan menekan tombol `Update`.
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **Edit and Update Data to Table (TBL_BARANG) in Application (Kasir)**
> ![Screenshot Tugas Pertemuan 8](Screenshot/%5BPV%5D%20-%20%5B8%5D%20Screenshot%201.png)

# 
# Pertemuan 7 (Insert Data, Database SQL Server dengan C#)
**PV_7_Kasir-Insert**
> - Project ini merupakan program untuk menampilkan data yang sudah ada di _database_, yaitu tabel **TBL_BARANG**, dan menampilkannya ke dalam tabel **DataGridView**, serta _user_ dapat melakukan **tambah data** dengan menekan tombol `Simpan`.
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **Insert Data to Table (TBL_BARANG) in Application (Kasir)**
> ![Screenshot Tugas Pertemuan 7](Screenshot/%5BPV%5D%20-%20%5B7%5D%20Screenshot%201.png)

# 
# Pertemuan 6 (Koneksi Database SQL Server dengan C#)
**PV_6_Kasir**
> - Project ini merupakan program untuk menampilkan data yang sudah di-_input_ di **SQL Server Database**, yaitu tabel **TBL_BARANG**, dan menampilkannya dalam bentuk tabel **DataGridView**.
> - Folder ini merupakan project/solution **Windows Forms Application .NET Framework C#** Visual Studio.
> - Dalam folder ini terdapat file Program `.sln` yang dapat dibuka dengan menggunakan Visual Studio.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat pada file `.cs` (C# Source File), yaitu `Form1.cs`.
> - Untuk file koneksi ke Database SQL Server terdapat pada file `.cs` (C# Source File), yaitu `koneksi.cs`.
> 
> **Insert Data to Table (TBL_BARANG) in SQL Server Database (Kasir)**
> ![Screenshot Tugas Pertemuan 6.1](Screenshot/%5BPV%5D%20-%20%5B6%5D%20Screenshot%201.png)
> 
> **DataGridView from Database Table**
> ![Screenshot Tugas Pertemuan 6.2](Screenshot/%5BPV%5D%20-%20%5B6%5D%20Screenshot%202.png)

# 
# Pertemuan 5 (Membuat Kalkulator Sederhana)
**PV_5_Kalkulator**
> - Project Solution ini merupakan program kalkulator sederhana yang akan meminta _input_ **Angka 1 dan Angka 2 serta operasi perhitungan yang diinginkan (+, -, x, /)** yang kemudian hasil perhitungannya akan ditampilkan di Label Hasil.
> - Folder ini merupakan project/solution **Windows Application** SharpDevelop.
> - Dalam folder ini terdapat file Solution `.sln` yang dapat dibuka dengan menggunakan SharpDevelop.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat dalam folder PV_5_Kalkulator, file `.cs` (C# Source File), yaitu `MainForm.cs`.
> 
> ![Screenshot Tugas Pertemuan 5](Screenshot/%5BPV%5D%20-%20%5B5%5D%20Screenshot%201.png)

# 
# Pertemuan 4 (Pemrograman Visual Sederhana)
**1. PV_4_ButtonMessageBox**
> - Project Solution ini akan meminta _input_ **Nama, NIM, Kelas, dan Mata Kuliah** yang akan ditampilkan di MessageBox baru.
> - Folder ini merupakan project/solution **Windows Application** SharpDevelop.
> - Dalam folder ini terdapat file Solution `.sln` yang dapat dibuka dengan menggunakan SharpDevelop.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat dalam folder PV_4_ButtonMessageBox, file `.cs` (C# Source File), yaitu `MainForm.cs`.
> 
> ![Screenshot Tugas2 Pertemuan 4](Screenshot/%5BPV%5D%20-%20%5B4%5D%20Screenshot%202.png)

**2. PV_4_ButtonNama**
> - Project Solution ini akan meminta _input_ **Nama** yang akan ditampilkan di MessageBox baru.
> - Folder ini merupakan project/solution **Windows Application** SharpDevelop.
> - Dalam folder ini terdapat file Solution `.sln` yang dapat dibuka dengan menggunakan SharpDevelop.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat dalam folder PV_4_ButtonNama, file `.cs` (C# Source File), yaitu `MainForm.cs`.
> 
> ![Screenshot Tugas1 Pertemuan 4](Screenshot/%5BPV%5D%20-%20%5B4%5D%20Screenshot%201.png)

# 
# Pertemuan 3 (Pengenalan SharpDevelop)
**1. PV_2_Tugas1_1**
> - Project Solution ini akan menampilkan tulisan **Hello World** di console.
> - Folder ini merupakan project/solution **Console Application** SharpDevelop.
> - Dalam folder ini terdapat file Solution `.sln` yang dapat dibuka dengan menggunakan SharpDevelop.
> - Sedangkan jika hanya ingin melihat _source code_-nya terdapat dalam folder PV_2_Tugas1_1, file `.cs` (C# Source File), yaitu `Program.cs`.
> 
> ![Screenshot Tugas1.1 Pertemuan 2](Screenshot/%5BPV%5D%20-%20%5B3%5D%20Screenshot%201.png)

**2. PV_2_Tugas1_2**
> - Project Solution ini akan meminta _input_ **Nama Anda** di _console_ dan menampilkannya.
> - Folder ini merupakan project/solution **Console Application** SharpDevelop.
> - Dalam folder ini terdapat file Solution `.sln` yang dapat dibuka dengan menggunakan SharpDevelop.
> - Sedangkan jika hanya ingin melihat _source code_-nya terdapat dalam folder PV_2_Tugas1_2, file `.cs` (C# Source File), yaitu `Program.cs`.
> 
> ![Screenshot Tugas1.2 Pertemuan 2](Screenshot/%5BPV%5D%20-%20%5B3%5D%20Screenshot%202.png)

**3. PV_3_Tugas1**
> - Project Solution ini akan meminta _input_ **Nama Mahasiswa** di TextBox, lalu menambahkannya ke **ListBox** dengan menekan Button **Tambah**. _User_ juga dapat menghapus daftar di **ListBox** dengan menekan tombol **Hapus**.
> - Folder ini merupakan project/solution **Windows Application** SharpDevelop.
> - Dalam folder ini terdapat file Solution `.sln` yang dapat dibuka dengan menggunakan SharpDevelop.
> - Sedangkan jika hanya ingin melihat _source code_ Form Design-nya terdapat dalam folder PV_3_Tugas1, file `.cs` (C# Source File), yaitu `MainForm.cs`.
> 
> ![Screenshot Tugas Pertemuan 3](Screenshot/%5BPV%5D%20-%20%5B3%5D%20Screenshot%203.png)
