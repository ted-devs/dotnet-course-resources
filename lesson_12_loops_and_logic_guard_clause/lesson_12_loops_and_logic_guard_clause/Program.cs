// Guard Clause technique

int age = 20;
double height = 6;
double weight = 65;

if (age < 18) return;
if (age > 30) return;
if (height < 5.5) return;
if (weight < 60) return;
if (weight > 80) return;

Console.WriteLine("You pass");

//if (age > 18)
//{
//    if (age < 30)
//    {
//        if (height > 5.5)
//        {
//            if (weight > 60)
//            {
//                if (weight < 80)
//                {
//                    Console.WriteLine("You pass");
//                }
//            }
//        }
//    }
//}