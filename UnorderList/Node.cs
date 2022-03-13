using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSructure17a
{
    internal class Node<T>
    {

		public T data;
		public Node<T> next;

		public Node(T data2)
		{
			this.data = (T)data2;
			this.next = null; 
		}

		
		public T getdata()
		{
			return data;
		}

		
		public Node<T> getNext()
		{
			return next;
		}

		
		public void setData(T newData)
		{
			this.data = newData;
		}

		public void setNext(Node<T> newNext)
		{
			this.next = newNext;
		}

	}
}
