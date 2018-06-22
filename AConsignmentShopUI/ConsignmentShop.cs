using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//the backend code for our form

namespace AConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        BindingSource itemsBinding = new BindingSource();

        public ConsignmentShop() //note: this is a constructor as it has no assignment type
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = Store.Items;

        }

        private void SetupData()
        {
            //Vendor demoVendor = new Vendor();  //creates new vendor object and instantiates with new Vendor

            //demoVendor.FirstName = "Bill";  //item it needs
            //demoVendor.LastName = "Smith";  //item it needs
            //demoVendor.Commission = .5;     //item it needs

            //store.Vendors.Add(demoVendor);

            //demoVendor = new Vendor();  //creates new vendor object and instantiates with new Vendor

            //demoVendor.FirstName = "Joan";  //item it needs
            //demoVendor.LastName = "Suzuki";  //item it needs
            //demoVendor.Commission = .5;     //item it needs

            //store.Vendors.Add(demoVendor);


            //Creates new instance, populates this instance and takes all that information and adds to our list
            //...all in one line.  Consider this a quicker way below:
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Joan", LastName = "Suzuki" });
            store.Vendors.Add(new Vendor { FirstName = "Laura", LastName = "Hamlin" });

            store.Items.Add(new Item
            {
                Title = "Parable of the Talents",
                Description = "A book about talents",
                Price = 17.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 10.50M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 23.50M,
                Owner = store.Vendors[2]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 7.50M,
                Owner = store.Vendors[0]
            });

            store.Name = "Seconds or Better";
        }


        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
 }

