using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHero.Models
{
    public class SuperHeroes
    {
        [Key]
        public int ID { get; set; }
        public string HeroName { get; set; }
        public string AlterEgoName { get; set; }
        public string MainAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}