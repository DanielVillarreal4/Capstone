using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using ccsystems.Models;

namespace ccsystems.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ClientController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @" 
                             select ClientID, FName, MName, LName, Email, 
                             ClientPhoneNumber, Password, AccessID from
                             dbo.ClientTable";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetByEmail(string Email, string Password, string ReturnURL)
        //{
        //    string query = @" 
        //                     select Email, Password from
        //                     dbo.ClientTable";
        //    DataTable table = new DataTable();
        //    string sqlDataSource = _configuration.GetConnectionString("AppCon");
        //    SqlDataReader myReader;
        //    using (SqlConnection myCon = new SqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //        {
        //            myReader = myCommand.ExecuteReader();
        //            table.Load(myReader);
        //            myReader.Close();
        //            myCon.Close();
        //        }
        //    }
        //    //var testEmail = table.Columns.ToString().Contains(Email);
        //    //var testPassWord = table.Columns.ToString().Contains(Password);
        //    //if (testEmail && testPassWord)
        //        return Redirect(ReturnURL);
        //    //else
        //    //    return Redirect("/login");
        //}

        [HttpPost]
        public JsonResult Post(Client client)
        {
            string query = @" 
                             insert into dbo.ClientTable
                             values (@FName, @MName, @LName, @Email, 
                             @ClientPhoneNumber, @Password, @AccessID)";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@FName", client.FName);
                    myCommand.Parameters.AddWithValue("@MName", client.MName);
                    myCommand.Parameters.AddWithValue("@LName", client.LName);
                    myCommand.Parameters.AddWithValue("@Email", client.Email);
                    myCommand.Parameters.AddWithValue("@ClientPhoneNumber", client.ClientPhoneNumber);
                    myCommand.Parameters.AddWithValue("@Password", client.Password);
                    myCommand.Parameters.AddWithValue("@AccessID", 3);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(Ok());
        }
        [HttpPut]
        public JsonResult Put(Client client)
        {
            string query = @" 
                             update dbo.ClientTable
                             set  FName = @FName, MName = @MName, LName = @LName,
                                  Email = @Email, ClientPhoneNumber= @ClientPhoneNumber, 
                                  Password=@Password,AccessID=@AccessID
                              where ClientID = @ClientID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@ClientID", client.ClientID);
                    myCommand.Parameters.AddWithValue("@FName", client.FName);
                    myCommand.Parameters.AddWithValue("@MName", client.MName);
                    myCommand.Parameters.AddWithValue("@LName", client.LName);
                    myCommand.Parameters.AddWithValue("@Email", client.Email);
                    myCommand.Parameters.AddWithValue("@ClientPhoneNumber", client.ClientPhoneNumber);
                    myCommand.Parameters.AddWithValue("@Password", client.Password);
                    myCommand.Parameters.AddWithValue("@AccessID", client.AccessID);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(Ok());
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @" 
                             delete from dbo.ClientTable
                              where ClientID = @ClientID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@ClientID", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(Ok());
        }
    }
}
