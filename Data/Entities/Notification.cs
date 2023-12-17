using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Notification : BaseEntity
    {
        public Guid UserId { get; set; }
        public bool Seen { get; set; } = false;
        public string Action { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public NotificationData Data { get; set; }
    }

    [ComplexType]
    public class NotificationData
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}