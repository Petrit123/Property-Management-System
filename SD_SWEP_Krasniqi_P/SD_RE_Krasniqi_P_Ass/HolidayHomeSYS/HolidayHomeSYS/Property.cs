using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HolidayHomeSYS
{
    class Property
    {
        private int Prop_No;
        private int No_beds;
        private string type;
        private string street;
        private string town;
        private string county;
        private string status;
        private decimal rent;
        private string garden;
        private string garage;
        private DateTime arrivalDate;
        private DateTime departureDate;
        private int tenantID;
        private string surname;
        private string forename;
        private int phoneNumber;
        private int cardNumber;
        private int bookingID;
        private int paymentID;
        private double amount;


        public Property()
        {
            Prop_No = 0;
            No_beds = 0;
            street = "";
            town = "";
            county = "";
            status = "";
            rent = 0;
            //arrivalDate = "";
            //departureDate = "";
            tenantID = 0;
            surname = "";
            forename = "";
            phoneNumber = 0;
            cardNumber = 0;
            bookingID = 0;
            paymentID = 0;
            amount = 0;

        }

        public void setProp_No(int Prop_No)
        {
            this.Prop_No = Prop_No;
        }
        public void setNo_beds(int No_beds)
        {
            this.No_beds = No_beds;
        }
        public void setType(String type)
        {
            this.type = type;
        }
        public void setStreet(string street)
        {
            this.street = street;
        }
        public void setTown(string town)
        {
            this.town = town;
        }
        public void setCounty(string county)
        {
            this.county = county;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public void setRent(decimal rent)
        {
            this.rent = rent;
        }
        public void setGarden(string garden)
        {
            this.garden = garden;
        }

        public void setGarage(string garage)
        {
            this.garage = garage;
        }

        public void setArrivalDate(DateTime arrivalDate)
        {
            this.arrivalDate = arrivalDate;
        }

        public void setDepartureDate(DateTime departureDate)
        {
            this.departureDate = departureDate;
        }

        public void setTenantID(int tenantID)
        {
            this.tenantID = tenantID;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setForename(string forename)
        {
            this.forename = forename;
        }

        public void setPhonenumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void setCardNumber(int cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public void setBookingID(int bookingID)
        {
            this.bookingID = bookingID;
        }

        public void setPaymentId(int paymentID)
        {
            this.paymentID = paymentID;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public int getProp_No()
        {
            return Prop_No;
        }

        public int getNo_Beds()
        {
            return No_beds;
        }

        public string getType()
        {
            return type;
        }

        public string getStreet()
        {
            return street;
        }

        public string getTown()
        {
            return town;
        }

        public string getCounty()
        {
            return county;
        }
        public string getStatus()
        {
            return status;
        }

        public decimal getRent()
        {
            return rent;
        }

        public string getGarden()
        {
            return garden;
        }

        public string getGarage()
        {
            return garage;
        }

        public DateTime getArrivalDate()
        {
            return arrivalDate;
        }

        public int PaymentID()
        {
            return paymentID;
        }

        internal void recordPayment(int v1, string text1, string text2, string v2)
        {
            throw new NotImplementedException();
        }

        public DateTime getDepartureDate()
        {
            return departureDate;
        }

        public int getTenantID()
        {
            return tenantID;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getForename()
        {
            return forename;
        }

        public int getPhoneNumber()
        {
            return phoneNumber;
        }

        public int getCardNumber()
        {
            return cardNumber;
        }

        public int getBookingID()
        {
            return bookingID;
        }

        public double getAmount()
        {
            return amount;
        }

      

        public static DataSet getProperty(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL = "SELECT Prop_No, No_beds, Garage, Garden,Status, Rent FROM Properties ORDER BY Prop_No";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet searchProperty(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL = "SELECT *FROM Properties where status = 'A' ORDER BY Prop_No";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet revenueAnalysis(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL = "SELECT *FROM Properties  ORDER BY Prop_No";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet searchProperty2(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL = "SELECT * FROM Properties where prop_no not in (SELECT distinct prop_no from bookings)";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet searchBooking(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL =  "SELECT* FROM BOOKINGS INNER JOIN tenants on bookings.tenant_id = tenants.tenant_ID where status = 'B'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet matchingProperty(DataSet DS,  string type, string county, DateTime dateFrom, DateTime dateTo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL = "SELECT * FROM Properties p WHERE status = 'A' AND p.Prop_Type = '" + type + "'  AND p.County = '" + county + "'  AND p.prop_no NOT IN (SELECT DISTINCT prop_no FROM bookings bk where (bk.DATEFROM BETWEEN '" + String.Format("{0:dd-MMM-yy}", dateFrom) + "'AND '" + String.Format("{0:dd-MMM-yy}", dateTo) + "') OR (bk.DATETO BETWEEN '" + String.Format("{0:dd-MMM-yy}", dateFrom) + "'AND '" + String.Format("{0:dd-MMM-yy}", dateTo) + "') OR (bk.DATEFROM < '" + String.Format("{0:dd-MMM-yy}", dateFrom) + "' AND bk.DATETO > '" + String.Format("{0:dd-MMM-yy}", dateTo) + "')) ORDER BY Prop_No";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }




        public void getProperty(int Pno)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Properties WHERE Prop_No = " + Pno;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                setProp_No(dr.GetInt16(0));
                setNo_beds(dr.GetInt32(1));
                setGarage(dr.GetString(8));
                setGarden(dr.GetString(9));
                setStatus(dr.GetString(6));
                setRent(dr.GetDecimal(7));
            }
            conn.Close();
        }

      

        public void getBooking(int BookingID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Bookings WHERE Booking_ID = " + BookingID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                setBookingID(dr.GetInt16(0));
                setTenantID(dr.GetInt16(1));
                setProp_No(dr.GetInt16(2));
                setStatus(dr.GetString(3));
                setArrivalDate(dr.GetDateTime(4));
                setDepartureDate(dr.GetDateTime(5));
                setRent(dr.GetDecimal(6));
            }
            conn.Close();
        }

        public void issueInvoice(int BookingID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT prop_no, surname, forename, dateFrom, dateTo, amount FROM Tenants INNER JOIN Bookings on Tenants.tenant_ID =  bookings.tenant_id where booking_id = " + BookingID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //setBookingID(dr.GetInt32(0));
                setProp_No(dr.GetInt32(0));
                setSurname(dr.GetString(1));
                setForename(dr.GetString(2));
                setArrivalDate(dr.GetDateTime(3));
                setDepartureDate(dr.GetDateTime(4));
                setRent(dr.GetDecimal(5));
            }
            conn.Close();
        }


        public void updProperty()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Properties SET No_beds = " + this.No_beds.ToString() + ", Garage = '" + this.garage.ToUpper() + "', Garden = '" + this.garden.ToUpper() + "', Status = '" + this.status.ToUpper() + "', Rent = " + this.rent + " WHERE Prop_No = " + this.Prop_No;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updProperty(int Pno)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Properties SET No_beds = " + this.No_beds.ToString() + ", Garage = '" + this.garage.ToUpper() + "', Garden = '" + this.garden.ToUpper() + "', Status = '" + this.status.ToUpper() + "', Rent = " + this.rent + " WHERE Prop_No = " + Pno;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void checkIn()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Bookings SET Status = '" + this.status.ToUpper() + "' WHERE Booking_ID = " + this.bookingID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void checkOut()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Bookings SET Status = '" + this.status.ToUpper() + "' WHERE Booking_ID = " + this.bookingID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updPropertyStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Properties SET Status = '" + this.status.ToUpper() + "' WHERE Prop_No = " + this.Prop_No;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void cancelBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "DELETE FROM Bookings where status = 'B' AND Booking_ID = " + this.bookingID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updPropertyStatus(int Pno)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Properties SET Status = '" + this.status.ToUpper() + "' WHERE Prop_No = " + Pno;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }





        public static int nextProp_No()
        {
            int nextProp_No;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Prop_No) FROM Properties";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextProp_No = 1;
            else
                nextProp_No = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return nextProp_No;
        }

        public static int nextTenant_Id()
        {
            int nextTenant_Id;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Tenant_ID) FROM Tenants";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextTenant_Id = 1;
            else
                nextTenant_Id = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return nextTenant_Id;

        }

        public static int nextPayment_Id()
        {
            int nextPay_Id;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Payment_ID) FROM Payments";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextPay_Id = 1;
            else
                nextPay_Id = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return nextPay_Id;

        }

        public static int nextBookingID()
        {
            int nextBooking_Id;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Booking_ID) FROM Bookings";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextBooking_Id = 1;
            else
                nextBooking_Id = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return nextBooking_Id;

        }

        public void regProperty()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "INSERT INTO Properties VALUES(" +
                 this.Prop_No +
                 "," + this.No_beds.ToString() + ",'" + this.type.ToUpper() +
                 "','" +
                 this.street.ToUpper() + "','" + this.town.ToUpper() + "','" + this.county.ToUpper() + "','" + this.status.ToUpper() + "'," + this.rent + ",'" + this.garage.ToUpper() + "','" + this.garden.ToUpper() + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public void recordPayment()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "INSERT INTO Payments VALUES(" + this.paymentID + "," + this.tenantID + ",'" + String.Format("{0:dd-MMM-yy}", this.arrivalDate) + "'," + this.rent + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

 
        public void regTenant()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "Insert INTO Tenants VALUES(" +
                this.tenantID + ",'" + this.surname.ToUpper() + "', '" + this.forename.ToUpper() + "'," + this.phoneNumber + "," + this.cardNumber + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public void insertBooking()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "Insert INTO Bookings Values(" +
                this.bookingID + "," + this.tenantID + "," + this.Prop_No + ",'" + this.status.ToUpper() + "','" + String.Format("{0:dd-MMM-yy}", this.arrivalDate) + "','" + String.Format("{0:dd-MMM-yy}", departureDate) + "'," + this.amount + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        internal string getNo_Beds(int v)
        {
            throw new NotImplementedException();
        }

        internal string getRent(decimal v)
        {
            throw new NotImplementedException();
        }

        public static DataSet getMonthlyData(DataSet DS, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(DateFrom,'MM'), SUM(Amount) FROM Bookings WHERE DateFrom LIKE '%" + Year + "' GROUP BY TO_CHAR(DateFrom, 'MM') " +
                            "ORDER BY TO_CHAR(DateFrom, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getPropertyData(DataSet DS, String Year, int pNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(DateFrom,'MM'), SUM(Amount) FROM Bookings WHERE prop_No = " + pNo + " AND DateFrom LIKE '%" + Year + "' GROUP BY TO_CHAR(DateFrom, 'MM') " +
                            "ORDER BY TO_CHAR(DateFrom, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getCheckIns(DataSet DS, String Date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM BOOKINGS INNER JOIN tenants on bookings.tenant_id = tenants.tenant_ID WHERE status = 'B' AND DateFrom = DATE '" + Date + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getCheckOuts(DataSet DS, String Date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM BOOKINGS INNER JOIN tenants on bookings.tenant_id = tenants.tenant_ID WHERE status = 'C-IN'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getInvoice(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM BOOKINGS INNER JOIN tenants on bookings.tenant_id = tenants.tenant_ID WHERE status = 'C-OUT'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getInvoice(DataSet DS, String ArrtDate)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM BOOKINGS INNER JOIN tenants on bookings.tenant_id = tenants.tenant_ID WHERE status = 'C-OUT' AND DateFrom = '" + ArrtDate + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static double getPropRate(int pNo)
        {
            double totalCost;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT rent from Properties where prop_no = " + pNo;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            totalCost = Convert.ToDouble(dr.GetValue(0));

            myConn.Close();

            return totalCost;

        }

       

        public static DataSet getProp(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Properties where prop_no not in (SELECT distinct prop_no from bookings)";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getDeRegProps(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Properties where prop_no not in (SELECT distinct prop_no from bookings) AND Status = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }
    }
}
