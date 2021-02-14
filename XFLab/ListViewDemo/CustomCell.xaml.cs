using System.Collections.ObjectModel;
using Xamarin.Forms;
using XFLab.Models;

namespace ListAndCollectionViewDemos
{

    public partial class CustomCell : ContentPage
	{
		public ObservableCollection<VeggieModel> veggies { get; set; }
		public CustomCell()
		{
            InitializeComponent();

            veggies = new ObservableCollection<VeggieModel> ();
			veggies.Add (new VeggieModel{ Name="Tomato", Type="Fruit", Image="tomato.png"});
			veggies.Add (new VeggieModel{ Name="Romaine Lettuce", Type="Vegetable", Image="lettuce.png"});
			veggies.Add (new VeggieModel{ Name="Zucchini", Type="Vegetable", Image="zucchini.png"});
            lstView.ItemsSource = veggies;
        }
    }
}

