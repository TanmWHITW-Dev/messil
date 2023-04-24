namespace Messil.Shared.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string SenderId { get; set; } = string.Empty;
        public User Sender { get; set; } = new User();
        public string RecieverId { get; set; } = string.Empty;
        public User Reciever { get; set;} = new User();
    }
}   
