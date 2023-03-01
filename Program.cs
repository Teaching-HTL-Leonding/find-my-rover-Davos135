string direction;
bool valid = false;
int x = 0, y = 0;

Level0();
//Level1();

void Level0()
{
while (!valid)
{
    Console.Write("Enter the direction: ");
    direction = Console.ReadLine()!;

    if (direction == "")
    {
        Console.WriteLine("can't be empty");
    }
    else
    {
        for (int i = 0; i < direction.Length; i++)
        {
            char c = direction[i];

            if (c == '<' || c == '>' || c == '^' || c == 'V')
            {
                switch (c)
                {
                    case '>':
                        x++;
                        break;
                    case '<':
                        x--;
                        break;
                    case 'V':
                        y--;
                        break;
                    case '^':
                        y++;
                        break;
                }
            }
            else
            {
                Console.WriteLine("invalid ");
                break;
            }

            if (i == direction.Length - 1)
            {
                valid = true;
            }
        }
    }
}
    if (x > 0 && y > 0) { System.Console.WriteLine($"{x}m east, {y}m north"); }
   else if (x > 0 && y < 0) { System.Console.WriteLine($"{x}m east, {y}m south"); }
   else if (x < 0 && y < 0) { System.Console.WriteLine($"{x}m west, {y}m south"); }
   else if (x < 0 && y > 0) { System.Console.WriteLine($"{x}m west, {y}m north"); }
   else if (x < 0 && y == 0) { System.Console.WriteLine($"{x}m west, {y}m "); }
   else if (x > 0 && y == 0) { System.Console.WriteLine($"{x}m east, {y}m "); }
   else if (x == 0 && y > 0) { System.Console.WriteLine($"{x}m , {y}m north "); }
   else if (x == 0 && y < 0) { System.Console.WriteLine($"{x}m , {y}m south "); } 
   else {Console.WriteLine("in the base");}
   


}

void Level1()
{
while (!valid)
{
    Console.Write("Enter the direction: ");
    direction = Console.ReadLine()!;

    if (direction == "")
    {
        Console.WriteLine("can't be empty");
    }
    else
    {
        for (int i = 0; i < direction.Length; i++)
        {
            char c = direction[i];

            if (c == '<' || c == '>' || c == '^' || c == 'V')
            {
                switch (c)
                {
                    case '>':
                        x++;
                        break;
                    case '<':
                        x--;
                        break;
                    case 'V':
                        y--;
                        break;
                    case '^':
                        y++;
                        break;
                }
            }
            else
            {
                Console.WriteLine("invalid ");
                break;
            }

            if (i == direction.Length - 1)
            {
                valid = true;
            }
        }
    }
}
double LinearDistance = Math.Sqrt(x * x + y * y);
double ManhattanDistance = x + (y * -1);
System.Console.WriteLine($"Linear Distance: {LinearDistance}m , Manhattan Distance: {ManhattanDistance}m");
}




