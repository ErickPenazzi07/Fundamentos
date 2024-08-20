using FundamentosOO;

internal class Program

{
    private static void Main(string[] args)
    {
        Livro livro1 = new Livro();
        livro1.title = "A volta de quem não foi";
        livro1.Autor = "Erick";
        livro1.Editora = "DjErick Studio";
        livro1.AnoLançamento = 2007;

        Livro livro2 = new Livro();
        livro2.title = "Eu to lek lek!";
        livro2.Autor = "Thiago";
        livro2.Editora = "VTigas Studio";
        livro2.AnoLançamento = 2000;

        Livro livro3 = new Livro();
        livro3.title = "Hoje é só capa";
        livro3.Autor = "Nobru";
        livro3.Editora = "Nariga Studio";
        livro3.AnoLançamento = 2007;

        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Gleison";
        aluno1.RM = 6969;
        aluno1.Email = "gleisoncapa@gmail.com";
        aluno1.Nascimento = new DateOnly(2022, 02, 22);

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Jurema";
        aluno2.RM = 9696;
        aluno2.Email = "juremazinha12@gmail.com";
        aluno2.Nascimento = new DateOnly(2017, 07, 27);

        Aluno aluno3 = new Aluno();
        aluno3.Nome = "Maiton";
        aluno3.RM = 6996;
        aluno3.Email = "MaitonGameplay15@gmail.com";
        aluno3.Nascimento = new DateOnly(2022, 02, 22);

        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("RM: " + aluno1.RM);
        Console.WriteLine("E-mail: " + aluno1.Email);
        Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        Console.WriteLine("================================================");
        Console.WriteLine();

        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("RM: " + aluno2.RM);
        Console.WriteLine("E-mail: " + aluno2.Email);
        Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        Console.WriteLine("================================================");
        Console.WriteLine();

        Console.WriteLine("Aluno 3");
        Console.WriteLine("Nome: " + aluno3.Nome);
        Console.WriteLine("RM: " + aluno3.RM);
        Console.WriteLine("E-mail: " + aluno3.Email);
        Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        Console.WriteLine("================================================");
        Console.WriteLine();

        //Instanciar um Objeto do Tipo Produto

        Produto p1 = new Produto();
        p1.Nome = "Coca-Cola 2 Litros";
        p1.Codigo = 124567;
        p1.Preco = 12;
        p1.Estoque = 96;

        //chamar o metodo Quantidade Estoque

        p1.QuantidadeEstoque();
        p1.Estoque = 85;
        //Chamar o metodo Quantidade Estoque
        p1.QuantidadeEstoque();

        //Instanciar um objeto de tipo Carro

        Carro carro1 = new Carro();

        carro1.Marca = "Fiat";
        carro1.Modelo = "Fuscao Preto";
        carro1.Velocidade = 60;


        carro1.Acelerar();

        Console.WriteLine("================================================");
        Console.WriteLine();

        Pessoa pessoa1 = new Pessoa();

        pessoa1.Nome = "André";
        pessoa1.Idade = 18;
        pessoa1.DiaAniversario();
        pessoa1.DiaAniversario();

        Console.WriteLine("================================================");
        Console.WriteLine();

        Funcionario func1 = new Funcionario();
        func1.Nome = "Luis Santos";
        func1.Idade = 20;
        func1.Cargo = "Aprendiz";
        func1.Salario = 1400.00;
        func1.Apresentacao();

        Console.WriteLine("================================================");
        Console.WriteLine();


        //instaciar do objeto
        Animal animal1 = new Animal();

        //inserindo dados no atributo
        animal1.Especie = "Cachorro";

        animal1.emitirSom();

        Gato gato1 = new Gato();
        gato1.Nome = "Plutão ";
        Console.WriteLine(gato1.Nome + "faz ");
        gato1.emitirSom();

        Console.WriteLine("================================================");
        Console.WriteLine();

        Porco porco1 = new Porco();
        porco1.Nome = "NhoNho ";
        Console.WriteLine(porco1.Nome + "faz ");
        porco1.emitirSom();

        Console.WriteLine("================================================");
        Console.WriteLine();

        Galinha galinha1 = new Galinha();
        galinha1.Nome = "Jurema ";
        Console.WriteLine(gato1.Nome + "faz ");
        galinha1.emitirSom();

        Console.WriteLine("================================================");
        Console.WriteLine();


    }

}



