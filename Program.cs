double percentualDeBonus, pontosATransferir, pontosAReduzir;

double percentualDeRetorno, pontosAAcrescentar;


Console.WriteLine("--- Milhas Bumerangue ---\n");

Console.Write(" Percentual de bonus ....");
percentualDeBonus = Convert.ToDouble(Console.ReadLine());

Console.Write(" Percentual de retorno....:");
percentualDeRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write(" Pontos de tranferencia....: ");
pontosATransferir = Convert.ToDouble(Console.ReadLine());


pontosAReduzir = pontosATransferir - ( pontosATransferir * percentualDeRetorno) / 100;
pontosAAcrescentar = pontosATransferir + (pontosATransferir * percentualDeRetorno) / 100;

Console.WriteLine();
Console.WriteLine($"pontos a reduzirna origem..........: {pontosAReduzir}");
Console.WriteLine($"pontos a acrescentar no destino....: {pontosAAcrescentar}");

