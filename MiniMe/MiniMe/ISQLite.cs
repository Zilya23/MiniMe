using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMe
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
