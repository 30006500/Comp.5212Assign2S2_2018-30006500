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
        int custindex = -1;
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
            tbxfirstName.Focus();
            Add.Enabled = true;
        }

        public void ClearDisplay()
        {
            listBox1.Items.Clear();
            Add.Enabled = true;
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (search.Text.Length == 0)
            {
                MessageBox.Show("You must enter a customer name");
                search.Focus();
            }
            else
            {                
                string searchquery = search.Text;
                search.Clear();
                ClearDisplay();
                foreach (Customer x in CustomerDB)
                {
                    int index = (CustomerDB.IndexOf(x));
                    if (searchquery == x.FName + " " + x.LName || searchquery == x.FName || searchquery == x.LName)
                    {
                        check = 1;
                        listBox1.Items.Add(CustomerDB[index].GetCustomer());                        
                    }
                }
                if (check == 0)
                {
                    MessageBox.Show("Customer not found, please try again");
                    search.Focus();
                }
            }        
         }

        private void clearList_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            search.Focus();
            Add.Enabled = true;
        }
               
        private void clear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            Add.Enabled = true;
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add.Enabled = false;
            string[] custinfo = listBox1.Text.Split('\t');
            tbxfirstName.Text = custinfo[0];
            tbxlastName.Text = custinfo[1];
            tbxphone.Text = custinfo[2];
            foreach (Customer x in CustomerDB)
            {
                if (x.FName == custinfo[0])
                {
                   custindex = (CustomerDB.IndexOf(x));
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CustomerDB.RemoveAt(custindex);
                    ClearDisplay();
                    DisplayCustomers();
                    ClearBoxes();
                    MessageBox.Show("The Customer has been deleted");
                    Add.Enabled = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operation Cancelled");
                }
            }
            
        }
        public void update_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a customer to update");
            }

            else if (tbxfirstName.Text == "" || tbxlastName.Text == "" || tbxphone.Text == "")
            {
                MessageBox.Show("All textboxes must be filled to continue");
            }

            else
            {
                CustomerDB[custindex].FName = tbxfirstName.Text;
                CustomerDB[custindex].LName = tbxlastName.Text;
                CustomerDB[custindex].Phone = tbxphone.Text;
                ClearBoxes();
                ClearDisplay();
                DisplayCustomers();
                MessageBox.Show("Customer details updated");
                Add.Enabled = true;
            }
            

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (tbxfirstName.Text == "" || tbxlastName.Text == "" || tbxphone.Text == "")
            {
                MessageBox.Show("All textboxes must be filled to continue");
            }
            else
            {
                CustomerDB.Add(new Customer(tbxfirstName.Text, tbxlastName.Text, tbxphone.Text));
                ClearBoxes();
                ClearDisplay();
                DisplayCustomers();
                MessageBox.Show("New customer has been added");
            }
        }
    }
}
