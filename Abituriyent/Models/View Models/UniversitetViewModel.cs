using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abituriyent.Models.View_Models
{
    public class UniversitetViewModel
    {
        public List<Universitet> Universitets { get; set; }
        public List<Fakulte> fakultes { get; set; }

        public List<Umumi> umumis { get; set; }
        public List<Qrup> qrups { get; set; }
        public List<Ixtisa> Ixtisas { get; set; }
        public List<TehsilFormasi> tehsilFormasis { get; set; }

    }
}