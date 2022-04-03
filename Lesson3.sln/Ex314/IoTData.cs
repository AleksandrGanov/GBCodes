using System;
using System.IO;

namespace Ex314
{
    /// <summary>
    /// "Библиотека печати"
    /// </summary>
    class IoTData
    {
        /// <summary>
        /// DataConsoleWrite
        /// </summary>
        /// <param name="JSON"></param>
        public void DataConsoleWrite(string JSON)
        { Console.WriteLine(JSON); }

        /// <summary>
        /// DataFileWrite
        /// </summary>
        /// <param name="JSON"></param>
        public void DataFileWrite(string JSON)
        { File.WriteAllText("data.dat", JSON); }

        /// <summary>
        /// DataStreamWrite
        /// </summary>
        /// <param name="JSON"></param>
        public void DataStreamWrite(string JSON)
        {
            using (var sw = new StreamWriter("StreamWriterData.dat"))
            {
                sw.WriteLine(JSON);
            }
        }
    }
}
