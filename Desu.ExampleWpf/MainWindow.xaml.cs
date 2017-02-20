namespace ExampleWpf
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Media;

    using Annotations;

    using Wacton.Desu.Kanji;
    using Wacton.Tovarisch.Randomness;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private List<IKanjiDictionaryEntry> kanjiEntries = new List<IKanjiDictionaryEntry>();
        private IKanjiDictionaryEntry currentEntry;

        public MainWindow()
        {
            var kanjiDictionary = new KanjiDictionary();
            this.kanjiEntries = kanjiDictionary.GetEntries().ToList();
            this.UpdateKanji();

            InitializeComponent();
        }

        public string Text => this.currentEntry.Literal;

        public ObservableCollection<Geometry> Strokes { get; set; }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.UpdateKanji();
        }

        private void UpdateKanji()
        {
            var hasStrokePaths = false;
            while (!hasStrokePaths)
            {
                this.currentEntry = RandomSelection.SelectOne(this.kanjiEntries);
                hasStrokePaths = this.currentEntry.StrokePaths.Any();
            }

            Strokes = new ObservableCollection<Geometry>();
            foreach (var strokePath in this.currentEntry.StrokePaths)
            {
                Strokes.Add(Geometry.Parse(strokePath));
            }

            this.OnPropertyChanged(nameof(this.Text));
            this.OnPropertyChanged(nameof(this.Strokes));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
