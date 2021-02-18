using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //this aynı class içindeki diğer constracter için
        //base ise implament edildiği sınıf için kullanıldı.
        public SuccessResult(string message):base(true)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
