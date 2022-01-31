using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca_Virtuala
{
    public class DB
    {
        private MySqlConnection conn;
        private MySqlCommand sqlQuery;
        private MySqlDataReader sqlReader;

        public MySqlConnection Conn
        {
            get { return conn; }
        }
        public MySqlCommand SqlQuery
        {
            get { return sqlQuery; }
            set { sqlQuery = value; }
        }
        public MySqlDataReader SqlReader
        {
            get { return sqlReader; }
            set { sqlReader = value; }
        }

        // -------

        private string server = "localhost";
        private string user = "root";
        private string password = "";
        private string database = "oop";
        private string port = "3306";

        private string mySqlConnectionString;
        // -------



        public bool Connect()
        {
            mySqlConnectionString = "datasource=" + server + ";port=" + port + ";username=" + user + ";password=" + password + ";database=" + database;

            try
            {
                conn = new MySqlConnection(mySqlConnectionString);
                conn.Open();
            }
            catch (MySqlException sqlE)
            {
                Console.WriteLine("[DEBUG ONLY] Conexiunea la baze de date a esuat -> " + sqlE.Message);
                return false;
            }

            return true;
        }
        public User LoginUser(string username, string password)
        {
            try
            {
                sqlQuery = new MySqlCommand("select * from users where Username='" + username + "' and Password='" + password + "' limit 1", conn);
                sqlReader = sqlQuery.ExecuteReader();

                if (sqlReader.Read())
                {
                    int id = sqlReader.GetInt32((int)DB_Data.ID);
                    int accessLevel = sqlReader.GetInt32((int)DB_Data.ACCESS_LEVEL);
                    int age = sqlReader.GetInt32((int)DB_Data.AGE);

                    string fullname = sqlReader.GetString((int)DB_Data.FULLNAME);
                    string email = sqlReader.GetString((int)DB_Data.EMAIL);
                    string pin = sqlReader.GetString((int)DB_Data.ADMIN_PIN);
                    string educationUnit = sqlReader.GetString((int)DB_Data.EDUCATION_UNIT);
                    string joined = sqlReader.GetString((int)DB_Data.JOINED);

                    sqlReader.Close();

                    sqlQuery = new MySqlCommand("update users set Connected=1 where Id='" + id + "'", conn);
                    sqlQuery.ExecuteNonQuery();

                    sqlReader.Close();

                    switch (accessLevel)
                    {
                        case 1:
                            return new User(id, username, joined, fullname, email, age);
                        case 2:
                            return new Student(id, username, joined, fullname, email, age, educationUnit);
                        case 3:
                            return new Administrator(id, username, joined, fullname, email, age, pin);
                    }
                }

                sqlReader.Close();
            }
            catch(MySqlException sqlE)
            {
                sqlReader.Close();
                Console.WriteLine(sqlE.Message);
            }

     
            return null;
        }
        public int RegisterUser(string username, string password, string email, string fullname, int age)
        {
            sqlQuery = new MySqlCommand("select * from users where username='" + username + "'", conn);
            sqlReader = sqlQuery.ExecuteReader();
            if (sqlReader.Read())
            {
                sqlReader.Close();
                return -1;
            }
            else
            {
                sqlReader.Close();
                try
                {
                    sqlQuery = new MySqlCommand("insert into users (Username,Password,Name,Email,Age) values(@Username,@Password,@Name,@Email,@Age)", conn);
                    sqlQuery.Parameters.AddWithValue("username", username);
                    sqlQuery.Parameters.AddWithValue("password", password);
                    sqlQuery.Parameters.AddWithValue("name", fullname);
                    sqlQuery.Parameters.AddWithValue("email", email);
                    sqlQuery.Parameters.AddWithValue("age", age);
                    sqlQuery.ExecuteNonQuery();

                    return 1;
                }
                catch (MySqlException sqlE)
                {
                    Console.WriteLine(sqlE.Message);
                    return 0;
                }
            }
        }
        public bool UpdateConnectedList(Main mainObject)
        {
            bool alreadyExists = false, modified = false;
            int id, accessLevel, age;
            string username, fullname, email, pin, educationUnit, joined;

            sqlQuery = new MySqlCommand("select * from users where Connected=1", conn);
            sqlReader = sqlQuery.ExecuteReader();
            while (sqlReader.Read())
            {
                alreadyExists = false;
                id = sqlReader.GetInt32((int)DB_Data.ID);

                foreach(User u in mainObject.ConnectedUsers)
                {
                    if(u.GetID == id)
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                
                if(!alreadyExists)
                {
                    modified = true;


                    id = sqlReader.GetInt32((int)DB_Data.ID);
                    accessLevel = sqlReader.GetInt32((int)DB_Data.ACCESS_LEVEL);
                    age = sqlReader.GetInt32((int)DB_Data.AGE);

                    username = sqlReader.GetString((int)DB_Data.USERNAME);
                    fullname = sqlReader.GetString((int)DB_Data.FULLNAME);
                    email = sqlReader.GetString((int)DB_Data.EMAIL);
                    pin = sqlReader.GetString((int)DB_Data.ADMIN_PIN);
                    educationUnit = sqlReader.GetString((int)DB_Data.EDUCATION_UNIT);
                    joined = sqlReader.GetString((int)DB_Data.JOINED);

                    switch (accessLevel)
                    {
                        case 1:
                            mainObject.ConnectedUsers.Add(new User(id, username, joined, fullname, email, age));
                            break;
                        case 2:
                            mainObject.ConnectedUsers.Add(new Student(id, username, joined, fullname, email, age, educationUnit));
                            break;
                        case 3:
                            mainObject.ConnectedUsers.Add(new Administrator(id, username, joined, fullname, email, age, pin));
                            break;
                    }
                }
            }
            sqlReader.Close();

            sqlQuery = new MySqlCommand("select * from users where Connected=0", conn);
            sqlReader = sqlQuery.ExecuteReader();
            while (sqlReader.Read())
            {
                id = sqlReader.GetInt32((int)DB_Data.ID);

                foreach (User u in mainObject.ConnectedUsers)
                {
                    if (u.GetID == id)
                    {
                        mainObject.ConnectedUsers.Remove(u);
                        modified = true;
                        break;
                    }
                }
            }

            sqlReader.Close();

            return modified;
        }
        public void LogoutUser(User userObject)
        {
            sqlQuery = new MySqlCommand("update users set Connected=0 where Id='" + userObject.GetID + "'", conn);
            sqlQuery.ExecuteNonQuery();
        }

        public void LoadCategories(Main mainObject)
        {
            sqlQuery = new MySqlCommand("select * from categories", conn);
            sqlReader = sqlQuery.ExecuteReader();

            if(sqlReader.HasRows)
            {
                int id;
                string name;

                while(sqlReader.Read())
                {
                    id = sqlReader.GetInt32(0);
                    name = sqlReader.GetString(1);

                    mainObject.Categories.Add(new Category(id, name, this));
                }
            }

            sqlReader.Close();

            foreach(Category c in mainObject.Categories)
            {
                c.LoadBooks();
            }
        }

    }
    public enum DB_Data : int
    {
        ID,
        USERNAME,
        FULLNAME,
        PASSWORD,
        EMAIL,
        ACCESS_LEVEL,
        AGE,
        ADMIN_PIN,
        EDUCATION_UNIT,
        CONNECTED,
        JOINED
    }
    public enum Book_Data :int
    {
        ID,
        NAME,
        AUTHOR,
        DESC,
        ADDEDTIME,
        QTY
    }
}
