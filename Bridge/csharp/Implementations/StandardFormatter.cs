using csharp.Interfaces;
namespace csharp.Implementations
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string header, string data){
            return $"{header}: {data}";
        }
    }
}