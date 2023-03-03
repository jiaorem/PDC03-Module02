using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity5 : ContentPage
    {
        ObservableCollection<employee> employees = new ObservableCollection<employee>();

        public ObservableCollection<employee> Employees { get { return employees; } }
        public Activity5()
        {
            InitializeComponent();

            {
                lst.ItemsSource = employees;

                employees.Add(new employee { DisplayName = "Mina", Position = "President", ProfileImage="mina.jpg" });
                employees.Add(new employee { DisplayName = "Chaewon", Position = "Vice President", ProfileImage = "chaewon.jpg" });
                employees.Add(new employee { DisplayName = "Minji", Position = "Secretary", ProfileImage = "https://image.kpopmap.com/2022/03/idol-vs-model-twice-mina_cover-image.jpg" });
            }
        }
    }
}