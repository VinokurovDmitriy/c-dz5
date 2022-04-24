// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу которая выведет количество четных чисел этого массива
int[] array = new int[10];

void fillArrayRandom(int[] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }
}

void printArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int countEven(int[] array){
    int result = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0){
            result++;
        }
    }
    return result;
}

fillArrayRandom(array);
printArray(array);
Console.WriteLine("Четных чисел в массиве " + countEven(array));
