using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using XFLab.Models;

namespace XFLab.Views
{
    public partial class DesignTimeDataDemo : ContentPage
    {
        public List<Animal> Animals { get; set; }
        public List<string> Items { get; set; }
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public DesignTimeDataDemo()
        {
            InitializeComponent();
            Name = "RunTime Name: Subramanyam Raju";
            ProfilePicture = "xamarinstore.jpg";

            Items = new List<string>();
            Items.Add("RunTime Item One");
            Items.Add("RunTime Item Two");
            Items.Add("RunTime Item Three");

            Animals = new List<Animal>();
            Animals.Add(new Animal { Name = "RunTime Baboon", Location = "Africa and Asia" });
            Animals.Add(new Animal { Name = "RunTime Capuchin Monkey", Location = "Central and South America" });
            Animals.Add(new Animal { Name = "RunTime Blue Monkey", Location = "Central and East Africa" });
            BindingContext = this;
        }

    }
}
