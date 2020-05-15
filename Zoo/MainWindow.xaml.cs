using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Zoo.Animals;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Animal> items = new List<Animal>();
        public MainWindow()
        {
            InitializeComponent();
            // what data is shown in the listview
            AnimalList.ItemsSource = items;
        }

        #region Buttons to add animals
        private void MonkeyButton_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new Monkey() { Name = nickNameTextBox.Text, Specie = "Monkey", Energy = 20 }); ;
            AnimalList.Items.Refresh();
            nickNameTextBox.Clear();
        }

        private void ElephantButton_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new Elephant() { Name = nickNameTextBox.Text, Specie = "Elephant", Energy = 10 });
            AnimalList.Items.Refresh();
            nickNameTextBox.Clear();

        }

        private void LionButton_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new Lion() { Name = nickNameTextBox.Text, Specie = "Lion", Energy = 10 });
            AnimalList.Items.Refresh();
            nickNameTextBox.Clear();

        }
        #endregion
        #region feeding buttons
        private void FeedAll(object sender, RoutedEventArgs e)
        {
            foreach(Animal item in items)
            {
                item.Eat();
                AnimalList.Items.Refresh();
            }
        }

        private void FeedLion_Click(object sender, RoutedEventArgs e)
        {
            foreach(Lion value in items.OfType<Lion>())
            {
                value.Eat();
                AnimalList.Items.Refresh();
            }
        }

        private void FeedElephant_Click(object sender, RoutedEventArgs e)
        {
            foreach (Elephant value in items.OfType<Elephant>())
            {
               value.Eat();
                AnimalList.Items.Refresh();
            }
        }

        private void FeedMonkeyButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Monkey value in items.OfType<Monkey>())
            {
                value.Eat();
                AnimalList.Items.Refresh();

            }
        }
        #endregion

        private void UseEnergy_Click(object sender, RoutedEventArgs e)
        {
            foreach(Animal animal in items)
            {
                animal.UseEnergy();
                AnimalList.Items.Refresh();
            }
        }

        private void ClearField(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (nickNameTextBox.Text == "Enter nickname")
            {
                nickNameTextBox.Text = null;
            }
        }
    }
}
