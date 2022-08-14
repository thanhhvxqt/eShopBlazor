using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


public class ViewLogin
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
}
public class ViewWebLogin
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
}
public class ViewWebClientLogin
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
}
public class ViewToken
{
    public string Token { get; set; }
    public string KhachhangId { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string NgayThamGia { get; set; }
}

