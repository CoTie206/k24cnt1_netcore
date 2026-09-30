using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HctNetCoreLab12_EF.Models
{
    [Table("HctCategory")]
    public class HctCategory
    {
        [Key]
        public int HctID { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string? HctName { get; set; }
        [Column(TypeName = "tinyint")]
        public byte HctStatus { get; set; }
        public DateTime HctCreatedDate { get; set; }
        //danh sách sản phẩm thuộc danh mục
        public ICollection<HctProduct>? HctProducts { get; set; }
    }
}
