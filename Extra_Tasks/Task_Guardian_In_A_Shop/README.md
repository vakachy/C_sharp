
>Есть магазин "Ромашка"  
Охранник ведёт журнал посещения  
***11-13  
10-14  
9-10  
11-22  
18-18  
0-23  
4-5  
4-5  
4-5***

>**Суть: показать интервалы, когда было больше всего 
людей в магазине**

>**Ответ: 4-5, 11-13**


```string s = "11-44";
var pos = s.IndexOf('-');
System.Console.WriteLine(s.Substring(0, pos));
System.Console.WriteLine(s.Substring(pos + 1));

string[] arg = s.Split('-');
System.Console.WriteLine(arg[0]);
System.Console.WriteLine(arg[1]);```