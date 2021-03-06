﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding
{
    public partial class MainForm : Form
    {
        List<Car> listCar = null;
        DataTable inventoryTable = new DataTable();
        DataView yugosOnlyView;
        public MainForm()
        {
            InitializeComponent();
            listCar = new List<Car> {
                new Car { Id = 1, PetName = "Chucky", Make = "BMW", Color = "Green" },
                new Car { Id = 2, PetName = "Tiny", Make= "Yugo", Color = "White" },
                new Car { Id = 3, PetName = "Ami", Make = "Jeep", Color = "Tan" },
                new Car { Id = 4, PetName = "PainInducer", Make = "Caravan", Color = "Pink" },
                new Car { Id = 5, PetName = "Fred", Make = "BMW", Color = "Green" },
                new Car { Id = 6, PetName = "Sidd", Make = "BMW", Color = "Black" },
                new Car { Id = 7, PetName = "Mel",  Make = "Firebird",  Color = "Red" },
                new Car { Id = 8, PetName = "Sarah", Make = "Colt", Color = "Black" },
             };
            CreateTable();
            CreateDataView();
        }

        void CreateTable()
        {
            var carIDColumn = new DataColumn("Id", typeof(int));
            var carMakeColumn = new DataColumn("Make", typeof(string));
            var carColorColumn = new DataColumn("Color", typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string)) { Caption = "Pet Name" };
            inventoryTable.Columns.AddRange(new[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });
            foreach (var i in listCar)
            {
                var newRow = inventoryTable.NewRow();
                newRow["Id"] = i.Id;
                newRow["Make"] = i.Make;
                newRow["Color"] = i.Color;
                newRow["PetName"] = i.PetName;
                inventoryTable.Rows.Add(newRow);
            }
            carInventoryGridView.DataSource = inventoryTable;

        }
        private void CreateDataView()
        {
            yugosOnlyView = new DataView(inventoryTable);
            yugosOnlyView.RowFilter = "Make='Yugo'";
            dataGridYugosView.DataSource = yugosOnlyView;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rowToDelete = inventoryTable.Select($"Id={int.Parse(txtCarToRemove.Text)}");
                rowToDelete[0].Delete();
                inventoryTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisplayMakes_Click(object sender, EventArgs e)
        {
            string stringFilter = $"Make = '{txtMakeToView.Text.Trim()}'";
            DataRow[] carRecords = inventoryTable.Select(stringFilter, "PetName DESC");
            if (carRecords.Length <= 0)
            {
                MessageBox.Show("There's no search result!");
            }
            else
            {
                string stringResult = null;
                for (int i = 0; i < carRecords.Count(); i++)
                {
                    stringResult += carRecords[i]["PetName"] + "\n";
                }
                MessageBox.Show(stringResult, $"We have {txtMakeToView.Text}s named:");
            }
        }

        private void ShowIDGT5_Click(object sender, EventArgs e)
        {
            string filterString = null;
            filterString = "ID > 5";

            DataRow[] dataRows = inventoryTable.Select(filterString, "ID");
            string outputString = null;

            for (int i = 0; i < dataRows.Length; i++)
            {
                outputString += $"{dataRows[i]["PetName"]}'s ID is {dataRows[i]["ID"]}\n";
            }
            MessageBox.Show(outputString);
        }

        private void ChangeBMW_Click(object sender, EventArgs e)
        {


            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to change BMW?", "Please reassure", MessageBoxButtons.YesNo))
            {
                string filterString = "Make = 'BMW'";
                DataRow[] dataRow = inventoryTable.Select(filterString);
                for (int i = 0; i < dataRow.Length; i++)
                {
                    dataRow[i]["Make"] = "Yugo";
                }
            }
        }
    }
}
