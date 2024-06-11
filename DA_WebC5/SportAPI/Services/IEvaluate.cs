using SportAPI.Model;
using System.Collections;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IEvaluate
    {
        public IEnumerable<Evaluate> GetEvaluate();
    }
}
