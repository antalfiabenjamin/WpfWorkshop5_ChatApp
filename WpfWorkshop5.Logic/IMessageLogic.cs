namespace WpfWorkshop5.Logic
{
    public interface IMessageLogic
    {
        void Create(Message item);
        IEnumerable<Message> ReadAll();
    }
}