using HalloEfCoreCodeFirst.Data;
using HalloEfCoreCodeFirst.Model;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace HalloEfCoreCodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EfContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = GetNewContext();
        }

        private EfContext GetNewContext()
        {
            var context = new EfContext();
            context.Database.EnsureCreated();
            return context;
        }

        private void LoadMitarbeiter(object sender, RoutedEventArgs e)
        {
            //myGrid.ItemsSource = _context.Mitarbeiter.Include(x => x.Abteilungen).ToList();
            myGrid.ItemsSource = _context.Mitarbeiter.ToList();
        }

        private void CreateDemoData(object sender, RoutedEventArgs e)
        {
            var abt1 = new Abteilung() { Bezeichnung = "Holz" };
            var abt2 = new Abteilung() { Bezeichnung = "Steine" };

            var mitarbeiters = new List<Mitarbeiter>();

            for (int i = 0; i < 20; i++)
            {
                var m = new Mitarbeiter()
                {
                    Name = $"Fred #{i:000}",
                    GebDatum = DateTime.Now.AddYears(-30).AddDays(i * 17),
                    Job = "Macht dinge"
                };

                if (i % 2 == 0)
                    m.Abteilungen.Add(abt1);
                if (i % 3 == 0)
                    m.Abteilungen.Add(abt2);

                mitarbeiters.Add(m);
            }

            var ran = new Random();

            for (int i = 0; i < 500; i++)
            {
                var k = new Kunde()
                {
                    Name = $"Wilma #{i:000}",
                    GebDatum = DateTime.Now.AddYears(-30).AddDays(i * 17),
                    KdNummer = $"K{i:00000}"
                };
                var ranMitarbeiterIndex = ran.Next(mitarbeiters.Count - 1);
                k.Ansprechpartner = mitarbeiters[ranMitarbeiterIndex];
                _context.Add(k);
            }


            _context.AddRange(mitarbeiters);
            _context.SaveChanges();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
        }

        private void myGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (myGrid.CurrentItem is Mitarbeiter m)
            {
                //_context.Entry(m).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //MessageBox.Show($"{_context.Entry(m).State}");
                MessageBox.Show($"{m.Name} hat {m.Kunden.Count} Kunden ");

                _context.Entry(m).Collection(m => m.Kunden).Load(); //explzit loading

                MessageBox.Show($"{m.Name} hat {m.Kunden.Count} Kunden ");
            }
        }
    }
}