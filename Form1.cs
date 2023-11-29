using DbContextEdition.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            SetStatus(false);
        }

        public void reload()
        {
            dgv.Rows.Clear();
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
            }
            //dgv.DataSource = _dbContext.GetAllByDataTable();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetStatus(true);
            /*RefreshForm();*/
            action = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                SetStatus(true);
                this.currentId = (int)dgv.SelectedRows[0].Cells[0].Value;
                var currentNv = _dbContext.GetAll().Find(x => x.Id == currentId);
                SetDataForm(currentNv);
                action = 2;
            }
            else MessageBox.Show("Not matching or something else");
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                
                var currentId = (int)dgv.SelectedRows[0].Cells[0].Value;
                _dbContext.delete(currentId);
                reload();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RefreshForm();
            SetStatus(false);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(action == 1)//add
            {
                var newNv = GetDataForm();
                try
                {
                    _dbContext.addNew(newNv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                RefreshForm();
                
            }
            if(action == 2)//edit
            {
                var newNv = GetDataForm();
                try
                {
                    _dbContext.update(newNv, this.currentId);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                RefreshForm();

            }
            if(action == 3)
            {
                MessageBox.Show("Current no search feature");
            }
            SetStatus(false);
            reload();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SetStatus(true);
            RefreshForm();
            action = 3;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private bool IsValidData(Xemay nv)
        {
            if (_dbContext.GetAll().Any(x => x.Id == nv.Id))
            {
                MessageBox.Show("Id already exists!");
                return false;
            }
            
            return true;
        }

        private void SetStatus(bool status)
        {
            gDetails.Enabled = status;
        }
        private void RefreshForm()
        {
            txtId.Text = "";
            txtSokhung.Text = "";
            txtSomay.Text = "";
            txtMamau.Text = "";
            cbxDungtich.Text = string.Empty;
            txtHangxe.Text = "";
            txtTenxe.Text = "";
            imgBox.Image = null;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (.png; *.jpg; *.jpeg; *.gif; *.bmp)|.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(this.imagePath);
                imgBox.Image = image;
            }

        }

        private Xemay GetDataForm()//add
        {
            int id;
            bool isValidId = int.TryParse(txtId.Text, out id);
            int dtxl;
            bool isValidDtxl = int.TryParse(cbxDungtich.SelectedItem.ToString(), out dtxl);
            return new Xemay()
            {
                Id = (isValidId) ? id : 0,
                Sokhung = txtSokhung.Text,
                Somay = txtSomay.Text,
                Mamau = int.Parse(txtHangxe.Text),
                Dungtichxilanh = cbxDungtich.SelectedItem.ToString(),
                Hangxe = txtSomay.Text,
                Tenxe = txtTenxe.Text,
                Anh = this.imagePath,
            };
        }

        private void SetDataForm(Xemay nv)//edit,delete
        {
            string path = dgv.SelectedRows[0].Cells[7].Value.ToString();
            if (path != null) { Image image = Image.FromFile(path); imgBox.Image = image; }
            else { imgBox.Image = null; }
            txtId.Text = nv.Id.ToString();
            txtSokhung.Text = nv.Sokhung;
            txtSomay.Text = nv.Somay;
            txtMamau.Text = nv.Mamau.ToString();
            cbxDungtich.SelectedItem = nv.Dungtichxilanh;
            txtHangxe.Text = nv.Hangxe.ToString();
            txtTenxe.Text = nv.Tenxe.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
