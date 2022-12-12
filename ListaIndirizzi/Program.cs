// See https://aka.ms/new-console-template for more information

using ListaIndirizzi;

List<Indirizzo> personalData = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:/Users/Samsung/Desktop/GenItaly/Esercizi/EX-VS2022/ListaIndirizzi/ListaIndirizzi/addresses.csv");
    while (!file.EndOfStream)
    {
        string row = file.ReadLine();
        string[] datainfo = row.Split(",");

        Indirizzo currentAddress = new Indirizzo(datainfo[0], datainfo[1], datainfo[2], datainfo[3], datainfo[4], datainfo[5]);
        Console.WriteLine(currentAddress.ToString());
        personalData.Add(currentAddress);
    } 

} catch (Exception e)
{
    Console.WriteLine("Errore");
}