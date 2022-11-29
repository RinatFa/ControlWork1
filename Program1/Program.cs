// Задача: Напишите программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string PrintArray1(string[] fsArray){
    string sStr = "[";
    for (int i = 0; i < fsArray.GetLength(0); i++){
        if (fsArray[i] != string.Empty){
            if (sStr.Length > 1){
                sStr += ", " + fsArray[i];
            }
            else{
                sStr += fsArray[i];
            }
        }
    }
    sStr += "]";
    return sStr;
}

string PrintArray2(string[] fsArray, int iCountSymb){
    string sStr = "[";
    for (int i = 0; i < fsArray.GetLength(0); i++){
        if (fsArray[i] != string.Empty){
            if (fsArray[i].Length <= iCountSymb + 2){
                if (sStr.Length > 1){
                    sStr += ", " + fsArray[i];
                }
                else{
                    sStr += fsArray[i];
                }
            }
        }
    }
    sStr += "]";
    return sStr;
}

int VerifyN(){
    int iTemp;          //Проверка на ввод числа!
    var vNumb = " ";
    while (int.TryParse(vNumb, out iTemp) == false){
        Console.Write("Введите число 0 для заданного массива или > 0  для ввода с клавиатуры = ");
        vNumb = Console.ReadLine();
        if (int.TryParse(vNumb, out iTemp) == false){
            Console.WriteLine("Введите число!");
        }
    }
    return Convert.ToInt32(vNumb);
}

string[] InputArray(){
    Console.WriteLine("Введите строки (остановка ввода: пустая строка): ");
    int iCount = 0;        
    string[] fsArray = new string[iCount];
    string[] fsArrayNew;          
    string sStr = "a";
    while (sStr != ""){
        sStr = Console.ReadLine()!;
        if (sStr != ""){
            iCount++;
            fsArrayNew = new string[iCount];
            for (int i = 0; i < fsArrayNew.Length - 1; i++){
                fsArrayNew[i] = fsArray[i];
            }
            fsArrayNew[iCount - 1] = "\"" + sStr + "\"";
            fsArray = fsArrayNew;
        }
    }
    return fsArray;
}

// 1. ввод значений
long lNumber = 10;
string[] sArray = new string[lNumber];
for (int i = 0; i < sArray.GetLength(0); i++){
    sArray[i] = string.Empty;
}
int iNumb = VerifyN();
if (iNumb == 0){
    sArray[0] = "\"1\"";
    sArray[1] = "\"-2\"";
    sArray[2] = "\"123\"";
    sArray[3] = "\"edr4\"";
    sArray[4] = "\"tute34235\"";
}
else{
    sArray = InputArray();
}
// 2. вычисление
string sStr1 = PrintArray1(sArray);
int iCount = 3;
string sStr2 = PrintArray2(sArray, iCount);
// 3. печать результата
Console.Write(sStr1 + " -> ");
Console.WriteLine(sStr2);
