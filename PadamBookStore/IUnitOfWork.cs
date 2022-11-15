namespace PadamBookStore
{
    internal interface IUnitOfWork
    {
        object Category { get; }

        void Save();
    }
}