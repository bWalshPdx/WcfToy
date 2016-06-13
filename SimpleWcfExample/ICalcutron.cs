using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleWcfExample
{
    
    [ServiceContract]
    public interface ICalcutron
    {
        [OperationContract]
        int GetRandomValue(int seedValue);

        // TODO: Add your service operations here
    }
}
