using System;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Spike.Fody
{
    public class ReactiveViewModel : ReactiveObject ///MUST derive from ReactiveObject somewhere in the hierarchy
    {
        [Reactive]
        public string LastName { get; set; }

        [Reactive]
        public string FirstName { get; set; }

        [Reactive]
        public string FullName { get; private set; }

        public ReactiveViewModel()
        {
            this.WhenAnyValue(x => x.LastName, x => x.FirstName,
                (x, y) => $"{x} {y}".Trim()).Subscribe(x => FullName = x);
        }
    }
}