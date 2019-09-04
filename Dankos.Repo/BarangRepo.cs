using Dankos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dankos.Repo
{
    public class BarangRepo
    {
        public static List<Barang> GetAll()
        {
            List<Barang> result = new List<Barang>();
            using (var db = new DataContext())
            {
                result = db.Barang.ToList();

                return result;
            }
        }
    }
}
