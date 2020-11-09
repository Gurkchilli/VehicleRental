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
        }



        //Triggers when clicking the "Calculate" button.
        private void registerReturnDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Makes sure a button was actually clicked
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //Saves the unique ID
                int bookingNumberReturn = (int)registerReturnDataGridView.Rows[e.RowIndex].Cells["BookingNumber"].Value;

                //Goes through all the entries in the Rental grid.
                for (int i = 0; i < registerRentalDataGridView.Rows.Count - 1; i++)
                {
                    //Stops when the correct row index has been found
                    if ((int)registerRentalDataGridView.Rows[i].Cells["RentBookingNumber"].Value == bookingNumberReturn)
                    {
                        DataGridViewRow rentRow = registerRentalDataGridView.Rows[i];
                        DataGridViewRow returnRow = registerReturnDataGridView.Rows[e.RowIndex];

                        registerReturnDataGridView.Rows[e.RowIndex].Cells["TotalCost"].Value = CalculateCost(rentRow, returnRow);
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



        public double CalculateCost(DataGridViewRow rentRow, DataGridViewRow returnRow)
        {
            DateTime dateRent =
                DateConcat((DateTime)rentRow.Cells["RentDate"].Value,
                           DateTime.ParseExact(rentRow.Cells["RentTime"].Value.ToString(),
                           "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
            DateTime dateReturn =
                DateConcat((DateTime)returnRow.Cells["Date"].Value,
                           DateTime.ParseExact(returnRow.Cells["Time"].Value.ToString(),
                           "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));

            //If you turn the vehicle back in the same day, it counts as 1 day
            int numberOfDays = (dateReturn - dateRent).Days + 1;


            //Since the different types of vehicles get
            if (rentRow.Cells["RentVehicleCategory"].Value.ToString().Trim() == "Småbil")
            {
                return Math.Round(dailyPrice * numberOfDays);
            }

            else if (rentRow.Cells["RentVehicleCategory"].Value.ToString().Trim() == "Van")
            {
                int rentDistance = (int)rentRow.Cells["RentCurrentDistance"].Value;
                int returnDistance = (int)returnRow.Cells["CurrentDistance"].Value;

                int numberOfKm = returnDistance - rentDistance;

                return Math.Round(dailyPrice * numberOfDays * 1.2f + kmPrice * numberOfKm);
            }

            else if (rentRow.Cells["RentVehicleCategory"].Value.ToString().Trim() == "Minibuss")
            {
                int rentDistance = (int)rentRow.Cells["RentCurrentDistance"].Value;
                int returnDistance = (int)returnRow.Cells["CurrentDistance"].Value;

                int numberOfKm = returnDistance - rentDistance;

                return Math.Round(dailyPrice * numberOfDays * 1.7f + kmPrice * numberOfKm * 1.5f);
            }

            else
            {
                return 0;
            }
        }


        //Only used for unit tests, as I could not fetch or create DataGridViewRows in the test file
        public double VanCostTest(DateTime dateRent, DateTime dateReturn, int rentDistance, int returnDistance)
        {
            int numberOfDays = (dateReturn - dateRent).Days + 1;
            int numberOfKm = returnDistance - rentDistance;

            return Math.Round(dailyPrice * numberOfDays * 1.2f + kmPrice * numberOfKm);
        }

        public double MinibussCostTest(DateTime dateRent, DateTime dateReturn, int rentDistance, int returnDistance)
        {
            int numberOfDays = (dateReturn - dateRent).Days + 1;
            int numberOfKm = returnDistance - rentDistance;

            return Math.Round(dailyPrice * numberOfDays * 1.7f + kmPrice * numberOfKm * 1.5f);
        }



    }
}
