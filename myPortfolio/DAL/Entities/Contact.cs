namespace myPortfolio.DAL.Entities
{
    public class Contact // giriş ve iletişim kısmının sağ tarafı
    {
        public int ContactId { get; set; }
        public string Title { get; set; } //contact kısmının başlığı
        public string Description { get; set; } //başlık altındaki mini açıklama
        public string Phone1 { get; set; } //phone başlık
        public string Phone2 { get; set; } //phone numara
        public string Email1 { get; set; } // mail başlık
        public string Email2 { get; set; }
        public string Address { get; set; } // adres bilgisi
    }
}
