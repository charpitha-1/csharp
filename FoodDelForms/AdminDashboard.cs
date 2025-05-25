using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDelForms.Lists;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FoodDelForms
{
    public partial class AdminDashboard : Form
    {
        DataProvider dataProvider;
        public AdminDashboard()
        {
            InitializeComponent();
            dataProvider = DataProvider.Instance;
            DataProvider.Instance.LoadData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Owner uinfo = new Owner()
            {
                DisplayName = "Sai Durga",
                Email = "abc@a.com",
                Password = "123456"
            };
            DataProvider.Instance.AddUser(uinfo);

            Location location = new Location()
            {
                LocationName = "CHENNAI"
            };
            DataProvider.Instance.AddLocation(location);
            Restaurant restaurant = new Restaurant("A2B", uinfo, location); 
            DataProvider.Instance.AddRestaurant(restaurant);
        }
        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation newlocation = new NewLocation(dataProvider);
            newlocation.ShowDialog();
            UpdateLocationgrid();
        }
        private void UpdateLocationgrid()
        {
            List<Location> locations = dataProvider.GetAllLocations();
            GridLocation.DataSource = null;
            GridLocation.DataSource = locations;
            GridLocation.Refresh();
        }
        private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRestaurant newrest = new NewRestaurant(dataProvider);
            newrest.ShowDialog();
            UpdateResturantgrid();
        }
        private void UpdateResturantgrid()
        {
            List<Restaurant> rests = dataProvider.GetAllRestaurants();
            GridRestaurant.DataSource = null;
            GridRestaurant.DataSource = rests;
            GridRestaurant.Refresh();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataProvider.Instance.SaveToFile();
        }
    }
}
