using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCameraSample
{
    public class KnownFace
    {
        public Microsoft.ProjectOxford.Face.Contract.Face Face { get; set; } = null;
        public Guid PersonId { get; set; }
        public string PersonName { get; set; }
    }
}
