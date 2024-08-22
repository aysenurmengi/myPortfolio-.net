namespace myPortfolio.DAL.Entities
{
    public class Message //contact kısmındaki sol taraf - mesaj alanı
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; } // gönderen ad soyad
        public string Subject { get; set; } // mesajın konusu
        public string Email { get; set; } // gönderen mail
        public string MessageDetail { get; set; } //mesajın içeriği
        public DateTime SendDate { get; set; } // mesajın gönderilme tarihi
        public bool IsRead { get; set; }
    }
}
