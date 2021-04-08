using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLBS.Models
{
    [Table("Chitietdonhangs")]
    public class Chitietdonhang
    {

        public virtual Donhang Donhang { get; set; }
        [DisplayName("Mã đơn hàng ")]
        public string madh { get; set; }

        public virtual Sach Sach { get; set; }
        [DisplayName("Mã sách ")]
        public string masach { get; set; }

        [Key]

        [DisplayName("Số lượng đơn hàng ")]
        public string soluong { get; set; }

        [DisplayName("Đơn giá")]
        public string dongia { get; set; }

    }
}