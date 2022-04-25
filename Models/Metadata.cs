using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Models
{
    public class MemberMetadata
    {
        public int MemberId { get; set; }
        [DisplayName("姓名")]
        public string Name { get; set; }
        [DisplayName("電子郵件")]
        public string Email { get; set; }
        [DisplayName("年齡")]
        public int? Age { get; set; }
        [DisplayName("檔案名稱")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    }
    public class AddressMetadata
    {

        public int Id { get; set; }
        [DisplayName("城市")]
        public string City { get; set; }
        [DisplayName("區域")]
        public string SiteId { get; set; }
        [DisplayName("道路")]
        public string Road { get; set; }

    }
}
