Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine(IdadeRetorno(idade));

static string IdadeRetorno(int idade)
{
    if (idade <= 12)
    {
        return "Criança";
    }
    else if (idade >= 12 && idade <= 18)
    {
        return "Adolescente";
    }
    return "Adulto";
}
