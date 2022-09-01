using Kordamine_1_OOP;
//See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Koduloom kass = new Koduloom("Murka", "punane", 'I', 5.5, 7, "Elus");
//kass.print_info();
//Koduloom kassKloon = new Koduloom(kass);
//kassKloon.muuda_Nimi("MurkaKloon");
//kassKloon.muuda_Vanus(2);
//kassKloon.muuda_Kaal(2.3);
//kassKloon.muuda_Sugu('I');
//kassKloon.print_info();
//Rat rat = new Rat(" Dambo", "Ratix", "punane", (double)Koduloom.sugu.Isane, (Koduloom.sugu)0.5, 1, "Elus");
//rat.print_info();
Tootaja tootaja = new Tootaja("THK", "õpetaja", "Marina", 1989, Isik.Sugu.tudruk, 200, 600, 1400);
Opilane Opilane = new Opilane("THK", "opilane", "Aleksandr", 2005, Isik.Sugu.poiss, 100, 300, 700);
Kutsekooliopilane Kutsekooliopilane = new Kutsekooliopilane("THK", "kutsekooliopilane", "Dany", 2006, Isik.Sugu.poiss, 100, 300, 700);
tootaja.print_Info();
Opilane.print_Info();
Kutsekooliopilane.print_Info();


