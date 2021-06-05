﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class Iznajmljivanje
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public int IDKlijenta { get; set; }
        [Required]
        public int IDVozila { get; set; }
        [Required]
        public int IDVozaca { get; set; }
        [Required]
        public int IDAdmin { get; set; }
        [Required]
        public double Cijena { get; set; }
        [Required]
        public string Lokacija { get; set; }
        [Required]
        [EnumDataType(typeof(Stanje))]
        public Stanje Stanje { get; set; }
        public string Komentar { get; set; }
        public int Popust { get; set; }
        [Required]
        public string NacinPlacanja { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumPreuzmanja { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumVracanja { get; set; }
    }
}
