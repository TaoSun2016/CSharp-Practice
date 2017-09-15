using System;
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
        }

        void CreateTable()
        {
            var carIDColumn = new DataColumn("Id",typeof(int));
            var carMakeColumn = new DataColumn("Make",typeof(string));
            var carColorColumn = new DataColumn("Color",typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string)) { Caption="Pet Name"};
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
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
