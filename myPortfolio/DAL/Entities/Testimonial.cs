namespace myPortfolio.DAL.Entities
{
    public class Testimonial //referans kısmı 
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; } // yorum yapan kişinin ad soyad
        public string Title { get; set; } //kişinin ünvanı
        public string Description { get; set; } // kişinin yorumu
        public string ImageUrl { get; set; } //kişinin resmi
    }
}
