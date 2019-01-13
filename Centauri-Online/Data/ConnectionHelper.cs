using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Data
{
    public class ConnectionHelper
    {

        internal static string DBFileName
        {
            get
            {
                return @"CentauriOnline.db";
            }
        }

        internal static string CHARACTER_DOC_NAME
        {
            get
            {
                return "character";
            }
        }

        internal static string TRANSACTION_DOC_NAME
        {
            get
            {
                return "transaction";
            }
        }
    }
}
