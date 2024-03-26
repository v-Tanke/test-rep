using System.Collections.Generic;

namespace WebApplication1.Data.Models
{
    public class Hall  //Зал
    {
        public int Id { get; set; }

        public string HallName { get; set; }

        public int HallCapacity { get; set; }

        public string HallGraphic { get; set;} // 2D or 3D

        public List<Seat> SeatList { get; set; }
    }
}
