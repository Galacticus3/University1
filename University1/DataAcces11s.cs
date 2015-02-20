using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace University1
{
    class DataAcces11s
    {
       // Form1 mainForm = (Form1)Application.OpenForms[0];
      /*  
        SqlConnection sql_con;
        SqlCommand sql_cmd;
        SqlDataAdapter adapterDB;
        DataSet DS;
        
        string exeptionString;
        public string SqlAnswerString { get; set; }


        
        /// <summary>
        /// set the connection
        /// </summary>
        void SetConnection()
        {
            string conn_str = @"Data Source=CHCLASS12\SQLEXPRESS;Initial Catalog=University1;User ID=sa;Password=SQL2012";
            sql_con = new SqlConnection(conn_str);
        }


        /// <summary>
        /// generic function to execute Create Command queries
        /// </summary>
        /// <param name="txtQuery">Query text</param>
        bool ExecuteQuery(string txtQuery)
        {
            
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            try
            {
                sql_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                exeptionString = ex.ToString();
                sql_con.Close();
                return false;
            }

            sql_con.Close();
            return true;
        }
        

        /// <summary>
        /// function to access the database and retrieve the data from the Groups table and fill the Dataset
        /// </summary>
        public DataTable LoadAllGroups()
        {
            DataTable groupsDT = new DataTable();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT * FROM Groups";
            adapterDB = new SqlDataAdapter(CommandText, sql_con);
            DS = new DataSet();
            DS.Reset();
            adapterDB.Fill(DS);
            groupsDT = DS.Tables[0];
            sql_con.Close();

            return groupsDT;

        }

        public DataTable LoadAllSubjects()
        {
            DataTable subjectsDT = new DataTable();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT * FROM Subjects";
            adapterDB = new SqlDataAdapter(CommandText, sql_con);
            DS = new DataSet();
            DS.Reset();
            adapterDB.Fill(DS);
            subjectsDT = DS.Tables[0];
            sql_con.Close();

            return subjectsDT;
        }

        public DataTable LoadAllStudents()
        {
            DataTable studentsDT = new DataTable();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = @"SELECT Students.id, Students.FirstName, Students.LastName, Students.Age, Groups.Name
                                    FROM Students
                                    LEFT OUTER JOIN Groups
                                    ON Students.GroupId = Groups.Id;";
            adapterDB = new SqlDataAdapter(CommandText, sql_con);
            DS = new DataSet();
            DS.Reset();
            adapterDB.Fill(DS);
            studentsDT = DS.Tables[0];
            sql_con.Close();

            return studentsDT;
        }

        public DataTable LoadAllGroupSubject()
        {
            DataTable groupsubjDT = new DataTable();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = @"SELECT GroupsSubjects.Id, Groups.Name, Subjects.Name
                                    FROM GroupsSubjects
                                    LEFT OUTER JOIN Groups
                                    ON GroupsSubjects.GroupId = Groups.Id
                                    LEFT OUTER JOIN Subjects
                                    ON GroupsSubjects.SubjectId = Subjects.Id;";
            adapterDB = new SqlDataAdapter(CommandText, sql_con);
            DS = new DataSet();
            DS.Reset();
            adapterDB.Fill(DS);
            groupsubjDT = DS.Tables[0];
            sql_con.Close();

            return groupsubjDT;
        }

        //Fun with Groups
        
        public void AddNewGroup(string groupname)
        {

            string txtSQLQuery = @"INSERT 
                                   INTO Groups (NAME) 
                                   VALUES ('" + groupname + "') ";
            if ( ExecuteQuery(txtSQLQuery) )
            {
                SqlAnswerString = "Add Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void UpdateCurrentGroup(string groupid, string groupname)
        {
            string txtSQLQuery = @"UPDATE Groups 
                                   SET NAME = '" + groupname + @"' 
                                   WHERE ID = '" + groupid + "' ";
            if (ExecuteQuery(txtSQLQuery))
            {
                SqlAnswerString = "Update Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void DeleteCurrentGroup(string rowIdInTable)
        {
            string txtSQLQuery = @"DELETE 
                                   FROM Groups
                                   WHERE ID=" + rowIdInTable + "";
            if ( ExecuteQuery(txtSQLQuery) )
            {
                SqlAnswerString = "Delete Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }

        }


        //Fun with Subjects

        public void AddNewSubject(string subjectname)
        {
            string txtSQLQuery = @"INSERT 
                                   INTO Subjects (NAME)
                                   VALUES ('" + subjectname + "') ";
            if ( ExecuteQuery(txtSQLQuery) )
            {
                SqlAnswerString = "Add Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void UpdateCurrentSubject(string subjid, string subjname)
        {
            string txtSQLQuery = @"UPDATE Subjects 
                                   SET NAME = '" + subjname + @"' 
                                   WHERE ID = '" + subjid + "' ";
            if ( ExecuteQuery(txtSQLQuery) )
            {
                SqlAnswerString = "Update Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void DeleteCurrentSubject(string rowIdInTable)
        {
            string txtSQLQuery = @"DELETE 
                                   FROM Subjects
                                   WHERE ID='" + rowIdInTable + "'";
            if ( ExecuteQuery(txtSQLQuery) )
            {
                SqlAnswerString = "Delete Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        //Fun with Students

        public void AddNewStudent(string fname, string lname, string age, string grId)
        {
            //string txtSQLQuery = String.Format(@"INSERT INTO Students (FirstName, LastName, Age, GroupId) VALUES ('{0}','{1}','{2}',{3}", fname, lname, age, grId);

            string txtSQLQuery = @"INSERT INTO Students (FirstName, LastName, Age, GroupId) VALUES ('" + fname +"','"+ lname +"','" + age +"','" + grId +"')";

            if (ExecuteQuery(txtSQLQuery))
            {
                SqlAnswerString = "Add Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void UpdateCurrentStudent(string stId, string stName, string stSurname, string stAge, string stGrId) 
        {
            string txtSQLQuery = @"UPDATE Students SET FirstName = '" + stName + "', LastName = '" + stSurname + "', Age = '" + stAge + "', GroupId = '" + stGrId + "' WHERE ID = '" + stId + "' ";
            if ( ExecuteQuery(txtSQLQuery) )
            {
                SqlAnswerString = "Update Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void DeleteCurrentStudent(string rowIdInTable)
        {
            string txtSQLQuery = @"DELETE 
                                   FROM Students
                                   WHERE ID='" + rowIdInTable + "'";
            if ( ExecuteQuery(txtSQLQuery) )
            {
                SqlAnswerString = "Delete Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }



        // Fun wit connections of Groups and Subjects 

        public void AddNewGroupSubj(string grId, string sbjId)
        {
            string txtSQLQuery = @"INSERT INTO GroupsSubjects (GroupId, SubjectId) VALUES ('" + grId + "','"+ sbjId +"')";

            if (ExecuteQuery(txtSQLQuery))
            {
                SqlAnswerString = "Add Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void UpdateCurrentGroupSubj(string grsbjId, string grId, string sbjId)
        {
            string txtSQLQuery = @"UPDATE Students SET GroupId = '" + grId + "', SubjectId = '" + sbjId + "' WHERE ID = '" + grsbjId + "' ";

            if (ExecuteQuery(txtSQLQuery))
            {
                SqlAnswerString = "Update Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }

        public void DeleteCurrentGroupSubj(string rowIdInTable)
        {
            string txtSQLQuery = @"DELETE 
                                   FROM GroupsSubjects
                                   WHERE ID='" + rowIdInTable + "'";
            if (ExecuteQuery(txtSQLQuery))
            {
                SqlAnswerString = "Delete Ok!";
            }
            else
            {
                SqlAnswerString = exeptionString;
            }
        }*/

    }
}
