class Program
{
    static void Main(string[] args)
    {

        int num1 = 0, num2 = 0; // declarando minhas variaveis 
        int resultado = 0;


        while (continua()) // loop para decisão de continuar ou não
        {

       
        Console.WriteLine("Digite o primeiro número inteiro");// imprimindo na tela do usuário 
        num1 = int.Parse(Console.ReadLine());// Guardando dados


        Console.WriteLine("Digite o segundo número inteiro");// imprimindo na tela do usuário 
        num2 = int.Parse(Console.ReadLine());// Guardando dados

        Console.WriteLine("Digite qual operação você quer fazer:"); // perguntando qual operação o usuario vai fazer 
        Console.WriteLine("1- Adição:");
        Console.WriteLine("2- Subtração:");
        Console.WriteLine("3- Divisão:");
        Console.WriteLine("4- Multiplicação:");


        int operacao = int.Parse(Console.ReadLine()); // Guardando dados da operação a ser feitra



        switch (operacao) // se a operacao for alguns desses casos...
        {
            case 1: // caso 1

                resultado = Adição(num1, num2); // faça isso 

                break;

            case 2: // caso 2

                resultado = Subtração(num1, num2);// faça isso

                break;

            case 3:  // caso 3

                resultado = Divisão(num1, num2);// faça isso

                break;

            case 4: // caso 4

                resultado = Multiplicação(num1, num2);// faça isso

                break;

            default:
                Console.WriteLine("Numero invalido, digite outro número");

                break;
        }

        Console.WriteLine("O resultado da operação pedida com os números {0} e {1} são: {2}", num1, num2, resultado);
    }

    }

    public static int Adição(int x, int y) // Metodo para fazer a Adicao
    {

        int result;

        result = x + y;


        return result;
    }

    public static int Subtração(int x, int y) // Metodo para fazer a Subtracao
    {

        int result;

        result = x - y;


        return result;
    }

    public static int Divisão(int x, int y) // Metodo para fazer a Divisao
    {

        int result;

        result = x / y;


        return result;
    }

    public static int Multiplicação(int x, int y) // Metodo para fazer a Multiplicação
    {

        int result;

        result = x * y;


        return result;
    }

    static bool continua() // condição para o loop rodar
{

 Console.WriteLine("Digite 'c' para continuar ou 's' para sair:"); // condição
 string entrada = Console.ReadLine(); 

return entrada != "s"; // se isso x retorne y


}



}