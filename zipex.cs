using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GenericList161123
{
    class List<T>
    {
        private T value;
        private List<T> next;
        public List(T value)
        {
            this.value = value;
            this.next = null;
        }
        public List(T value, List<T> next)
        {
            this.value = value;
            this.next = next;
        }
        public T GetValue()
        {
            return value;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public List<T> GetNext()
        {
            return next;
        }
        public void SetNext(List<T> next)
        {
            this.next = next;
        }
        public bool HasNext()
        {
            return this.next != null;
        }
        public override string ToString()
        {
            return this.value + " --> " + this.next;
        }

    }
    class ZipInfo
    {
        char ch;
        long times;
        public ZipInfo(char ch,long times)
        {
            this.ch = ch;
            this.times = times;
        }
        public char GetChar()
        {
            return ch;
        }
        public long GetTimes()
        {
            return times;
        }
        public string ToString()
        {
            return ""+ch + ":" + times;
        }
    }
    class program
    {
        public static List<ZipInfo> Zip(List<char> lst)
        {
            List<ZipInfo> chain = new List<ZipInfo>(new ZipInfo(lst.GetValue(), 1));
            while (lst.HasNext() != false)
            {
                if ((lst.GetNext()).GetValue() == lst.GetValue())
                {
                    chain.SetValue(new ZipInfo(lst.GetValue(), chain.GetValue().GetTimes() + 1));
                    lst = lst.GetNext();
                }
                else
                {
                    chain = new List<ZipInfo>(new ZipInfo(lst.GetValue(), 1),chain);
                    lst = lst.GetNext();
                }

            }
            List<ZipInfo> temp=chain;
            while (temp.HasNext() != false)
            {
                temp = temp.GetNext();
            }
            exist=jjgh
            exist.next(new ggg('a'), 99)
            return chain;
        }
        public static void Main(string[] args)
        {
            List<char> valnig =
                new List<char>('A', new List<char>('A', new List<char>('A', new List<char>('A', new List<char>('C', new List<char>('C'))))));
            List<ZipInfo> finalvalnig = Zip(valnig);
            Console.WriteLine(""+finalvalnig.GetValue().ToString()+"  "+finalvalnig.GetNext().GetValue().ToString()) ;
        }
    }
}
