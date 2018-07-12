using System.Linq;
using csharp.Interfaces;
namespace csharp.Implementations
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string header, string data){
            return string.Format("{0}: {1}", header, new string(data.Reverse().ToArray()));
        }
    }
}