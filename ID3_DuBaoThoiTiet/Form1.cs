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
                    var dataDA = MyAttribute.GetDifferentAttributeNamesOfColumn(MainHandler.Data, 1);
                    var dataMay = MyAttribute.GetDifferentAttributeNamesOfColumn(MainHandler.Data, 2);
                    foreach (var item in dataND)
                    {
                        cmbND.Items.Add(item);
                    }
                    foreach (var item in dataDA)
                    {
                        cmbDA.Items.Add(item);
                    }
                    foreach (var item in dataMay)
                    {
                        cmbMay.Items.Add(item);
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
            var nd = cmbND.SelectedItem.ToString();
            valuesForQuery.Add(MainHandler.Data.Columns[0].ToString(), nd);
            var da = cmbDA.SelectedItem.ToString();
            valuesForQuery.Add(MainHandler.Data.Columns[1].ToString(), da);
            var may = cmbMay.SelectedItem.ToString();
            valuesForQuery.Add(MainHandler.Data.Columns[2].ToString(), may);
            var description = Tree.CalculateResult(Tree.Root, valuesForQuery, "");
            if (MainHandler.Result == "Nang".ToUpper())
            {
                lbThoiTiet.Text = "Nắng";
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\Sunny-icon.png");
            }
                
            else if (MainHandler.Result == "Mua".ToUpper())
            {
                lbThoiTiet.Text = "Mưa";
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\rain-icon.jfif");
            }
            else if (MainHandler.Result == "Mat me".ToUpper())
            {
                lbThoiTiet.Text = "Mát mẻ";
                pictureBox1.Image = Image.FromFile(@"D:\DoAN\ID3_DuBaoThoiTiet\DATN_DuBaoThoiTiet\ID3_DuBaoThoiTiet\Images\cool.png");
            }
            else
                lbThoiTiet.Text = "Không có kết quả";

            richTextBox1.Text = description;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
