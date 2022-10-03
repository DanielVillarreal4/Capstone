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
    public class AccessLevelController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AccessLevelController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @" 
                             select AccessID, AccessLevelTitle, LevelDescription from
                             dbo.AccessLevelTable";
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
        public JsonResult Post(AccessLevel level)
        {
            string query = @" 
                             insert into dbo.AccessLevelTable
                             values (@AccessLevelTitle, @LevelDescription)";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@AccessLevelTitle", level.AccessLevelTitle);
                    myCommand.Parameters.AddWithValue("@LevelDescription", level.LevelDescription);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(Ok());
        }
        [HttpPut]
        public JsonResult Put(AccessLevel level)
        {
            string query = @" 
                             update dbo.AccessLevelTable
                             set  AccessLevelTitle = @AccessLevelTitle, LevelDescription = @LevelDescription
                             where AccessID = @AccessID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@AccessLevelTitle", level.AccessLevelTitle);
                    myCommand.Parameters.AddWithValue("@LevelDescription", level.LevelDescription);
                    myCommand.Parameters.AddWithValue("@AccessID", level.AccessID);

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
                             delete from dbo.AccessLevelTable
                              where AccessID = @AccessID";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@AccessID", id);
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
