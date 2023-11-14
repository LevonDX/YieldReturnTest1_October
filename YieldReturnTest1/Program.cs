namespace YieldReturnTest1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomNumArray customNumArray = new CustomNumArray();
			customNumArray.Add(1);
			customNumArray.Add(2);
			customNumArray.Add(3);
			customNumArray.Add(4);


			foreach (int num in customNumArray)
			{
				Console.WriteLine(num);
			}
		}
	}
}