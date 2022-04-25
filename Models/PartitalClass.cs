using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Models
{
    public class PartitalClass
    {
    }
    [ModelMetadataTypeAttribute(typeof(MemberMetadata))]
    public partial class Member
    {

    }
    [ModelMetadataTypeAttribute(typeof(MemberMetadata))]
    public partial class Address
    {

    }
}
