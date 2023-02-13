void AddDigitalToArray1 (double[] digital)
    {
           
        for ( int i=0 ;  i < digital.Length; i++)
            {
                digital[i] = new Random().Next(-10000, 10000); 
                if(digital[i]>0)
                {
                   digital[i] = digital[i] + new Random().NextDouble() ;
                }
                else
                {
                    digital[i] = digital[i] - new Random().NextDouble();
                }
            }       
          
    }    

int ReadInt1(string argument1)
{
    Console.Write($"Enter {argument1} - ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine(" You entered an invalid number, try again!");
    }
    

    return number; 
}
void DifferenceBetweenMaxAndMin(double[] array)
{
    double max = array[1];
    double min = array[1] ;
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
        else if( min > array[i])
        {
            min = array[i];
        }

    }
    System.Console.WriteLine($"minimal number = {min}; maximal number = {max} ; Defference between max and min number = {max + min} "); 
}
double[] array = new double [ReadInt1(" Enter array lenght  ")];
AddDigitalToArray1(array);
Console.WriteLine();
Console.WriteLine(string.Join("    ", array));
Console.WriteLine();
DifferenceBetweenMaxAndMin(array);