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
    public class AppointmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AppointmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @" 
                             select AppointmentID, DateCreated, ClientID, EmployeeID, StreetAddress, 
                             City, State, ZipCode, StartTime, EndTime, Cancel, Description from
                             dbo.AppointmentTable";
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
        public JsonResult Post(Appointment appointment)
        {
            string query = @" 
                             insert into dbo.AppointmentTable
                             values (@DateCreated, @ClientID, @EmployeeID, @StreetAddress, @City, @State, 
                                     @ZipCode, @StartTime, @EndTime, @Cancel, @Description)";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@DateCreated", appointment.DateCreated);
                    myCommand.Parameters.AddWithValue("@ClientID", appointment.ClientID);
                    myCommand.Parameters.AddWithValue("@EmployeeID", appointment.EmployeeID);
                    myCommand.Parameters.AddWithValue("@StreetAddress", appointment.StreetAddress);
                    myCommand.Parameters.AddWithValue("@City", appointment.City);
                    myCommand.Parameters.AddWithValue("@State", appointment.State);
                    myCommand.Parameters.AddWithValue("@ZipCode", appointment.ZipCode);
                    myCommand.Parameters.AddWithValue("@StartTime", appointment.StartTime);
                    myCommand.Parameters.AddWithValue("@EndTime", appointment.EndTime);
                    myCommand.Parameters.AddWithValue("@Cancel", appointment.Cancel);
                    myCommand.Parameters.AddWithValue("@Description", appointment.Description);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(Ok());
        }


        //NO UPDATE, CLIENT MUST CANCEL APPOINTMENT AND CREATE A NEW APPOINTMENT INSTEAD


        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @" 
                             delete from dbo.AppointmentTable
                              where AppointmentID = @AppointmentID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@AppointmentID", id);
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
