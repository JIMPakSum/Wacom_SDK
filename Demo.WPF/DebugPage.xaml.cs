using Demo.WPF.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace Demo.WPF
{
    /// <summary>
    /// Interaction logic for DebugPage.xaml
    /// </summary>
    public partial class DebugPage : Window , INotifyPropertyChanged
    {
        private readonly WritingsDbContext db = new WritingsDbContext();

        public DebugPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Database.EnsureCreated();

            //Debug.WriteLine(db.Database.EnsureCreated());

            db.ChAssessments.Load();
            db.EngAssessments.Load();
            db.StrokeDatas.Load();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
