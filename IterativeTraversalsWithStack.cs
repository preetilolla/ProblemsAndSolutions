using System;
using System.Collections.Generic;
using System.Text;

namespace PS
{
	// Iterative traversals with Stack.
	class IterativeInorder
	{
		static void Main(string[] args)
		{
			Node root = new Node(5);
			root.Left = new Node(2, new Node(1), new Node(3));
			root.Right = new Node(7, new Node(6), new Node(8));
			getIterativeInorder(root);
			getIterativePreOrder(root);
			getIterativePostOrder(root);
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

		static void getIterativePreOrder(Node root)
		{
			List<int> preorder = new List<int>();
			Stack<Node> s = new Stack<Node>();
			Node current = root;

			while (!(s.Count == 0))
			{
				current = s.Pop();
				if (current != null)
				{
					preorder.Add(current.Data);
					s.Push(current.Right);
					s.Push(current.Left);
				}
			}

			Console.WriteLine("\n\nThe preorder traversal is..");
			foreach (int i in preorder)
			{
				Console.Write(i + " ");
			}
		}

		static void getIterativePostOrder(Node root)
		{
			List<int> postorder = new List<int>();
			Stack<Node> s = new Stack<Node>();
			Node current = root;

			while (true)
			{
				while (current != null)
				{
					s.Push(current);
					s.Push(current);
					current = current.Left;
				}
				if (s.Count == 0)
				{
					break;
				}
				current = s.Pop();
				
				if (s.Count != 0 && s.Peek() == current)
				{
					current = current.Right;
				}
				else
				{
					postorder.Add(current.Data);
					current = null;
				}
			}

			Console.WriteLine("\n\nThe postorder traversal is..");
			foreach (int i in postorder)
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
