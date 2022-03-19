/*
 * Created by SharpDevelop.
 * User: AndrewBenedictus
 * Date: Rab, 23 Feb 2022
 * Time: 16.07.31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PV_2_Tugas1_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Nama kamu siapa? ");
			
			string nama = Console.ReadLine();
			
			Console.WriteLine("Nama kamu " + nama);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
