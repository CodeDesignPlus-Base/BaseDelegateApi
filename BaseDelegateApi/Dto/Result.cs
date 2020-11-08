using System.Collections.Generic;

namespace BaseDelegateApi.Dto
{
    public class Result<TResult>
    {
        public List<TResult> Results { get; set; }
    }
}
