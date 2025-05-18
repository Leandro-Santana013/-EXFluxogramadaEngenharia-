char movendo, deveria;

Console.WriteLine("Objeto está se movendo (S/N): ");
movendo = char.Parse(Console.ReadLine()!.ToUpper());

Console.WriteLine("Deveria (S/N) se mover: ");
deveria = char.Parse(Console.ReadLine()!.ToUpper());

if (movendo != 'S' && movendo != 'N' || deveria != 'S' && deveria != 'N')
{
    Console.WriteLine("Letra errada");
    return;
}

if (movendo == 'S')
{
    if (deveria == 'S')
        Console.WriteLine("Otimo");
    else
        Console.WriteLine("SilverTape");
}
else
{
    if (deveria == 'S')
        Console.WriteLine("WD40");
    else
        Console.WriteLine("Otimo");
}