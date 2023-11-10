using System;

/// <summary>
/// Represents a queue.
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
	/// <summary>
	/// head of the queue
	/// </summary>
	Node head;
	/// <summary>
	/// tail of the queue
	/// </summary>
	Node tail;
	/// <summary>
	/// number of nodes in the queue
	/// </summary>
	int count = 0;


	/// <summary>
	/// Represents a node of a queue.
	/// </summary>
	public class Node
	{
		/// <summary>
		/// value of the node
		/// </summary>
		public T value = default(T);
		/// <summary>
		/// next node in the queue
		/// </summary>
		public Node next = null;

		/// <summary>
		/// Constructor for a Node.
		/// </summary>
		/// <param name="value"></param>
		public Node(T value)
		{
			this.value = value;
		}
	}

	/// <summary>
	/// method that returns the Queue's type
	/// </summary>
	/// <returns></returns>
	public string CheckType()
	{
		return typeof(T).ToString();
	}

	/// <summary>
	/// Creates a new Node and adds it to the end of the queue.
	/// </summary>
	public void Enqueue(T value)
	{
		Node newNode = new Node(value);
		if (head == null)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			tail.next = newNode;
			tail = newNode;
		}
		count++;
	}

	/// <summary>
	/// Removes the first node in the queue and returns its value.
	/// </summary>
	/// <returns></returns>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			T value = head.value;
			head = head.next;
			count--;
			return value;
		}
	}

	/// <summary>
	/// Returns the value of the first node of the queue without removing the node.
	/// </summary>
	/// <returns></returns>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			return head.value;
		}
	}

	/// <summary>
	/// Returns the number of nodes in a queue.
	/// </summary>
	/// <returns></returns>
	public int Count()
	{
		return count;
	}

	/// <summary>
	/// Prints the queue, starting from the head.
	/// </summary>
	public void Print()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
			Node current = head;
			while (current != null)
			{
				Console.WriteLine(current.value);
				current = current.next;
			}
		}
	}

}
