namespace ProgrammersBlog.Shared.Utilites.Results.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; } // new DataResult<Category>(ResultStatus.Success);
        
    }
}