using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ComprasEntities db = new ComprasEntities())
            {
                /*Cliente nuevoCliente = new Cliente();
                nuevoCliente.IdCliente = Convert.ToInt32(11);
                nuevoCliente.Nombre = "Abelina Lesper";
                nuevoCliente.Direccion = "Roma #1050";
                db.Cliente.Add(nuevoCliente);
                db.SaveChanges();*/

                var clientes = db.Cliente.OrderBy(dato => dato.Nombre);
                Lista.DataSource = clientes.ToList();

                /*var clientes2 =(from dato in db.Cliente
                                join 
                                from
                                where
                                select new
                                {
                                    TimeLeft= dato.StartTime*69*60*24-db.
                                }).Cliente.OrderBy(dato => dato.TimeLeft);*/






            }

            using (ComprasEntities db2 = new ComprasEntities())
            {
                var lentes = from dato in db2.Lente
                             where (dato.Material == "Pasta" && dato.Precio < 3000)
                             orderby dato.Marca
                             select dato;

                Lista2.DataSource = lentes.ToList();

            }
        }
    }
}
