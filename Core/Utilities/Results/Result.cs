using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //mesaj vermek istenıyor.(Constracter)
        public Result(bool success,string message):this(success)//diğer constracter'ın da çalışmasını istiyor.
        {
            Message = message;
        }
        public Result(bool success)//mesaj vermek istenmiyor.(Constracter)
        {
            Success=success;
        }
        public bool Success
        {
            get;
        }

        public string Message
        {
            get;
        }
    }
}
