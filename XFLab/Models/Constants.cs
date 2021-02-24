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

        public const string APP_ANALYTICS_ANDROID_KEY = "android=80c49ef1-6d9d-47f7-8903-714df3f1dd0f;";
        public const string APP_ANALYTICS_IOS_KEY = "ios=9388fbba-7d9d-4fca-b195-07b53925529f;";

    }
}
