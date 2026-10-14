using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gul
{
    public partial class Form1 : Form
    {
        double toplamGelir = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("GulNovu", "Gül növü (gül adı)");
            dataGridView1.Columns.Add("SatisSayi", "Satış sayı");
            dataGridView1.Columns.Add("Qiymeti", "Qiyməti");
            dataGridView1.Columns.Add("YekunQiymeti", "Yekun qiyməti");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnSatisEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(txtSay.Text) || string.IsNullOrWhiteSpace(txtQiymet.Text))
            {
                MessageBox.Show("Məlumatları tam daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSay.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır say olmaz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtQiymet.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır qiymət olmaz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result = count * price;

            dataGridView1.Rows.Add(textBox1.Text, count.ToString(), price.ToString(), result.ToString("F2"));

            toplamGelir += result;
            lblToplamGelir.Text = toplamGelir.ToString("F2");

            textBox1.Clear();
            txtSay.Clear();
            txtQiymet.Clear();
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSay_Click(object sender, EventArgs e)
        {

        }

        private void lblToplamGelir_Click(object sender, EventArgs e)
        {

        }
    }
}