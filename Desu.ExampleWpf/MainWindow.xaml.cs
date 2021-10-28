namespace Wacton.Desu.ExampleWpf
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Media;

    using Wacton.Desu.ExampleWpf.Properties;
    using Wacton.Desu.Kanji;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private readonly List<IKanjiEntry> kanjiEntries;
        private IKanjiEntry currentEntry;
        private readonly Random random = new Random();

        public MainWindow()
        {
            this.kanjiEntries = KanjiDictionary.ParseEntries().ToList();
            this.UpdateKanji();

            InitializeComponent();
        }

        public string Text => this.currentEntry.Literal;
        public string Meanings => this.GetEnglishMeanings();

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
                this.currentEntry = this.kanjiEntries[this.GetRandomIndex()];
                hasStrokePaths = this.currentEntry.StrokePaths.Any();
            }

            this.Strokes = new ObservableCollection<Geometry>();
            foreach (var strokePath in this.currentEntry.StrokePaths)
            {
                this.Strokes.Add(Geometry.Parse(strokePath));
            }

            this.OnPropertyChanged(nameof(this.Text));
            this.OnPropertyChanged(nameof(this.Meanings));
            this.OnPropertyChanged(nameof(this.Strokes));
        }

        private int GetRandomIndex()
        {
            return this.random.Next(0, this.kanjiEntries.Count - 1);
        }

        private string GetEnglishMeanings()
        {
            var englishMeanings = this.currentEntry.Meanings
                .Where(meaning => meaning.Language == Wacton.Desu.Enums.Language.English)
                .Select(meaning => meaning.Term);

            return string.Join(" · ", englishMeanings);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
