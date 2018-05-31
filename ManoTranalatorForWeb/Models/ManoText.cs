using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManoTranalatorForWeb.Models
{
    public class ManoText
    {
        public string Id { get; set; }
        public string InputText { get; set; }
        public string OutputText { get; set; }

        public ManoText()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
