using Clase_07.Clases;

////Tractor
Tractor tractor = new Tractor("Tractor New Holland", 30,"Obdulio Lemus", "Verde");
Console.WriteLine(tractor.DameInformacion());
Console.WriteLine(tractor.EncenderMotor());
for(int i = 0; i < 7; i++)
{
    Console.WriteLine(tractor.acelerar(5));
}
Console.WriteLine(tractor.LevantarPala());
Console.WriteLine(tractor.Bajarpala());
Console.WriteLine(tractor.capacidad(70));
Console.WriteLine(tractor.capacidad(100));


//Moto
Moto moto = new Moto("Moto Yamaha", 120, "Donald Lemus","Negra");

Console.WriteLine($"\n{moto.DameInformacion()}");
Console.WriteLine(moto.EncenderMotor());
for (int i = 0; i < 15; i++)
{
    Console.WriteLine(moto.acelerar());
}
Console.WriteLine(moto.frenoAdelante());
Console.WriteLine(moto.frenoAdelante());
Console.WriteLine(moto.frenoAtras());
Console.WriteLine(moto.frenoAtras());
Console.WriteLine(moto.Parrila());
Console.WriteLine(moto.Parrila());
Console.WriteLine(moto.Caballito());
Console.WriteLine(moto.Caballito());

//Carretilla
CarretillaElevadora carretilla = new CarretillaElevadora("Montacargas Toyota", 20, "Donald Obdulio", "Amarrila");
Console.WriteLine($"\n{carretilla.DameInformacion()}");
Console.WriteLine(carretilla.EncenderMotor());
for(int i = 0; i < 3; i++)
{
    Console.WriteLine(carretilla.acelerar());
}
Console.WriteLine(carretilla.Carga("No"));
Console.WriteLine(carretilla.Carga("Si"));
Console.WriteLine(carretilla.SubirBrazos());
Console.WriteLine(carretilla.SubirBrazos());
Console.WriteLine(carretilla.BajarBrazos());
Console.WriteLine(carretilla.BajarBrazos());





