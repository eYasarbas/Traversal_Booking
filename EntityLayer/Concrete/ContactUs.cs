﻿namespace EntityLayer.Concrete
{
    public class ContactUs
    {
        public int ContactUsId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; } = DateTime.UtcNow;
        public bool MessageSatus { get; set; }
    }
}
