﻿using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using AutoLotDAL.Models;
using System;
using static System.Console;

namespace AutoLotDAL.ConnectedLayer
{
    public class InventoryDAL
    {
        private SqlConnection _sqlConnection = null;
        public void OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection { ConnectionString = connectionString };
            _sqlConnection.Open();
        }
        public void CloseConnection()
        {
            _sqlConnection.Close();
        }
        public void InsertAuto(int id, string color, string make, string petName)
        {
            // Note the "placeholders" in the SQL query.
            string sql = "Insert Into Inventory" +
            "(Make, Color, PetName) Values" +
            "(@Make, @Color, @PetName)";
            // This command will have internal parameters.
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@Make",
                    Value = make,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "@Color",
                    Value = color,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "@PetName",
                    Value = petName,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
            }
        }
        public void InsertAuto(NewCar car)
        {
            // Format and execute SQL statement.
            string sql = "Insert Into Inventory" + "( Make, Color, PetName) Values" + $"('{car.Make}', '{car.Color}','{car.PetName}')";
            // Execute using our connection.
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteCar(int id)
        {
            // Delete the car with the specified CarId
            string sql = $"Delete from Inventory where CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry!  That car is on order!", ex);
                    throw error;
                }
            }
        }
        public void UpdateCarPetName(int id, string newPetName)
        {
            // Update the PetName of the car with the  specified CarId.
            string sql = $"Update Inventory Set PetName = '{newPetName}' Where CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<NewCar> GetAllInventoryAsList()
        {
            // This will hold the records.
            List<NewCar> inv = new List<NewCar>();
            // Prep command object.
            string sql = "Select * From Inventory";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    inv.Add(new NewCar
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    });
                }
                dataReader.Close();
            }
            return inv;
        }
        public DataTable GetAllInventoryAsDataTable()
        {
            // This will hold the records.
            DataTable dataTable = new DataTable();
            // Prep command object.
            string sql = "Select * From Inventory";
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                SqlDataReader dataReader   = cmd.ExecuteReader();
                // Fill the DataTable with data from the  reader and clean up.
                dataTable.Load(dataReader);
                dataReader.Close();
            }
            return dataTable;
        }
        public string LookUpPetName(int carID)
        {
            string carPetName;
            // Establish name of stored proc.
            using (SqlCommand command = new SqlCommand("GetPetName", _sqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Input param.
                SqlParameter param = new SqlParameter
                {
                    ParameterName = "@carID",
                    SqlDbType = SqlDbType.Int,
                    Value = carID,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(param);

                // Output param.
                param = new SqlParameter
                {
                    ParameterName = "@petName",
                    SqlDbType = SqlDbType.Char,
                    Size = 10,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(param);

                // Execute the stored proc.
                command.ExecuteNonQuery();
                // Return output param.
                carPetName = (string)command.Parameters["@petName"].Value;
            }
            return carPetName;
        }
        // A new member of the InventoryDAL class.
        public void ProcessCreditRisk(bool throwEx, int custID)
        {
            // First, look up current name based on customer ID.
            string fName;
            string lName;
            var cmdSelect =
            new SqlCommand($"Select * from Customers where CustId = { custID }", _sqlConnection);
            using (var dataReader = cmdSelect.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    fName = (string)dataReader["FirstName"];
                    lName = (string)dataReader["LastName"];
                }
                else
                {
                    return;
                }
            }
            // Create command objects that represent each step of the operation.
            var cmdRemove = new SqlCommand($"Delete from Customers where CustId = { custID }",_sqlConnection);
            var cmdInsert = new SqlCommand("Insert Into CreditRisks" + $"(FirstName, LastName) Values('{fName}','{lName}')",_sqlConnection);
            // We will get this from the connection object.
            SqlTransaction tx = null;
            try
            {
                tx = _sqlConnection.BeginTransaction();
                // Enlist the commands into this transaction.
                cmdInsert.Transaction = tx;
                cmdRemove.Transaction = tx;
                // Execute the commands.
                cmdInsert.ExecuteNonQuery();
                cmdRemove.ExecuteNonQuery();
                // Simulate error.
                if (throwEx)
                {
                    throw new Exception("Sorry! Database error!Tx failed...");
                }
                // Commit it!
                tx.Commit();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                // Any error will roll back transaction.
                // Using the new conditional access operator to check for null.
                tx?.Rollback();
            }
        }
    }
}
