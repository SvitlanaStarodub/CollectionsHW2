using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionHW
{
    public class ListData : IEnumerable
    {
        private readonly ILogger Logger;
        private IList<int> _initArray;
        private IList<int> _updatedArray;
        
        public ListData(IList<int> array, ILogger logger)
        {
            _initArray = new List<int>(array);
            _updatedArray = new List<int>();
            Logger = logger;
        }

        public void AddIndexRange (int firstIndexRange, int lastIndexRange)
        {
            try
            {
                if (firstIndexRange < 0 && lastIndexRange < 0)
                {
                    for (int i = firstIndexRange; i < _initArray.Count - i - 1; i--)
                    {
                        _updatedArray.Add(_initArray[i]);
                    }
                }
                if (firstIndexRange <= lastIndexRange)
                {
                    for (int i = firstIndexRange; i <= lastIndexRange; i++)
                    {
                        _updatedArray.Add(_initArray[i]);
                    }
                }
                if (firstIndexRange >= lastIndexRange)
                {
                    for (int i = firstIndexRange; i >= lastIndexRange; i--)
                    {
                        _updatedArray.Add(_initArray[i]);
                    }
                }
            }
            catch(Exception e)
            {
                Logger.Log(e);
                
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _updatedArray.GetEnumerator();
        }
    }    
}
