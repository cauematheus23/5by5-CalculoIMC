using System.Reflection.PortableExecutable;

float a, p, imc;
string s;
Console.WriteLine("Olá, bem vindo para calcular seu imc");
do
{
    Console.WriteLine("Digte seu sexo [M] / [F]: ");
    s = Console.ReadLine();
   
} while (s.ToLower() != "m" && s.ToLower() != "f");

do
{
    Console.WriteLine("Digite sua altura em metros");
    a = float.Parse(Console.ReadLine());
} while (a <= 0);

do
{
    Console.WriteLine("Digite seu peso em kg");
    p = float.Parse(Console.ReadLine());
} while (p <= 0);

imc = p / (a * a);
if (imc <= 18.5)
{
    Console.WriteLine($"Seu sexo é {s} e seu imc {imc} = Abaixo do peso");
}
else if (imc > 18.5 && imc <= 24.9)
{
    Console.WriteLine($"Seu sexo é {s} e seu imc {imc} = Peso ideal(parabens)");
}
else if (imc >= 25 && imc <= 29.9)
{
    Console.WriteLine($"Seu sexo é {s} e seu imc {imc} = Levemente acima do peso");
}
else if (imc >= 30 && imc <= 34.9)
{
    Console.WriteLine($"Seu sexo é {s} e seu imc {imc} = Obesidade grau 1");
}
else if (imc >= 35 && imc <= 39.9)
{
    Console.WriteLine($"Seu sexo é {s} e seu imc {imc} = Obesidade grau 2(severa)");
}
else
{
    Console.WriteLine($"Seu sexo é {s} e seu imc {imc} = Obesidade grau 3(morbida)");
}


