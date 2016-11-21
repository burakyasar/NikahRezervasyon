using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDugun.Models
{
    public class Rezervasyon
    {
        [Key]
        public int RezervasyonID { get; set; }
        [Required]
        [Display(Name ="Ad Soyad")]
        public string AdSoyad { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Mesaj { get; set; }
        [Display(Name ="Katılacak mısınız?")]
        public bool KatilacakMi { get; set; }
        public DateTime Tarih { get; set; }
        public string IP { get; set; }

        public Rezervasyon() {
            Tarih = DateTime.Now;
        }
    }
}