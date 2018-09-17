using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayHomeSYS
{
    class Bookings
    {
        private int Prop_No;
        private int Tenant_Id;
        private int Booking_Id;
        private string Booking_Status;
        private DateTime dateFrom;
        private DateTime dateTo;
        private double amount;
        private string surname;
        private string forename;

        public Bookings()
        {
            Prop_No = 0;
            Tenant_Id = 0;
            Booking_Id = 0;
            Booking_Status = "";
            amount = 0;
            surname = "";
            forename = "";
        }

        public void setProp_No(int prop_no)
        {
            this.Prop_No = prop_no;
        }

        public void setTenant_Id(int tenant_Id)
        {
            this.Tenant_Id = tenant_Id;
        }

        public void setBooking_Id(int booking_Id)
        {
            this.Booking_Id = booking_Id;
        }

        public void setBooking_Status(string BookingStatus)
        {
            this.Booking_Status = BookingStatus;
        }

        public void setDateFrom(DateTime dateFrom)
        {
            this.dateFrom = dateFrom;
        }

        public void setDateTo(DateTime dateTo)
        {
            this.dateTo = dateTo;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setForename(string forename)
        {
            this.forename = forename;
        }

       

        public int getProp_No()
        {
            return Prop_No;
        }

        public int getTenant_Id()
        {
            return Tenant_Id;
        }

        public int getBooking_Id()
        {
            return Booking_Id;
        }

        public string getBookingStatus()
        {
            return Booking_Status;
        }

        public DateTime getDateFrom()
        {
            return dateFrom;
        }

        public DateTime getDateTo()
        {
            return dateTo;
        }

        public double getAmount()
        {
            return amount;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getForename()
        {
            return forename;
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

       

        public void insertBooking()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "Insert INTO Bookings Values(" +
                this.Booking_Id + "," + this.Tenant_Id + "," + this.Prop_No + ",'" + this.Booking_Status.ToUpper() + "','" + String.Format("{0:dd-MMM-yy}", this.dateFrom) + "','" + String.Format("{0:dd-MMM-yy}", dateTo) + "'," + this.amount + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

       

        public static DataSet searchBooking(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL = "SELECT* FROM BOOKINGS INNER JOIN tenants on bookings.tenant_id = tenants.tenant_ID where status = 'B'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
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
                setBooking_Id(dr.GetInt16(0));
                setTenant_Id(dr.GetInt16(1));
                setProp_No(dr.GetInt16(2));
                setBooking_Status(dr.GetString(3));
                setDateFrom(dr.GetDateTime(4));
                setDateTo(dr.GetDateTime(5));
                setAmount(dr.GetDouble(6));
            }
            conn.Close();
        }

        public void cancelBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "DELETE FROM Bookings where status = 'B' AND Booking_ID = " + this.Booking_Id;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
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

        public void checkIn()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Bookings SET Status = '" + this.Booking_Status.ToUpper() + "' WHERE Booking_ID = " + this.Booking_Id;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
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

        public void checkOut()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Bookings SET Status = '" + this.Booking_Status.ToUpper() + "' WHERE Booking_ID = " + this.Booking_Id;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

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
                setDateFrom(dr.GetDateTime(3));
                setDateTo(dr.GetDateTime(4));
                setAmount(dr.GetDouble(5));
            }
            conn.Close();
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

    }
}
