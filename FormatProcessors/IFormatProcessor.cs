using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightek.PBM.FormatProcessors
{
    public interface IFormatProcessor
    {
        string FormatIdentifier { get; }
        string FormatIdentifierLarge { get; }
        void Process(string[] TokensArray, int Offset, Bitmap Bitmap);
    }
}
