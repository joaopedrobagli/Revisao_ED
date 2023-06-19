class Program
{
    static void Main(string[] args)
    {
        
        Funcionario funcionario1 = new Funcionario();

        funcionario1.nome = "João";
        funcionario1.cargo = "programador";
        funcionario1.salario = 300f;
        funcionario1.cargaHoraria = 50;

        funcionario1.imprimir();

        funcionario1.promover("gerente", 1000f);
        funcionario1.imprimir();

        funcionario1.aumentarCargaHorariaDeTrabalho(10);
        funcionario1.imprimir();

        
        Carro carro1 = new Carro();
        carro1.nomeModelo = "Fusca";
        carro1.fabricanteMontadora = "Ford";
        carro1.dataFabricacao = "15-06-2020";
        carro1.preco = 50000f;

       
        ListaCarros listaCarros = new ListaCarros();

        listaCarros.inserir(carro1);

        Carro carro2 = new Carro();
        carro2.nomeModelo = "Celta";
        carro2.fabricanteMontadora = "Chevrolet";
        carro2.dataFabricacao = "20-12-2023";
        carro2.preco = 45000f;

        listaCarros.inserir(carro2);

        listaCarros.percorrer();

        bool encontrouCarro = listaCarros.consultar("Fusca");
        if (encontrouCarro)
        {
            Console.WriteLine("O carro Fusca está na lista.");
        }
        else
        {
            Console.WriteLine("O carro Fusca não está na lista.");
        }

        listaCarros.remover();

        listaCarros.percorrer();

        Console.ReadLine();
    }
}

