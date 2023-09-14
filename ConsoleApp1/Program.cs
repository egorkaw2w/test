/*Console.WriteLine("Сколько ложек сахар вы хотите? ");
string txt = Console.ReadLine();
int num = Convert.ToInt32(txt);
int lojkiSahara = 1 ;
while (lojkiSahara != num + 1)
{
   Console.WriteLine("Добавила " + lojkiSahara + " Ложек сахара");
    lojkiSahara += 1;
    //lojkiSahara++
}*/
/*Console.WriteLine("Сколько ложек сахар вы хотите? ");
string txt = Console.ReadLine();
int num = Convert.ToInt32(txt);
int lojkiSahara = 1;
for (int lojkisahara = 1;lojkisahara < num; lojkisahara++)
{
    Console.WriteLine();
}*/
string txt;
do
{
    Console.WriteLine("Какой цвет вы любите?");
    Console.WriteLine( "1. red");
    Console.WriteLine("2. brown?");
    Console.WriteLine("3. black?");
    Console.WriteLine("4.nothing");

    txt = Console.ReadLine();
    if (txt == "1")
    {
        Console.WriteLine("Why not brown?");
    }
    else if (txt == 2) {
        Console.WriteLine("Why  this?");
            }

} while (txt != "4");