using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace FlowerShop
{
    public partial class MainWindow : Window
    {
        public class Flower
        {
            public string Name { get; set; }
            public string Price { get; set; }
        }

        public ObservableCollection<Flower> Flowers { get; set; } = new ObservableCollection<Flower>
        {
            new Flower { Name = "Roses", Price = "$10" },
            new Flower { Name = "Tulips", Price = "$7" },
            new Flower { Name = "Daisies", Price = "$5" },
            new Flower { Name = "Lilies", Price = "$12" }
        };

        private int selectedIndex = -1;

        public MainWindow()
        {
            InitializeComponent();
            FlowerList.ItemsSource = Flowers;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                Flowers.Add(new Flower { Name = txtName.Text, Price = txtPrice.Text });
                txtName.Clear();
                txtPrice.Clear();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < Flowers.Count)
            {
                Flowers[selectedIndex].Name = txtName.Text;
                Flowers[selectedIndex].Price = txtPrice.Text;
                // Refresh list
                FlowerList.Items.Refresh();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < Flowers.Count)
            {
                Flowers.RemoveAt(selectedIndex);
                txtName.Clear();
                txtPrice.Clear();
                selectedIndex = -1;
                FlowerList.UnselectAll();
            }
        }

        private void FlowerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIndex = FlowerList.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < Flowers.Count)
            {
                txtName.Text = Flowers[selectedIndex].Name;
                txtPrice.Text = Flowers[selectedIndex].Price;
            }
            else
            {
                txtName.Clear();
                txtPrice.Clear();
            }
        }
    }
}