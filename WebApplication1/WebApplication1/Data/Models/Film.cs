using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Data.Models
{
    public class Film
    {
        public int Id { get; set; }

        public string FilmName { get; set; }

        public string FilmStartDate { get; set; } //начало показов

        public string FilmAgeRestrictions { get; set; } //возрастные ограничения

        public string FilmCategory { get; set; } //драма, мелодрама

        public string FilmTime { get; set; } //продолжительность

        public string FilmDescription { get; set;} //описание
    }
}
