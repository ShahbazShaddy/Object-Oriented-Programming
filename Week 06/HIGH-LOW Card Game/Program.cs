using High_Low.BL;
using High_Low.UIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = Menu.gameMenu();
                if(option == 1)
                {
                    bool gamerunning = true;
                    int score = 0;
                    Deck obj = new Deck();
                    obj.shuffle();
                    Card card1 = obj.dealCard();

                    while (gamerunning)
                    {
                        int remain_check = obj.cardsLeft();
                        Card card2 = obj.dealCard();
                        int card_Check = Menu.remaining(card1, remain_check);
                        if (card_Check == 1)
                        {
                            if (card2.getValue() >= card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                Menu.gameLose(card2, score,gamerunning);
                            }
                        }
                        if(card_Check == 2)
                        {
                            if(card2.getValue() < card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                Menu.gameLose(card2 , score,gamerunning);
                            }
                        }
                        if(obj.cardsLeft() == 0 && card2 == null)
                        {
                            Menu.gamewin(gamerunning);
                            break;
                        }
                    }
                }
            }
            while (option != 2);
        }
    }
}
