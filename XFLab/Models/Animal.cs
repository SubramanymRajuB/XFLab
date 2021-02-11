namespace XFLab.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsMischievous { get; set; }
        public bool IsFavorite { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
