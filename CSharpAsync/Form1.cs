using System;
using System.Threading;
using System.Windows.Forms;

namespace CSharpAsync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCallMethod_Click(object sender, EventArgs e)
        {
            this.Text = DoWork();
        }

        private string DoWork()
        {
            Thread.Sleep(10000);
            return "Done with work!";
        }
    }
}
