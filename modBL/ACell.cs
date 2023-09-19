using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL
{
    public class ACell : ICell
    {
        public ACell(Option opt)
        {
            Option = opt;
        }

        /// <summary>
        /// Col name
        /// </summary>
        public virtual string CName => "A";

        /// <summary>
        /// Unique name
        /// </summary>
        public virtual string UName => "Default";

        /// <summary>
        /// Option thể hiện thông tin các ppt đang sử dụng
        /// </summary>
        public Option Option { get; set; }

        public virtual string formula(string[] args)
        {
            return "";
        }
        public virtual string formula(string hangMucId, string[] args)
        {
            return "";
        }
    }
}
