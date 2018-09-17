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


        public Property()
        {
            Prop_No = 0;
            No_beds = 0;
            street = "";
            town = "";
            county = "";
            status = "";
            rent = 0;

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

       

        

        public int getNo_Beds()
        {
            return No_beds;
        }

        public string getType()
        {
            return type;
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
            String strSQL = "SELECT * FROM Properties where prop_no not in (SELECT distinct prop_no from bookings " + 
                                                                            "WHERE dateFrom >'" + String.Format("{0:dd-MMM-yy}", DateTime.Now) + "')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet searchPropertyAvail(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            String strSQL = "SELECT * FROM Properties  WHERE Status = 'A'";
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

      

      


        public void updProperty()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Properties SET No_beds = " + this.No_beds.ToString() + ", Garage = '" + this.garage.ToUpper() + "', Garden = '" + this.garden.ToUpper() + "', Status = '" + this.status.ToUpper() + "', Rent = " + this.rent + " WHERE Prop_No = " + this.Prop_No;

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

        public static void propertyCheckInOut(int Prop_No, string prop_status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Properties SET Status = '" + prop_status + "' WHERE Prop_No = " + Prop_No;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
