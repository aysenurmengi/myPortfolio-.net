namespace myPortfolio.DAL.Entities
{
    public class SocialMedia //alttaki sosyal medya hesaplarının yer aldığı kısım
    {
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; } // hesap linki
        public string Icon { get; set; }
    }
}
