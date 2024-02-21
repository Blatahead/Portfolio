namespace tpo1
{
	class TDO1
	{	
		///// PARTIE 1 : De l'algorithme au langage de programmation
		//Algorithme n°1 : afficher la valeur absolue d'un nombre
		//traduction en C#
		static void Exo1()
		{
			Console.WriteLine("---- VALEUR ABSOLUE ----");
			Console.WriteLine("Saisissez un nombre :");
			int n = Convert.ToInt32(Console.ReadLine());
			if (n < 0)
			{
				Console.WriteLine("La valeur absolue est donc " + (-n));
			}
			else
			{
				Console.WriteLine("La valeur absolue est donc " + n);
			}
		}
		// Partie 2 //
		static void Exo2_1()
		{
			Console.WriteLine("---- CLASSE AGE ----");
			Console.WriteLine("Saisissez votre âge :");
			int n = Convert.ToInt32(Console.ReadLine());
			if(n<= 25){
				Console.WriteLine("salut gamin");
			}
			else if(n>25 & n<55)
			{
				Console.WriteLine("bonjour monsieur");
			}
			else if(n>=55)
			{
				Console.WriteLine("Je te vénère, oh mon grand maître !");
			}
		}
		static void Exo2_2()
		{
			Console.WriteLine("---- CALCUL IMC ----");
			Console.Write("Entrez votre poids en kilogrammes : ");
			double poids = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Entrez votre taille en centimètres : ");
			double tailleCm = Convert.ToDouble(Console.ReadLine());
			double tailleM = tailleCm / 100;

			double imc = poids / (tailleM * tailleM);

			Console.WriteLine($"Votre IMC est : {imc:F2}");

			if (imc < 19)
			{
				Console.WriteLine("Vous êtes maigre.");
			}
			else if (imc >= 19 && imc <= 25)
			{
				Console.WriteLine("Vous êtes sans intérêt.");
			}
			else if (imc > 25 && imc <= 40)
			{
				Console.WriteLine("Vous êtes gros.");
			}
			else
			{
				Console.WriteLine("IMC non valide.");
			}
		}
		static void Exo2_3()
		{
			Console.WriteLine("---- NOMBRE LE PLUS GRAND ----");
			Console.WriteLine("Vous allez saisir deux nombres l'un après l'autre.");
			Console.WriteLine("Saisissez le premier : ");
			double n1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Saisissez le second : ");
			double n2 = Convert.ToDouble(Console.ReadLine());

			if(n1>n2)
			{
				Console.WriteLine($"{n1} est le plus grand nombre saisi.");
			}
			else if(n2>n1)
			{
				Console.WriteLine($"{n2} est le plus grand nombre saisi.");
			}
			else
			{
				Console.WriteLine($"{n1} et {n2} sont égaux.");
			}

		}
		static void Exo2_4()
		{
			Console.WriteLine("---- VALEUR ABSOLUE ----");
			Console.WriteLine("Saisissez un nombre :");
			int n = Convert.ToInt32(Console.ReadLine());
			if (n < 0)
			{
				Console.WriteLine("La valeur absolue est donc " + (-n));
			}
			else
			{
				Console.WriteLine("La valeur absolue est donc " + n);
			}
		}
		static void Exo2_5()
		{
			Console.WriteLine("---- AIRE CARRE ----");
			Console.WriteLine("Saisissez la longueur du carré :");
			double l_carre= Convert.ToDouble(Console.ReadLine());
			double s_carre = l_carre * l_carre;
			Console.WriteLine($"L'aire du carré est de {s_carre:F2} m^2");
		}

		static void Exo2_6()
		{
			Console.WriteLine("---- AIRE RECTANGLE ----");
			Console.WriteLine("Saisissez la longueur du rectangle :");
			double lon_rec= Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Saisissez la largeur du rectangle :");
			double lar_rec= Convert.ToDouble(Console.ReadLine());
			double s_rec = lon_rec * lar_rec;
			Console.WriteLine($"L'aire du carré est de {s_rec:F2} m^2");
		}

		static void Exo2_7()
		{
			Console.WriteLine("---- AIRE CERCLE ----");
			Console.WriteLine("Saisissez le rayon du cercle :");
			double ray= Convert.ToDouble(Console.ReadLine());
			double s_cercle = Math.PI*(ray*ray);
			Console.WriteLine($"L'aire du cercle est de {s_cercle:F2} m^2");
		}

		static void Exo2_8()
		{
			Console.WriteLine("---- COTE CARRE ----");
			Console.WriteLine("Saisissez le rayon du cercle :");
			double ray= Convert.ToDouble(Console.ReadLine());
			double s_cercle = Math.PI*(ray*ray);
			double cote_carre = Math.Sqrt(s_cercle);
			Console.WriteLine($"Le côté du carré correspondant est {cote_carre:F4} m");
		}

		static void Exo2_9()
		{
			Console.WriteLine("---- PERMUTATION ----");
			int val1 = 17;
			int val2 = 56787;
			Console.WriteLine("val1 = "+ val1 + ", val 2 ="+ val2);
			(val2, val1) = (val1, val2);
			Console.WriteLine("val1 = "+ val1 + ", val 2 ="+ val2);
		}

		static void Exo2_10()
		{
			Console.WriteLine("Entrez une syllabe : ");
			string? syllabe = Console.ReadLine();
			string mot = syllabe+syllabe;
			Console.WriteLine(mot);
		}
		static void Exo1_2()
		{
			int n = 1;
			int carre = n * n;

			while (carre < 100)
			{
				Console.WriteLine("Carré : " + carre + " Nombre : " + n);
				n++;
				carre = n * n;
			}
		}
		static void Exo4_1()
		{
			Console.WriteLine("Entrez un nombre : ");
			int nombre = Convert.ToInt32(Console.ReadLine());

			if (nombre < 0)
			{
				Console.WriteLine("La factorielle n'est pas définie pour les nombres négatifs.");
			}
			else if (nombre == 0)
			{
				Console.WriteLine("La factorielle de 0 est 1.");
			}
			else
			{
				int factorielle = 1;
				int index = 1;

				while (index <= nombre)
				{
					factorielle *= index;
					index++;
				}

				Console.WriteLine("La factorielle de " + nombre + " est " + factorielle);
			}
		}
		static void Exo4_2()
		{
			Console.WriteLine("Entrez le premier nombre : ");
			int a = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Entrez le deuxième nombre : ");
			int b = Convert.ToInt32(Console.ReadLine());

			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}

			Console.WriteLine("Le PGCD est " + a);
		}
		static void Exo4_3()
		{
			Console.WriteLine("Entrez le dividende : ");
			int dividende = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Entrez le diviseur : ");
			int diviseur = Convert.ToInt32(Console.ReadLine());

			int quotient = 0;
			int reste = dividende;

			while (reste >= diviseur)
			{
				reste -= diviseur;
				quotient++;
			}

			Console.WriteLine("Le quotient est " + quotient);
			Console.WriteLine("Le reste est " + reste);
		}
		static void Exo4_4()
		{
			Console.Write("Entrez un entier : ");
			int n = Convert.ToInt32(Console.ReadLine());

			if (n <= 1)
			{
				Console.WriteLine("L'entier n'est pas premier.");
			}
			else if (n <= 3)
			{
				Console.WriteLine("L'entier est premier.");
			}
			else if (n % 2 == 0 || n % 3 == 0)
			{
				Console.WriteLine("L'entier n'est pas premier.");
			}
			else
			{
				int diviseur = 5;
				while (diviseur * diviseur <= n)
				{
					if (n % diviseur == 0)
					{
						Console.WriteLine("L'entier n'est pas premier.");
						return;
					}
					diviseur += 2;
				}
				Console.WriteLine("L'entier est premier.");
			}
		}
		static void Main(string[] args)
		{	
			// Exo1();
			// Exo1_2();
			// Exo2_1();
			// Exo2_2();
			// Exo2_3();
			// Exo2_4();
			// Exo2_5();
			// Exo2_6();
			// Exo2_7();
			// Exo2_8();
			// Exo2_9();
			// Exo2_10();
			// Exo4_1();
			// Exo4_2();
			// Exo4_3();
			Exo4_4();
		}
	};
};