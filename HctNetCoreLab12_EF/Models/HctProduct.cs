using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HctNetCoreLab12_EF.Models
{
    [Table("HctProduct")]
    public class HctProduct
    {
        [Key]
        public int HctID { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(150,ErrorMessage ="Tên sản phẩm không được vượt quá 150 ký tự")]
        [Column(TypeName = "nvarchar(150)")]
        public string? HctName { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string? HctImage { get; set; }
        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public float HctPrice { get; set; }
        public float HctSalePrice { get; set; }
        public byte HctStatus { get; set; }
        [StringLength(1000, ErrorMessage = "Mô tả sản phẩm không được vượt quá 1000 ký tự")]
        [Column(TypeName = "ntext")]
        public string? HctDescription { get; set; }
        [Required(ErrorMessage = "Danh mục sản phẩm không được để trống")]
        public int HctCategoryID { get; set; }
        public DateTime HctCreatedDate { get; set; }
        //Khóa ngoại tới bảng category
        public HctCategory? HctCategory { get; set; }

    }
}
