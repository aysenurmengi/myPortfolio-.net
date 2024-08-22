namespace myPortfolio.DAL.Entities
{
    public class Experience //experience kısmnın tamamı
    {
        public int ExperienceId { get; set; }
        public string Head { get; set; } // başlığımız - çalıştığımız yerin adı
        public string Title { get; set; } // ünvanımız
        public string Date { get; set; } // çalıştığımız tarihler
        public string Description { get; set; } // iş tanımı - kısa açıklama 
    }
}
