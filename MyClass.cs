using System.ComponentModel;

namespace ReactiveUI.SourceGenerators.Repro1;

public class MyReactiveBase : IReactiveObject
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event PropertyChangingEventHandler? PropertyChanging;

    public void RaisePropertyChanging(PropertyChangingEventArgs args)
    {
        throw new NotImplementedException();
    }

    public void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
        throw new NotImplementedException();
    }
}

public partial class MyClass : MyReactiveBase
{
    [Reactive] public partial string TestProp { get; set; }
}