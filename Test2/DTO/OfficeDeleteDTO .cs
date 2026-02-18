using System.ComponentModel;

namespace Test2.DTO
{
    public class OfficeDeleteDTO
    {

        public string ACPD_SID { get; set; }

        [DefaultValue("Admin")]
        public string ACPD_NowID { get; set; }

    
    }
}
