using System;
using Xamarin.Forms;

namespace FormsGallery
{
    // Used in CollectionViewDemoPage and ListViewDemoPage
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, DateTime birthday, Color favoriteColor)
        {
            Name = name;
            Birthday = birthday;
            FavoriteColor = favoriteColor;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; private set; }

        public string Name { set; get; }

        public DateTime Birthday { set; get; }

        public Color FavoriteColor { set; get; }
    };
}
