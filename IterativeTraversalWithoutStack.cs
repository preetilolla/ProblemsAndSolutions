using System;
using System.Collections.Generic;
using System.Text;

namespace PSIT
{
	// Iterative traversals without using Stack.
	class IterativeTraversalsWithoutStack
	{
		static void Main(string[] args)
		{
			Node root = new Node(5);
			root.Left = new Node(2);
			root.Left.Parent = root;
			root.Left.Left = new Node(1);
			root.Left.Left.Parent = root.Left;
			root.Left.Right = new Node(3);
			root.Left.Right.Parent = root.Left;
			root.Right = new Node(7);
			root.Right.Parent = root;
			root.Right.Left = new Node(6, null, null, root.Right);
			root.Right.Right = new Node(8, null, null, root.Right);
			root.Right.Left.Parent = root.Right;
			root.Right.Right.Parent = root.Right;
			getIterativeInorder(root);
			//getIterativePreOrder(root);
			//getIterativePostOrder(root);
			Console.ReadKey();
		}

		static void getIterativeInorder(Node root)
		{
			List<int> inorder = new List<int>();
			Node prev = null;
			Node current = root;

			while (current != null)
			{
				Node next = null;
				if (current.Parent == prev)
				{
					if (current.Left != null)
					{
						next = current.Left;
					}
					else
					{
						inorder.Add(current.Data);
						next = current.Right != null ? current.Right : current.Parent;
					}
				}
				else if (current.Left == prev)
				{
					inorder.Add(current.Data);
					next = current.Right != null ? current.Right : current.Parent;
				}
				else
				{
					next = current.Parent;
				}
				prev = current;
				current = next;
			}

			Console.WriteLine("The inorder traversal is..");
			foreach (int i in inorder)
			{
				Console.Write(i + " ");
			}
		}

		static void getIterativePreOrder(Node root)
		{
			
		}

		static void getIterativePostOrder(Node root)
		{
			
		}
	}

	class Node
	{
		int data;
		Node left;
		Node right;
		Node parent;

		public Node(int data, Node left = null, Node right = null, Node parent = null)
		{
			this.data = data;
			this.left = left;
			this.right = right;
			this.parent = null;
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
		public Node Parent
		{
			get { return parent; }
			set { parent = value; }
		}
	}
}
