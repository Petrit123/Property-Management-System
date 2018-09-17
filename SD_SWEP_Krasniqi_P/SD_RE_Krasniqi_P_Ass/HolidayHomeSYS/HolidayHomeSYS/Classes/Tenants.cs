using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayHomeSYS
{
    class Tenants
    {
        private int tenant_id;
        private string surname;
        private string forename;
        private int cardNumber;
        private int phoneNumber;

        public Tenants()
        {
            tenant_id = 0;
            surname = "";
            forename = "";
            cardNumber = 0;
            phoneNumber = 0;
        }

        public void setTenantID(int TenantId)
        {
            this.tenant_id = TenantId;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setForename(string forename)
        {
            this.forename = forename;
        }

        public void setCardNumber(int cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public void setPhoneNumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public int getTenantId()
        {
            return tenant_id;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getForename()
        {
            return forename;
        }

        public int getCardNumber()
        {
            return cardNumber;
        }

        public int getPhoneNumber()
        {
            return phoneNumber;
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

        public void regTenant()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "Insert INTO Tenants VALUES(" +
                this.tenant_id + ",'" + this.surname.ToUpper() + "', '" + this.forename.ToUpper() + "'," + this.phoneNumber + "," + this.cardNumber + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }
    }
}
