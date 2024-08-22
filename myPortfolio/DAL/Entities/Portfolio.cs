namespace myPortfolio.DAL.Entities
{
    public class Portfolio // projelerimizi gösterdiğimiz kısım
    {
        public int PortfolioId { get; set; }
        // açıklama kısmını statik olarak giricez

        //projelerin olduğu kutular
        public string Title { get; set; } // ana başlığı
        public string SubTitle { get; set; } // mini tanımı
        public string ImageUrl { get; set; } // proje kağpağındaki resim
        public string Url { get; set; } // proje linki
        public string Description { get; set; }

    }
}
