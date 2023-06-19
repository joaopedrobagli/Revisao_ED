using System;

struct Funcionario
{
    public string nome;
    public string cargo;
    public float salario;
    public int cargaHoraria;

    public void aumentoSalarialPorPromocaoEmValor(float valor)
    {
        salario += valor;
    }

    public void promover(string novoCargo, float aumentoSalarial)
    {
        cargo = novoCargo;
        aumentoSalarialPorPromocaoEmValor(aumentoSalarial);
    }

    public void descontoSalarialPorFaltaEmValor(float valor)
    {
        salario -= valor;
    }

    public void aumentarCargaHorariaDeTrabalho(int horas)
    {
        cargaHoraria += horas;
        salario *= (cargaHoraria / 40.0f); 
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Carga Horária: " + cargaHoraria + " horas");
    }
}

struct Carro
{
    public string nomeModelo;
    public string fabricanteMontadora;
    public string dataFabricacao;
    public float preco;
}

class No
{
    public Carro carro;
    public No proximo;
}

class ListaCarros
{
    private No primeiro;
    private No ultimo;

    public ListaCarros()
    {
        primeiro = null;
        ultimo = null;
    }

    public void inserir(Carro carro)
    {
        No novoNo = new No();
        novoNo.carro = carro;
        novoNo.proximo = null;

        if (primeiro == null)
        {
            primeiro = novoNo;
            ultimo = novoNo;
        }
        else
        {
            ultimo.proximo = novoNo;
            ultimo = novoNo;
        }
    }

    public bool consultar(string nomeModelo)
    {
        No atual = primeiro;
        while (atual != null)
        {
            if (atual.carro.nomeModelo == nomeModelo)
                return true;
            atual = atual.proximo;
        }
        return false;
    }

    public void remover()
    {
        if (primeiro == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        if (primeiro == ultimo)
        {
            primeiro = null;
            ultimo = null;
        }
        else
        {
            No atual = primeiro;
            while (atual.proximo != ultimo)
            {
                atual = atual.proximo;
            }
            ultimo = atual;
            ultimo.proximo = null;
        }
    }

    public void percorrer()
    {
        No atual = primeiro;
        while (atual != null)
        {
            Console.WriteLine("Nome do Modelo: " + atual.carro.nomeModelo);
            Console.WriteLine("Fabricante/Montadora: " + atual.carro.fabricanteMontadora);
            Console.WriteLine("Data de Fabricação: " + atual.carro.dataFabricacao);
            Console.WriteLine("Preço: " + atual.carro.preco);
            Console.WriteLine();
            atual = atual.proximo;
        }
    }
}
