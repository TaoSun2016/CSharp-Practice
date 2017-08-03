using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportDataToOfficeApp
{
    public partial class MainForm : Form
    {
        List<Car> carsInStock = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            carsInStock = new List<Car> {
                                            new Car {Color="Green", Make="VW",PetName="Mary"},
                                            new Car {Color="Red", Make="Saab",PetName="Mel"},
                                            new Car {Color="Black", Make="Ford",PetName="Hank"},
                                            new Car {Color="Yellow", Make="BMW",PetName="Davie"}
                                        };
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            // Reset the source of data.
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = carsInStock;
        }
    }
}
