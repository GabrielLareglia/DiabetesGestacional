int glicemia;
string diagnostico;
ConsoleColor corExibicao;

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Diabetes Gestacional");
Console.WriteLine();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Glicemia (em mg/dL): ");
glicemia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.ResetColor();

if (glicemia > 126)
{
    diagnostico = "Diabetes Mellitus na gravidez";
    corExibicao = ConsoleColor.Red;
}
else
{
    if (glicemia >= 92)
    {
        diagnostico = "Compatível com Diabetes Gestacional";
        corExibicao = ConsoleColor.Yellow;
    }
    else
    {
        diagnostico = "Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
        corExibicao = ConsoleColor.Blue;
    }
}

Console.ForegroundColor = corExibicao;

Console.WriteLine();
Console.WriteLine(diagnostico);
Console.ResetColor();
