using Front_Back.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_Back.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }

        public Image Images { get; set; }

        public IEnumerable<Work> Works { get; set; }

    }
}
