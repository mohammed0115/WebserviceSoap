using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
namespace AmaniProject
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string cs = ConfigurationManager.ConnectionStrings["BankAccountAmaniEntities"].ConnectionString;


        public SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(cs);
            return con;
        }

        [WebMethod]
        public String InsertAccount(String AccNo, String TypeLoan, String Bank_Branch_id, String Balance)
        {
            try
            {
                SqlConnection con = this.connect();
                con.Open();
                String Query = "INSERT INTO [dbo].[account] ([AccNo],[TypeLoan] ,[Balance],[Bank_Branch_id]) values('" + AccNo + "','" + TypeLoan + "','" + Balance + "','" + Bank_Branch_id + "')";

                SqlCommand comm = new SqlCommand(Query, con);
                comm.Connection = con;
                comm.CommandText = Query;

                comm.ExecuteNonQuery();
                con.Close();
                return "successfull";



            }
            catch (SqlException e) { return e.Message; }



        }

        [WebMethod]
        public String Insertbank(String code, String Name, String Addresss)
        {
            try
            {
                SqlConnection con = this.connect();
                con.Open();
                String Query = "INSERT INTO [dbo].[bank] ([code],[Name],[Addresss]) values('" + code + "','" + Name + "','" + Addresss + "')";

                SqlCommand comm = new SqlCommand(Query, con);
                comm.Connection = con;
                comm.CommandText = Query;

                comm.ExecuteNonQuery();
                con.Close();
                return "successfull";



            }
            catch (SqlException e) { return e.Message; }


        }






        [WebMethod]
        public String Insertbank_branch(String Bank_Branch_id, String Address, String code)
        {

            try
            {
                SqlConnection con = this.connect();
                con.Open();
                String Query = "INSERT INTO [dbo].[bank_branch] ([code],[Bank_Branch_id] ,[Address]) values('" + code + "','" + Bank_Branch_id + "','" + Address + "')";

                SqlCommand comm = new SqlCommand(Query, con);
                comm.Connection = con;
                comm.CommandText = Query;

                comm.ExecuteNonQuery();
                con.Close();
                return "successfull";



            }
            catch (SqlException e) { return e.Message; }

        }



        [WebMethod]
        public String customer(String SSN,
            String Bank_Branch_id,
            String Phone, String Name,
            String Addresss)
        {



            try
            {
                SqlConnection con = this.connect();
                con.Open();
                String Query = "INSERT INTO [dbo].[customer] ([SSN],[Bank_Branch_id] ,[Name],[Addresss],[Phone]) values('" + SSN + "','" + Bank_Branch_id + "','" + Name + "','" + Addresss + "','" + Phone + "')";

                SqlCommand comm = new SqlCommand(Query, con);
                comm.Connection = con;
                comm.CommandText = Query;

                comm.ExecuteNonQuery();
                con.Close();
                return "successfull";



            }
            catch (SqlException e) { return e.Message; }
        }

        [WebMethod]
        public String loan(String LoanNo,
            String Amount,
            String type,
            String Bank_Branch_id)
        {




            try
            {
                SqlConnection con = this.connect();
                con.Open();
                String Query = "INSERT INTO [dbo].[loan] ([LoanNo],[Bank_Branch_id] ,[Amount],[type]) values('" + LoanNo + "','" + Bank_Branch_id + "','" + Amount + "','" + type + "')";

                SqlCommand comm = new SqlCommand(Query, con);
                comm.Connection = con;
                comm.CommandText = Query;

                comm.ExecuteNonQuery();
                con.Close();
                return "successfull";



            }
            catch (SqlException e) { return e.Message; }
        }

        [WebMethod]
        public String customer_Account(String AccNo, String SSN)
        {
            try
            {
                SqlConnection con = this.connect();
                con.Open();
                String Query = "INSERT INTO [dbo].[customer_Account] ([SSN],[AccNo] ) values('" + SSN + "','" + AccNo + "')";

                SqlCommand comm = new SqlCommand(Query, con);
                comm.Connection = con;
                comm.CommandText = Query;

                comm.ExecuteNonQuery();
                con.Close();
                return "successfull";



            }
            catch (SqlException e) { return e.Message; }



        }
        [WebMethod]
        public String LOAN_CUSTOMER(String LoanNo, String SSN)
        {
            try
            {
                SqlConnection con = this.connect();
                con.Open();
                String Query = "INSERT INTO [dbo].[LOAN_CUSTOMER] ([SSN],[LoanNo] ) values('" + SSN + "','" + LoanNo + "')";

                SqlCommand comm = new SqlCommand(Query, con);
                comm.Connection = con;
                comm.CommandText = Query;

                comm.ExecuteNonQuery();
                con.Close();
                return "successfull";



            }
            catch (SqlException e) { return e.Message; }
        }

    }
}
