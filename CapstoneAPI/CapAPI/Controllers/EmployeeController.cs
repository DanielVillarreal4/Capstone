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
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @" 
                             select EmployeeID, FName, MName, LName, Email, 
                             EmployeePhoneNumber, Password, AccessID from
                             dbo.EmployeeTable";
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

        [HttpPost]
        public JsonResult Post(Employee emp)
        {
            //string query = "";
            //if (emp.MName != null)
            //{
            string query = @" 
                             insert into dbo.EmployeeTable
                             values (@FName, @MName, @LName, @Email, 
                             @EmployeePhoneNumber, @Password, @AccessID)";
            //}
            //else { 
            //    query = @" 
            //                 insert into dbo.EmployeeTable
            //                 values (@FName, @LName, @Email, 
            //                 @EmployeePhoneNumber, @Password, @AccessID)"; }

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@FName", emp.FName);
                    myCommand.Parameters.AddWithValue("@MName", emp.MName);
                    myCommand.Parameters.AddWithValue("@LName", emp.LName);
                    myCommand.Parameters.AddWithValue("@Email", emp.Email);
                    myCommand.Parameters.AddWithValue("@EmployeePhoneNumber", emp.EmployeePhoneNumber);
                    myCommand.Parameters.AddWithValue("@Password", emp.Password);
                    myCommand.Parameters.AddWithValue("@AccessID", emp.AccessID);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(Ok());
        }
        [HttpPut]
        public JsonResult Put(Employee emp)
        {
            string query = @" 
                             update dbo.EmployeeTable
                             set  FName = @FName, MName = @MName, LName = @LName,
                                  Email = @Email, EmployeePhoneNumber= @EmployeePhoneNumber, 
                                  Password=@Password,AccessID=@AccessID
                              where EmployeeID = @EmployeeID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
                    myCommand.Parameters.AddWithValue("@FName", emp.FName);
                    myCommand.Parameters.AddWithValue("@MName", emp.MName);
                    myCommand.Parameters.AddWithValue("@LName", emp.LName);
                    myCommand.Parameters.AddWithValue("@Email", emp.Email);
                    myCommand.Parameters.AddWithValue("@EmployeePhoneNumber", emp.EmployeePhoneNumber);
                    myCommand.Parameters.AddWithValue("@Password", emp.Password);
                    myCommand.Parameters.AddWithValue("@AccessID", emp.AccessID);
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
                             delete from dbo.EmployeeTable
                              where EmployeeID = @EmployeeID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@EmployeeID", id);
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
