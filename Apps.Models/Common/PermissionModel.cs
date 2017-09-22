using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apps.Models
{
    public partial class PermissionModel
    {

        public string Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }

        public string Iconic { get; set; }
        public string AreasName { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public short FormMethod { get; set; }

        public short OperationType { get; set; }

        public Nullable<int> Sort { get; set; }

        public bool IsLast { get; set; }

        public string State
        {
            get
            {
                return IsLast ? "open" : "closed";
            }
        }
    }
}
