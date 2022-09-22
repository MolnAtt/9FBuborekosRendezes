using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9FBuborekosRendezes
{
	class Program
	{
		static void Kiír(List<int> lista, int j = -1, int k = -1)
		{

			for (int i = 0; i < lista.Count; i++)
			{
				if (i == j || i == k)
				{
					Console.ForegroundColor = ConsoleColor.Green;
				}
				Console.Write(lista[i]);
				Console.Write(" ");
				if (i == j || i == k)
				{
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
			Console.WriteLine();
		}
		static void Csere(List<int> lista, int i, int j)
		{
			int temp = lista[i];
			lista[i] = lista[j];
			lista[j] = temp;
		}
		static void BuborekosRendezes(List<int> lista)
		{
			for (int vége = lista.Count; vége > 1; vége--)
			{
				for (int i = 1; i < vége; i++)
				{
					if (lista[i - 1] > lista[i])
					{
						Csere(lista, i - 1, i);
					}
					Kiír(lista, i - 1, i);
				}
			}
		}

		static void Javitott_BuborekosRendezes(List<int> lista)
		{
			for (int vége = lista.Count; vége > 1; vége--)
			{
				for (int i = 1; i < vége; i++)
				{
					if (lista[i - 1] > lista[i])
					{
						Csere(lista, i - 1, i);
					}
					else if (i == vége-1) 
					{
						vége--;
					}
					Kiír(lista, i - 1, i);
				}

			}
		}
		static void Main(string[] args)
		{
			List<int> lista = new List<int> { 3, 0, 1, 8, 7, 2, 5, 4, 6, 9 };
			Console.WriteLine("Ez a rendezendő:");
			Kiír(lista);
			Console.WriteLine("------------------");
			Console.WriteLine("lépések:");
			Javitott_BuborekosRendezes(lista);

			Console.WriteLine("------------------");
			Console.WriteLine("kész:");
			Kiír(lista);
			Console.ReadKey();
		}
	}
}
