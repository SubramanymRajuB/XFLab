using System.Collections.Generic;
using MonkeyApp.Models;
using XFLab.Models;

namespace MonkeyApp.ViewModels
{
    public class MonkeysPageViewModel
    {
        public IList<Monkey> Monkeys { get; private set; }

        public MonkeysPageViewModel()
        {
            Monkeys = MonkeyData.Monkeys;
        }
    }
}
