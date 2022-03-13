using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSructure17a
{
    internal class Program
    {
        static void Main(string[] args)
        {
			UnorderList<int> list = new UnorderList<int>();
			list.insert(12);
			list.insert(15);
			list.insert(7);
			list.insertAtStart(8);
			list.insertAtEnd(2, 55);
			list.show();
			if (list.search(7))
			{
				Console.WriteLine("found");
			}
			else
			{
				Console.WriteLine("not found");
			}
			list.deleteAtEnd(1);
			list.deleteAtStart();
			list.show();
		}
    }
}
