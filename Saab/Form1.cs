using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerRentalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registerRentalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vehicleDatabaseDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehicleDatabaseDataSet1.RegisterReturn' table. You can move, or remove it, as needed.
            this.registerReturnTableAdapter.Fill(this.vehicleDatabaseDataSet1.RegisterReturn);
            // TODO: This line of code loads data into the 'vehicleDatabaseDataSet1.RegisterRental' table. You can move, or remove it, as needed.
            this.registerRentalTableAdapter.Fill(this.vehicleDatabaseDataSet1.RegisterRental);
        }

        private void registerRentalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registerReturnDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
