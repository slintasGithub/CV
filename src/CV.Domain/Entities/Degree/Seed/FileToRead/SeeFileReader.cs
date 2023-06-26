using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Entities.Degree.Seed.FileToRead
{
    public class SeedFileReader
    {
        public static byte[]? ReadPdfFile(string fileName)
        {
            byte[] _Buffer = null;

            try
            {
                string currentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName + "\\CV.Domain\\Entities\\Degree\\Seed\\FileToRead\\";

                System.IO.FileStream _FileStream = new System.IO.FileStream(currentDirectory + "\\" + fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                System.IO.BinaryReader _BinaryReader = new System.IO.BinaryReader(_FileStream);

                long _TotalBytes = new System.IO.FileInfo(currentDirectory + "\\" + fileName).Length;

                _Buffer = _BinaryReader.ReadBytes((Int32)_TotalBytes);

                _FileStream.Close();
                _FileStream.Dispose();
                _BinaryReader.Close();
            }
            catch (Exception _Exception)
            {
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
            }

            return _Buffer;
        }
    }
}
