// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        //int a = 10;
        //float f = 23.45f;
        //double d = 56.777;
        //string str = "Ajay";
        //Console.WriteLine("value of a =" + a);
        //Console.WriteLine("value of f{0},d{1}", f, d);
        //Console.WriteLine($"a={a},float ={f},double={d}");
        //Console.WriteLine(str);


        //int sum, sub, multi, div;

        //Console.WriteLine("Enter a 1st number:");
        //int num1=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("enter a 2nd number");
        //int num2=Convert.ToInt32(Console.ReadLine());

        //sum=num1 + num2;
        //Console.WriteLine(sum);


        //sub = num1 - num2;
        //Console.WriteLine(sub);

        //multi = num1 * num2;
        //Console.WriteLine(multi);


        //div = num1 / num2;
        //Console.WriteLine(div);




        Student stud = new Student();
        stud.Name = "Ajay";
        stud.Percentage = 60.00;
        stud.RollNumber = 18;

        Console.WriteLine($"Student name{stud.Name}");
        Student stud = new Student { RollNumber = 18, nameof = "Aj", Percentage = 75 };
        Console.WriteLine($"Student name {stud.Name} Percentage is {stud.Percentage}");



    }
}
