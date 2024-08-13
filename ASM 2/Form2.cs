using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASM_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;

            listView.Columns.Add("Name", 140);
            listView.Columns.Add("Address", 210);
            listView.Columns.Add("Phone number", 120);
            listView.Columns.Add("Customer Types", 160);
            listView.Columns.Add("Last record", 130);
            listView.Columns.Add("Current record", 130);
            listView.Columns.Add("Water used", 120);
            listView.Columns.Add("Total price ", 130);

            cbTypes.SelectedIndexChanged += cbTypes_SelectedIndexChanged;

            txtnumberp.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string types = null;
            bool isHousehold = false;

            if (cbTypes.SelectedIndex == 0)
            {
                types = "Household customer";
                isHousehold = true;
            }
            else if (cbTypes.SelectedIndex == 1)
            {
                types = "Administrative agency, public services";
            }
            else if (cbTypes.SelectedIndex == 2)
            {
                types = "Production units";
            }
            else if (cbTypes.SelectedIndex == 3)
            {
                types = "Business services";
            }

            string numberOfPeople = txtnumberp.Text;

            if (isHousehold)
            {
                if (string.IsNullOrEmpty(numberOfPeople) || !int.TryParse(numberOfPeople, out _))
                {
                    MessageBox.Show("Enter valid number of people in household.");
                    return;
                }
            }
            else if (!string.IsNullOrEmpty(numberOfPeople))
            {
                MessageBox.Show("Family size is only entered for customer type 'Household customer'.");
                return;
            }

            string lastmonth = txtLastmonth.Text;
            string currentmonth = txtCurrentmonth.Text;
            string consumption = txtWaterUsed.Text;
            string total = txtTotal.Text;

            ListViewItem item = new ListViewItem();
            item.Text = name;
            item.SubItems.Add(address);
            item.SubItems.Add(phone);
            item.SubItems.Add(types);
            item.SubItems.Add(lastmonth);
            item.SubItems.Add(currentmonth);
            item.SubItems.Add(consumption);
            item.SubItems.Add(total);
            listView.Items.Add(item);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem Item = listView.SelectedItems[0];

                string name = txtname.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                string used = txtWaterUsed.Text;
                string total = txtTotal.Text;
                string types = cbTypes.SelectedIndex switch
                {
                    0 => "Household customer",
                    1 => "Administrative agency, public services",
                    2 => "Production units",
                    3 => "Business services",
                    _ => Item.SubItems[3].Text
                };


                string lastMonth = txtLastmonth.Text;
                string currentMonth = txtCurrentmonth.Text;


                bool LastMonthValid = int.TryParse(lastMonth, out int lastMonthValue);
                bool CurrentMonthValid = int.TryParse(currentMonth, out int currentMonthValue);

                ListViewItem edit = new ListViewItem();
                Item.Text = name;
                Item.SubItems[1].Text = address;
                Item.SubItems[2].Text = phone;
                Item.SubItems[3].Text = types;
                Item.SubItems[4].Text = lastMonth;
                Item.SubItems[5].Text = currentMonth;
                Item.SubItems[6].Text = used;
                Item.SubItems[7].Text = total;

                listView.Items.Add(edit);

            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }
        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypes.SelectedIndex == 0)
            {
                txtnumberp.ReadOnly = false;
            }
            else
            {
                txtnumberp.ReadOnly = true;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                Form3 billform = new Form3();
                billform.CustomerName = selectedItem.Text;
                billform.CustomerPhone = selectedItem.SubItems[1].Text;
                billform.CustomerAddress = selectedItem.SubItems[2].Text;
                billform.CustomerType = selectedItem.SubItems[3].Text;
                billform.LastMonth = selectedItem.SubItems[4].Text;
                billform.ThisMonth = selectedItem.SubItems[5].Text;
                billform.Used = selectedItem.SubItems[6].Text;
                billform.Total = selectedItem.SubItems[7].Text;

                billform.Show();
            }
            else
            {
                MessageBox.Show("Please select the invoice you want to print!!!");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Xóa nội dung các ô văn bản
            txtname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtLastmonth.Text = string.Empty;
            txtCurrentmonth.Text = string.Empty;
            txtWaterUsed.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtnumberp.Text = string.Empty;
            txtDescription.Text = string.Empty;

            cbTypes.SelectedIndex = -1;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                listView.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show(" Select the item you want to delete.");
            }
        }
        private double CalculateTotalBill(double price)
        {
            double envFee = price * 0.1;
            double VAT = (price + envFee) * 0.1;
            double totalBill = price + envFee + VAT;
            return totalBill;
        }
        private void btnHCal_Click(object sender, EventArgs e)
        {
            if (cbTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select customer type.");
                return;
            }

            string customerType = cbTypes.SelectedItem.ToString();
            string description = "";

            switch (customerType)
            {
                case "Household customer":
                    description =
                        "     Household customer" + Environment.NewLine +
                        "To 10 m3/people/month" + Environment.NewLine +
                        " = 5.973 VND/m3" + Environment.NewLine +
                        "From 10-20 m3/people/month" + Environment.NewLine +
                        " = 7.052 VND/m3" + Environment.NewLine +
                        "From 20-30 m3/people/month" + Environment.NewLine +
                        " =  8.699 VND/m3" + Environment.NewLine +
                        "Over 30 m3/people/month" + Environment.NewLine +
                        " =  15.929 VND/m3";
                    break;

                case "Administrative agency, public services":
                    description =
                        "Administrative agency, public services" + Environment.NewLine +
                        "9.955 VND/m3";
                    break;

                case "Production units":
                    description =
                        "     Production units" + Environment.NewLine +
                        "11.615 VND/m3";
                    break;

                case "Business services":
                    description =
                        "     Business services" + Environment.NewLine +
                        "22.068 VND/m3";
                    break;

                default:
                    description = "Invalid customer type.";
                    break;
            }
            txtDescription.Text = description;
        }
        private void btnCal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
              string.IsNullOrWhiteSpace(txtPhone.Text) ||
              cbTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter your information into the form!!!");
                return;
            }
            try
            {
                string name = txtname.Text;
                double lastMonthReading = double.Parse(txtLastmonth.Text);
                double currentMonthReading = double.Parse(txtCurrentmonth.Text);


                double consumption = currentMonthReading - lastMonthReading;
                if (consumption < 0)
                {
                    MessageBox.Show("The amount of water used is invalid, please re-enter.");
                    return;
                }


                txtWaterUsed.Text = consumption.ToString("0.##");


                string customerType = cbTypes.SelectedItem.ToString();
                double price = 0;


                switch (customerType)
                {
                    case "Household customer":
                        if (consumption > 0 && consumption <= 10)
                        {
                            price = consumption * 5.973;
                        }
                        else if (consumption > 10 && consumption <= 20)
                        {
                            price = (10 * 5.973) + (consumption - 10) * 7.052;
                        }
                        else if (consumption > 20 && consumption <= 30)
                        {
                            price = (10 * 5.973) + (10 * 7.052) + (consumption - 20) * 8.699;
                        }
                        else if (consumption > 30)
                        {
                            price = (10 * 5.973) + (10 * 7.052) + (10 * 8.699) + (consumption - 30) * 15.929;
                        }
                        break;

                    case "Administrative agency, public services":
                        price = consumption * 9.955;
                        break;

                    case "Production units":
                        price = consumption * 11.615;
                        break;

                    case "Business services":
                        price = consumption * 22.068;
                        break;

                    default:
                        MessageBox.Show("Invalid customer type.");
                        return;
                }


                double totalBill = CalculateTotalBill(price);

                txtTotal.Text = totalBill.ToString("0.##");


                bool updated = false;
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.Text == name)
                    {

                        if (item.SubItems.Count >= 8)
                        {
                            item.SubItems[4].Text = currentMonthReading.ToString("0.##");
                            item.SubItems[5].Text = lastMonthReading.ToString("0.##");
                            item.SubItems[6].Text = consumption.ToString("0.##");
                            item.SubItems[7].Text = totalBill.ToString("0.##");
                            updated = true;
                            break;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid value.");
            }
        }
        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selected_Item = listView.SelectedItems[0];

                string Name = selected_Item.SubItems[0].Text;
                string address = selected_Item.SubItems[1].Text;
                string phone = selected_Item.SubItems[2].Text;
                string types = selected_Item.SubItems[3].Text;
                string last = selected_Item.SubItems[4].Text;
                string current = selected_Item.SubItems[5].Text;
                string used = selected_Item.SubItems[6].Text;
                string total = selected_Item.SubItems[7].Text;

                txtname.Text = Name;
                txtAddress.Text = address;
                txtPhone.Text = phone;
                txtLastmonth.Text = last;
                txtCurrentmonth.Text = current;
                txtWaterUsed.Text = used;
                txtTotal.Text = total;

                if (types == "Household customer")
                {
                    cbTypes.SelectedIndex = 0;
                }
                else if (types == "Administrative agency, public services")
                {
                    cbTypes.SelectedIndex = 1;
                }
                else if (types == "Production units")
                {
                    cbTypes.SelectedIndex = 2;
                }
                else if (types == "Business services")
                {
                    cbTypes.SelectedIndex = 3;
                }
            }
        }
    }
}