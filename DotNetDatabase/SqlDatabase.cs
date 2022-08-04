using MySql.Data.MySqlClient;//for connection 
using System.Data;//for reader purpose
using model;
using System.Collections.Generic;

namespace MySqlDataConnectionDemo
{
    class MySqlClass
    {
        public MySqlConnection conn;
        public string myConnectionString;
        public void MySqlMethod()
        {
            myConnectionString = "server=localhost; port=3307; uid=root; pwd=password; database=my_org";

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                System.Console.WriteLine($"MYSQL version:{conn.ServerVersion}");

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "worker";//table name from where we want to fetch the data
                cmd.Connection = conn;
                cmd.CommandType = CommandType.TableDirect;//give complete table data
                MySqlDataReader reader = cmd.ExecuteReader();//it will read the data

                while (reader.Read())//reader.read will fetch particular row, reader[0] give 1st col data
                {
                    System.Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4] + "\t" + reader[5] + "\t" + reader[6]);
                }

                reader.Close();
                System.Console.WriteLine();


                //modal classes............
                List<Worker> workers = new List<Worker>();

                String newString = "select *from worker";
                MySqlCommand cmd6 = new MySqlCommand(newString, conn);//query and the connection on which want to perform
                MySqlDataReader reader6 = cmd6.ExecuteReader();//it will read the data

                while (reader6.Read())//reader.read will fetch particular row, reader[0] give 1st col data
                {
                    Worker worker = new Worker(reader6.GetInt32("Worker_Id"), reader6.GetString("first_Name"), reader6.GetString("last_Name"), reader6.GetDouble("salary"), reader6.GetString("joining_Date"), reader6.GetString("email"), reader6.GetString("department"));
                    workers.Add(worker);
                    //System.Console.WriteLine(reader6[0] + "\t" + reader6[1] + "\t" + reader6[2] + "\t" + reader6[3] + "\t" + reader6[4] + "\t" + reader6[5] + "\t" + reader6[6]);
                }

                foreach (Worker worker1 in workers)
                {
                    System.Console.WriteLine(worker1.toString());
                }



                string requestQueryString = "SELECT * from Worker where Department='HR'";
                MySqlCommand cmd1 = new MySqlCommand(requestQueryString, conn);//query and the connection on which want to perform
                MySqlDataReader reader1 = cmd1.ExecuteReader();//it will read the data

                while (reader1.Read())//reader.read will fetch particular row, reader[0] give 1st col data
                {
                    System.Console.WriteLine(reader1[0] + "\t" + reader1[1] + "\t" + reader1[2] + "\t" + reader1[3] + "\t" + reader1[4] + "\t" + reader1[5] + "\t" + reader1[6]);
                }
                reader1.Close();
                System.Console.WriteLine();

                using var cmd2 = new MySqlCommand();
                cmd2.Connection = conn;

                cmd2.CommandText = "DROP TABLE IF EXISTS cars";
                cmd2.ExecuteNonQuery();

                cmd2.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY AUTO_INCREMENT,
        name TEXT, price INT)";
                cmd2.ExecuteNonQuery();

                cmd2.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
                cmd2.ExecuteNonQuery();

                cmd2.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
                cmd2.ExecuteNonQuery();

                cmd2.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
                cmd2.ExecuteNonQuery();

                cmd2.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
                cmd2.ExecuteNonQuery();



                string requestQueryString1 = "SELECT * from cars";
                MySqlCommand cmd3 = new MySqlCommand(requestQueryString1, conn);//query and the connection on which want to perform
                MySqlDataReader reader2 = cmd3.ExecuteReader();//it will read the data

                while (reader2.Read())//reader.read will fetch particular row, reader[0] give 1st col data
                {
                    System.Console.WriteLine(reader2[0] + "\t" + reader2[1] + "\t" + reader2[2] + "\t");
                }
                reader2.Close();
                System.Console.WriteLine();


                using var cmd4 = new MySqlCommand();
                cmd4.Connection = conn;

                cmd4.CommandText = "update cars set price=89456 WHERE name='Audi'";
                cmd4.ExecuteNonQuery();

                using var cmd5 = new MySqlCommand();
                cmd5.Connection = conn;

                cmd5.CommandText = "delete from cars WHERE name='Audi'";
                cmd5.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

    }

}