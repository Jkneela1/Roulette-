using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Roulette
{
    public class LetsPlay
    {
        NumsandColors numsandColors = new NumsandColors();
        Random rand = new Random();
        public void Playing()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Welcome to the game of Roulette");
            Console.WriteLine("How much money do you want to have PLAYA!");
            int Dinero = int.Parse(Console.ReadLine());
        GoBack:
            Console.WriteLine("There are many bets that you can do in the game of Roulette. Choose ONE of the following bets below");
            Console.WriteLine(" _________________________________");
            Console.WriteLine("|    1. Numbers     2. Odd or Even|");
            Console.WriteLine("|    3. Color       4. Low or High|");
            Console.WriteLine("|    5. Dozens      6. Columns    |");
            Console.WriteLine("|    7. Street Row  8. Double Row |");
            Console.WriteLine("|    9. Split      10. 4 Coners   |");
            Console.WriteLine("|__________________________________");
            Console.WriteLine($"You have {Dinero} dollars.");

            int Bet = Convert.ToInt32(Console.ReadLine());

            if (Bet == 1 || Bet == 2 || Bet == 3 || Bet == 4 || Bet == 5 ||
                    Bet == 6 || Bet == 7 || Bet == 8 || Bet == 9 || Bet == 10)
            {
                

            impoor:
                Console.WriteLine("How much money you tryna wage?");
                int wager = int.Parse(Console.ReadLine());
                if (wager > Dinero)
                {
                    Console.WriteLine("Sorry, you lack the funds to be a baller");
                    goto impoor;
                }

                else 
                {
                    Dinero -= wager;
                    string rolling = numsandColors.numbers[rand.Next(0, 37)];
                    int rolling2 = numsandColors.numbers2[rand.Next(0, 37)];
                    if (Bet == 1)
                    {
                        Console.WriteLine("Since you want to choose numebers, choose yours!");
                        int selection = int.Parse(Console.ReadLine());
                        if (selection.ToString() == rolling)
                        {
                            Console.WriteLine($"The roll was {rolling} and you selected {selection}. Congratulations, you won! {wager * 3}");
                            Dinero += wager * 3;
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }

                        else
                        {
                            Console.WriteLine($"The roll was {rolling} and you selected {selection}. Sorry you lost {wager}");
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }

                    }
                    else if (Bet == 2)
                    {
                        Console.WriteLine("Ok HOTSHOT, odd or even?");
                        Console.WriteLine("For odd 1. and for even 2.");
                        int selection = int.Parse(Console.ReadLine());

                        if (selection == 1)
                        {
                            Console.WriteLine("You chose odd! Well lets see if you lost some mula");
                            Console.ReadLine();

                            bool modulo = rolling2 % 2 == 0;
                            if (modulo == true)
                            {
                                Console.WriteLine($"Sorry Champ{rolling2} is not an odd number");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else if (modulo == false)
                            {
                                Console.WriteLine($"Congrats, {rolling2} is an odd number You win {wager * 2}");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }

                        }

                        if (selection == 2)
                        {
                            Console.WriteLine("So you want an eveb number, lets see what you got!");
                            Console.ReadLine();

                            bool modulo = rolling2 % 2 == 0;
                            if (modulo == false)
                            {
                                Console.WriteLine($"Sorry Champ{rolling2} is not an odd number");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else if (modulo == true)
                            {
                                Console.WriteLine($"Congrats, {rolling2} is an odd number You win {wager * 2}");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                    }
                    else if (Bet == 3)
                    {
                        Console.WriteLine("Choose a color, Red or Black");
                        string selection = Console.ReadLine().ToLower();

                        if (selection == "red")
                        {
                            Console.WriteLine("You chose red so lets see what we got ");

                            if (rolling == numsandColors.numbers[0] || rolling == numsandColors.numbers[2] || rolling == numsandColors.numbers[4] ||
                                rolling == numsandColors.numbers[6] || rolling == numsandColors.numbers[8] || rolling == numsandColors.numbers[11] ||
                                rolling == numsandColors.numbers[13] || rolling == numsandColors.numbers[15] || rolling == numsandColors.numbers[17] ||
                                rolling == numsandColors.numbers[18] || rolling == numsandColors.numbers[20] || rolling == numsandColors.numbers[22] ||
                                rolling == numsandColors.numbers[24] || rolling == numsandColors.numbers[26] || rolling == numsandColors.numbers[29] ||
                                rolling == numsandColors.numbers[31] || rolling == numsandColors.numbers[33] || rolling == numsandColors.numbers[35])
                            {
                                Console.WriteLine($"Congrats, {rolling} is a red number ");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, the number that was rolled was not the color you wanted :(");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        else if (selection == "black")
                        {
                            Console.WriteLine("You chose the number black, hope you got it ");
                            if (rolling == numsandColors.numbers[1] || rolling == numsandColors.numbers[3] || rolling == numsandColors.numbers[5] ||
                                rolling == numsandColors.numbers[7] || rolling == numsandColors.numbers[9] || rolling == numsandColors.numbers[10] ||
                                rolling == numsandColors.numbers[12] || rolling == numsandColors.numbers[14] || rolling == numsandColors.numbers[16] ||
                                rolling == numsandColors.numbers[19] || rolling == numsandColors.numbers[21] || rolling == numsandColors.numbers[23] ||
                                rolling == numsandColors.numbers[25] || rolling == numsandColors.numbers[27] || rolling == numsandColors.numbers[28] ||
                                rolling == numsandColors.numbers[30] || rolling == numsandColors.numbers[32] || rolling == numsandColors.numbers[34])
                            {
                                Console.WriteLine($"Congrats, {rolling} is a black number ");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine($"sorry pal, you rolled {rolling} and thats not black :( , better luck next time");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }

                    }
                    else if (Bet == 4)
                    {
                        Console.WriteLine("AhHh the good ole lows and high. You wann go high or low?");
                        string selection = Console.ReadLine().ToLower();
                        if (selection == "high")
                        {
                            Console.WriteLine("You think itll be high? Lets see ");
                            if (rolling2 > 19)
                            {
                                Console.WriteLine($"Good job you rolled {rolling2}, you get {wager * 2}");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else if (rolling2 < 19)
                            {
                                Console.WriteLine("Sorry bub, you rolled" + rolling2 + "maybe better luck next time");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        else if (selection == "low")
                        {
                            Console.WriteLine("You think itll be low? Lets see ");
                            if (rolling2 < 19)
                            {
                                Console.WriteLine($"Good job you rolled{rolling2}, you get {wager * 2}");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else if (rolling2 > 19)
                            {
                                Console.WriteLine("Sorry bub, you rolled" + rolling2 + "maybe better luck next time");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                    }
                    else if (Bet == 5)
                    {
                        Console.WriteLine("So you like to play Dozens? Ok which set you want");
                        Console.WriteLine("For 1-12 press 1., for 13-24 press 2. and for 25-36 press 3.");
                        int selection = int.Parse(Console.ReadLine());

                        if (selection == 1)
                        {
                            Console.WriteLine("1 through 12? Ok lets get it.");
                            Console.ReadLine();
                            if (rolling2 > 0 && rolling2 < 12)
                            {
                                Console.WriteLine("Congratulations, you won");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you win some, You lose some");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 2)
                        {
                            Console.WriteLine("13 through 24? Ok lets get it.");
                            Console.ReadLine();
                            if (rolling2 > 13 && rolling2 < 24)
                            {
                                Console.WriteLine("Congratulations, you won");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you win some, You lose some");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }

                        }
                        if (selection == 3)
                        {
                            Console.WriteLine("25 through 36? Ok lets get it.");
                            Console.ReadLine();
                            if (rolling2 > 25 && rolling2 < 36)
                            {
                                Console.WriteLine("Congratulations, you won");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you win some, You lose some");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                    }
                    else if (Bet == 6)
                    {
                        Console.WriteLine("Columns is the name, and Roulette is the game! Columns are nomrally 2-1 so lets play");
                        Console.WriteLine("Which column do you want Column 1 with 1, 4, 7, etc. Column 2 with 2, 5, 8, or Column 3 wit 3, 6, 9");
                        int selection = int.Parse(Console.ReadLine());

                        if (selection == 1)
                        {
                            Console.WriteLine("The column 1 selection includes 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34");
                            Console.ReadLine();
                            if (rolling2 == 1 || rolling2 == 4|| rolling2 == 7 || rolling2 == 10 || rolling2 == 13 || rolling2 == 16 || rolling2 == 19||
                                rolling2 == 22 || rolling2 == 25 || rolling2 == 28|| rolling2 == 31|| rolling2 == 34)
                            {
                                Console.WriteLine($"Congratulations, you rolled {rolling2} which met the parameters! You won {wager *2} ");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;

                            }
                            else
                            {
                                Console.WriteLine($"ouch! you rolled {rolling2}, maybe better luck nex time!");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                       else if (selection == 2)
                       {
                            Console.WriteLine("The column 2 selection includes 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35");
                            Console.ReadLine();
                            if (rolling2 == 2 || rolling2 == 5 || rolling2 == 8 || rolling2 == 11 || rolling2 == 14 || rolling2 == 17 || rolling2 == 20 ||
                                rolling2 == 23 || rolling2 == 26|| rolling2 == 29 || rolling2 == 32 || rolling2 == 35)
                            {
                                Console.WriteLine($"Congratulations, you rolled {rolling2} which met the parameters! You won {wager * 2} ");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;

                            }
                            else
                            {
                                Console.WriteLine($"ouch! you rolled {rolling2}, maybe better luck nex time!");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                       }
                       else if (selection == 3)
                       {
                            Console.WriteLine("The column 1 selection includes 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
                            Console.ReadLine();
                            if (rolling2 == 3 || rolling2 == 6 || rolling2 == 9 || rolling2 == 12 || rolling2 == 15 || rolling2 == 18 || rolling2 == 21 ||
                                rolling2 == 24 || rolling2 == 27 || rolling2 == 30 || rolling2 == 33 || rolling2 == 3)
                            {
                                Console.WriteLine($"Congratulations, you rolled {rolling2} which met the parameters! You won {wager * 2} ");
                                Dinero += wager * 2;
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;

                            }
                            else
                            {
                                Console.WriteLine($"ouch! you rolled {rolling2}, maybe better luck nex time!");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                       }

                    }
                    else if (Bet == 7)
                    {
                        Console.WriteLine("So if you dont know, you selected street rows, which is pretty much pairs of 3. Like 1, 2, 3 or 22, 23, 24");
                        Console.ReadLine();
                        Console.WriteLine("There are 12 different outcomes, Choose one of the rows and well, play");
                        int selection = int.Parse(Console.ReadLine());
                        if( selection == 1)
                        {
                            Console.WriteLine("Ok row one contains values one, two, and 3. Good Luck!");
                            Console.ReadLine();

                            if(rolling2 == 1 || rolling2 == 2|| rolling2 == 3)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack; ;
                            }
                        }
                        if (selection == 2)
                        {
                            Console.WriteLine("Ok row one contains values 4, 5, 6. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 4 || rolling2 == 5 || rolling2 == 6)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 3)
                        {
                            Console.WriteLine("Ok row one contains values 7, 8, 9. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 7 || rolling2 == 8 || rolling2 == 9)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2); 
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 4)
                        {
                            Console.WriteLine("Ok row one contains values 10, 11, 12. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 10 || rolling2 == 11 || rolling2 == 12)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack; ;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 5)
                        {
                            Console.WriteLine("Ok row one contains values 13, 14, 15. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 13 || rolling2 == 14 || rolling2 == 15)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 6)
                        {
                            Console.WriteLine("Ok row one contains values 16, 17, 18. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 16 || rolling2 == 17 || rolling2 == 18)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 7)
                        {
                            Console.WriteLine("Ok row one contains values 19, 20, 21. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 19 || rolling2 == 20 || rolling2 == 21)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled "+ rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 8)
                        {
                            Console.WriteLine("Ok row one contains values 22, 23, 24. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 22 || rolling2 == 23 || rolling2 == 24)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 9)
                        {
                            Console.WriteLine("Ok row one contains values 25, 26, 27. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 25 || rolling2 == 26 || rolling2 == 27)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 10)
                        {
                            Console.WriteLine("Ok row one contains values 28, 29, 30. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 28 || rolling2 == 29 || rolling2 == 30)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 11)
                        {
                            Console.WriteLine("Ok row one contains values 31, 32, 33. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 31 || rolling2 == 32 || rolling2 == 33)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                        if (selection == 12)
                        {
                            Console.WriteLine("Ok row one contains values 34, 35, 36. Good Luck!");
                            Console.ReadLine();

                            if (rolling2 == 34 || rolling2 == 35 || rolling2 == 36)
                            {
                                Console.WriteLine("WOW, you must be one lucku person, due to the probability of this being low, I upped the wager to * 5");
                                Console.WriteLine($"You won {wager * 5}");
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                            else
                            {
                                Console.WriteLine("Sorry champ, youll get it next time!");
                                Console.WriteLine("You rolled " + rolling2);
                                Console.ReadLine();
                                Console.Clear();
                                goto GoBack;
                            }
                        }
                    }
                    else if (Bet == 8)
                    {
                        Console.WriteLine("If you didnt know, double rows are also the same as doing the street rows, but its two instead of one");
                        Console.ReadLine();

                        Console.WriteLine("Choose one of the double rows. To do this, enter the bins of the two rows such as 1, 2, 3, 4, 5, 6");
                        int selection1 = int.Parse(Console.ReadLine());
                        int selection2 = int.Parse(Console.ReadLine());
                        int selection3 = int.Parse(Console.ReadLine());
                        int selection4 = int.Parse(Console.ReadLine());
                        int selection5 = int.Parse(Console.ReadLine());
                        int selection6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Now that youve selected your 6 bins, lets see what we rolling!");
                        Console.ReadLine();
                        if (rolling2 == selection1 || rolling2 == selection2 || rolling2 == selection3 || rolling2 == selection4 || rolling2 == selection5 ||
                            rolling2 == selection6)
                        {
                            Console.WriteLine("Lucky man! You rolled" + rolling2 + " which matched one of the rows you chose. You won" + wager *2 );
                            Dinero += wager * 2;
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }
                        else
                        {
                            Console.WriteLine("Sucks teeth. Sorry buddy we rolled" + rolling2 +" mission failed, youll get em next time");
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }

                    }
                    else if (Bet == 9)
                    {
                        Console.WriteLine("So you chose splits? Split corners are at the edge of two continuos numbers. So any two numbers that connect" +
                            "on the board is the split! For example 1/2 or 11/14 or 32/ 35.");
                        Console.WriteLine("There is a low probability so ive increased the wager multiplier to *4. Now choose your split");
                        int selection1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("And for the secont part of the spilt?");
                        int selection2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Alrighty, lets roll and see if you winning");
                        Console.ReadLine();
                        if (selection1 == rolling2 || selection2 == rolling2)
                        {
                            Console.WriteLine($"Daaaaaam, you are really lucky. We rolled"+ rolling2 +"You now earned" + wager * 4);
                            Dinero += wager * 4;
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, you rolled {rolling2}. Maybe next time youll choose the right numbers! Good luck.");
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }
                    }
                    else if (Bet == 10)
                    {
                        Console.WriteLine("So 4 corners is pretty much like split, but it involves all corners touch each other.");
                        Console.WriteLine("Some examples include 1, 2, 4, 5 or 19, 20, 22, 23. Choose your 4 corners.");
                        int selection1 = int.Parse(Console.ReadLine());
                        int selection2 = int.Parse(Console.ReadLine());
                        int selection3 = int.Parse(Console.ReadLine());
                        int selection4 = int.Parse(Console.ReadLine());

                        Console.WriteLine("You ready to make some money? I am lets go!");
                        Console.ReadLine();
                        if( selection1 == rolling2 || selection2 == rolling2 || selection3 == rolling2 || selection4 == rolling2)
                        {
                            Console.WriteLine($"Look at you being lucky, we rolled {rolling2} good job. Well give you {wager * 3}");
                            Dinero += wager * 3;
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }
                        else
                        {
                            Console.WriteLine($"Yikes, we rolled {rolling2}, better luck next time");
                            Console.ReadLine();
                            Console.Clear();
                            goto GoBack;
                        }


                    }
                }
            }      



            else { 
                Console.WriteLine("Enter a valid Bet!");
                Console.ReadLine();
                Console.Clear();
                goto GoBack;
            }

        }
    }
}
