// Задайте массив заполненный случайными  числами.
//найдите сумму элементов массива стоящих на не четных позициях
int[] array = new int[10];
void fillArrayRandom(int[] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-100, 101);
    }
}

void printArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int getEvenSum(int[] array){
    int result = 0;
    for(int i = 0; i < array.Length; i++){
        if(i % 2 != 0){
            result += array[i];
        }
    }
    return result;
}

fillArrayRandom(array);
printArray(array);
Console.WriteLine("Сумма элементов массива стоящих на не четных позициях равна " + getEvenSum(array));