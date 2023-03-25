void ejemploArreglo()
{

    int[] numero = new int[5];// definimos y creamos el arreglo
    int suma = 0;
    numero[0]=45; 
    numero[1] = 50;
    numero[2] = 68;
    numero[3] = 70;
    numero[4] = 86;
    numero[5] = 92;
    numero[6] = 69;
    int elementos = 10;





    for (int i = 0; i < elementos ; i++) 


        {
        suma = suma + numero[i];
        Console.WriteLine(numero[i]);
    }
    Console.WriteLine("Sumatoria=" + suma);
    Console.WriteLine(" El promedio es =" + suma / elementos );

}
ejemploArreglo();