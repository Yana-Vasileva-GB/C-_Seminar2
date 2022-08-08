int temp = -30;

/* 
else if - иначе если, ищет первую истину и на этом завершает проверку условий.
if - новая проверка, 4 отдельные проверки
*/

if (temp < 0) Console.WriteLine("Надень шапку");
else if (temp < -10) Console.WriteLine("Надень зимнюю куртку");
else if (temp < -20) Console.WriteLine("Лучше остаться дома");
else if (temp <= -30) Console.WriteLine("Сидим дома");