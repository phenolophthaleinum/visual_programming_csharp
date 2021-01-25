using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TranslateSeq
{
    [DataContract]
    public class TranslateSeq
    {
        [DataMember]
        public string sequence;
    }
}
