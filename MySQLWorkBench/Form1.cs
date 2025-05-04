using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MySQLWorkBench
{
    public partial class Form1 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; uid= root ; password = 1221 ; ");
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            LoadDatabase();
        }

        private void LoadDatabase()
        {
            db_Lbox.Items.Clear();
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
            cmd = new MySqlCommand("SHOW DATABASES", baglanti);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                db_Lbox.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            baglanti.Close();
        }

        private void db_Lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Lbox.Items.Clear();

            if (db_Lbox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir veritabanı seçin.");
                return;
            }

            string selectedDb = db_Lbox.SelectedItem.ToString();

            // Bağlantı stringini oluştur
            string newConnStr = $"server=localhost;uid=root;password=1221;database={selectedDb};"; // Gerekirse şifreyi ekle

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(newConnStr))
                {
                    baglanti.Open();

                    string query = "SHOW TABLES;";
                    using (MySqlCommand cmd = new MySqlCommand(query, baglanti))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            bool hasTable = false;
                            while (reader.Read())
                            {
                                tb_Lbox.Items.Add(reader[0].ToString());
                                hasTable = true;
                            }

                            if (!hasTable)
                            {
                                MessageBox.Show("Bu veritabanında tablo bulunamadı.");
                            }
                        }
                    }
                    baglanti.Close();
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("MySQL Hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Genel Hata: " + ex.Message);
            }
        }

        private void crtData_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Datatext.Text))
            {
                MessageBox.Show("Lütfen bir veritabanı adı girin.");
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                string yeniDb = Datatext.Text.Trim();

                // Önce veritabanı var mı diye kontrol et
                cmd = new MySqlCommand($"SHOW DATABASES LIKE '{yeniDb}'", baglanti);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("Bu isimde bir veritabanı zaten mevcut!");
                }
                else
                {
                    // Veritabanı yoksa oluştur
                    cmd = new MySqlCommand($"CREATE DATABASE {yeniDb}", baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"'{yeniDb}' adlı veritabanı başarıyla oluşturuldu.");
                    LoadDatabase(); // listeyi yenile
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void CrtTable_Click(object sender, EventArgs e)
        { 

            string tableName = TableText.Text.Trim();
            string selectedDb = db_Lbox.SelectedItem?.ToString();

            // Bağlantı cümlesi (Windows Authentication gibi bir kullanım yoksa, MySQL'de UID ve PWD gerekir)
            string connectionString = $"Server=localhost;Database={selectedDb};Uid=root;Pwd=1221;"; // Şifreyi kendine göre değiştir

            if (string.IsNullOrEmpty(selectedDb))
            {
                MessageBox.Show("Please select a database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Please enter a table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (TableExists(selectedDb, tableName))
            {
                MessageBox.Show("Table with that name already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = $@"
        CREATE TABLE `{tableName}` (
            id INT AUTO_INCREMENT PRIMARY KEY,
            Ad VARCHAR(50),
            Soyad VARCHAR(50),
            KayitTarihi DATETIME DEFAULT CURRENT_TIMESTAMP
        );";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Table has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTables(selectedDb); // tabloyu listeleme fonksiyonun varsa çağır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        private bool TableExists(string dbName, string tableName)
        {
            string connStr = $"Server=localhost;Database={dbName};Uid=root;Pwd=1221;"; // Şifreyi kendi bilgine göre değiştir
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SHOW TABLES LIKE '{tableName}';", conn);
                object result = cmd.ExecuteScalar();
                return result != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Table check error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        void LoadTables(string database)
        {
            tb_Lbox.Items.Clear();

            string connStr = $"Server=localhost;Database={database};Uid=root;Pwd=1221;"; 
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SHOW TABLES;", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tb_Lbox.Items.Add(reader[0].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tables couldn't load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void tb_Lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_Lbox.SelectedItem == null || db_Lbox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hem veritabanı hem de tablo seçin.");
                return;
            }

            string selectedDb = db_Lbox.SelectedItem.ToString();
            string selectedTable = tb_Lbox.SelectedItem.ToString();

            string connStr = $"Server=localhost;Database={selectedDb};Uid=root;Pwd=1221;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM `{selectedTable}`";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tablo yüklenemedi: " + ex.Message);
                }
            }
        }

        private void clrTable_Click(object sender, EventArgs e)
        {
            if (tb_Lbox.SelectedItem == null || db_Lbox.SelectedItem == null) return;

            string selectedDb = db_Lbox.SelectedItem.ToString();
            string selectedTable = tb_Lbox.SelectedItem.ToString();

            string connStr = $"Server=localhost;Database={selectedDb};Uid=root;Pwd=1221;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = $"DELETE FROM `{selectedTable}`;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tablo temizlendi.");
                tb_Lbox_SelectedIndexChanged(null, null); // Yeniden yükle
            }
        }

        private void clrCell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                dataGridView1.CurrentCell.Value = DBNull.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRow newRow = dt.NewRow();
            dt.Rows.Add(newRow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                string columnName = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name;
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt.Columns.Contains(columnName))
                {
                    dt.Columns.Remove(columnName);
                }
            }
        }

        private void dltData_Click(object sender, EventArgs e)
        {
            if (db_Lbox.SelectedItem == null) return;

            string selectedDb = db_Lbox.SelectedItem.ToString();
            if (MessageBox.Show($"'{selectedDb}' veritabanını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand($"DROP DATABASE `{selectedDb}`;", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veritabanı silindi.");
                LoadDatabase();
            }
        }

        private void dltTable_Click(object sender, EventArgs e)
        {
            if (tb_Lbox.SelectedItem == null || db_Lbox.SelectedItem == null) return;

            string selectedDb = db_Lbox.SelectedItem.ToString();
            string selectedTable = tb_Lbox.SelectedItem.ToString();

            string connStr = $"Server=localhost;Database={selectedDb};Uid=root;Pwd=1221;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"DROP TABLE `{selectedTable}`;", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tablo silindi.");
                LoadTables(selectedDb);
            }
        }
    }
}

