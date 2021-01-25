using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TranslateSeq
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TranslateSeqService : ITranslateSeq
    {
        public string TestFunc(string sequence)
        {
            return sequence + "works.";
        }

        public string Translate(string sequence)
        {
            try
            {
                byte[] strBytes = Encoding.UTF8.GetBytes(sequence);
                MemoryStream string_stream = new MemoryStream(strBytes);
               
                var parser_obj = new Bio.IO.FastA.FastAParser();

                var parsedSeq = parser_obj.Parse(string_stream).First();

                var translated = (Bio.Sequence)Bio.Algorithms.Translation.ProteinTranslation.Translate(
                    Bio.Algorithms.Translation.Transcription.Transcribe(parsedSeq));

                return translated.ConvertToString();
            }
            catch
            {
                return "There was something wrong! Check your input format (FASTA) or check your connection.";
            }
        }
    }
}
