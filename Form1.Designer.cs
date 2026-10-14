using System.Drawing;
using System.Windows.Forms;

namespace Gul
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            lblGulNovu = new Label();
            textBox1 = new TextBox();
            lblSay = new Label();
            txtSay = new TextBox();
            lblQiymet = new Label();
            txtQiymet = new TextBox();
            btnSatisEt = new Button();
            lblToplamText = new Label();
            lblToplamGelir = new Label();
            btnCixis = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 220);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblGulNovu);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblSay);
            groupBox1.Controls.Add(txtSay);
            groupBox1.Controls.Add(lblQiymet);
            groupBox1.Controls.Add(txtQiymet);
            groupBox1.Controls.Add(btnSatisEt);
            groupBox1.Font = new Font("Arial", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(20, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 210);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gül məlumatları";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblGulNovu
            // 
            lblGulNovu.AutoSize = true;
            lblGulNovu.Location = new Point(15, 44);
            lblGulNovu.Name = "lblGulNovu";
            lblGulNovu.Size = new Size(94, 22);
            lblGulNovu.TabIndex = 0;
            lblGulNovu.Text = "Gül növü";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Arial", 10F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(15, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 1;
            // 
            // lblSay
            // 
            lblSay.AutoSize = true;
            lblSay.Location = new Point(15, 117);
            lblSay.Name = "lblSay";
            lblSay.Size = new Size(45, 22);
            lblSay.TabIndex = 2;
            lblSay.Text = "Say";
            lblSay.Click += lblSay_Click;
            // 
            // txtSay
            // 
            txtSay.BackColor = Color.White;
            txtSay.Font = new Font("Arial", 10F);
            txtSay.ForeColor = Color.Black;
            txtSay.Location = new Point(15, 147);
            txtSay.Name = "txtSay";
            txtSay.Size = new Size(80, 27);
            txtSay.TabIndex = 3;
            // 
            // lblQiymet
            // 
            lblQiymet.AutoSize = true;
            lblQiymet.Location = new Point(115, 117);
            lblQiymet.Name = "lblQiymet";
            lblQiymet.Size = new Size(75, 22);
            lblQiymet.TabIndex = 4;
            lblQiymet.Text = "Qiymət";
            // 
            // txtQiymet
            // 
            txtQiymet.BackColor = Color.White;
            txtQiymet.Font = new Font("Arial", 10F);
            txtQiymet.ForeColor = Color.Black;
            txtQiymet.Location = new Point(115, 147);
            txtQiymet.Name = "txtQiymet";
            txtQiymet.Size = new Size(80, 27);
            txtQiymet.TabIndex = 5;
            // 
            // btnSatisEt
            // 
            btnSatisEt.BackColor = Color.Maroon;
            btnSatisEt.ForeColor = Color.White;
            btnSatisEt.Location = new Point(230, 136);
            btnSatisEt.Name = "btnSatisEt";
            btnSatisEt.Size = new Size(120, 45);
            btnSatisEt.TabIndex = 6;
            btnSatisEt.Text = "Satış et";
            btnSatisEt.UseVisualStyleBackColor = false;
            btnSatisEt.Click += btnSatisEt_Click;
            // 
            // lblToplamText
            // 
            lblToplamText.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblToplamText.ForeColor = Color.White;
            lblToplamText.Location = new Point(406, 252);
            lblToplamText.Name = "lblToplamText";
            lblToplamText.Size = new Size(130, 30);
            lblToplamText.TabIndex = 2;
            lblToplamText.Text = "Toplam gəlir:";
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblToplamGelir.ForeColor = Color.White;
            lblToplamGelir.Location = new Point(551, 252);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(150, 30);
            lblToplamGelir.TabIndex = 3;
            lblToplamGelir.Text = "0.00";
            lblToplamGelir.Click += lblToplamGelir_Click;
            // 
            // btnCixis
            // 
            btnCixis.BackColor = Color.SaddleBrown;
            btnCixis.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCixis.ForeColor = Color.White;
            btnCixis.Location = new Point(618, 420);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(120, 40);
            btnCixis.TabIndex = 4;
            btnCixis.Text = "Çıxış";
            btnCixis.UseVisualStyleBackColor = false;
            btnCixis.Click += btnCixis_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(427, 285);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            BackColor = Color.SlateBlue;
            ClientSize = new Size(760, 480);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(lblToplamText);
            Controls.Add(lblToplamGelir);
            Controls.Add(btnCixis);
            Name = "Form1";
            Text = "Gül Satışı";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGulNovu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSay;
        private System.Windows.Forms.TextBox txtSay;
        private System.Windows.Forms.Label lblQiymet;
        private System.Windows.Forms.TextBox txtQiymet;
        private System.Windows.Forms.Button btnSatisEt;
        private System.Windows.Forms.Label lblToplamText;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Button btnCixis;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}