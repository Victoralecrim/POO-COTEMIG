//String[] Carros = { "monza", "fiat 47", "passat", "radett" };
//       foreach (String c in Carros)
//            Console.WriteLine(c);

//int x = 10;
//int y = 0;

//while (x < y)
//{
//    Console.WriteLine("{0}",x);
//    x++;
//}

//var nomes = new List<string> {"José", "Maria"};
//nomes.Add("Mariana");
//nomes.Add("Marina");
//nomes.RemoveAt(1);
//nomes.RemoveRange(0, 2);
//nomes.Clear();

//foreach(String nome in nomes)
//    Console.WriteLine($"olá {nome.ToUpper()}!");

//int[] numeros = new int[5];
//Console.WriteLine("Digite 5 numeros");

//for (int i = 0; i < numeros.Length; i++)
//{
//    numeros[i] = Convert.ToInt32(Console.ReadLine());
//}

//static void soma()
//{
//    int n1 = 1;
//    int n2 = 2;
//    int n3 = 3;

//    int soma = n1 + n2 + n3;
//    Console.WriteLine(soma);
//}
//soma();

//static int cubo(int l)
//{
//    return l*l*l;
//}

//Console.WriteLine(cubo(3));


//static int f1(int x)
//{
//    return x*5;
//}
//static int f2(int y)
//{
//    return y * 2;
//}

//Console.WriteLine(f2(f1(2)));



int [,] mat = new int[2,2];

for(int c = 0; c < 2; c++)
{
    for (int l = 0; l < 2; l++)
    {
        mat[c, l] = 1;
    }
    
}