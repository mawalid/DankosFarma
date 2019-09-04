using System.Collections.Generic;
using System.Data.Entity;

namespace Dankos.Model
{
    class Initializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { KodeCustomer = "W123", NamaCustomer = "Walid", Alamat = "Sidoarjo", NPWP = "1234567890" });
            customer.Add(new Customer { KodeCustomer = "X123", NamaCustomer = "Irfan", Alamat = "Jakarta", NPWP = "1234567891" });
            customer.Add(new Customer { KodeCustomer = "Y123", NamaCustomer = "Harsan", Alamat = "Klaten", NPWP = "1234567892" });
            customer.Add(new Customer { KodeCustomer = "Z123", NamaCustomer = "Latifa", Alamat = "Jogja", NPWP = "1234567893" });
            base.Seed(context);
            foreach (var item in customer)
            {
                context.Customer.Add(item);
            }

            List<Barang> barang = new List<Barang>();
            barang.Add(new Barang { KodeBarang = "A123", NamaBarang = "Konidin", Satuan = "Tablet", Stok = 10, Harga = 2000 });
            barang.Add(new Barang { KodeBarang = "B123", NamaBarang = "Panadol", Satuan = "Pil", Stok = 20, Harga = 3000 });
            barang.Add(new Barang { KodeBarang = "C123", NamaBarang = "Vitamin", Satuan = "Sirup", Stok = 30, Harga = 4000 });
            barang.Add(new Barang { KodeBarang = "D123", NamaBarang = "Actifed", Satuan = "Bubuk", Stok = 40, Harga = 5000 });
            base.Seed(context);
            foreach (var item in barang)
            {
                context.Barang.Add(item);
            }
        }
    }
}