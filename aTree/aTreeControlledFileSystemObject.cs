using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace aTree
{
    [XmlType("FileSystemObject")]
   public class aTreeControlledFileSystemObject
    {

        List<aTreeAccessControlEntry> _AccessControlEntries = new List<aTreeAccessControlEntry>();
        List<aTreeControlledFileSystemObject> _Children = new List<aTreeControlledFileSystemObject>();

        string _Name;
        string _FullName;
        string _Owner;
        long _Size;
        bool _PassedFilter = true;
        Exception _LastException;
        aTreeObjectDisplayCategory _DisplayCategory;
        aTreeControlledObjectCategory _ObjectCategory;

        int _Attributes;
        DateTime _CreationTime;
        DateTime _LastWriteTime;
        DateTime _LastAccessTime;

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

        [XmlElementAttribute("LastAccessTime")]
        public DateTime LastAccessTime
        {
            get
            {
                return _LastAccessTime;
            }
            set
            {
                _LastAccessTime = value;
            }
        }

        [XmlElementAttribute("LastWriteTime")]
        public DateTime LastWriteTime
        {
            get
            {
                return _LastWriteTime;
            }
            set
            {
                _LastWriteTime = value;
            }
        }

        [XmlElementAttribute("CreationTime")]
        public DateTime CreationTime
        {
            get
            {
                return _CreationTime;
            }
            set
            {
                _CreationTime = value;
            }
        }

        [XmlElementAttribute("Attributes")]
        public int Attributes
        {
            get
            {
                return _Attributes;
            }
            set
            {
                _Attributes = value;
            }
        }

        [XmlElement("Name")]
        public string Name {
            get {
                return _Name;
            }
            set {
                _Name = value;
            }
        }

        [XmlElement("FullName")]
        public string FullName {
            get {
                return _FullName;
            }
            set {
                _FullName = value;
            }
        }

        [XmlElementAttribute("Size")]
        public long Size {
            get {
                return _Size;
            }
            set {
                _Size = value;
            }
        }

        [XmlIgnore]
        public Exception LastException {
            get {
                return _LastException;
            }
            set {
                _LastException = value;
            }
        }

        [XmlElementAttribute("DisplayClass")]
        public aTreeObjectDisplayCategory DisplayClass {
            get {
                return _DisplayCategory;
            }
            set {
                _DisplayCategory = value;
            }
        }

        [XmlElementAttribute("ObjectCategory")]
        public aTreeControlledObjectCategory ObjectCategory {
            get {
                return _ObjectCategory;
            }
            set {
                _ObjectCategory = value;
            }
        }

        [XmlElement("AccessControlEntries", typeof(aTreeAccessControlEntry))]
        public List<aTreeAccessControlEntry> AccessControlEntries {
            get {
                return _AccessControlEntries;
            }
        }

        [XmlElement("Children", typeof(aTreeControlledFileSystemObject))]
        public List<aTreeControlledFileSystemObject> Children {
            get{
                return _Children;
            }
        }

        [XmlElementAttribute("Owner")]
        public string Owner {
            get {
                return _Owner;
            }
            set {
                _Owner=value;
            }
        }


    }
}
