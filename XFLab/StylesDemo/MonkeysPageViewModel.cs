using System.Collections.Generic;
using XFLab.Models;

namespace MonkeyApp.ViewModels
{
    public class MonkeysPageViewModel
    {
        public IList<Animal> Monkeys { get; private set; }

        public MonkeysPageViewModel()
        {
            Monkeys = MonkeyData.Monkeys;
        }
    }
}
