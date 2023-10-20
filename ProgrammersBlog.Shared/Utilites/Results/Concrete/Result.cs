using System;
using ProgrammersBlog.Shared.Utilites.Results.Abstract;
using ProgrammersBlog.Shared.Utilites.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Utilites.Results.Concrate
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }
        public Result(ResultStatus resultStatus,string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus,string message,Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}