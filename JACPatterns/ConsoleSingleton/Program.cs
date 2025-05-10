using ConsoleSingleton; 

Console.WriteLine(Singleton.Instance.texto);
Console.WriteLine(Singleton.Instance.numerito.ToString());
Console.ReadLine();
Singleton.Instance.texto = "XXXXXXXXX";
Singleton.Instance.numerito = 3;
Console.WriteLine(Singleton.Instance.texto);
Console.WriteLine(Singleton.Instance.numerito.ToString());
Console.ReadLine();

//Console.WriteLine(Singleton.GetInstance("Pedro").Texto);
//Console.WriteLine(Singleton.GetInstance("JUan").Texto);