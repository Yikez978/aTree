using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aTree
{
    class FileSize
    {
        static public decimal BToKB(decimal Bytes){
            return Bytes / 1024;
        }
        static public decimal KBToMB(decimal Kilobytes) {
            return Kilobytes / 1024;
        }

        static public decimal MBToGB(Decimal Megabytes) {
            return Megabytes / 1024;
        }

        static public decimal GBToTB(Decimal Gigabytes){
            return Gigabytes / 1024;
        }

        static public string NormalizeString(long Bytes) {
            decimal RunningSize = Bytes;
            string Suffix="B";

            if (RunningSize >= 1024){
                RunningSize = BToKB(RunningSize);
                Suffix = "KB";
            }

            if (RunningSize >= 1024){
                RunningSize = KBToMB(RunningSize);
                Suffix = "MB";
            }

            if (RunningSize >= 1024){
                RunningSize = MBToGB(RunningSize);
                Suffix = "GB";
            }

            if (RunningSize >= 1024){
                RunningSize = GBToTB(RunningSize);
                Suffix = "TB";
            }

            return String.Format("{0:0.##} {1}", RunningSize, Suffix);

        }

    }
}
