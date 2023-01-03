using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class Usuario : BaseEntity
{
    public string UserName { get; set; }
    public string Pass { get; set; }
    public DateTime FechaCreacion { get; set; }
}
