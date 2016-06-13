using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleWcfExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calcutron" in both code and config file together.
    public class Calcutron : ICalcutron
    {
        public int GetRandomValue(int seedValue)
        {
            Random random = new Random();
            return random.Next(seedValue);
        }
    }

    [DataContract]
    public class ToyModel
    {
        int _currentSeed;
        int _previousRandomValues;
        
        [DataMember]
        public int CurrentSeed
        {
            get { return _currentSeed; }
            set { _currentSeed = value; }
        }

        [DataMember]
        public int PreviousRandomValue
        {
            get { return _previousRandomValues; }
            set { _previousRandomValues = value; }
        }
    }
}
