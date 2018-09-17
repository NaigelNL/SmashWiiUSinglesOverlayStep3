using SmashWiiUOverlayManager.Models;
using SmashWiiUOverlayManager.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SmashWiiUOverlayManager
{
    public partial class MainWindow : Window
    {
        public MainViewModel MainViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel();

            // create new grid
            Grid newGrid = new Grid();
            //newGrid.ShowGridLines = true;

            // first main column
            newGrid.ColumnDefinitions.Add(new ColumnDefinition());
            List<Control> controlsMainColumn = new List<Control>();

            controlsMainColumn.Add(TitleLabel("Current round"));
            TextBox currentRoundBox = new TextBox();
            currentRoundBox.TextChanged += delegate { int parsed = 0; int.TryParse(currentRoundBox.Text, out parsed); MainViewModel.currentRound = parsed; currentRoundBox.Text = parsed.ToString(); };
            controlsMainColumn.Add(currentRoundBox);

            controlsMainColumn.Add(TitleLabel("Best of"));
            TextBox bestOfBox = new TextBox();
            bestOfBox.TextChanged += delegate { int parsed = 0; int.TryParse(bestOfBox.Text, out parsed); MainViewModel.bestOf = parsed; bestOfBox.Text = parsed.ToString(); };
            controlsMainColumn.Add(bestOfBox);

            controlsMainColumn.Add(TitleLabel(""));// for spacing

            Button submitButton = new Button();
            submitButton.Content = "Submit";
            submitButton.Click += delegate { MainViewModel.UpdateInformation(); };
            controlsMainColumn.Add(submitButton);

            for (int i = 0; i < controlsMainColumn.Count; i++)
            {
                Grid.SetColumn(controlsMainColumn[i], 0);
                Grid.SetRow(controlsMainColumn[i], i);
                newGrid.Children.Add(controlsMainColumn[i]);
            }

            int totalRows = controlsMainColumn.Count;// keep track of total amount of rows we need

            newGrid.ColumnDefinitions.Add(new ColumnDefinition());// empty column

            // player columns
            for (int i = 0; i < MainViewModel.players.Length; i++)
            {
                int currentIndex = i;// for use with delegate functions
                Player p = MainViewModel.players[currentIndex];

                int currentColumn = newGrid.ColumnDefinitions.Count;
                newGrid.ColumnDefinitions.Add(new ColumnDefinition());

                List<Control> controls = new List<Control>();

                controls.Add(TitleLabel("Player name"));
                TextBox playerNameBox = new TextBox();
                playerNameBox.TextChanged += delegate { p.name = playerNameBox.Text; };
                controls.Add(playerNameBox);

                controls.Add(TitleLabel("Player sponsor"));
                TextBox playerSponsorBox = new TextBox();
                playerSponsorBox.TextChanged += delegate { p.sponsor = playerSponsorBox.Text; };
                controls.Add(playerSponsorBox);

                controls.Add(TitleLabel("Player Twitter"));
                TextBox playerTwitterBox = new TextBox();
                controls.Add(playerTwitterBox);
                playerTwitterBox.TextChanged += delegate { p.twitter = playerTwitterBox.Text; };

                controls.Add(TitleLabel("Player score"));
                TextBox playerScoreBox = new TextBox();
                controls.Add(playerScoreBox);
                playerScoreBox.TextChanged += delegate { int parsed = 0; int.TryParse(playerScoreBox.Text, out parsed); p.score = parsed; playerScoreBox.Text = parsed.ToString(); };

                controls.Add(TitleLabel("Player character"));
                ComboBox playerCharacterBox = new ComboBox();
                playerCharacterBox.DisplayMemberPath = "Name";
                playerCharacterBox.ItemsSource = MainViewModel.CharacterList;
                playerCharacterBox.SelectedIndex = 0;
                playerCharacterBox.SelectionChanged += delegate { p.selectedCharacter = playerCharacterBox.SelectedItem as Character; };
                MainViewModel.players[i].selectedCharacter = playerCharacterBox.SelectedItem as Character;//set default, so it's not null
                controls.Add(playerCharacterBox);

                controls.Add(TitleLabel("Player port"));
                ComboBox playerPortBox = new ComboBox();
                controls.Add(playerPortBox);
                playerPortBox.DisplayMemberPath = "Name";
                playerPortBox.ItemsSource = MainViewModel.PortList;
                playerPortBox.SelectedIndex = 0;
                playerPortBox.SelectionChanged += delegate { p.selectedPort = playerPortBox.SelectedItem as Port; };
                MainViewModel.players[i].selectedPort = playerPortBox.SelectedItem as Port;// again avoid null
                //Button button = new Button();
                //button.Click += delegate { Console.WriteLine(string.Format("i {0}", currentIndex)); };
                //controls.Add(button);

                for (int j = 0; j < controls.Count; j++)
                {
                    Grid.SetColumn(controls[j], currentColumn);
                    Grid.SetRow(controls[j], j);
                    newGrid.Children.Add(controls[j]);
                }

                if (totalRows < controls.Count)
                {
                    totalRows = controls.Count;
                }
            }

            newGrid.ColumnDefinitions.Add(new ColumnDefinition());

            // after creating column, check what the totalrows needs to be
            for (int i = 0; i < totalRows; i++)
            {
                var row = new RowDefinition();
                row.Height = GridLength.Auto;
                newGrid.RowDefinitions.Add(row);
            }

            this.Content = newGrid;
            this.DataContext = this;
        }

        private Label TitleLabel(string content)
        {
            var l = new Label();
            l.FontWeight = FontWeights.Bold;
            l.Content = content;
            return l;
        }
    }
}