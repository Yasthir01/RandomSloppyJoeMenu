using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RandomSloppyJoeMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;

            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)  // we only want the first 3 items to be normal menu items. Remaining two to be bagels
                {
                    menuItems[i].Breads = new string[]
                    {
                        "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"
                    };
                }
                menuItems[i].Generate();  // you have to call Generate otherwise the MenuItems fields will be blank
            }
            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;

            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;

            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;

            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;

            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            // the last item on the menu is the special sandwich made with premium ingredients
            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] {"Organic Ham", "Mushroom Patty", "Mortadella"},
                Breads = new string[] {"a gluten free roll", "a wrap", "a pita"},
                Condiments = new string[] {"Dijon Mustard", "Miso Dressing", "Au Jus"}
            };
            // generate the special menu item
            specialMenuItem.Generate();

            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;

            guacamole.Text = "Add guacamole for " + guacamoleMenuItem.Price;

        }
    }
}
