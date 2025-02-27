//BUBLE_SORT
int[] array = [99, 82, 50, 67, 90, 20, 71, 8, 21, 18];

bool mudou = true;
int ultimo = array.Length -1;
int ultimoTemp = array.Length-1;

while (mudou) {
    int pos = 0;
    mudou = false;
    int temp = 0;

    while (pos<ultimo) {
        if (array[pos] > array [pos+1]){
            temp = array[pos];
            array[pos] = array[pos+1];
            array[pos+1] = temp;
            mudou = true;
            ultimoTemp = pos;
        }
        pos++;
    }
    ultimo = ultimoTemp;

    Console.WriteLine(string.Join(",",array));
}