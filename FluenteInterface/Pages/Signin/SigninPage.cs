using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages
{
    public class SigninPage
    {
        public SigninActions Actions()
        {
            return new SigninActions();
        }
    }
}
