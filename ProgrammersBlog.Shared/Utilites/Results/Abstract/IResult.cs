using System;
using ProgrammersBlog.Shared.Utilites.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Utilites.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; set; } // ResultStatus.Success;
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}