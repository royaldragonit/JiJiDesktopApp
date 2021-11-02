using Ji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell
{
    public partial class frmLoginWithGoogle : ClientForm
    {
        public frmLoginWithGoogle()
        {
            InitializeComponent();
            //webBrowser1.ScriptErrorsSuppressed = true;
            //webBrowser1.Url=new System.Uri("https://accounts.google.com/o/oauth2/auth/identifier?redirect_uri=storagerelay%3A%2F%2Fhttps%2Flocalhost%3A44315%3Fid%3Dauth543847&response_type=permission%20id_token&scope=email%20profile%20openid&openid.realm&client_id=347259590655-svmov937tvcq7ge3erhp51lfoq4k1jh4.apps.googleusercontent.com&ss_domain=https%3A%2F%2Flocalhost%3A44315&fetch_basic_profile=true&gsiwebsdk=2&flowName=GeneralOAuthFlow", System.UriKind.Absolute);
        }
    }
}
