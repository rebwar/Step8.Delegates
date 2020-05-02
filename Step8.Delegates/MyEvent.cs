using System;
using System.Collections.Generic;
using System.Text;

namespace Step8.Delegates
{
    public class MyEvent
    {
        public delegate void MyEventhandler(int n);

        public event MyEventhandler SomeEvent;
        public void OnSomeEvent(int n)
        {
            if (SomeEvent != null)
            {
                SomeEvent(n);
            }
        }
    }
}
