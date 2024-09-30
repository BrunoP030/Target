// 1 
     Console.Write("Informe um número: ");
    int number = Convert.ToInt32(Console.ReadLine());

    bool fibonacci = seqFibonacci(number);

    if (fibonacci)
    {
        Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine($"O número {number} não pertence à sequência de Fibonacci.");
    }

    static bool seqFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        while (b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == numero;
    }

// 2
Console.WriteLine("******************************* Exercicio 2 *******************************");
string frase = "Bom dia, hoje eu vou na academia e ir para a faculdade!";
Console.WriteLine(frase);

string letras = frase.ToLower();
int count = 0;
foreach(char a in letras)
{
    if(a == 'a')
    {
        count++;
    }
}

if(count > 0)
{
    Console.WriteLine($"A letra 'A' aparece {count} vezes");
}
else
{
    Console.WriteLine("A letra 'A' não aparece nenhuma vez");
}

// 3
Console.WriteLine("******************************* Exercicio 3 *******************************");

int indice = 12;
int soma  = 0;
int k = 1;
while(k < indice)
{
    k = k + 1;
    soma = k + soma;
}
Console.WriteLine(soma);
Console.WriteLine($"O valor da variável 'soma' é: {soma}");

// 4
Console.WriteLine("******************************* Exercicio 4 *******************************");

Console.WriteLine("A = [1,3,5,7,9] (números ímpares); B = [2,4,8,16,32,64, 128](potências de 2); C = [0, 1, 4, 9, 16, 25, 36, 49](quadrados perfeitos); D = [4, 16, 36, 64, 100](quadrados de 2, 4, 6,8); E = [1, 1, 2, 3, 5, 8, 13](números de Fibonacci); F = [2, 10, 12, 16, 17, 18, 19, 20](sequência de números);");

Console.WriteLine("******************************* Exercicio 5 *******************************");

Console.WriteLine("Primeiro, ligue o primeiro interruptor e deixe-o ligado por cerca de 10 minutos. Depois, desligue-o e ligue o segundo interruptor. Em seguida, vá até as lâmpadas. A lâmpada que estiver acesa corresponde ao segundo interruptor. Toque nas lâmpadas que estiverem apagadas: a que estiver quente é controlada pelo primeiro interruptor, enquanto a que estiver fria é do terceiro interruptor.");