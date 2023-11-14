using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturnTest1
{
	internal class CustomNumArray : IEnumerable<int>
	{
		private int[] array;


		public CustomNumArray(int[] array)
		{
			this.array = array;
		}

		public CustomNumArray()
		{
			this.array = new int[0];
		}

		public void Add(int num)
		{
			int[] newArray = new int[array.Length + 1];
			for (int i = 0; i < array.Length; i++)
			{
				newArray[i] = array[i];
			}
			newArray[array.Length] = num;
			array = newArray;
		}

		public IEnumerator<int> GetEnumerator()
		{
			return new CustomNumArrayEnumerator(this);

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public int this[int index]
		{
			get
			{
				return this.array[index];
			}
		}

		private class CustomNumArrayEnumerator : IEnumerator<int>
		{
			private readonly CustomNumArray numArray;
			public CustomNumArrayEnumerator(CustomNumArray numArray)
			{
				this.numArray = numArray;
			}

			#region Enumerator

			int currentIndex = -1;
			public int Current
			{
				get
				{
					return numArray.array[currentIndex];
				}
			}

			public bool MoveNext()
			{
				return ++currentIndex < numArray.array.Length;
			}

			public void Reset()
			{
				currentIndex = -1;
			}

			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}
			public void Dispose()
			{

			}

			#endregion

		}
	}
}
