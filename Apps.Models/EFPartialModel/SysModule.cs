using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    public partial class SysModule
    {
        public Apps.Models.TreeNode ToNode()
        {
            return new TreeNode()
            {
                id = this.Id,
                text = this.Name,
                attributes = new
                {
                    url = "/" + this.AreasName + "/" + this.ControllerName + "/" + this.ActionName,
                },
                //@checked = false,
                //state = "open"
            };
        }
    }
}
