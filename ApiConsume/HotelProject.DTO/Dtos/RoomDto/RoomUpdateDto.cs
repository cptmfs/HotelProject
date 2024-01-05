using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTO.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını giriniz..")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli ekleyiniz..")]
        public string CoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz..")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen başlık bilgisi giriniz..")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karater veri girişi yapınız")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz..")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisi giriniz..")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Lütfen wifi bilgisi giriniz..")]
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
