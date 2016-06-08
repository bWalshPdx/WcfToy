using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleWcfExample
{
    
    [ServiceContract]
    public interface IWidget
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        ToyObject GetDataUsingDataContract(ToyObject composite);

        // TODO: Add your service operations here
    }

    
    [DataContract]
    public class ToyObject
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }




}
