using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class frmGuestList : Form
    {
        public frmGuestList()
        {
            InitializeComponent();
        }

        private GuestList reservations = new GuestList();

        private void frmDisplayForm_Load(object sender, EventArgs e)
        {            
            reservations.Changed += new GuestList.ChangedHandler(HandledChange);
            reservations.Fill();
            FillGuestListBox();
        }

        private void HandledChange(GuestList guests)
        {
            guests.Save();
            FillGuestListBox();
        }

        private void FillGuestListBox()
        {
            lstGuestList.Items.Clear();

            foreach(Reservation guest in reservations)
            { lstGuestList.Items.Add(guest.GetDisplayText()); }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            frmReservation newGuestForm = new frmReservation();
            Reservation guest = newGuestForm.MakeReservation();

            if (guest != null)
            { reservations += guest; }
        }

        private void lstGuestList_MouseDoubleClick(object sender, MouseEventArgs e)
        { GetDetails(); }

        private void btnDetails_Click(object sender, EventArgs e)
        { GetDetails(); }

        private void GetDetails()
        {
            int i = lstGuestList.SelectedIndex;
            Reservation guest = reservations[i];

            MessageBox.Show($"{guest.ReservationName}: " +
                $"{guest.ArrivalDate.ToString("d")} - {guest.DepartureDate.ToString("d")}\n" +
                $"{guest.Stay.TotalDays} days at ({guest.Price.ToString("c")})\n" +
                $"Average Price/Day {guest.AveragePrice.ToString("c")}",
                "Reservation Details");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstGuestList.SelectedIndex;

            Reservation guest = reservations[i];
            reservations -= guest;
        }

        private void btnExit_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
