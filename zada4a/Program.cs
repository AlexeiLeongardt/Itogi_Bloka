// Решаем поставленную задачу

Console.Write("Введите размер массива:");
int A = Convert.ToInt32(Console.ReadLine());
string[] mas1 = new string[A];
string[] mas2 = new string[mas1.Length];

for (int i = 0; i < mas1.Length; i++)
{
    Console.Write("Введите элемент массива:");
    mas1[i]=Convert.ToString(Console.ReadLine());
}
