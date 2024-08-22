namespace myPortfolio.DAL.Entities
{
    public class Feature //ilk karşımıza çıkan alan(home kısmı)
    {
        public int FeatureId { get; set; }
        public string Title { get; set; } //homethere yazan kısım
        public string Description { get; set; } //adım soyadım mesleğim kısmı
    }
}
