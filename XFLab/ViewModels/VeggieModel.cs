using System.Collections.ObjectModel;

namespace ListAndCollectionViewDemos
{
    public class VeggieModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }
        public bool IsReallyAVeggie { get; set; }
        public bool IsAVeggie { get; set; } //set false for de jure vegetables, like pizza
        public string Image { get; set; }
    }

    public class GroupedVeggieModel : ObservableCollection<VeggieModel>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}

