using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NIM
{
    // <summary>
    // Interaction logic for MainWindow.xaml
    // </summary>
    public partial class MainWindow : Window
    {
        private Random rnd; // = new Random();
        private int tokens; // = rnd.Next(10, 33);
        private Ellipse[] ellipses; // = new Ellipse[tokens];
        private Brush[] colours; // = { Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.Yellow, Brushes.Purple, Brushes.Orange, Brushes.Turquoise, Brushes.Violet };
        private bool player;
        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();
            tokens = rnd.Next(16, 33);
            ellipses = new Ellipse[tokens];
            colours = [ Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.Yellow, Brushes.Purple, Brushes.Orange, Brushes.Turquoise, Brushes.Violet ];
            player = true;
            GeneratePlayingField();
        }

        void GeneratePlayingField()
        {
            for (int i = 0; i < tokens; i++)
            {
                ellipses[i] = new Ellipse { Width = 40, Height = 40, Fill = colours[rnd.Next(0, colours.Length)], Stroke = Brushes.Black, StrokeThickness = 4 };
                gameArea.Children.Add(ellipses[i]);
                Canvas.SetLeft(ellipses[i], i * 45 + 40);
                if (i > 15)
                {
                    Canvas.SetLeft(ellipses[i], (i - 16) * 45 + 40);
                }
            }
            ;
            for (int i = 0; i < tokens; i++)
            {
                Canvas.SetTop(ellipses[i], 100);
                if (i > 15)
                {
                    Canvas.SetTop(ellipses[i], 150);
                }
                ;
            }
            ;
            this.info.Text = $"There are {gameArea.Children.Count} tokens left";
            this.info2.Text = $"It is Player 1's turn";
        }
        bool IsGameOver()
        {
            if (gameArea.Children.Count <= 0)
            {
                return true;
            }
            return false;
        }

        void UpdatePlayer()
        {
            if (player)
            {
                player = false;
                this.info2.Text = $"It is Player 2's turn";
            }
            else
            {
                player = true;
                this.info2.Text = $"It is Player 1's turn";
            }
        }

        int BeatThePlayer()
        {
            Thread.Sleep(rnd.Next(500,1500));
            if (gameArea.Children.Count % 4 == 0)
            {
                return rnd.Next(1, 4);
            }
            else
            {
                return gameArea.Children.Count % 4;
            }
        }

        void RemoveTokens(int n)
        {
            for (int i = 0; i < n; i++)
            {
                gameArea.Children.RemoveAt(gameArea.Children.Count - 1);
            }
            this.info.Text = $"There are {gameArea.Children.Count} tokens left";
        }

        void ClickThing(int n)
        {
            if (gameArea.Children.Count <= n-1)
            {
                MessageBox.Show("You can't take more tokens than are available!");
            }
            else
            {
                RemoveTokens(n);
                if (IsGameOver())
                {
                    MessageBox.Show($"Game Over! Player {(player ? "1" : "2")} wins!");
                }
                else
                {
                    UpdatePlayer();
                    AllowUIToUpdate();
                    int toRemove = BeatThePlayer();
                    RemoveTokens(toRemove);
                    if (IsGameOver())
                    {
                        MessageBox.Show($"Game Over! Player {(player ? "1" : "2")} wins!");
                    }
                    else
                    {
                        UpdatePlayer();
                    }
                }
            }
        }
        void AllowUIToUpdate()
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Render, new DispatcherOperationCallback(delegate (object parameter)
            {
                frame.Continue = false;
                return null;
            }), null);

            Dispatcher.PushFrame(frame);
            //EDIT:
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate { }));
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            ClickThing(1);
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            ClickThing(2);
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            ClickThing(3);
        }

        void Reset(object sender, RoutedEventArgs e)
        {
            gameArea.Children.Clear();
            tokens = rnd.Next(16, 33);
            ellipses = new Ellipse[tokens];
            player = true;
            GeneratePlayingField();
        }

        void Quit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}