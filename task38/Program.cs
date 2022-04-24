//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

int[] array = new int[10];
void fillArrayRandom(int[] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(0, 101);
    }
}

void printArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int getDifference(int[] array){
    int min = array[0];
    int max = array[0];
    for(int i = 1; i < array.Length; i++){
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    Console.WriteLine("min = " + min);
    Console.WriteLine("max = " + max);
return max - min;
}


fillArrayRandom(array);
printArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + getDifference(array));