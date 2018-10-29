using System;

namespace Pallindrom
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			do {
				Console.Write ("Pallindrom eingeben:");
				string check = Console.ReadLine ();
				check = check.ToLowerInvariant();
				char[] check_ar = check.ToCharArray ();
				string viseVersa = string.Empty;
				for (int i = 0; i < check_ar.Length; i++) {
					viseVersa = viseVersa + check_ar [check_ar.Length - 1 - i];
				}
				if (check == viseVersa) {
					Console.WriteLine ("Pallindrom :)");
				} else {
					Console.WriteLine ("no Pallindrom :(");
				}
			} while(true);
				
				
		}
	}
}
