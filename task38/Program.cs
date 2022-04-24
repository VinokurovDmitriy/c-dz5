//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

double[] array = new double[10];
void fillArrayRandom(double[] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = Math.Round(new Random().NextDouble(), 3) * 10;
    }
}

void printArray(double[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double getDifference(double[] array){
    double min = array[0];
    double max = array[0];
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