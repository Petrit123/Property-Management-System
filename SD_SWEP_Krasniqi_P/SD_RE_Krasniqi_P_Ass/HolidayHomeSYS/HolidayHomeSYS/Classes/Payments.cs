using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayHomeSYS.Classes
{
    class Payments
    {
        private int payment_id;
        private int tenant_id;
        private DateTime date_Paid;
        private double amount;

        public Payments()
        {
            payment_id = 0;
            tenant_id = 0;
            amount = 0;
        }

        public void setPaymentID(int paymentId)
        {
            this.payment_id = paymentId;
        }

        public void setTenantID(int tenantID)
        {
            this.tenant_id = tenantID;
        }

        public void setDatePaid(DateTime datePaid)
        {
            this.date_Paid = datePaid;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public int getPaymentID()
        {
            return payment_id;
        }

        public int getTenantID()
        {
            return tenant_id;
        }

        public DateTime getDatePaid()
        {
            return date_Paid;
        }

        public double getAmount()
        {
            return amount;
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

        public void recordPayment()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "INSERT INTO Payments VALUES(" + this.payment_id+ "," + this.tenant_id + ",'" + String.Format("{0:dd-MMM-yy}", this.date_Paid) + "'," + this.amount + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }
    }
}
