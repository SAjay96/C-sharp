 class Threedigit
    {
	static void main(string[] args)
	{
		int num, first_digit, third_digit;
		int Sum = 0, Reminder;
				

			  Console.WriteLine("Enter The Number:");
				num=Convert.ToInt32(Console.ReadLine());	
				if(num>99 && num<1000)
					{
					 Console.WriteLine("It is a Three Digit Number.");
					}
				else
				{
            Console.WriteLine("It is Not a Three Digit Number.");
				}

		  first_digit = num;

		while (first_digit >= 10)
		{
			first_digit = first_digit / 10;
		}

		third_digit = num % 10;

        Console.WriteLine("The First Digit " + num + "  =  " + first_digit);
        Console.WriteLine("The Third Digit " + num + "  =  " + third_digit);

		Sum = first_digit + third_digit;

		
        Console.WriteLine(+Sum);

		}
    }

