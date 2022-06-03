using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DevExpress.Mvvm;
using Microsoft.UI.Xaml;

namespace winui_mvvm_custom_service {
    public class ViewModel : ViewModelBase {
        public ICommand LockUpdatesCommand { get; set; }
        public ICommand UnlockUpdatesCommand { get; set; }
        public ObservableCollection<Customer> Customers { get; set; }
        public IUpdateService GridUpdateService => GetUIService<IUpdateService>();

        DispatcherTimer updateTimer = new DispatcherTimer();
        Random rnd = new Random();
        public ViewModel() {
            LockUpdatesCommand = new DelegateCommand(LockUpdates);
            UnlockUpdatesCommand = new DelegateCommand(UnlockUpdates);
            Customers = new ObservableCollection<Customer>();
            for (int i = 1; i < 5; i++) {
                Customers.Add(new Customer() { ID = i, Name = "Name" + i });
            }
            updateTimer.Interval = new TimeSpan(0, 0, 1);
            updateTimer.Tick += UpdateRandomItem;
            updateTimer.Start();
        }

        private void UpdateRandomItem(object sender, object e) {
            Customers.Add(new Customer() { ID = Customers.Count, Name = "Name" + Customers.Count });
        }
        public void LockUpdates() { GridUpdateService.BeginUpdate(); }
        public void UnlockUpdates() { GridUpdateService.EndUpdate(); }
    }

    public class Customer { 
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
