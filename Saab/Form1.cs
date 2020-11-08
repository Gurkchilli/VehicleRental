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


            //Some pre-made values are given when the Form is Loaded, we calculate these first
            foreach (DataGridViewRow row in registerReturnDataGridView.Rows)
            {
                //In order to ignore empty rows
                if (row.Cells["BookingNumber"].Value != null)
                {
                    int bookingNumber = (int)row.Cells["BookingNumber"].Value;
                    int returnDistance = (int)row.Cells["CurrentDistance"].Value;

                    DateTime dateReturn = 
                        DateConcat((DateTime)row.Cells["Date"].Value, 
                                   DateTime.ParseExact(row.Cells["Time"].Value.ToString(),
                                   "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));

                    row.Cells["TotalCost"].Value = bookingNumber;

                    if (bookingNumber.Equals("Småbil"))
                    {
                        row.Cells["TotalCost"].Value = SmallCar(bookingNumber, dateReturn);
                    }
                    else if (bookingNumber.Equals("Van"))
                    {
                        row.Cells["TotalCost"].Value = Van(bookingNumber, dateReturn);
                    }
                    else if (bookingNumber.Equals("Minibuss"))
                    {
                        row.Cells["TotalCost"].Value = Minibuss(bookingNumber, dateReturn);
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

        private float SmallCar(int bookingNumber, DateTime datetime)
        {

            return 0;
        }

        //Also needs distance
        private float Van(int bookingNumber, DateTime datetime)
        {

            return 0;
        }

        //Also needs distance
        private float Minibuss(int bookingNumber, DateTime datetime)
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
