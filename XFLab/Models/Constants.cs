using System.Collections.Generic;
using Xamarin.Forms;
using XFLab.Models;

namespace XFLab
{
    public static class AppConstants
    {
        public static List<VeggieModel> Veggies = new List<VeggieModel>
        {
            new VeggieModel() { Name = "Tomato", Comment = "actually a fruit", IsAVeggie = false, Image="tomato.png" },
            new VeggieModel() { Name = "Pizza", Comment = "no comment", IsAVeggie = false, Image = "pizza.png" },
            new VeggieModel() { Name = "Romaine Lettuce", Comment = "good in salads", IsAVeggie = true, Image = "lettuce.png" },
            new VeggieModel() { Name = "Zucchini", Comment = "grows relatively easily", IsAVeggie = true, Image = "zucchini.png" }
        };

        public static double NormalFontSize = 18;
        public static string Idiom = Device.Idiom.ToString();
    }
}
