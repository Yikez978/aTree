using System;
using System.Windows.Forms;

namespace aTree
{
    class aTreeConfig
    {

        public aTreeConfig(string RootPath) {

            if (string.IsNullOrEmpty(RootPath)) {
                throw new ArgumentNullException("RootPath cannot be null.","RootPath");
            }
            _RootPath = RootPath;
        }

        string _RootPath = string.Empty;
        public String RootPath{
            get {
                return _RootPath;
            }
            set {
                _RootPath = value;
            }
        }

        bool _RegExIncludeFilterEnabled = false;
        public bool RegExIncludeFilterEnabled
        {
            get
            {
                return _RegExIncludeFilterEnabled;
            }
            set
            {
                _RegExIncludeFilterEnabled = value;
            }
        }

        bool _RegExExcludeFilterEnabled = false;
        public bool RegExExcludeFilterEnabled
        {
            get
            {
                return _RegExExcludeFilterEnabled;
            }
            set
            {
                _RegExExcludeFilterEnabled = value;
            }
        }

        String _RegExIncludeFilter = string.Empty;
        public String RegExIncludeFilter
        {
            get
            {
                return _RegExIncludeFilter;
            }
            set
            {
                _RegExIncludeFilter = value;
            }
        }

        String _RegExExcludeFilter =string.Empty;
        public String RegExExcludeFilter
        {
            get
            {
                return _RegExExcludeFilter;
            }
            set
            {
                _RegExExcludeFilter = value;
            }
        }

        bool _ShowInheritedACEs = false;
        public bool ShowInheritedACEs
        {
            get
            {
                return _ShowInheritedACEs;
            }
            set
            {
                _ShowInheritedACEs = value;
            }
        }

        bool _ShowFileSize = false;
        public bool ShowFileSize
        {
            get
            {
                return _ShowFileSize;
            }
            set
            {
                _ShowFileSize = value;
            }
        }

        bool _ShowFiles = false;
        public bool ShowFiles
        {
            get
            {
                return _ShowFiles;
            }
            set
            {
                _ShowFiles = value;
            }
        }

        aTreeScanDirection _ScanDirection = aTreeScanDirection.None;
        public aTreeScanDirection ScanDirection
        {
            get
            {
                return _ScanDirection;
            }
            set
            {
                _ScanDirection = value;
            }
        }

        bool _BasicExcludeFilterEnabled = false;
        public bool BasicExcludeFilterEnabled
        {
            get
            {
                return _BasicExcludeFilterEnabled;
            }
            set
            {
                _BasicExcludeFilterEnabled = value;
            }
        }

        bool _BasicIncludeFilterEnabled = false;
        public bool BasicIncludeFilterEnabled
        {
            get
            {
                return _BasicIncludeFilterEnabled;
            }
            set
            {
                _BasicIncludeFilterEnabled = value;
            }
        }

        String _BasicIncludeFilter = string.Empty;
        public String BasicIncludeFilter
        {
            get
            {
                return _BasicIncludeFilter;
            }
            set
            {
                _BasicIncludeFilter = value;
            }
        }

        String _BasicExcludeFilter = string.Empty;
        public String BasicExcludeFilter
        {
            get
            {
                return _BasicExcludeFilter;
            }
            set
            {
                _BasicExcludeFilter = value;
            }
        }

        int _ScanLevels = 0;
        public int ScanLevels
        {
            get
            {
                return _ScanLevels;
            }
            set
            {
                _ScanLevels = value;
            }
        }


        bool _CustomMaxThreads = false;
        public bool CustomMaxThreads
        {
            get {
                return _CustomMaxThreads;
            }
            set {
                _CustomMaxThreads = value;
            }
        }

        int _MaxWorkerThreads = 0;
        public int MaxWorkerThreads {
            get {
                return _MaxWorkerThreads;
            }
            set {
                _MaxWorkerThreads = value;
            }
        }
    }
}
