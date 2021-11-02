using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell
{
    public abstract class TestAbtract
    {
        public string Da;
        public virtual string DongVat()
        {
             Da= "xám";
            return Da;
        }
        public void ThucVat()
        {

        }
        public int MyProperty { get; set; }
    }
    public class Ga : TestAbtract
    {
        public override string DongVat()
        {
            base.Da = "lông";
            return Da;
        }
        public new void ThucVat()
        {

        }
    }
    public class Ca : TestAbtract
    {
        public override string DongVat()
        {
            base.Da = "vảy";
            return Da;
        }
    }
}
