using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Backend.Model
{
    public interface IEntity<T>
    {
        [Key]
        T Id { get; set; }
    }
}
