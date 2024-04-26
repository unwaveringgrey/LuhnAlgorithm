using System.ComponentModel.DataAnnotations;

namespace ProgrammingPractice.DTOs
{
    public class LuhnDTO
    {

        [Required]
        public string luhnString { get; set; }
        public bool? luhnValid { get; set; }
    }
}
