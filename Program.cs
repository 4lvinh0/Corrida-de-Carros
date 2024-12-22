
using Corrida_de_Onibus;

int carro1 = 1;
int carro2 = 1;

bool andamento = true;

Random rdm = new Random();


do{

#region Imagem
Console.WriteLine(Visual.linhaExtremidade);

Console.WriteLine(new string(' ', carro1 ) + Visual.topoCarro);
Console.WriteLine(new string(' ', carro1 ) + Visual.meioCarro);
Console.WriteLine(new string(' ', carro1 ) + Visual.baixoCarro);

Console.WriteLine(Visual.linhaMeio);

Console.WriteLine(new string(' ', carro2 ) + Visual.topoCarro);
Console.WriteLine(new string(' ', carro2 ) + Visual.meioCarro);
Console.WriteLine(new string(' ', carro2 ) + Visual.baixoCarro);

Console.WriteLine(Visual.linhaExtremidade);

Console.ReadKey();
Console.Clear();

#endregion

#region Sorteio

carro1 += rdm.Next(0, 5);
carro2 += rdm.Next(0, 5);



#endregion

}while(andamento);


