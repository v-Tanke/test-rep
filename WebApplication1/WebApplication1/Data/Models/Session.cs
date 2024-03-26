namespace WebApplication1.Data.Models
{
    public class Session
    {
        public int Id { get; set; }

        public string SessionDate { get; set; }

        public string SessionTime { get; set; }

        public int FilmId { get; set; }

        public virtual Film Film { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public int HallId { get; set; }

        public virtual Hall Hall { get; set; }
    }
}
