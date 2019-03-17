using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS
{
	// Connect n ropes with minimum cost - Greedy approach.
	class ConnectRopes
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the array elements separated by space : ");
			string[] input = Console.ReadLine().Split(' ');
			int[] actualInput = input.Select(int.Parse).ToArray();
			Console.WriteLine("The minimum cost is : " + getJoiningCost(actualInput));
			Console.ReadKey();
		}

		static int getJoiningCost(int[] arr)
		{
			int minCost = 0;
			MinHeap h = new MinHeap(100, arr.Length);
			int min1, min2;
			for (int i = 0; i < arr.Length; i++)
			{
				h.assignData(arr[i], i);
			}
			h.minHeap();

			while (!(h.getSize() == 1))
			{
				min1 = h.ExtractMin();
				min2 = h.ExtractMin();
				minCost += min1 + min2;

				h.Insert(min1 + min2);
				h.minHeap();
			}
			return minCost;
		}
	}

	// Defining MinHeap
	public class MinHeap
	{
		int[] heap;
		int size = 0;
		int maxSize;

		public MinHeap(int max, int s)
		{
			heap = new int[max + 1];
			this.maxSize = max;
			this.size = s;
			heap[0] = Int32.MinValue;
		}

		public void assignData(int data, int i)
		{
			heap[i] = data;
		}
		public int getSize()
		{
			return size;
		}
		private int parent(int i)
		{
			return i / 2;
		}

		private int leftChild(int i)
		{
			int left = 2 * i;
			if (left >= size)
			{
				return -1;
			}
			return left;
		}

		private int rightChild(int i)
		{
			int right = 2 * i + 1;
			if (right >= size)
			{
				return -1;
			}
			return right;
		}

		private bool isLeaf(int i)
		{
			if (i >= size / 2 && i <= size)
			{
				return true;
			}
			return false;
		}

		private void Swap(int fpos, int spos)
		{
			int tmp;
			tmp = heap[fpos];
			heap[fpos] = heap[spos];
			heap[spos] = tmp;
		}

		private void Heapify(int i)
		{
			int l, r, min;
			l = leftChild(i);
			r = rightChild(i);
			if (l != -1 && heap[l] < heap[i])
			{
				min = l;
			}
			else
			{
				min = i;
			}
			if (r != -1 && heap[r] < heap[min])
			{
				min = r;
			}
			if (min != i)
			{
				Swap(heap[i], heap[min]);
				Heapify(min);
			}
		}

		public void Insert(int data)
		{
			heap[++size] = data;
			int current = size;
			while (heap[current] < heap[parent(current)])
			{
				Swap(heap[current], heap[parent(current)]);
				current = parent(current);
			}
		}

		public void minHeap()
		{
			for (int pos = (size / 2); pos >= 1; pos--)
			{
				Heapify(pos);
			}
		}

		public int ExtractMin()
		{
			int data;
			if (size == 0)
			{
				return -1;
			}
			data = heap[1];
			heap[1] = heap[size - 1];
			size--;
			Heapify(1);
			return data;
		}
	}
}
