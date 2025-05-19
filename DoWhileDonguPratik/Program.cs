//Bu pratikte aynı sorunun cevabını hem while hem de do-while ile kodlamanız ve örnek girdilerde ikisi arasındaki farkı irdelemeniz bekleniyor.

//Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

//( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

//Örnek inputlar : 10 ve - 5

//Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz.



int limit = 0;
int sayac = 1;

Console.WriteLine("Kaç defa yazdırmak istersiniz?: ");

limit = Convert.ToInt32(Console.ReadLine());

while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

Console.WriteLine("-------------------------------------------");

int sayac2 = 1;
int limit2 = 0;

Console.WriteLine("Kaç defa yazdırmak istersiniz: ");
limit2 = Convert.ToInt32(Console.ReadLine());


do
{

    Console.WriteLine("Ben bir Patikalıyım");
    sayac2++;

} while (sayac2 <= limit2);


// do -while döngüsü, en az bir kez çalışır. Bu nedenle, kullanıcı -5 gibi bir negatif sayı girse bile, "Ben bir Patika'lıyım" mesajı en az bir kez ekrana yazdırılır.
// while da döngü koşulu sağlamadan çalışmaz.
