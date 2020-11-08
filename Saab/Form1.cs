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

        private float dailyPrice = 150;
        private float kmPrice = 10;

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
            // TODO: This line of code loads data into the 'vehicleDatabaseDataSetCost.RegisterReturn' table. You can move, or remove it, as needed.
            this.registerReturnTableAdapter1.Fill(this.vehicleDatabaseDataSetCost.RegisterReturn);
            // TODO: This line of code loads data into the 'vehicleDatabaseDataSet1.RegisterReturn' table. You can move, or remove it, as needed.
            this.registerReturnTableAdapter.Fill(this.vehicleDatabaseDataSet1.RegisterReturn);
            // TODO: This line of code loads data into the 'vehicleDatabaseDataSet1.RegisterRental' table. You can move, or remove it, as needed.
            this.registerRentalTableAdapter.Fill(this.vehicleDatabaseDataSet1.RegisterRental);


            //The TotalCost column is ReadOnly, which is indicated by making the background color gray.
            this.registerReturnDataGridView.Columns["TotalCost"].DefaultCellStyle.BackColor = Color.LightGray;

            //We iterate through both rentData and registerdata to match the booking numbers.
            var rentData = registerRentalDataGridView.Rows;
            var returnData = registerReturnDataGridView.Rows;

            //The last row is always empty
            for (int i = 0; i < returnData.Count - 1; i++)
            {
                for (int j = 0; j < rentData.Count - 1; j++)
                {
                    if ((int)rentData[j].Cells["RentBookingNumber"].Value == (int)returnData[i].Cells["BookingNumber"].Value)
                    {
                        DataGridViewRow rentRow = rentData[j];
                        DataGridViewRow returnRow = returnData[i];

                        if (rentData[j].Cells["RegisterVehicleCategory"].Value.Equals("Småbil"))
                        {
                            returnData[i].Cells["TotalCost"].Value = SmallCar(rentRow, returnRow);
                        }
                        else if (rentData[j].Cells["RegisterVehicleCategory"].Value.Equals("Van"))
                        {
                            returnData[i].Cells["TotalCost"].Value = Van(rentRow, returnRow);
                        }
                        else if (rentData[j].Cells["RegisterVehicleCategory"].Value.Equals("Minibuss"))
                        {
                            returnData[i].Cells["TotalCost"].Value = Minibuss(rentRow, returnRow);
                        }


                        returnData[i].Cells["TotalCost"].Value = 10000;
                        break;
                    }
                }
            }
        }

        //Converts date and time to a single DateTime variable
        private DateTime DateConcat(DateTime date, DateTime time)
        {
            return new DateTime(date.Year, date.Month, date.Day,
                                time.Hour, time.Minute, time.Second);
        }

        private float SmallCar(DataGridViewRow rentRow, DataGridViewRow returnRow)
        {
            int rentDistance = (int)rentRow.Cells["RentCurrentDistance"].Value;
            int returnDistance = (int)returnRow.Cells["CurrentDistance"].Value;

            DateTime dateRent =
                DateConcat((DateTime)rentRow.Cells["Date"].Value,
                           DateTime.ParseExact(rentRow.Cells["Time"].Value.ToString(),
                           "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
            DateTime dateReturn =
                DateConcat((DateTime)returnRow.Cells["Date"].Value,
                           DateTime.ParseExact(returnRow.Cells["Time"].Value.ToString(),
                           "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));

            return 0;
        }

        //Also needs distance
        private float Van(DataGridViewRow rentRow, DataGridViewRow returnRow)
        {

            return 0;
        }

        //Also needs distance
        private float Minibuss(DataGridViewRow rentRow, DataGridViewRow returnRow)
        {

            return 0;
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
