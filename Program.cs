// See https://aka.ms/new-console-template for more information
int time =4;
string sonuc=time<=18 ? "İyi günler": "İyi Geceler";
sonuc=time>=6 &&time<=11 ?"Günaydın!":time>=12 && time<=18 ? "İyi Günler!":"İyi Geceler!";
System.Console.WriteLine(sonuc);