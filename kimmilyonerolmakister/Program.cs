using System.ComponentModel.Design;

int dogru = 0;
//Burada dogru cevapları sayabilmek için bir değişken atıyoruz

Console.WriteLine("Merhabalar yarışmamıza hoş geldiniz");
Console.WriteLine("Sizlere 3 adet soru sorulacak,2 sine dogru cevap verirseniz 1 Milyon TL'lik büyük ödülü kazanacaksınız!");
Console.WriteLine("Hadi Sorularımıza gelelim.");
Console.WriteLine();

#region birincisoru
Console.WriteLine("Hangi marka bir islay bölgesi viskisidir?");
Console.WriteLine("A)Laphroaig");
Console.WriteLine("B)Cardhu");
string bir = Console.ReadLine().ToLower(); //büyük küçük harf duyarlılığı istemediğimiz için girdileri küçük harfe sabitliyoruz

if (bir == "a")
{
    Console.WriteLine("Cevabınız Doğru");
    dogru++;            //Doğru cevağ sayısını 1 arttırdığımız kısım
}
else
{
    Console.WriteLine("Cevabınız Yanlış");
}
#endregion

#region ikincisoru
Console.WriteLine("Hangi marka bir lowland bölgesi viskisidir?");
Console.WriteLine("A)The Macallan");
Console.WriteLine("B)Glenkincie");
string iki = Console.ReadLine().ToLower();

if (iki == "b")
{
    if (dogru == 1) //cevabımız dogru ise daha önceden 1 dogrumuz var mı diye yokladıgımız kısım
    {
        Console.WriteLine("Tebrikler dogru cevap 1 Milyon TL'lik büyük ödülü kazandınız! ");
        return; //2 dogruya ulaştığımız için kazandınız mesajı ileterek yarışmayı sonlandırıyoruz
        dogru++;

    }



    else
    {
        Console.WriteLine("Cevabınız Doğru");
        Console.WriteLine("Hadi son soruya geçelim");
    }
    dogru++;   //daha önceden 1 dogrumuz olmadıgı için dogru cevapda degiskenimizi arttırdıgımız kısım
}
else
{

    if (dogru == 1)     //daha önceden dogru cevabımız var ve yanlıs yaptıysak son soruya yönlenen sonuç
    {
        Console.WriteLine("Cevabınız yanlış hadi son soruya geçelim");

    }
    else
    {
        Console.WriteLine("Malesef yanlış cevap elendiniz!");
        return;    //hiç dogru cevabımız olmadıgı için yarışmadan elenildigi için elendiniz yazısını alıp yarışmayı bitirdiğimiz kısım

    }
}



#endregion

#region ucuncusoru
Console.WriteLine("Hangi marka bir speyside bölgesi viskisidir?");
Console.WriteLine("A)Ardbeg");
Console.WriteLine("B)Glenfiddich");
string uc = Console.ReadLine().ToLower();

//son soruda dogru ise kazanıcagımız için direk dogru veya yanlisa odaklı cevap veriyorum.

if (uc == "b")
{
    Console.WriteLine("Tebrikler dogru cevap 1 Milyon TL'lik büyük ödülü kazandınız!");  
}
else
{
    Console.WriteLine("Malesef yanlış cevap elendiniz!");
}
#endregion
Console.ReadKey();