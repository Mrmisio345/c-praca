using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1 {
    public partial class MainWindow : Window {
        public bool PlayerTurn { get; set; }

        public int Amount { get; set; }

        public bool IsWon { get; set; }

        public MainWindow() {
            InitializeComponent();      
            NewGame();
        }

        public void NewGame() {
            PlayerTurn = false;
            IsWon = false;
            Amount = 0;
            Button_0_0.Content = string.Empty; 
            Button_1_0.Content = string.Empty; 
            Button_2_0.Content = string.Empty; 
            Button_0_1.Content = string.Empty; 
            Button_1_1.Content = string.Empty; 
            Button_2_1.Content = string.Empty; 
            Button_0_2.Content = string.Empty; 
            Button_1_2.Content = string.Empty; 
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            PlayerTurn ^= true;
            Amount++;

            if (Amount > 9 || IsWon) {
                NewGame();
                return;
            }

            var button = sender as Button;
            
            button.Content = PlayerTurn ? "O" : "X";

            CheckIfPlayerWon();
        }
        private void CheckIfPlayerWon() {
            if (Button_0_0.Content.ToString() !=string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content) {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                IsWon = true;
            } else if (Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content) {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                IsWon = true;
            } else if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content) {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                IsWon = true;
            } else if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content) {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                IsWon = true;
            } else if (Button_0_1.Content.ToString() != string.Empty && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content) {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                IsWon = true;
            } else if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content) {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                IsWon = true;
            } else if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content) {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                IsWon = true;
            } else if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content) {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                IsWon = true;
            }  else {
                IsWon = false;
            }
        }
    }
}
