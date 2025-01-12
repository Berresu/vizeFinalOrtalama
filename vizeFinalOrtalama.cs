using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Vize Notunuzu Giriniz: ");
	int vizeNotu = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Final Notunuzu Giriniz: ");
	int finalNotu = Convert.ToInt32(Console.ReadLine());
		
    int ortalama = ((vizeNotu * 40) / 100) + ((finalNotu * 60) / 100);
    Console.WriteLine("Ortalamanız: " + ortalama);
        
	if (finalNotu < 45)
	{
		Console.WriteLine("Final Notunuz 45'in Altında Olduğu İçin Kaldınız.");
	}
	else if (ortalama >= 50)
	{
		Console.WriteLine("Not Ortalamanız 50 Veya 50'den Yüksek Olduğu İçin Geçtiniz.");
	}
	else
	{
		Console.WriteLine("Not Ortalamanız 50'den Düşük Olduğu İçin Kaldınız.");
	}
  }
}
