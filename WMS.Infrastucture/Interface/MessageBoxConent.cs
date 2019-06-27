using System;
using System.Windows;
using Microsoft.Practices.Prism.Events;

namespace WMS.Infrastucture.Interface
{
    public enum MessageType
    {
        INFO,
        ERROR,
        QUESTION,
        WARNING,
        STOP
    }
    public enum MessageBoxButtons
    {
        OK,
        OKCancel,
        YesNo,
        YesNoCancel
    }

    public enum MessageBoxIcon
    {
        Information,
        Error,
        Warning,
        Exclaimation,
        Question,
        Stop
    }
    public class MessageBoxEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public Action<bool> CallbackAction { get; set; }
        public bool IsModalMessage { get; set; }
        public MessageType MessageType { get; set; }
    }
    public class MessageBoxEvent : CompositePresentationEvent<MessageBoxEventArgs>
    {
    }
    public class MessageBoxConent
    {
        public string Message { get; set; }
        public MessageBoxButtons MessageBoxButton { get; set; }
        public MessageBoxIcon MessageBoxImage { get; set; }
        public bool IsModalWindow { get; set; }
        public Window ParentWindow { get; set; }
    }
}
