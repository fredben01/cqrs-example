

namespace Banking.Cqrs.Core.Messages
{
    public abstract class Message
    {
        public String Id { get; set; } = string.Empty;

        public Message(string id) {
            Id = id;
        }
    }
}
