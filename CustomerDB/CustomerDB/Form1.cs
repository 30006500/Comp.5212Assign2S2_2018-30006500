using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDB
{
    public partial class Form1 : Form
    {
        List<Customer> CustomerDB = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadDB();
        }

        public void LoadDB()
        {
            CustomerDB.Add(new Customer("Jaarna", "Kereopa", "123-2514"));
            CustomerDB.Add(new Customer("Sue", "Stook",	"123-1263"));
            CustomerDB.Add(new Customer("Jamie", "Allom", "123-3658"));
            CustomerDB.Add(new Customer("Brian", "Janes", "123-9898"));
        }

        public void ClearBoxes()
        {
            tbxfirstName.Clear();
            tbxlastName.Clear();
            tbxphone.Clear();
        }

        public void ClearDisplay()
        {
            listBox1.ResetText();
        }

        public void DisplayCustomers()
        {
            foreach(Customer x in CustomerDB)
            {
                listBox1.Items.Add(x.GetCustomer());
            }
        }

        private void listCust_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            DisplayCustomers();
        }
    }
}
