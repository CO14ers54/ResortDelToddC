using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Endpoint_HockeyExample.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45)]
        [Column(TypeName = "varchar(45)")]
        public string NameFirst { get; set; }
        [Required]
        [MaxLength(45)]
        [Column(TypeName = "varchar(45)")]
        public string NameLast { get; set; }
        [MaxLength(45)]
        [Column(TypeName = "varchar(45)")]
        public string NameMiddle { get; set; }
        [Required]
        public int HeightFeet { get; set; }
        [Required]
        public int HeightInches { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        [MaxLength(3)]
        [Column(TypeName = "varchar(3)")]
        public string ShotSide { get; set; }
        [Required]
        public DateTime Born { get; set; }
        //public string Country { get; set; }
        //public List<Position> Positions { get; set; }
        //public List<Team> Teams { get; set; }
    }

    public class PlayerWithCurrentTeam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45)]
        public string NameFirst { get; set; }
        [Required]
        [MaxLength(45)]
        public string NameLast { get; set; }
        [MaxLength(45)]
        public string NameMiddle { get; set; }
        [Required]
        public int HeightFeet { get; set; }
        [Required]
        public int HeightInches { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        [MaxLength(3)]
        public string ShotSide { get; set; }
        [Required]
        public DateTime Born { get; set; }
        public string CurrentTeamName { get; set; }
        public string CurrentTeamMascot { get; set; }
    }

    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45)]
        public string Name { get; set; }
        [Required]
        [MaxLength(45)]
        public string Mascot { get; set; }
        [Required]
        [MaxLength(4)]
        public string Abbreviation { get; set; }
    }

    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45)]
        public string Name { get; set; }
    }

    public class Position
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45)]
        public string Name { get; set; }
        [Required]
        [MaxLength(5)]
        public string Abbreviation { get; set; }
    }

    public class PlayersTeams
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int TeamId { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }

    public class PlayersPositions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public int SkillRank { get; set; }
    }

    public class PlayersCountry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
