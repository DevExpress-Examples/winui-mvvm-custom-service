using DevExpress.WinUI.Core;
using DevExpress.WinUI.Grid;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace winui_mvvm_custom_service
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window {
        public ViewModel ViewModel { get; set; }
        public MainWindow() {
            this.InitializeComponent();
            ViewModel = new ViewModel();
        }
    }
    public interface IUpdateService {
        void BeginUpdate();
        void EndUpdate();
    }
    public class GridUpdateService : UIServiceBase<GridControl>, IUpdateService {
        public void BeginUpdate() {
            AssociatedObject?.BeginDataUpdate();
        }
        public void EndUpdate() {
            AssociatedObject?.EndDataUpdate();
        }
    }
}
