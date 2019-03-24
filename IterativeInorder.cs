using System;
using System.Collections.Generic;
using System.Text;

namespace PS
{
	class IterativeInorder
	{
		static void Main(string[] args)
		{
			Node root = new Node(5);
			root.Left = new Node(2, new Node(1), new Node(3));
			root.Right = new Node(7, new Node(6), new Node(8));
			getIterativeInorder(root);
			Console.ReadKey();
		}

		static void getIterativeInorder(Node root)
		{
			List<int> inorder = new List<int>();
			Stack<Node> s = new Stack<Node>();
			Node current = root;

			while (!(s.Count == 0) || current != null)
			{
				if (current != null)
				{
					s.Push(current);
					current = current.Left;
				}
				else
				{
					current = s.Pop();
					inorder.Add(current.Data);
					current = current.Right;
				}
			}

			Console.WriteLine("The inorder traversal is..");
			foreach (int i in inorder)
			{
				Console.Write(i + " ");
			}
		}
	}

	class Node
	{
		int data;
		Node left;
		Node right;

		public Node(int data, Node left = null, Node right = null)
		{
			this.data = data;
			this.left = left;
			this.right = right;
		}

		public int Data
		{
			get { return data; }
			set { data = value; }
		}

		public Node Left
		{
			get { return left; }
			set { left = value; }
		}

		public Node Right
		{
			get { return right; }
			set { right = value; }
		}
	}
}
