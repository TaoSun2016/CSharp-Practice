using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using AutoLotDAL.Models;
using System;

namespace AutoLotDAL.ConnectedLayer
{
    class InventoryDAL
    {
        private SqlConnection _sqlConnection = null;
        public void OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection{ ConnectionString = connectionString };
            _sqlConnection.Open();
        }
        public void CloseConnection()
        {
            _sqlConnection.Close();
        }
        public void InsertAuto(int id, string color,string make, string petName)
        {
            // Format and execute SQL statement.
            string sql = "Insert Into Inventory" + $"(Make, Color, PetName) Values ('{make}','{color}', '{petName}')";
            // Execute using our connection.
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void InsertAuto(NewCar car)
        {
            // Format and execute SQL statement.
            string sql = "Insert Into Inventory" + "( Make, Color, PetName) Values" +  $"('{car.Make}', '{car.Color}','{car.PetName}')";
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
            using (SqlCommand command = new SqlCommand(sql,_sqlConnection))
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
    }
}
