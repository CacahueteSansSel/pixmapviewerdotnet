using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightek.PBM
{
    public static class FilePatterns
    {
        public const string PIXMAPS = "Black or white pixmap (0-1/P1)|*.pbm|Grayshade pixmap (0-255/P2)|*.pgm|RGB pixmap (0-255/P3)|*.ppm";
        public const string IMAGE_FILES_STANDARD = "JPEG Image|*.jpg;*.jpeg|PNG Image|*.png";
    }
}
