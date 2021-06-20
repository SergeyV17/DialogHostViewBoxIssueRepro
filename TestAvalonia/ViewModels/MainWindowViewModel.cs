using ReactiveUI;
using System.Reactive;

namespace TestAvalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> OpenDialogCommand { get; }

        public MainWindowViewModel()
        {
            OpenDialogCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await DialogHost.DialogHost.Show("TestContent", "Test");
            });
        }
    }
}
