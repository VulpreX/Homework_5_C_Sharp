void AddDigitalToArray1 (int[] digital)
    {
           
        for ( int i=0 ;  i < digital.Length; i++)
            {
                digital[i] = Math.Abs(new Random().Next(-10000, 10000));
                
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
void SearchForEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if ( array[i] % 2 == 0)
        {
            count++ ;
        }        
          
    }
    Console.WriteLine($" Amount of even numbers = {count}"); 

}
int[] array = new int [ReadInt1(" Enter array lenght ")];
AddDigitalToArray1(array);
Console.WriteLine();
Console.WriteLine(string.Join(" ", array));
SearchForEvenNumbers(array);

