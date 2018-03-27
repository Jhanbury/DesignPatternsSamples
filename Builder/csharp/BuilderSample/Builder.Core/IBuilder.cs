namespace Builder.Core
{
    public interface IBuilder<T> where T : class
    {
        T Build();
    }
}