// Задача: Напишите программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string PrintArray1(string[] fB){
    string sStr = "[";
    for (int i = 0; i < fB.GetLength(0); i++){
        if (fB[i] != string.Empty){
            if (sStr.Length > 1){
                sStr += ", " + fB[i];
            }
            else{
                sStr += fB[i];
            }
        }
    }
    sStr += "]";
    return sStr;
}

string PrintArray2(string[] fB, int iC){
    string sStr = "[";
    for (int i = 0; i < fB.GetLength(0); i++){
        if (fB[i] != string.Empty){
            if (fB[i].Length <= iC + 2){
                if (sStr.Length > 1){
                    sStr += ", " + fB[i];
                }
                else{
                    sStr += fB[i];
                }
            }
        }
    }
    sStr += "]";
    return sStr;
}

int VerifyN(){
    int temp;          //Проверка на ввод числа!
    var vNumb = " ";
    while (int.TryParse(vNumb, out temp) == false){
        Console.Write("Введите число 0 для заданного массива или > 0  для ввода с клавиатуры = ");
        vNumb = Console.ReadLine();
        if (int.TryParse(vNumb, out temp) == false){
            Console.WriteLine("Введите число!");
        }
    }
    return Convert.ToInt32(vNumb);
}

string[] InputArray(){
    Console.WriteLine("Введите строки (остановка ввода: пустая строка): ");
    int iCount = 0;        
    string[] fB = new string[iCount];
    string[] fB2;          
    string sStr = "a";
    while (sStr != ""){
        sStr = Console.ReadLine()!;
        if (sStr != ""){
            iCount++;
            fB2 = new string[iCount];
            for (int i = 0; i < fB2.Length - 1; i++){
                fB2[i] = fB[i];
            }
            fB2[iCount - 1] = "\"" + sStr + "\"";
            fB = fB2;
        }
    }
    return fB;
}

// 1. ввод значений
long fN = 10;
string[] fA = new string[fN];
for (int i = 0; i < fA.GetLength(0); i++){
    fA[i] = string.Empty;
}
int iN = VerifyN();
if (iN == 0){
    fA[0] = "\"1\"";
    fA[1] = "\"-2\"";
    fA[2] = "\"123\"";
    fA[3] = "\"edr4\"";
    fA[4] = "\"tute34235\"";
}
else{
    fA = InputArray();
}
// 2. вычисление
string sStr1 = PrintArray1(fA);
int iCount = 3;
string sStr2 = PrintArray2(fA, iCount);
// 3. печать результата
Console.Write(sStr1 + " -> ");
Console.WriteLine(sStr2);
