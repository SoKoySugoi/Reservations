namespace Reservations
{
    partial class frmReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtNumberOfNights = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtReservationName = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(43, 233);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(75, 23);
            this.btnEstimate.TabIndex = 2;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(143, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Location = new System.Drawing.Point(56, 58);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(65, 13);
            this.lblArrivalDate.TabIndex = 2;
            this.lblArrivalDate.Tag = "Arrival date";
            this.lblArrivalDate.Text = "Arrival Date:";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(35, 92);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(83, 13);
            this.lblDepartureDate.TabIndex = 3;
            this.lblDepartureDate.Tag = "Departure date";
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.AutoSize = true;
            this.lblNumberOfNights.Location = new System.Drawing.Point(26, 126);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(92, 13);
            this.lblNumberOfNights.TabIndex = 4;
            this.lblNumberOfNights.Tag = "Number of nights";
            this.lblNumberOfNights.Text = "Number of Nights:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(57, 160);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 13);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Tag = "Total Price";
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Location = new System.Drawing.Point(12, 194);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(106, 13);
            this.lblAvgPrice.TabIndex = 6;
            this.lblAvgPrice.Tag = "Average price per night";
            this.lblAvgPrice.Text = "Avg. Price Per Night:";
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(143, 55);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(100, 20);
            this.txtArrivalDate.TabIndex = 0;
            this.txtArrivalDate.Tag = "Arrival Date";
            this.txtArrivalDate.TextChanged += new System.EventHandler(this.ClearDeparture);
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(143, 89);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(100, 20);
            this.txtDepartureDate.TabIndex = 1;
            this.txtDepartureDate.Tag = "Departure Date";
            // 
            // txtNumberOfNights
            // 
            this.txtNumberOfNights.Location = new System.Drawing.Point(143, 123);
            this.txtNumberOfNights.Name = "txtNumberOfNights";
            this.txtNumberOfNights.ReadOnly = true;
            this.txtNumberOfNights.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfNights.TabIndex = 9;
            this.txtNumberOfNights.TabStop = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(143, 157);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 10;
            this.txtTotalPrice.TabStop = false;
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(143, 191);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.ReadOnly = true;
            this.txtAvgPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAvgPrice.TabIndex = 11;
            this.txtAvgPrice.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Reservation Name:";
            // 
            // txtReservationName
            // 
            this.txtReservationName.Location = new System.Drawing.Point(143, 21);
            this.txtReservationName.Name = "txtReservationName";
            this.txtReservationName.Size = new System.Drawing.Size(100, 20);
            this.txtReservationName.TabIndex = 13;
            this.txtReservationName.Tag = "Reservation Name";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(258, 87);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 14;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // frmReservation
            // 
            this.AcceptButton = this.btnEstimate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(357, 276);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.txtReservationName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAvgPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtNumberOfNights);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.lblAvgPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblNumberOfNights);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEstimate);
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtNumberOfNights;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtAvgPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtReservationName;
        private System.Windows.Forms.Button btnReserve;
    }
}

