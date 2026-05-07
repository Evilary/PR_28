using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TaskManager_Чернышков.Classes
{
    public class Notification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
