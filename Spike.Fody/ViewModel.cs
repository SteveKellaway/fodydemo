using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Spike.Fody
{
    // TODO Cannot add [Reactive] here
    public class ViewModel : ReactiveObject ///MUST derive from ReactiveObject somewhere in the hierarchy
    {
        [Reactive] //TODO does not warn that class does not implement INotifyPropertyChanged
        public string LastName { get; set; }
    }
}
