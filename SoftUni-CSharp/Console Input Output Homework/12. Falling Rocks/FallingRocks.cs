using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    const double gameVer = 4.5;
    static uint points = 0;

    static int playFieldWidth;
    static int playerLives;
    static double speed;
    static double acceleration;

    const int pointsLive = 5;
    const int pointsSpeed = 3;
    const int pointsAcc = 2;

    const int PenaltyLives = 1;
    const double PenaltySpeed = 10.0;
    const double PenaltyAcc = 0.1;

    const int BonusLives  = 1;
    const double BonusSpeed  = 30.0;
    const double BonusAcc = 0.1;

    static void Settings()
    {
        Console.Title = "Falling Rocks";

        Console.BufferHeight = Console.WindowHeight = 27;
        Console.BufferWidth = Console.WindowWidth = 71;

        // Console.OutputEncoding = System.Text.Encoding.Unicode;

        playFieldWidth = 43;
        playerLives = 7;
        speed = 100.0;
        acceleration = 0.3;

    }

    struct Object
    {
        public int x;
        public int y;
        public sbyte length;
        public string sign;
        public ConsoleColor color;
    }

    static ConsoleColor GenerateRandomColor(Random randomGen)
    {
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        var colour = (ConsoleColor)consoleColors.GetValue(randomGen.Next(consoleColors.Length));

        if (colour == ConsoleColor.Black)
        {
            return GenerateRandomColor(randomGen);
        }
        else
        {
            return (ConsoleColor)consoleColors.GetValue(randomGen.Next(consoleColors.Length));
        }
    }

    private static Object RocksSignLengthGen(Object newRock, string randomSign)
    {
        for (int i = 0; i <= newRock.length; i++)
        {
            newRock.sign += randomSign;
        }
        return newRock;
    }

    static void PrintAtPosition(int x, int y, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void CreateNewRock(string[] symbols, Random randomGen, List<Object> rocksList)
    {
        Object newRock = new Object();
        newRock.color = GenerateRandomColor(randomGen);
        newRock.x = randomGen.Next(0, playFieldWidth);
        newRock.y = -1;
        newRock.length = (sbyte)randomGen.Next(0, 3);
        string randomSign = symbols[randomGen.Next(0, symbols.Length - 1)];
        newRock = RocksSignLengthGen(newRock, randomSign);
        rocksList.Add(newRock);
    }

    static void CreateBonusLive(Random randomGen, List<Object> objects)
    {
        Object newBonus = new Object();
        newBonus.color = ConsoleColor.Green;
        newBonus.x = randomGen.Next(0, playFieldWidth);
        newBonus.y = -1;
        newBonus.sign = "L";
        objects.Add(newBonus);
    }

    static void CreateBonusSpeed(Random randomGen, List<Object> objects)
    {
        Object newBonus = new Object();
        newBonus.color = ConsoleColor.Green;
        newBonus.x = randomGen.Next(0, playFieldWidth);
        newBonus.y = -1;
        newBonus.sign = "S";
        objects.Add(newBonus);
    }

    static void CreateBonusAcc(Random randomGen, List<Object> objects)
    {
        Object newBonus = new Object();
        newBonus.color = ConsoleColor.Green;
        newBonus.x = randomGen.Next(0, playFieldWidth);
        newBonus.y = -1;
        newBonus.sign = "A";
        objects.Add(newBonus);
    }

    static Object PlayerMove(Object userDwarf)
    {
        while (Console.KeyAvailable)
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);
            if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                if (userDwarf.x - 1 >= 0)
                {
                    userDwarf.x = userDwarf.x - 1;
                }
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                if (userDwarf.x + 1 < playFieldWidth)
                {
                    userDwarf.x = userDwarf.x + 1;
                }
            }
        }
        return userDwarf;
    }

    static void SpeedAccLimit()
    {
        if (speed > 300)
        {
            speed = 300;
        }
        if (acceleration <= 0.1)
        {
            acceleration = 0.1;
        }
    }

    static void Main()
    {
        Settings();
        
        Object userDwarf = new Object();
        userDwarf.x = 20;
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.length = 3; // check if is need
        userDwarf.sign = "(0)";
        userDwarf.color = ConsoleColor.Yellow;

        string[] symbols = new string[] { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";", "-" };
        Random randomGen = new Random();
        List<Object> objects = new List<Object>();

        while (true)
        {
            bool crashed = false;
            bool takenBonus = false;

            sbyte bonusChance = (sbyte)randomGen.Next(0, 177);

            speed += acceleration;
            SpeedAccLimit();

            if ((bonusChance >= 6) && (10 >= bonusChance))
            {
                CreateBonusSpeed(randomGen, objects);
            }
            else if ((bonusChance >= 15) && (17 >= bonusChance))
            {
                CreateBonusLive(randomGen, objects);
            }
            else if ((bonusChance >= 77) && (79 >= bonusChance))
            {
                CreateBonusAcc(randomGen, objects);
            }
            else
            {
                CreateNewRock(symbols, randomGen, objects);
            }

            userDwarf = PlayerMove(userDwarf);

            List<Object> fallingRocksList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object rock = objects[i];
                Object newObject = new Object();
                newObject.x = rock.x;
                newObject.y = rock.y + 1;
                newObject.length = rock.length;
                newObject.sign = rock.sign;
                newObject.color = rock.color;

                if ((newObject.sign == "L") && (userDwarf.x <= newObject.x + newObject.length) && (userDwarf.x + 2 >= newObject.x) && (userDwarf.y == newObject.y))
                {
                    takenBonus = true;
                    playerLives += BonusLives;
                    points += pointsLive;
                }
                else if ((newObject.sign == "S") && (userDwarf.x <= newObject.x + newObject.length) && (userDwarf.x + 2 >= newObject.x) && (userDwarf.y == newObject.y))
                {
                    takenBonus = true;
                    speed -= BonusSpeed;
                    points += pointsSpeed;
                }
                else if ((newObject.sign == "A") && (userDwarf.x <= newObject.x + newObject.length) && (userDwarf.x + 2 >= newObject.x) && (userDwarf.y == newObject.y))
                {
                    takenBonus = true;
                    acceleration -= BonusAcc;
                    points += pointsAcc;
                }
                else if ((userDwarf.x <= newObject.x + newObject.length) && (userDwarf.x + 2 >= newObject.x) && (userDwarf.y == newObject.y))
                {
                    crashed = true;
                    playerLives -= PenaltyLives;
                    speed += PenaltySpeed;
                    acceleration += PenaltyAcc;
                    SpeedAccLimit();
                    if (playerLives <= 0)
                    {
                        Console.Clear();
                        PrintAtPosition(21, 9, "Game Over!", ConsoleColor.Red);
                        PrintAtPosition(11, 10, "Press ENTER to start a new game.", ConsoleColor.Red);
                        PrintGameInfo();
                        Console.ReadLine();

                        Settings();
                    }
                }

                // Points
                if (newObject.y == userDwarf.y)  
                {
                    points += 1;
                }

                if (newObject.y < Console.WindowHeight)
                {
                    fallingRocksList.Add(newObject);
                }
            }

            objects = fallingRocksList;

            Console.Clear();
            if (takenBonus)
            {
                objects.Clear();
                PrintAtPosition(userDwarf.x, userDwarf.y, "†††", ConsoleColor.Green);
            }
            else if (crashed)
            {
                objects.Clear();
                PrintAtPosition(userDwarf.x, userDwarf.y, "XXX", ConsoleColor.Red);
            }
            else
            {
                PrintAtPosition(userDwarf.x, userDwarf.y, userDwarf.sign, userDwarf.color);
            }

            foreach (Object rock in objects)
            {
                PrintAtPosition(rock.x, rock.y, rock.sign, rock.color);
            }

            PrintGameInfo();

            Thread.Sleep((int)(400 - speed)); 
        }
    }

    static void PrintGameInfo()
    {
        PrintAtPosition(45, 1, "Falling Rocks", ConsoleColor.Green);
        PrintAtPosition(45, 2, "bY beBoss 2014", ConsoleColor.Red);
        PrintAtPosition(45, 3, "Version:", ConsoleColor.Green);
        PrintAtPosition(54, 3, string.Format("{0}", gameVer), ConsoleColor.Blue);

        PrintAtPosition(45, 6, "Points:", ConsoleColor.Red);
        PrintAtPosition(53, 6, string.Format("{0}", points), ConsoleColor.Green);

        PrintAtPosition(45, 8, "Lives:", ConsoleColor.White);
        PrintAtPosition(52, 8, string.Format("{0}", playerLives), ConsoleColor.Green);

        PrintAtPosition(45, 9, "Speed:", ConsoleColor.White);
        PrintAtPosition(52, 9, string.Format("{0:f1}", speed), ConsoleColor.Blue);

        PrintAtPosition(45, 10, "Acceleration:", ConsoleColor.White);
        PrintAtPosition(59, 10, string.Format("{0}", acceleration), ConsoleColor.Red);

        PrintAtPosition(45, 12, "Points:", ConsoleColor.Red);
        PrintAtPosition(45, 13, "- Lives (L):", ConsoleColor.Blue);
        PrintAtPosition(58, 13, string.Format("+{0}", pointsLive), ConsoleColor.Green);
        PrintAtPosition(45, 14, "- Speed (S):", ConsoleColor.Blue);
        PrintAtPosition(58, 14, string.Format("+{0}", pointsSpeed), ConsoleColor.Green);
        PrintAtPosition(45, 15, "- Acceleration (A):", ConsoleColor.Blue);
        PrintAtPosition(65, 15, string.Format("+{0}", pointsAcc), ConsoleColor.Green);

        PrintAtPosition(45, 17, "Bonuses:", ConsoleColor.Red);
        PrintAtPosition(45, 18, "- Lives (L):", ConsoleColor.Blue);
        PrintAtPosition(58, 18, string.Format("+{0}", BonusLives), ConsoleColor.Green);
        PrintAtPosition(45, 19, "- Speed (S):", ConsoleColor.Blue);
        PrintAtPosition(58, 19, string.Format("-{0}", BonusSpeed), ConsoleColor.Green);
        PrintAtPosition(45, 20, "- Acceleration (A):", ConsoleColor.Blue);
        PrintAtPosition(65, 20, string.Format("-{0}", BonusAcc), ConsoleColor.Green);

        PrintAtPosition(45, 22, "In crush:", ConsoleColor.Red);
        PrintAtPosition(45, 23, "- Lives:", ConsoleColor.Blue);
        PrintAtPosition(54, 23, string.Format("-{0}", PenaltyLives), ConsoleColor.Green);
        PrintAtPosition(45, 24, "- Speed:", ConsoleColor.Blue);
        PrintAtPosition(54, 24, string.Format("+{0}", PenaltySpeed), ConsoleColor.Green);
        PrintAtPosition(45, 25, "- Acceleration:", ConsoleColor.Blue);
        PrintAtPosition(61, 25, string.Format("+{0}", PenaltyAcc), ConsoleColor.Green);
    }
}