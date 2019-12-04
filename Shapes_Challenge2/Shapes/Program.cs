using System;
using Shapes_Challenge2;
namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input.ToLower() != "h")
            {
                try
                {

                    Console.WriteLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Would you like to: ");
                    Console.WriteLine("(A)Create Squarer");
                    Console.WriteLine("(C)Create Rectangle");
                    Console.WriteLine("(E)Create Equilateral");
                    Console.WriteLine("(F)Create RightAngle");
                    Console.WriteLine("(G)Create Circle");
                    Console.WriteLine("(H) To Exit");
                    Console.Write("Enter selection: ");

                    input = Console.ReadLine();

                    if (input.ToLower() == "a")
                    {
                        try
                        {
                            Console.WriteLine("Please enter Colour: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Please enter esquare Length: ");
                            string lenght = Console.ReadLine();
                            double s1 = Convert.ToDouble(lenght);

                            if (!(s1 % 1 > 0))
                            {

                                Square sq = new Square(color, s1);
                                Console.WriteLine(sq + " New square : {0} ,{1} ", color, s1);

                            }
                            else
                            {
                                throw new InvalidLengthException();

                            }

                        }
                        catch (InvalidLengthException )
                        {
                            Console.WriteLine("Decimal is not allowed try again!"  );
                        }

                    }
                    else if (input.ToLower() == "c")
                    {
                        try
                        {

                            Console.WriteLine("Please enter Colour: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Please enter rectangle Length: ");
                            string lenght1 = Console.ReadLine();
                            Console.WriteLine("Please enter rectangle Width: ");
                            string lenght2 = Console.ReadLine();
                            double s1 = Convert.ToDouble(lenght1);
                            double s2 = Convert.ToDouble(lenght2);

                            if (!(s1 % 1 > 0) && !(s2 % 1 > 0))
                            {

                                Rectangle rec = new Rectangle(color, s1, s2);

                                Console.WriteLine(rec + " New Rectangle {0}, {1}, {2}", color, s1, s2);
                            }
                            else
                            {
                                throw new InvalidLengthException();
                            }

                        }
                        catch (InvalidLengthException )
                        {
                            Console.WriteLine("Decimal is not allowed try again!" );
                        }
                    }


                    else if (input.ToLower() == "e")
                    {
                        try
                        {
                            Console.WriteLine("Please enter Colour: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Please enter Equilateral Length: ");
                            string lenght = Console.ReadLine();


                            double s1 = Convert.ToDouble(lenght);

                            if (!(s1 % 1 > 0))
                            {

                                Equilateral eq = new Equilateral(color, s1);
                                Console.WriteLine(eq + " New Equilateral : {0} ,{1} ", color, s1);
                            }
                            else
                            {
                                throw new InvalidLengthException();
                            }

                        }
                        catch (InvalidLengthException )
                        {
                            Console.WriteLine("Decimal is not allowed try again!"  );
                        }

                    }
                    else if (input.ToLower() == "f")
                    {
                        try
                        {

                            Console.WriteLine("Please enter Colour: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Please enter RightAngle Length: ");
                            string lenght1 = Console.ReadLine();
                            Console.WriteLine("Please enter RightAngle Width: ");
                            string lenght2 = Console.ReadLine();



                            double s1 = Convert.ToDouble(lenght1);
                            double s2 = Convert.ToDouble(lenght2);

                            if (!(s1 % 1 > 0) && !(s2 % 1 > 0))
                            {

                                RightAngle rig = new RightAngle(color, s1, s2);

                                Console.WriteLine(rig + " New RightAngle {0}, {1}, {2}", color, s1, s2);
                            }
                            else
                            {
                                throw new InvalidLengthException();
                            }

                        }
                        catch (InvalidLengthException )
                        {
                            Console.WriteLine("Decimal is not allowed try again!"  );
                        }
                    }
                    else if (input.ToLower() == "g")
                    {
                        try
                        {
                            Console.WriteLine("Please enter Colour: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Please enter Circle Length: ");
                            string radius = Console.ReadLine();

                            double r = Convert.ToDouble(radius);

                            if (!(r % 1 > 0))
                            {

                                Circle cir = new Circle(color, r);
                                Console.WriteLine(radius + " New Circle : {0} ,{1} ", color, radius);
                            }
                            else
                            {
                                throw new InvalidLengthException();
                            }

                        }
                        catch (InvalidLengthException )
                        {
                            Console.WriteLine("Decimal is not allowed try again!"  );
                        }
                    }

                    else if (input.ToLower() == "h")
                    {
                        break;
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                }
                catch (InvalidInputException )
                {

                    Console.WriteLine("Invalid selection!!! try again: ");
                }

            }


        }
    }
}


