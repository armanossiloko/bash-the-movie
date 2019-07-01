using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM.Models
{
    /*public enum AttachmentType { Json, Text }

    public class Attachment
    {
        public object Content { get; set; }
        public string FileName { get; set; }
        public AttachmentType Type { get; set; }

        public Attachment(string FileName, object Content)
        {
            this.FileName = FileName;
        }

        public async Task<MemoryStream> ContentToStreamAsync()
        {
            string Text;
            switch (Type)
            {
                case AttachmentType.Json:
                    Text = Newtonsoft.Json.JsonConvert.SerializeObject(Content);
                    break;
                case AttachmentType.Text:
                    Text = Content.ToString();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var Stream = new MemoryStream();
            var Writer = new StreamWriter(Stream, Encoding.UTF8);
            await Writer.WriteAsync(Text);
            await Writer.FlushAsync();
            Stream.Position = 0;
            return Stream;
        }
    }*/
}
