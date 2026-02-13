using System.ComponentModel;

namespace Test2.DTO
{
    public class OfficeDTO
    {
        [DefaultValue("王小明")]
        public string ACPD_Cname { get; set; }

        [DefaultValue("Kevin")]
        public string ACPD_Ename { get; set; } 

        [DefaultValue("小明")]
        public string ACPD_Sname { get; set; } 

        [DefaultValue("kevin@test.com")]
        public string ACPD_Email { get; set; }

        [DefaultValue("kevin123")]
        public string ACPD_LoginID { get; set; }

        [DefaultValue("password123")]
        public string ACPD_LoginPWD { get; set; } 

        [DefaultValue("Admin")]
        public string ACPD_NowID { get; set; }

        [DefaultValue("面試測試資料")]
        public string ACPD_Memo { get; set; } 
    }
}
