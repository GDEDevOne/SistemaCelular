using SistemaCelular.Models;

Nokia nokia = new("99 99999999", "A", "123456", 32);
Iphone iphone = new("99 99999999", "A", "123456", 32);

nokia.Ligar();
nokia.ReceberLigação();
nokia.InstalarAplicativo("Aplicativo Teste Nokia");

iphone.Ligar();
iphone.ReceberLigação();
iphone.InstalarAplicativo("Aplicativo Teste IPhone");