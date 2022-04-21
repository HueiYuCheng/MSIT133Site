using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Models
{
    public class Members
    {
        public int MemberId { get; set; }
        /// <summary>
        /// 會員名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 會員信箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 會員年齡
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 會員照片名稱
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 會員照片檔案[byte]
        /// </summary>
        public byte FileData { get; set; }



    }
}
