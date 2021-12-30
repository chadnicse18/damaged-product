using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
    public partial class Damaged_product_report : Form
    {
        public Damaged_product_report()
        {
            InitializeComponent();
        }

        private void Damaged_product_report_Load(object sender, EventArgs e)
        {
            this.Damaged_ProductTableAdapter.Fill(this.inventory_managementdbDataSet.Damaged_Product);
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
