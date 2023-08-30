using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattahc
{
    [Serializable]
    public struct ChatRoom
    {
        public string name;
        public List<string> memberIdList;
    }
}
