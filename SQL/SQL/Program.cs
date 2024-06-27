using System;
using MySql.Data.MySqlClient;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verbindungszeichenfolge mit den bereitgestellten Daten
            string connectionString = "Server=sql7.freesqldatabase.com;Database=sql7716485;Uid=sql7716485;Pwd=fNIcBWqGmC;Port=3306";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if table exists
                    string checkTableQuery = "SHOW TABLES LIKE 'EMPLOYEE'";
                    MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, connection);
                    var tableExists = checkTableCommand.ExecuteScalar();

                    if (tableExists == null)
                    {
                        // Create table
                        string createTableQuery = @"
                            CREATE TABLE EMPLOYEE (
                                empId INTEGER PRIMARY KEY,
                                name TEXT NOT NULL,
                                dept TEXT NOT NULL,
                                salary REAL NOT NULL,
                                address TEXT NOT NULL
                            )";
                        MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                        createTableCommand.ExecuteNonQuery();
                        Console.WriteLine("Table created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Table already exists.");
                    }

                    // Insert data
                    string insertDataQuery = @"
                        INSERT INTO EMPLOYEE VALUES (1, 'Clark', 'Sales', 60000, '123 Elm St');
                        INSERT INTO EMPLOYEE VALUES (2, 'Dave', 'Accounting', 55000, '456 Oak St');
                        INSERT INTO EMPLOYEE VALUES (3, 'Ava', 'Sales', 62000, '789 Pine St');
                        INSERT INTO EMPLOYEE VALUES (4, 'Eva', 'Accounting', 58000, '321 Maple St');
                        INSERT INTO EMPLOYEE VALUES (5, 'Aywa', 'Sales', 63000, '654 Birch St');
                        INSERT INTO EMPLOYEE VALUES (6, 'Seb', 'Bla bla', 70000, '987 Cedar St')";
                    MySqlCommand insertDataCommand = new MySqlCommand(insertDataQuery, connection);
                    insertDataCommand.ExecuteNonQuery();
                    Console.WriteLine("Data inserted successfully.");

                    // Fetch data
                    string[] departments = { "Sales", "Accounting", "Bla bla" };
                    foreach (var dept in departments)
                    {
                        string fetchDataQuery = "SELECT * FROM EMPLOYEE WHERE dept = @dept";
                        MySqlCommand fetchDataCommand = new MySqlCommand(fetchDataQuery, connection);
                        fetchDataCommand.Parameters.AddWithValue("@dept", dept);
                        MySqlDataReader reader = fetchDataCommand.ExecuteReader();

                        Console.WriteLine($"Fetching data for department '{dept}':");
                        while (reader.Read())
                        {
                            Console.WriteLine($"EmpId: {reader["empId"]}, Name: {reader["name"]}, Dept: {reader["dept"]}, Salary: {reader["salary"]}, Address: {reader["address"]}");
                        }
                        reader.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"MySQL Error occurred: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}