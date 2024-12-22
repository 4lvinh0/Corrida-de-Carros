
using Corrida_de_Onibus;

int carro1 = 1;
int carro2 = 1;

bool andamento = true;

Random rdm = new Random();


do
{
    carro1 += rdm.Next(1, 7);
    carro2 += rdm.Next(1, 7);


    #region Imagem
    Console.Clear();

    Console.WriteLine(Visual.linhaExtremidade);

    Console.WriteLine(new string(' ', carro1) + Visual.topoCarro);
    Console.WriteLine(new string(' ', carro1) + Visual.meioCarro);
    Console.WriteLine(new string(' ', carro1) + Visual.baixoCarro);

    Console.WriteLine(Visual.linhaMeio);

    Console.WriteLine(new string(' ', carro2) + Visual.topoCarro);
    Console.WriteLine(new string(' ', carro2) + Visual.meioCarro);
    Console.WriteLine(new string(' ', carro2) + Visual.baixoCarro);

    Console.WriteLine(Visual.linhaExtremidade);

    //Console.ReadKey();

    #endregion

    if (carro1 >= 135 && carro2 >= 135)
    {
        Console.WriteLine("\n\n\n =================== EMPATE!!! ===================\n\n\n");
        andamento = false;
    }



    if (carro1 >= 135)
    {
        Console.WriteLine("\n\n\n =================== Carro 1 venceu!!! ===================\n\n\n");
        andamento = false;
    }
    if (carro2 >= 135)
    {
        Console.WriteLine("\n\n\n =================== Carro 2 venceu!!! ===================\n\n\n");
        andamento = false;
    }



    await Task.Delay(150);

} while (andamento);


