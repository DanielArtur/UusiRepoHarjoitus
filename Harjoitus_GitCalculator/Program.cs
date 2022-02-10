using System;




float calculation = MakeCount(getNumber("Anna ensimmäinen luku"), getNumber("Anna toinen luku"));


Console.WriteLine(calculation);



float getNumber(string text)
{
    try
    {
        Console.WriteLine(text);
        float number = float.Parse(Console.ReadLine());
        return number;
    }
    catch
    {
        Console.WriteLine("Antamasi tieto on väärä!");
        return getNumber(text);



    }
}


float MakeCount(float num_1, float num_2)
{
    Console.WriteLine("Kerro operaattori");
    string answer = Console.ReadLine();


    switch(answer)
    {
        case "-":
            return num_1 - num_2;
            
        case "+":
            return num_1 + num_2; ;
            
        case "/":
            return num_1 / num_2; ;
            
        case "*":
            return num_1 * num_2; ;
            
        default:
            Console.WriteLine("Väärä operaattori: " + answer);
            return MakeCount(num_1, num_2);
            





    }


}
