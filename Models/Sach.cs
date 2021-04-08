using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLBS.Models
{
    [Table("Sachs")]
    public  class Sach
    {
        [Key]

        [DisplayName("Mã sách")]
        public string masach { get; set; }

        [DisplayName("Tên sách ")]
        public string tensach { get; set; }

        [DisplayName("Gía bán ")]
        [Column(TypeName = "numeric")]
        public decimal? giaban { get; set; }

        [DisplayName("Mô tả ")]
        public string mota { get; set; }

        [DisplayName("Ảnh bìa")]
        [StringLength(50)]
        public string anhbia { get; set; }

        [DisplayName("Ngày cập nhật ")]
        public DateTime? ngaycapnhat { get; set; }

        [DisplayName(" Số lượng tồn")]
        public string soluongton { get; set; }

        public virtual Nhaxuatban Nhaxuatban { get; set; }

        [DisplayName("Mã nhà xuất bản ")]
        public string manxb { get; set; }

        public virtual Chude Chude { get; set; }

        [DisplayName("Mã chủ đề ")]
        public string machude { get; set; }
    }
}
