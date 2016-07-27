using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace aTree
{
    [XmlType("AccessControlEntry")]
    public class aTreeAccessControlEntry
    {

        int _AccessFlags;
        int _InheritanceFlags;
        int _PropagationFlags;
        int _AccessControlType;
        aTreeObjectDisplayCategory _DisplayClass;
        bool _IsInherited;
        string _Identity;
        bool _PassedFilter = true;

        [XmlElementAttribute("PassedFilter")]
        public bool PassedFilter
        {
            get
            {
                return _PassedFilter;
            }
            set
            {
                _PassedFilter = value;
            }
        }

        [XmlElementAttribute("AccessFlags")]
        public int AccessFlags {
            get
            {
                return _AccessFlags;
            }
            set
            {
                _AccessFlags = value;
            }
        }

        [XmlElementAttribute("InheritanceFlags")]
        public int InheritanceFlags
        {
            get
            {
                return _InheritanceFlags;
            }
            set
            {
                _InheritanceFlags = value;
            }
        }

        [XmlElementAttribute("PropagationFlags")]
        public int PropagationFlags
        {
            get
            {
                return _PropagationFlags;
            }
            set
            {
                _PropagationFlags = value;
            }
        }

        [XmlElementAttribute("AccessControlType")]
        public int AccessControlType
        {
            get
            {
                return _AccessControlType;
            }
            set
            {
                _AccessControlType = value;
            }
        }

        [XmlElementAttribute("IsInherited")]
        public bool IsInherited
        {
            get
            {
                return _IsInherited;
            }
            set
            {
                _IsInherited = value;
            }
        }

        [XmlElementAttribute("Identity")]
        public string Identity
        {
            get
            {
                return _Identity;
            }
            set
            {
                _Identity = value;
            }
        }

        [XmlElementAttribute("DisplayClass")]
        public aTreeObjectDisplayCategory DisplayClass
        {
            get
            {
                return _DisplayClass;
            }
            set
            {
                _DisplayClass = value;
            }
        }
    }
}
