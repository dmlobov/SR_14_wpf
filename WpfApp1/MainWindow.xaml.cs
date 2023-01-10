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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Апельсин",
                ProductSize = 140.00,
                ProductImage = 1,
                ProductCategory = ProductCategoryes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Лимон",
                ProductSize = 140.00,
                ProductImage = 2,
                ProductCategory = ProductCategoryes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Ананас",
                ProductSize = 140.00,
                ProductImage = 3,
                ProductCategory = ProductCategoryes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Чайник",
                ProductSize = 140.00,
                ProductImage = 4,
                ProductCategory = ProductCategoryes.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
