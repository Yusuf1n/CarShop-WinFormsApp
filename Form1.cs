using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carCatalogueBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Create_Car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_Make.Text, txt_Model.Text, txt_Colour.Text, int.Parse(txt_Year.Text), decimal.Parse(txt_Price.Text));
            //MessageBox.Show(c.ToString());
            myStore.CarCatalogue.Add(c);
            carCatalogueBindingSource.ResetBindings(false);
            txt_Make.Text = "";
            txt_Model.Text = "";
            txt_Colour.Text = "";
            (txt_Year.Text) = "";
            (txt_Price.Text) = "";
        }

        private void btn_Add_To_Cart_Click(object sender, EventArgs e)
        {
            //Get the car from the catalogue
            Car selected = (Car)lst_Catalogue.SelectedItem;

            //Add the car to the cart
            myStore.Cart.Add(selected);

            //Update the list box control
            cartBindingSource.ResetBindings(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carCatalogueBindingSource.DataSource = myStore.CarCatalogue;

            cartBindingSource.DataSource = myStore.Cart;

            lst_Catalogue.DataSource = carCatalogueBindingSource;
            lst_Catalogue.DisplayMember = ToString();

            lst_Cart.DataSource = cartBindingSource;
            lst_Cart.DisplayMember = ToString();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_Total.Text = "£" + total.ToString();
            cartBindingSource.ResetBindings(false);
        }
    }
}
