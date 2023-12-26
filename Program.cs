using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("329995549", "Iphone 15", "12435", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new Nokia ("32997897", "Nokia 1100", "13235", 12);
nokia.Ligar();
nokia.InstalarAplicativo("FreeFire");