using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ApiProblemModel
{
    public int StatusCode { get; set; }
    public List<string> Message { get; set; }
    public bool IsSuccess { get; set; } = false;
    public AppUser user { get; set; }
}

