namespace Messil.Shared.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string BodyHtml { get; set; } = string.Empty;
        public string SenderId { get; set; } = string.Empty;
        public User Sender { get; set; } = new User();
        public List<string> RecieverId { get; set; } = new List<string>();
        public List<User> Reciever { get; set; } = new List<User>();
    }
}
