using System;
using System.Windows.Forms;
using GenericValidation;

namespace Reservations
{
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private Reservation guest = null;

        //This method sends user data through validation methods and receives boolean expressions based on their return values
        //Then if it receives false values it will display a message box that provides meaningful instructions for each validation step.
        public bool IsValidData()
        {
            return Validator.IsPresent(txtReservationName)&&
                
                Validator.IsPresent(txtArrivalDate) &&
                Validator.IsPresent(txtDepartureDate) &&
                
                Validator.IsDateTime(txtArrivalDate) &&
                Validator.IsShortDateTimeWithinRange
                (txtArrivalDate, DateTime.Today, DateTime.Today.AddDays(30)) &&

                Validator.IsDateTime(txtDepartureDate) &&
                Validator.IsShortDateTimeWithinRange
                (txtDepartureDate, DateTime.Parse(txtArrivalDate.Text), 
                DateTime.Parse(txtArrivalDate.Text).AddDays(14));
        }

        public Reservation MakeReservation()
        {
            this.ShowDialog();
            return guest;
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            ReservationInfo();

            if (guest != null)
            {
                txtAvgPrice.Text = guest.AveragePrice.ToString("c");             //Displays the Average Price
                txtTotalPrice.Text = guest.Price.ToString("c");                  //Displays the Total Price
                txtNumberOfNights.Text = guest.Stay.TotalDays.ToString();        //Displays the value of the stay variable
                txtArrivalDate.Focus();                                          //In the NumberOfNights Text Box     
            }
        }

        //This Method displays an initial arrival and departure date based on the user systems current DateTime
        private void frmReservations_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime departure = currentDate.AddDays(3);

            txtArrivalDate.Text = currentDate.ToShortDateString();
            txtDepartureDate.Text = departure.ToShortDateString();
        }

        //Clears all text boxes when the user alters the initial arrival date
        //For a more seamless price comparing experience
        private void ClearDeparture(object sender, EventArgs e)
        {
            txtDepartureDate.Text = "";
            txtNumberOfNights.Text = "";
            txtTotalPrice.Text = "";
            txtAvgPrice.Text = "";
        }

        private void ReservationInfo()
        {
            try
            {
                if (IsValidData())                                                  //If the user input is valid
                {
                    guest = new Reservation(
                        Convert.ToDateTime(txtArrivalDate.Text),
                        Convert.ToDateTime(txtDepartureDate.Text),
                        txtReservationName.Text);              
                }
            }
            catch (Exception ex)                                                    //Catches additional exceptions and displays
            {                                                                       //The Stack Trace for debug purposes
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            ReservationInfo();
            this.Close();
        }
    }
}