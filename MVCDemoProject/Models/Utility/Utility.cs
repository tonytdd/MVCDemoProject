using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCDemoProject.Models.Utility
{
    public static class Utility
    {
        // 78 is the size of the OLE header for Northwind images
        private static readonly int _offset = 78;

        /// <summary>
        /// 移除OLE Header以便正確顯示在頁面上
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] RemoveHeader(this byte[] image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(image, _offset, image.Length - _offset);

                return ms.ToArray();
            }
        }

        /// <summary>
        /// 將圖片轉換為byte[]
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static byte[] InsertHeader(this HttpPostedFileBase file)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                file.InputStream.CopyTo(ms);

                return new byte[_offset].Concat(ms.GetBuffer()).ToArray();
            }
        }
    }
}