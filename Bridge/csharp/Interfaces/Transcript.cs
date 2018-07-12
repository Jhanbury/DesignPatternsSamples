namespace csharp.Interfaces
{
    public abstract class Transcript
    {
        protected readonly IFormatter _formatter;
        public Transcript(IFormatter formatter){
            _formatter = formatter;
        }
        
        abstract public void Print();
    }
}