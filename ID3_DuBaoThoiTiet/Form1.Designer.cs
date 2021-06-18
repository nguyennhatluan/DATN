
namespace ID3_DuBaoThoiTiet
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInitialTree = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewWeather = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbThoiTiet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbMay = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDA = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbND = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 693);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridViewWeather);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1127, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInitialTree);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 602);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 56);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnInitialTree
            // 
            this.btnInitialTree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitialTree.Location = new System.Drawing.Point(196, 0);
            this.btnInitialTree.Name = "btnInitialTree";
            this.btnInitialTree.Size = new System.Drawing.Size(222, 46);
            this.btnInitialTree.TabIndex = 1;
            this.btnInitialTree.Text = "Tạo cây quyết định";
            this.btnInitialTree.UseVisualStyleBackColor = true;
            this.btnInitialTree.Click += new System.EventHandler(this.btnInitialTree_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import dữ liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewWeather
            // 
            this.dataGridViewWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeather.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWeather.Name = "dataGridViewWeather";
            this.dataGridViewWeather.RowHeadersWidth = 51;
            this.dataGridViewWeather.RowTemplate.Height = 29;
            this.dataGridViewWeather.Size = new System.Drawing.Size(1118, 594);
            this.dataGridViewWeather.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1127, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonGuess);
            this.panel4.Location = new System.Drawing.Point(9, 580);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 79);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuess.Location = new System.Drawing.Point(10, 13);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(221, 42);
            this.buttonGuess.TabIndex = 0;
            this.buttonGuess.Text = "Dự đoán";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(783, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 571);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 408);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 163);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.lbThoiTiet);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 402);
            this.panel5.TabIndex = 0;
            // 
            // lbThoiTiet
            // 
            this.lbThoiTiet.AutoSize = true;
            this.lbThoiTiet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbThoiTiet.Location = new System.Drawing.Point(130, 52);
            this.lbThoiTiet.Name = "lbThoiTiet";
            this.lbThoiTiet.Size = new System.Drawing.Size(71, 30);
            this.lbThoiTiet.TabIndex = 0;
            this.lbThoiTiet.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 571);
            this.panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(10, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 275);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mô tả kết quả";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(727, 234);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox3);
            this.panel10.Location = new System.Drawing.Point(507, 143);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 136);
            this.panel10.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbMay);
            this.groupBox3.Location = new System.Drawing.Point(11, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 114);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mây";
            // 
            // cmbMay
            // 
            this.cmbMay.FormattingEnabled = true;
            this.cmbMay.Location = new System.Drawing.Point(6, 25);
            this.cmbMay.Name = "cmbMay";
            this.cmbMay.Size = new System.Drawing.Size(163, 27);
            this.cmbMay.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox2);
            this.panel9.Location = new System.Drawing.Point(251, 143);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 136);
            this.panel9.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDA);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Độ ẩm";
            // 
            // cmbDA
            // 
            this.cmbDA.FormattingEnabled = true;
            this.cmbDA.Location = new System.Drawing.Point(6, 25);
            this.cmbDA.Name = "cmbDA";
            this.cmbDA.Size = new System.Drawing.Size(159, 27);
            this.cmbDA.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Location = new System.Drawing.Point(10, 143);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 136);
            this.panel8.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbND);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhiệt độ";
            // 
            // cmbND
            // 
            this.cmbND.FormattingEnabled = true;
            this.cmbND.Location = new System.Drawing.Point(6, 25);
            this.cmbND.Name = "cmbND";
            this.cmbND.Size = new System.Drawing.Size(159, 27);
            this.cmbND.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(757, 138);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dự báo thời tiết";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 229);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 705);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewWeather;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbMay;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDA;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbND;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInitialTree;
        private System.Windows.Forms.Label lbThoiTiet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

