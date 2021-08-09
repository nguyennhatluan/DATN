using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3_DuBaoThoiTiet
{
    public partial class Form1 : Form
    {
        bool disabled = false;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage2)
            {
                if (MainHandler.Data == null)
                {
                    MessageBox.Show("Hãy tạo cây quyết định trước khi dự đoán");
                    buttonGuess.Enabled = false;
                }
                else
                {
                    buttonGuess.Enabled = true;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogImportData = new OpenFileDialog();
            if(dialogImportData.ShowDialog() == DialogResult.OK)
            {
                if (dialogImportData.FileName != string.Empty)
                {
                    var data = FileHandler.ImportFromCsvFile(dialogImportData.FileName);
                    if(data == null)
                    {
                        MessageBox.Show("Không có dữ liệu");
                    }
                    else
                    {
                        MessageBox.Show("Đã import dữ liệu");
                        dataGridViewWeather.DataSource = data;
                        MainHandler.Data = data;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInitialTree_Click(object sender, EventArgs e)
        {
            if(MainHandler.Data != null)
            {
                Tree.Root = MainHandler.CreateTree();
                
                if(Tree.Root != null)
                {
                    MessageBox.Show("Đã tạo cây quyết định");
                    var dataND = MyAttribute.GetDifferentAttributeNamesOfColumn(MainHandler.Data, 0);
                    var NDValues = dataND.Select(int.Parse).ToList().OrderBy(p=>p);
                    var dataDA = MyAttribute.GetDifferentAttributeNamesOfColumn(MainHandler.Data, 1);
                    var DAValues = dataDA.Select(int.Parse).ToList().OrderBy(p=>p);
                    var dataMay = MyAttribute.GetDifferentAttributeNamesOfColumn(MainHandler.Data, 2);
                    var MayValues = dataMay.Select(int.Parse).ToList().OrderBy(p=>p);
                    var dataMua = MyAttribute.GetDifferentAttributeNamesOfColumn(MainHandler.Data, 3);
                    var MuaValues = dataMua.Select(float.Parse).ToList().OrderBy(p=>p);
                    foreach (var item in NDValues)
                    {
                        cmbND.Items.Add(item);
                    }
                    foreach (var item in DAValues)
                    {
                        cmbDA.Items.Add(item);
                    }
                    foreach (var item in MayValues)
                    {
                        cmbMay.Items.Add(item);
                    }
                    foreach (var item in MuaValues)
                    {
                        cmbMua.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể tạo cây");
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            var valuesForQuery = new Dictionary<string, string>();
            var nd = cmbND.SelectedItem == null ? null : cmbND.SelectedItem.ToString();
            valuesForQuery.Add(MainHandler.Data.Columns[0].ToString(), nd);
            var da = cmbDA.SelectedItem == null ? null : cmbDA.SelectedItem.ToString();
            valuesForQuery.Add(MainHandler.Data.Columns[1].ToString(), da);
            var may = cmbMay.SelectedItem == null? null : cmbMay.SelectedItem.ToString();
            valuesForQuery.Add(MainHandler.Data.Columns[2].ToString(), may);
            var mua = cmbMua.SelectedItem == null ? null : cmbMua.SelectedItem.ToString();
            valuesForQuery.Add(MainHandler.Data.Columns[3].ToString(), mua);
            var description = Tree.CalculateResult(Tree.Root, valuesForQuery, "");
            if(string.IsNullOrEmpty(nd) || string.IsNullOrEmpty(da) || string.IsNullOrEmpty(may) || string.IsNullOrEmpty(mua))
            {
                MessageBox.Show("Bạn hãy chọn đủ dữ liệu!");
            }
            if (MainHandler.Result == "sunny".ToUpper())
            {
                lbThoiTiet.Text = "Nắng";
                lbThoiTiet.Visible = true;
                richTextBox2.Text = "Dự báo: Thời tiết sẽ nắng";
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\Sunny-icon.png");
            }
                
            else if (MainHandler.Result == "Rain".ToUpper())
            {
                lbThoiTiet.Text = "Mưa";
                richTextBox2.Text = "Dự báo: Thời tiết sẽ mưa";
                lbThoiTiet.Visible = true;
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\rain-icon.jfif");
            }
            else if (MainHandler.Result == "cool".ToUpper())
            {
                lbThoiTiet.Text = "Mát mẻ";
                richTextBox2.Text = "Dự báo: Thời tiết sẽ mát mẻ";
                lbThoiTiet.Visible = true;
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\cool.png");
            }
            else if (MainHandler.Result == "partly cloudy".ToUpper())
            {
                lbThoiTiet.Text = "Mây một phần";
                richTextBox2.Text = "Dự báo: Thời tiết sẽ nắng và có mây một phần";
                lbThoiTiet.Visible = true;
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\partlycloudy01.png");
            }
            else
            {
                lbThoiTiet.Text = "Không có kết quả";
                richTextBox2.Text = "Không có kết quả dự báo về thời tiết";
                lbThoiTiet.Visible = true;
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\notfound.png");
            }
                

            richTextBox1.Text = description;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbDA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbThoiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
