namespace myPortfolio.DAL.Entities
{
    public class Skill //about kısmının sağ tarafı - yetenekler
    {
        public int SkillId { get; set; }
        public string Title { get; set; } // yetenek kısmının başlığı
        public int Value { get; set; } //skill'in yeteneğini tutacak % olarak
    }
}
