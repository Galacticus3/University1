using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataAccess
    {
        private string configConnection;
        public string SqlAnswerString { get; set; }

        public DataAccess(string st)
        {
            configConnection = st;
        }

        /// <summary>
        /// function to access the database and retrieve the data from the Groups table
        /// </summary>
        /// <returns>Groups table</returns>
        public DataTable LoadAllGroups()
        {
            DataTable groupsDT = new DataTable();
            string txtQuery = "SELECT * FROM Groups";
            using (SqlConnection connection = new SqlConnection(configConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(txtQuery, connection);
                groupsDT.Load(command.ExecuteReader());
                connection.Close();
            }
            return groupsDT;
        }

        /// <summary>
        /// function to access the database and retrieve the data from the Subjects table
        /// </summary>
        /// <returns>Subjects table</returns>
        public DataTable LoadAllSubjects()
        {
            DataTable subjectsDT = new DataTable();
            string txtQuery = "SELECT * FROM Subjects";
            using (SqlConnection connection = new SqlConnection(configConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(txtQuery, connection);
                subjectsDT.Load(command.ExecuteReader());
                connection.Close();
            }
            return subjectsDT;
        }

        /// <summary>
        /// function to access the database and retrieve the data from the Students table
        /// </summary>
        /// <returns>Students table</returns>
        public DataTable LoadAllStudents()
        {
            DataTable studentsDT = new DataTable();
            string txtQuery = @"SELECT Students.id, Students.FirstName, Students.LastName, Students.Age, Groups.Name
                                FROM Students
                                LEFT OUTER JOIN Groups
                                ON Students.GroupId = Groups.Id;";
            using (SqlConnection connection = new SqlConnection(configConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(txtQuery, connection);
                studentsDT.Load(command.ExecuteReader());
                connection.Close();
            }

            return studentsDT;
        }

        /// <summary>
        /// function to access the database and retrieve the data from the GroupsSubjects table
        /// </summary>
        /// <returns>GroupsSubjects table</returns>
        public DataTable LoadAllGroupSubject()
        {
            DataTable groupsubjDT = new DataTable();
            string txtQuery = @"SELECT GroupsSubjects.Id, Groups.Name, Subjects.Name
                                FROM GroupsSubjects
                                INNER JOIN Groups
                                ON GroupsSubjects.GroupId = Groups.Id
                                INNER JOIN Subjects
                                ON GroupsSubjects.SubjectId = Subjects.Id";
            using (SqlConnection connection = new SqlConnection(configConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(txtQuery, connection);
                groupsubjDT.Load(command.ExecuteReader());
                connection.Close();
            }
            return groupsubjDT;
        }

        public DataTable LoadAllSubjectsInGroup(int grId)
        {
            DataTable dt = new DataTable();
            string txtQuery = @"SELECT GroupsSubjects.Id, Groups.Name, Subjects.Name
                                FROM GroupsSubjects
                                INNER JOIN Groups
                                ON GroupsSubjects.GroupId = Groups.Id
                                INNER JOIN Subjects
                                ON GroupsSubjects.SubjectId = Subjects.Id
                                WHERE Groups.Id = @grId";
            using (SqlConnection connection = new SqlConnection(configConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(txtQuery, connection);
                command.Parameters.Add("@grId", SqlDbType.Int).Value = grId;
                command.ExecuteNonQuery();
                dt.Load(command.ExecuteReader());
                connection.Close();
            }
            return dt;
        }

        public DataTable LoadGroupsWithCurrSubject(int sbjId)
        {
            DataTable dt = new DataTable();
            string txtQuery = @"SELECT GroupsSubjects.Id, Groups.Name, Subjects.Name
                                FROM GroupsSubjects
                                INNER JOIN Groups
                                ON GroupsSubjects.GroupId = Groups.Id
                                INNER JOIN Subjects
                                ON GroupsSubjects.SubjectId = Subjects.Id
                                WHERE Subjects.Id = @sbjId";
            using (SqlConnection connection = new SqlConnection(configConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(txtQuery, connection);
                command.Parameters.Add("@sbjId", SqlDbType.Int).Value = sbjId;
                command.ExecuteNonQuery();
                dt.Load(command.ExecuteReader());
                connection.Close();
            }
            return dt;
        }


        //Fun with Groups   

        /// <summary>
        /// SQL query wich add new group
        /// </summary>
        /// <param name="groupname">new group name</param>
        public void AddNewGroup(string groupname)
        {
            SqlAnswerString = "Add Ok!";
            string txtSQLQuery = @"INSERT 
                                   INTO Groups (Name) 
                                   VALUES (@grName) ";
            try 
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@grName", SqlDbType.NVarChar).Value = groupname;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }

        /// <summary>
        /// SQL query wich update current group
        /// </summary>
        /// <param name="groupid">Id of group name wich will update</param>
        /// <param name="groupname">new group name</param>
        public void UpdateCurrentGroup(int groupid, string groupname)
        {
            SqlAnswerString = "Update Ok!";
            string txtSQLQuery = @"UPDATE Groups 
                                   SET NAME = @grName 
                                   WHERE ID = @grId ";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@grId", SqlDbType.Int).Value = groupid;
                    command.Parameters.Add("@grName", SqlDbType.NVarChar).Value = groupname;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupid"></param>
        public void DeleteCurrentGroup(int groupid)
        {
            SqlAnswerString = "Delete Ok!";
            string txtSQLQuery = @"DELETE 
                                   FROM Groups
                                   WHERE ID = @grId";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@grId", SqlDbType.Int).Value = groupid;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }


        //Fun with Subjects

        public void AddNewSubject(string subjectname)
        {
            SqlAnswerString = "Add Ok!";
            string txtSQLQuery = @"INSERT 
                                   INTO Subjects (NAME)
                                   VALUES (@sbjName) ";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@sbjName", SqlDbType.NVarChar).Value = subjectname;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }

        public void UpdateCurrentSubject(int subjectid, string subjectname)
        {
            SqlAnswerString = "Update Ok!";
            string txtSQLQuery = @"UPDATE Subjects 
                                   SET NAME = @sbjName
                                   WHERE ID = @sbjId";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@sbjId", SqlDbType.Int).Value = subjectid;
                    command.Parameters.Add("@sbjName", SqlDbType.NVarChar).Value = subjectname;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }

        public void DeleteCurrentSubject(int subjectid)
        {
            SqlAnswerString = "Delete Ok!";
            string txtSQLQuery = @"DELETE 
                                   FROM Subjects
                                   WHERE ID = @sbjId";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@sbjId", SqlDbType.Int).Value = subjectid;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }


        //Fun with Students

        public void AddNewStudent(string fname, string lname, int age, int grId)
        {
            SqlAnswerString = "Add Ok!";
            string txtSQLQuery = @"INSERT 
                                   INTO Students (FirstName, LastName, Age, GroupId) 
                                   VALUES (@stFName, @stLName, @stAge, @grId)";

            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@stFName", SqlDbType.NVarChar).Value = fname;
                    command.Parameters.Add("@stLNAME", SqlDbType.NVarChar).Value = lname;
                    command.Parameters.Add("@stAge", SqlDbType.Int).Value = age;
                    command.Parameters.Add("@grId", SqlDbType.Int).Value = grId;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }

        public void UpdateCurrentStudent(int stId, string fname, string lname, int age, int grId)
        {
            SqlAnswerString = "Update Ok!";
            string txtSQLQuery = @"UPDATE 
                                   Students SET FirstName = @stFName, LastName = @stLName, Age = @stAge, GroupId = @grId 
                                   WHERE ID = @stId";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@stId", SqlDbType.Int).Value = stId;
                    command.Parameters.Add("@stFName", SqlDbType.NVarChar).Value = fname;
                    command.Parameters.Add("@stLNAME", SqlDbType.NVarChar).Value = lname;
                    command.Parameters.Add("@stAge", SqlDbType.Int).Value = age;
                    command.Parameters.Add("@grId", SqlDbType.Int).Value = grId;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }

        public void DeleteCurrentStudent(int stId)
        {
            SqlAnswerString = "Delete Ok!";
            string txtSQLQuery = @"DELETE 
                                   FROM Students
                                   WHERE ID= @stId";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@stId", SqlDbType.Int).Value = stId;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }


        // Fun wit connections of Groups and Subjects 

        public void AddNewGroupSubj(int grId, int sbjId)
        {
            SqlAnswerString = "Add Ok!";
            string txtSQLQuery = @"INSERT 
                                   INTO GroupsSubjects (GroupId, SubjectId) 
                                   VALUES (@grId, @sbjId)";

            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@grId", SqlDbType.Int).Value = grId;
                    command.Parameters.Add("@sbjId", SqlDbType.Int).Value = sbjId;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }

        public void DeleteCurrentGroupSubj(int grsbjId)
        {
            SqlAnswerString = "Delete Ok!";
            string txtSQLQuery = @"DELETE 
                                   FROM GroupsSubjects
                                   WHERE ID= @grsbjId";
            try
            {
                using (SqlConnection connection = new SqlConnection(configConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(txtSQLQuery, connection);
                    command.Parameters.Add("@grsbjId", SqlDbType.Int).Value = grsbjId;
                    command.ExecuteNonQuery();
                }
            } 
            catch (SqlException ex)
            {
                SqlAnswerString = ex.ToString();
            }
        }




    }
}
