using ClosedXML.Excel;
using DbContextEdition.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DbContextEdition
{
    public partial class Form1 : Form
    {
        NvContext _dbContext;
        private int action = 0;
        private int currentId = 0;
        private string imagePath;
        public Form1()
        {
            InitializeComponent();
            _dbContext = new NvContext();
            SetStatusDetail(false);
            SetStatusButton(true);
        }

        public void reload()
        {
            /*dgv.Rows.Clear();
            var lstNv = _dbContext.GetAll();
            foreach (var nv in lstNv)
            {
                dgv.Rows.Add(new object[]
                {
                                nv.Id,
                                nv.Sokhung,
                                nv.Somay,
                                nv.Mamau,
                                nv.Dungtichxilanh,
                                nv.Hangxe,
                                nv.Tenxe,
                                nv.Anh,
                });
            }*/
            dgv.DataSource = _dbContext.GetAllByDataTable();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RefreshForm();
            SetStatusDetail(true);
            SetStatusButton(false);
            action = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                SetStatusDetail(true);
                SetStatusButton(false);
                dgv.Enabled = false;
                this.currentId = (int)dgv.SelectedRows[0].Cells[0].Value;
                var currentNv = _dbContext.GetAll().Find(x => x.Id == currentId);
                txtSokhung.Enabled = false;
                txtSomay.Enabled = false;
                SetDataForm(currentNv);
                action = 2;
            }
            else MessageBox.Show("Not matching or something else");
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                var nowId = (int)dgv.SelectedRows[0].Cells[0].Value;
                if(MessageBox.Show("Are you sure delete?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _dbContext.delete(nowId);
                }
                reload();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RefreshForm();
            SetStatusDetail(false);
            SetStatusButton(true);
            dgv.Enabled = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(action == 1)//add
            {
                var newNv = GetDataForm();
                if (!IsValidData(newNv)) { MessageBox.Show("You must enter all member"); return; }
                if (!IsFullData(newNv)) { MessageBox.Show("You must enter all member"); return; }
                try
                    {
                    if (MessageBox.Show("Are you sure add?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _dbContext.addNew(newNv);
                    }
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                
                RefreshForm();
                reload();
            }
            if(action == 2)//edit
            {
                var newNv = GetDataForm();
                if (!IsFullData(newNv)) { MessageBox.Show("You must enter all member"); return; }
                    try
                    {
                    if (MessageBox.Show("Are you sure edit?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _dbContext.update(newNv, this.currentId);
                    }
                }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                RefreshForm();
                reload() ;
            }
            
            if (action == 3)
            {
                try { 
                    /*var idFind = txtId.Text == "" ? "id" :$"{txtId.Text}";*/
                    /*var mauFind = cbxMamau.SelectedItem.ToString() == "mamau" ? "" : $"N'{cbxMamau.SelectedItem}'";
                    var hangFind = txtHangxe.Text == "hangxe" ? "" : $"N'{txtHangxe.Text}'";
                    var query = $" hangxe like {hangFind} and mamau = {mauFind}";*/
                    var query = $" mamau = '{cbxMamau.SelectedItem}' AND hangxe LIKE '{txtHangxe.Text}'";
                    var resFind = _dbContext.FindByDataTable(query);
                    dgv.DataSource = resFind;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }

            SetStatusDetail(false);
            SetStatusButton(true);
            dgv.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            RefreshForm();
            SetStatusFind(true);
            SetStatusButton(false);
            action = 3;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure exit?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private bool IsValidData(Xemay nv)
        {
            if(_dbContext.GetAll().Any(x=>x.Sokhung == nv.Sokhung))
            {
                MessageBox.Show("So khung already exists!");
                return false;
            }
            if (_dbContext.GetAll().Any(x => x.Somay == nv.Somay) )
            {
                MessageBox.Show("So may already exists!");
                return false;
            }
            return true;
        }
        private bool IsFullData(Xemay nv)
        {
            if (txtHangxe.Text == null) return false; 
            else if (cbxMamau.Text == null) return false;
            else if (txtSokhung.Text == null) return false;
            else if (txtSomay.Text == null) return false;
            else if (txtTenxe.Text == null) return false;
            else if (cbxDungtich.Text == null) return false;
            else if (imgBox.Image == null) return false;
            return true;
        }
        private bool IsValidImageFile(string filePath)
        {
            try
            {
                using (var img = Image.FromFile(filePath))
                {
                    return img.RawFormat.Guid == ImageFormat.Jpeg.Guid ||
                           img.RawFormat.Guid == ImageFormat.Png.Guid ||
                           img.RawFormat.Guid == ImageFormat.Gif.Guid ||
                           img.RawFormat.Guid == ImageFormat.Bmp.Guid;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void SetStatusDetail(bool status)
        {
            gDetails.Enabled = status;
        }
        private void SetStatusButton(bool status)
        {
            gButton.Enabled = status;
        }
        private void SetStatusFind(bool status)
        {
            SetStatusDetail(status);
            txtSokhung.Enabled = !status;
            txtSomay.Enabled = !status;
            txtTenxe.Enabled = !status;
            cbxDungtich.Enabled = !status;
        }
        private void RefreshForm()
        {
            txtId.Text = null;
            txtSokhung.Text = null;
            txtSomay.Text = null;
            txtHangxe.Text = null;
            txtTenxe.Text = null;
            imgBox.Image = null;
            cbxDungtich.SelectedIndex = 0;
            cbxMamau.SelectedIndex = 0;

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (.png; *.jpg; *.jpeg; *.gif; *.bmp)|.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imagePath = openFileDialog.FileName;
                if (IsValidImageFile(this.imagePath))
                {
                    Image image = Image.FromFile(this.imagePath);
                    imgBox.Image = image;
                }
                else { MessageBox.Show("Invalid image file"); }
            }
        }

        private Xemay GetDataForm()//add
        {
            int id;
            bool isValidId = int.TryParse(txtId.Text, out id);
            return new Xemay()
            {
                Id = (isValidId) ? id : 0,
                Sokhung = txtSokhung.Text,
                Somay = txtSomay.Text,
                Mamau = int.Parse(cbxMamau.SelectedItem.ToString()),
                Dungtichxilanh = int.Parse(cbxDungtich.SelectedItem.ToString()),
                Hangxe = txtHangxe.Text,
                Tenxe = txtTenxe.Text,
                Anh = this.imagePath,
            };
        }

        private void SetDataForm(Xemay nv)//edit,delete
        {
            string path = dgv.SelectedRows[0].Cells[7].Value.ToString();
            if (path != null) { 
                if(IsValidImageFile(path)) { 
                    Image image = Image.FromFile(path); imgBox.Image = image;
                }
                else { imgBox.Image = null; }
            }
            else { imgBox.Image = null; }
            txtId.Text = nv.Id.ToString();
            txtSokhung.Text = nv.Sokhung;
            txtSomay.Text = nv.Somay;
            cbxMamau.SelectedItem = nv.Mamau.ToString();
            cbxDungtich.SelectedItem = nv.Dungtichxilanh.ToString();
            txtHangxe.Text = nv.Hangxe.ToString();
            txtTenxe.Text = nv.Tenxe.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlXeMayDataSet.tXemay' table. You can move, or remove it, as needed.
            this.tXemayTableAdapter.Fill(this.qlXeMayDataSet.tXemay);


        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                /*var Id1 = (int)dgv.SelectedRows[0].Cells[0].Value;
                var currentNv =_dbContext.GetAll().Find(x => x.Id == Id1);
                SetDataForm(currentNv);*/
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sFDialog = new SaveFileDialog();
                sFDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sFDialog.Title = "Save an Excel File";
                sFDialog.ShowDialog();
                // Tạo một Workbook mới
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Data");

                // Điền dữ liệu từ DataGridView vào worksheet
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 1, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Lưu workbook vào một file Excel
                workbook.SaveAs(sFDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
