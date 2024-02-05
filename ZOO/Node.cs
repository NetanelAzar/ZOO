using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
	internal class Node<T>
	{
		private T value;  //node's value
		private Node<T> next; // reference to next Node

		public Node(T value)
		{
			this.value = value;
			this.next = null;
		}

		public Node(T value, Node<T> next)
		{
			this.value = value;
			this.next = next;
		}

		/* Returns the value of the current node **/
		public T GetValue()
		{
			return this.value;
		}

		/* Returns a reference to the node which is next to the current node **/
		public Node<T> GetNext()
		{
			return this.next;
		}

		/* Return true if the current node has successor. Else, returns false. **/
		public bool HasNext()
		{
			return (this.next != null);
		}

		/* Sets the value attribute to the given parameter value **/
		public void SetValue(T value)
		{
			this.value = value;
		}

		/* Sets the next attribute to the given parameter value **/
		public void SetNext(Node<T> next)
		{
			this.next = next;
		}

		/* Returns a string that describes the node (and its' successesors **/
		public override string ToString()
		{
			return value.ToString();
		}

	}
}
