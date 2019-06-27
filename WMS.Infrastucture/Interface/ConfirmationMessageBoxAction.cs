using System.Windows;
using System.Windows.Interactivity;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;

namespace WMS.Infrastucture.Interface
{
    public class ConfirmationMessageBoxAction : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            var args = parameter as InteractionRequestedEventArgs;
            if (args != null)
            {
                var confirmation = args.Context as Confirmation;
                if (confirmation != null)
                {
                    var content = confirmation.Content as MessageBoxConent;
                    //var window = new ConfirmationWindow
                    //{
                    //    DataContext = new MessageBoxViewModel
                    //    {
                    //        Message = (content != null ? content.Message : ""),
                    //        MessageBoxButton = (content != null ? content.MessageBoxButton : MessageBoxButtons.OK),
                    //        MessageBoxImage = (content != null ? content.MessageBoxImage : MessageBoxIcon.Information),
                    //        Title = confirmation.Title,
                    //        Confirmation = confirmation
                    //    },
                    //    Owner = (content != null ? content.ParentWindow : null),
                    //    Icon = ((content != null && content.ParentWindow != null) ? content.ParentWindow.Icon : null)

                    //};
                    //EventHandler closeHandler = null;
                    //closeHandler = (sender, e) =>
                    //{
                    //    window.Closed -= closeHandler;
                    //    args.Callback();
                    //};
                    //window.Closed += closeHandler;

                    //var buttonType = window.ViewModel.MessageBoxButton;
                    //switch (buttonType)
                    //{
                    //    case MessageBoxButtons.OK:
                    //        window.btnOk.Focus();
                    //        break;
                    //    case MessageBoxButtons.OKCancel:
                    //        window.btnOk.Focus();
                    //        break;
                    //    case MessageBoxButtons.YesNo:
                    //        window.btnYes.Focus();
                    //        break;
                    //    case MessageBoxButtons.YesNoCancel:
                    //        window.btnYes.Focus();
                    //        break;
                    //    default:
                    //        break;
                    //}

                    //if (content != null && content.IsModalWindow)
                    //{
                    //    window.ShowDialog();

                    //}
                    //else
                    //{
                    //    window.Show();
                    //}
                }
            }

        }
    }

}
