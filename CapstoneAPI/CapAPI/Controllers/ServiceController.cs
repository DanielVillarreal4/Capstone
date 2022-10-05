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
    public class ServiceController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ServiceController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @" 
                             select ServiceID, ServiceName,  ServiceDescription from
                             dbo.ServiceTable";
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
        public JsonResult Post(Service service)
        {
            string query = @" 
                             insert into dbo.ServiceTable
                             values (@ServiceName, @ServiceDescription)";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@ServiceName", service.ServiceName);
                    myCommand.Parameters.AddWithValue("@ServiceDescription", service.ServiceDescription);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(Ok());
        }
        [HttpPut]
        public JsonResult Put(Service service)
        {
            string query = @" 
                             update dbo.ServiceTable
                             set ServiceName = @ServiceName, ServiceDescription = @ServiceDescription
                             where ServiceID = @ServiceID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@ServiceName", service.ServiceName);
                    myCommand.Parameters.AddWithValue("@ServiceDescription", service.ServiceDescription);
                    myCommand.Parameters.AddWithValue("@ServiceID", service.ServiceID);

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
                             delete from dbo.ServiceTable
                              where ServiceID = @ServiceID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@ServiceID", id);
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
