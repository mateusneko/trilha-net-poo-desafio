using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

static void TestarNokia()
{
    Console.WriteLine("Smartphone Nokia G60:");
    Smartphone nokia = new Nokia(numero: "8756-8897", modelo: "G60", imei: "956321078923001", memoria: 64);

    nokia.Ligar();
    nokia.InstalarAplicativo("Banco do Brasil");
    Console.WriteLine("\n------------------------------------------------------------------------------- \n");


}
static void TestarIphone()
{
    Console.WriteLine("Iphone 14 Pro:");
    Smartphone iphone = new Iphone(numero: "9795-4477", modelo: "pro", imei: "154895321623014", memoria: 128);

    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Genshin Impact");

}
TestarNokia();
TestarIphone();
