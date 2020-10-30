using System;

namespace Lab3
{
    public interface IOperationInfo
    {
        public Func<string>[] GetFuncsWithOperationStringResult();
    }
}
