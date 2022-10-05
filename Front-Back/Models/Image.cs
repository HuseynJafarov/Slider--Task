using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Front_Back.Models
{
    public class Image:BaseEntity
    {
        public string ImgUrl { get; set; }
    }
}
