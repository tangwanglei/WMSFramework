
namespace WMS.Infrastucture.Interface
{
    public interface IMessageBoxViewModel
    {
        MessageBoxButtons MessageBoxButton { get; set; }
        MessageBoxIcon MessageBoxImage { get; set; }
        string Title { get; set; }
        string Message { get; set; }
    }
}
