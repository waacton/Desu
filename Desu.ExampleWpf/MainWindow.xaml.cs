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
            kanjiEntries = KanjiDictionary.ParseEntries().ToList();
            UpdateKanji();

            InitializeComponent();
        }

        public string Text => currentEntry.Literal;
        public string Meanings => GetEnglishMeanings();

        public ObservableCollection<Geometry> Strokes { get; set; }

        private void OnNextButtonClick(object sender, RoutedEventArgs e) => UpdateKanji();
        
        private void UpdateKanji()
        {
            var hasStrokePaths = false;
            while (!hasStrokePaths)
            {
                currentEntry = kanjiEntries[GetRandomIndex()];
                hasStrokePaths = currentEntry.StrokePaths.Any();
            }

            Strokes = new ObservableCollection<Geometry>();
            foreach (var strokePath in currentEntry.StrokePaths)
            {
                Strokes.Add(Geometry.Parse(strokePath));
            }

            OnPropertyChanged(nameof(Text));
            OnPropertyChanged(nameof(Meanings));
            OnPropertyChanged(nameof(Strokes));
        }

        private int GetRandomIndex()
        {
            return random.Next(0, kanjiEntries.Count - 1);
        }

        private string GetEnglishMeanings()
        {
            var englishMeanings = currentEntry.Meanings
                .Where(meaning => meaning.Language.Equals(Enums.Language.English))
                .Select(meaning => meaning.Term);

            return string.Join(" · ", englishMeanings);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
