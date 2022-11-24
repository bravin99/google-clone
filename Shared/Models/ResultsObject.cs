using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleClone.Shared.Models
{
    public class ResultObject
    {
        public enum ResultType
        {
            File,
            Webpage,
            Video
        }

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ResultType Type { get; set; }
        public DateTime Updated { get; set; }
    }
}