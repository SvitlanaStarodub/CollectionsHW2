using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionHW
{
    public class ListData : IEnumerable
    {
        private IList<int> _initArray;
        private IList<int> _updatedArray;
        public ListData(IList<int> array)
        {
            _initArray = new List<int>(array);
            _updatedArray = new List<int>();
        }

        public void AddIndexRange (int firstIndexRange, int lastIndexRange)
        {
            if(firstIndexRange < 0 && lastIndexRange < 0)
            {
                for (int i = firstIndexRange; i < _initArray.Count-i-1; i--)
                {
                    _updatedArray.Add(_initArray[i]);
                }
            }
            if(firstIndexRange <= lastIndexRange)
            {
                for (int i = firstIndexRange; i <= lastIndexRange; i++)
                {
                    _updatedArray.Add(_initArray[i]);
                }
            }
            if(firstIndexRange >= lastIndexRange)
            {
                for (int i = firstIndexRange; i >= lastIndexRange; i--)
                {
                    _updatedArray.Add(_initArray[i]);
                }
            }            
        }

        public IEnumerator GetEnumerator()
        {
            return _updatedArray.GetEnumerator();
        }
    }    
}
