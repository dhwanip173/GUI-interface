using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_B
{
    public partial class frmMain : Form
    {
    /*
           
    Name: Dhwani Patel
    Student number : 000811565
    Date:   March 23, 2021
    Authorship: I, Dhwani Patel, 000811565 certify that this material is my original work. No other person's work has been used without due acknowledgement.

    */

        public int totalPrice = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This will add all the hair dressers into thr combobox(dropdown) with their values
        /// </summary>
        /// <param name="selectedService"></param>
        /// <returns></returns>
        public List<cmbItems> addHairdressers(bool selectedService = false)
        {
            List<cmbItems> lstitem = new List<cmbItems>();
            lstitem.Add(new cmbItems { Text = "Jane Samley", Value = 30 });
            lstitem.Add(new cmbItems { Text = "Pat", Value = 45 });
            lstitem.Add(new cmbItems { Text = "Ron", Value = 40 });
            lstitem.Add(new cmbItems { Text = "Sue", Value = 50 });
            lstitem.Add(new cmbItems { Text = "Laurie", Value = 45 });
            if (selectedService != true)
            {
                foreach (var bike in lstitem)
                {
                    cmbHairdressers.Items.Add(bike.Text);
                }
                cmbHairdressers.SelectedIndex = 0;
            }

            List<cmbItems> lstHair = new List<cmbItems>();
            lstHair.AddRange(lstitem);
            return lstHair;
        }

        /// <summary>
        /// This will add all the services into listbox with their values (prices)
        /// </summary>
        /// <param name="selectedService">Bool value to check if we have to add values</param>
        /// <returns></returns>
        public List<lstItemsServices> addServices(bool selectedService = false)
        {
            List<lstItemsServices> lstitem = new List<lstItemsServices>();
            lstitem.Add(new lstItemsServices { Text = "Cut", Value = 30 });
            lstitem.Add(new lstItemsServices { Text = "Wash, blow-dry,and Style", Value = 20 });
            lstitem.Add(new lstItemsServices { Text = "Colour", Value = 40 });
            lstitem.Add(new lstItemsServices { Text = "Highlights", Value = 50 });
            lstitem.Add(new lstItemsServices { Text = "Extensions", Value = 200 });
            lstitem.Add(new lstItemsServices { Text = "Up-do", Value = 60 });
            if (selectedService != true)
            {
                foreach (var services in lstitem)
                {
                    lstServices.Items.Add(services);
                }
            }

            List<lstItemsServices> lstService = new List<lstItemsServices>();
            lstService.AddRange(lstitem);
            return lstService;
        }
        /// <summary>
        /// This is to create combox properties with values. Class for combox values
        /// </summary>
        public class cmbItems
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        /// <summary>
        /// This is to have list type items
        /// </summary>
        public class lstItemsServices
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {

            List<cmbItems> lstHair = addHairdressers(true);
            List<lstItemsServices> lstService = addServices(true);
            string comboText = cmbHairdressers.Text;
            int ComboValue = lstHair.Where(a => a.Text == comboText).Select(a => a.Value).FirstOrDefault();

            List<string> lstService1 = new List<string>();
            foreach (var item in lstServices.SelectedItems)
            {
                bool checkText = lstChargedItems.Items.Contains(item.ToString());
                if (checkText == false)
                {
                    lstService1.Add(item.ToString());
                }
            }

            bool checkHair = lstChargedItems.Items.Contains(comboText);

            if (checkHair == false)
            {
                lstChargedItems.Items.Add(comboText);
                lstPrices.Items.Add("$" + ComboValue + ".00");
                totalPrice += ComboValue;
            }
            if (lstService1.Count > 0)
            {
                for (var i = 0; i < lstService1.Count; i++)
                {
                    int serviceValue = lstService.Where(a => a.Text == lstService1[i]).Select(a => a.Value).FirstOrDefault();
                    lstChargedItems.Items.Add(lstService1[i]);
                    lstPrices.Items.Add("$" + serviceValue + ".00");
                    totalPrice += serviceValue;

                }
            }
            btnCalculate.Enabled = true;
            cmbHairdressers.Enabled = false;
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            // Reloading the form
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtCalculatedPrice.Text = "$" + totalPrice + ".00";
        }

        private void listBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnService.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addHairdressers();
            addServices();
        }

        private void cmbHairdressers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
