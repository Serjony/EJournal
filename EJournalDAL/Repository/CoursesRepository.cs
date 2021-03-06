using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using EJournalDAL.Models.BaseModels;
using System.Configuration;
using System.Reflection;

namespace EJournalDAL.Repository
{
    public class CoursesRepository : ICoursesRepository
    {
        private string _connectionString;

        public CoursesRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EJournalDB"].ConnectionString;
        }

        public CourseDTO AddCourse(CourseDTO courseDTO)
        {
            string command = $"[EJournal].[{MethodBase.GetCurrentMethod().Name}] @Name";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                courseDTO.Id = db.Query<int>(command, new { courseDTO.Name }).FirstOrDefault();
            }

            return courseDTO;
        }

        public void DeleteCourse(int Id)
        {
            string command = $"[EJournal].[{MethodBase.GetCurrentMethod().Name}] @Id";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(command, new { Id });
            }
        }

        public List<CourseDTO> GetAllCourses()
        {
            string command = $"[EJournal].[{MethodBase.GetCurrentMethod().Name}]";
            List<CourseDTO> courseDTO = new List<CourseDTO>();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                courseDTO = db.Query<CourseDTO>(command).ToList();
            }

            return courseDTO;
        }

        public CourseDTO GetCourse(int id)
        {
            string command = $"[EJournal].[{MethodBase.GetCurrentMethod().Name}] @Id";
            CourseDTO courseDTO = null;
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                courseDTO = db.Query<CourseDTO>(command, new { id }).FirstOrDefault();
            }

            return courseDTO;
        }

        public void UpdateCourse(CourseDTO courseDTO)
        {
            string command = $"[EJournal].[{MethodBase.GetCurrentMethod().Name}] @Id, @Name";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(command, new { courseDTO.Id, courseDTO.Name });
            }
        }

        public int GetCountGroupsByCourse(int Id)
        {
            int count = 0;
            string command = $"[EJournal].[{MethodBase.GetCurrentMethod().Name}] @Id";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                count = db.Query<int>(command, new { Id }).FirstOrDefault();
            }

            return count;
        }
    }
}
