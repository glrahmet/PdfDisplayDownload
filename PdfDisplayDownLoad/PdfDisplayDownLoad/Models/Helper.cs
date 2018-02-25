using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PdfDisplayDownLoad.Models
{
    public static class Helper
    { 
        public static byte[] GetBytesFromFile(string fullFilePath)
        { 
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(fullFilePath);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return bytes;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            } 
        }
    }
}