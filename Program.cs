Console.WriteLine("BEM VINDO Á CALCULADORA!\nInforme qual operação você quer realizar:");
Console.WriteLine("+ > SOMA\n- > SUBTRAÇÃO\n* > MULTIPLICAÇÃO\n/ > DIVISÃO\n% > RESTO DA DIVISÃO");

string operador = Console.ReadLine();

Console.WriteLine("DIGITE OS DOIS VALORES");
var a = Convert.ToDouble(Console.ReadLine());
var b = Convert.ToDouble(Console.ReadLine());

float resposta = 0;
int saidaValor = 0;

switch (operador)
{
    case "+":
        resposta = (float)(a + b);
        Console.WriteLine("QUER O RESULTADO INTEIRO(1) OU NÃO INTEIRO(2)?");
        saidaValor = Convert.ToInt32(Console.ReadLine());
        switch (saidaValor)
        {
            case 1:
                Console.WriteLine($"O RESULTADO É {Convert.ToInt32(resposta)}");
                break;
            case 2:
                Console.WriteLine($"O RESULTADO É {resposta}");
                break;
        }
        break;
    case "-":
        resposta = (float)(a - b);
        Console.WriteLine("QUER O RESULTADO INTEIRO(1) OU NÃO INTEIRO(2)?");
        saidaValor = Convert.ToInt32(Console.ReadLine());
        switch (saidaValor)
        {
            case 1:
                Console.WriteLine($"O RESULTADO É {Convert.ToInt32(resposta)}");
                break;
            case 2:
                Console.WriteLine($"O RESULTADO É {resposta}");
                break;
        }
        break;
    case "*":
        resposta =(float)(a * b);
        Console.WriteLine("QUER O RESULTADO INTEIRO(1) OU NÃO INTEIRO(2)?");
        saidaValor = Convert.ToInt32(Console.ReadLine());
        switch (saidaValor)
        {
            case 1:
                Console.WriteLine($"O RESULTADO É {Convert.ToInt32(resposta)}");
                break;
            case 2:
                Console.WriteLine($"O RESULTADO É {resposta}");
                break;
        }
        break;
    case "/":
        if ( a == 0 || b == 0)
        {
            Console.WriteLine("NÃO EXISTE DIVISÃO POR ZERO!");
            break;
        }
        else
        {
            resposta = (float)(a / b);
            Console.WriteLine("QUER O RESULTADO INTEIRO(1) OU NÃO INTEIRO(2)?");
            saidaValor = Convert.ToInt32(Console.ReadLine());
            switch (saidaValor)
            {
                case 1:
                    Console.WriteLine($"O RESULTADO É {Convert.ToInt32(resposta)}");
                    break;
                case 2:
                    Console.WriteLine($"O RESULTADO É {resposta}");
                    break;
            }
            break;
        }
    case "%":
        resposta =(float)(a % b);
        Console.WriteLine("QUER O RESULTADO INTEIRO(1) OU NÃO INTEIRO(2)?");
        saidaValor = Convert.ToInt32(Console.ReadLine());
        switch (saidaValor)
        {
            case 1:
                Console.WriteLine($"O RESULTADO É {Convert.ToInt32(resposta)}");
                break;
            case 2:
                Console.WriteLine($"O RESULTADO É {resposta}");
                break;
        }
        break;
    default:
        Console.WriteLine("ERRO, ENCERRANDO SISTEMA...");
        break;
}







Console.ReadKey();