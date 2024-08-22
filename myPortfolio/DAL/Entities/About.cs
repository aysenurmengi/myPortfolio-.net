namespace myPortfolio.DAL.Entities
{
    public class About // about kısmının giriş ve sol kısmı
    {
        public int AboutId { get; set; }
        public string Title { get; set; } // about kısmmındaki büyük başlık
        public string SubDescription { get; set; } // ilk mini açıklama
        public string Details { get; set; } // about kısmındaki uzun açıklamam
    }
}
