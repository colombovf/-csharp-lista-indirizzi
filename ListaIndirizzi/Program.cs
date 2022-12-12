// See https://aka.ms/new-console-template for more information

using ListaIndirizzi;

List<Indirizzo> personalData = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:/Users/Samsung/Desktop/GenItaly/Esercizi/EX-VS2022/ListaIndirizzi/ListaIndirizzi/addresses.csv");
    string row;
    if (!file.EndOfStream)
        row = file.ReadLine();
    
    while (!file.EndOfStream)
    {
        row = file.ReadLine();
        string[] datainfo = row.Split(",");

        Indirizzo currentAddress = new Indirizzo(datainfo[0], datainfo[1], datainfo[2], datainfo[3], datainfo[4], datainfo[5]);
       // Console.WriteLine(currentAddress.ToString());
        personalData.Add(currentAddress);
    } 

} catch (Exception e)
{
    Console.WriteLine("Errore di lettura");
    Console.WriteLine("Inserire Nome,Cognome,Strada,città,provincia,ZIP (seguendo il formato indicato)");
    string newStringDataInfo = Console.ReadLine();
    string[] datainfo = newStringDataInfo.Split(",");
    Indirizzo currentAddress = new Indirizzo(datainfo[0], datainfo[1], datainfo[2], datainfo[3], datainfo[4], datainfo[5]);
    //Console.WriteLine(currentAddress.ToString());
    personalData.Add(currentAddress);
}

foreach(Indirizzo addr in personalData)
{
    Console.WriteLine(addr);
}