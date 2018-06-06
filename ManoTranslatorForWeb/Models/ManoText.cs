using System;

namespace ManoTranslatorForWeb.Models
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
