using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class MonAn
{
    public enum PhanLoai
    {
        [Display(Name = "Đồ Ăn Nhanh")]
        DoAnNhanh = 1,
        [Display(Name = "Combo")]
        Combo = 2,
        [Display(Name = "Nước")]
        Drink = 3
    }
    [Key]
    [Column("MonAnID")]
    public int Id { get; set; }
    [DisplayName("Tên món ăn")]
    [Column(TypeName = "nvarchar(50)")]
    [StringLength(50)]
    [Required(ErrorMessage = "Phải nhập tên món ăn")]
    public string Name { get; set; }
    [Column(TypeName = "money")]
    [DisplayName("Giá")]
    [Required, Range(1, int.MaxValue, ErrorMessage = "Phải nhập giá")]
    public decimal Gia { get; set; }
    [DisplayName("Số lượng")]
    [Required, Range(1, int.MaxValue, ErrorMessage = "Phải nhập số lượng")]
    public int Quantity { get; set; }
    //[Required, Range(1, int.MaxValue, ErrorMessage = "Hãy chọn loại")]
    [DisplayName("Phân loại")]
    public PhanLoai phanLoai { get; set; }
    //    [Column(TypeName = "nvarchar(250)")]
    //    [DisplayName("Hình ảnh")]
    //    public string Hinh { get; set; }
    //[NotMapped]
    //[DataType(DataType.Upload)]
    //[Required(ErrorMessage = "Chon file upload")]
    //[DisplayName("File ")]
    //[FileExtensions(Extensions = "png,jpg,jpeg,gif")]
    //public IFormFile ImageFile { get; set; }
    [Column(TypeName = "nvarchar(250)")]
    [Required(ErrorMessage = "Phải nhập mô tả")]
    public string MoTa { get; set; }
    [DisplayName("Đang phục vụ")]
    [Required(ErrorMessage = "Phải nhập trạng thái")]
    public bool TrangThai { get; set; }
    public int Views { get; set; }
    //public List<ProductNCategoryProduct> ProductNCategoryProducts { get; set; }
    public List<ProductPhoto> Photos { get; set; }

    public Category Category { get; set; }
    [ForeignKey("Category")]
    public int? CategoryID { get; set; }
}

