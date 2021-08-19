using Neodynamic.SDK.ZPLPrinter;

namespace ZPL_Net6
{
    class Program
    {
        const string _licenseKey = "";
        const string _licenseOwner = "";

        static void Main(string[] args)
        {
            var myZPLPrinter = new ZPLPrinter(_licenseOwner, _licenseKey);
        }
    }
}
