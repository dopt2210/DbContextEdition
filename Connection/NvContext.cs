using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbContextEdition.Connection
{
    public class NvContext
    {
        private DbContext _dbContext = new DbContext();
        public DataTable GetAllByDataTable() => _dbContext.GetTable("Select * from tXemay");

        public List<Xemay> GetAll()
        {
            var nvDataTable = _dbContext.GetTable("Select * from tXemay");
            var lstNv = new List<Xemay>();
            foreach (DataRow row in nvDataTable.Rows)
            {
                var nv = new Xemay()
                {
                    Id = (int)row["id"],
                    Sokhung = row["sokhung"].ToString(),
                    Somay = row["somay"].ToString(),
                    Mamau = (int)row["mamau"],
                    Dungtichxilanh = row["dungtichxilanh"].ToString(),
                    Hangxe = row["hangxe"].ToString(),
                    Tenxe = row["tenxe"].ToString(),
                    Anh = row["anh"].ToString(),

                };
                lstNv.Add(nv);
            }
            return lstNv;
        }

        public void addNew(Xemay nv)
        {
            string query = $"INSERT INTO tXemay ([sokhung],[somay],[tenxe],[mamau],[dungtichxilanh],[hangxe],[tenxe],[anh]) VALUES (N'{nv.Sokhung}', N'{nv.Somay}', N'{nv.Mamau}', N'{nv.Dungtichxilanh}', N'{nv.Hangxe}', N'{nv.Tenxe}', N'{nv.Anh}')";
            _dbContext.ExcuteQuery(query);
        }
        public void delete(int idNv)
        {
            string query = $"delete from tXemay where id= {idNv}";
            _dbContext.ExcuteQuery(query);

        }
        public void update(Xemay nv, int idNv)
        {
            string query = $"UPDATE tXemay SET [sokhung]=N'{nv.Sokhung}', [somay]=N'{nv.Somay}', [mamau]= N'{nv.Mamau}', [dungtichxilanh]=N'{nv.Dungtichxilanh}', [hangxe]=N'{nv.Hangxe}',[tenxe]='{nv.Tenxe}' [anh]=N'{nv.Anh}' WHERE id = N'{nv.Id}'";
            _dbContext.ExcuteQuery(query);

        }

    }
}
