using atividade;

Biblioteca.Biblioteca biblioteca = new Biblioteca.Biblioteca();
int selectedOption = 0;

while (true)
{
    Console.Clear();

    ConsoleUtils.WriteTitle("Bem vindo à Biblioteca");

    Console.WriteLine("     Cadastrar Novo Livro");
    Console.WriteLine("     Marcar Livro como perdido");
    Console.WriteLine("     Marcar Livro como destruido");
    Console.WriteLine("     Atualizar dados do livro");
    Console.WriteLine("     Novo Usuário");
    Console.WriteLine("     Altualizar Cadastro do Usuário");
    Console.WriteLine("     Banir Usuário");
    Console.WriteLine("     Emprestar Livro");
    Console.WriteLine("     Devolver Livro");
    Console.WriteLine("     Sair");

    Console.SetCursorPosition(0, 1 + selectedOption);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(">");
    Console.SetCursorPosition(119, 1 + selectedOption);
    Console.WriteLine("<");
    Console.ForegroundColor = ConsoleColor.White;

    var input = Console.ReadKey();
    if (input.Key == ConsoleKey.DownArrow || input.Key == ConsoleKey.RightArrow)
    {
        selectedOption++;
        if (selectedOption == 9) selectedOption = 0;
    }
    else if (input.Key == ConsoleKey.UpArrow || input.Key == ConsoleKey.LeftArrow)
    {
        selectedOption--;
        if (selectedOption < 0) selectedOption = 9;

    }
    else if (input.Key == ConsoleKey.Enter)
    {
        if (selectedOption == 9) { Console.Clear(); return; }
        if (selectedOption == 0) { biblioteca.cadastrarLivro(); }
        selectedOption = 0;
    }
}