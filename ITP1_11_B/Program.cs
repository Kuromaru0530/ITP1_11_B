using System;
using System.Linq;
using System.Collections.Generic;
class Dice
{
    private int[] surfaces = { 0, 1, 2, 3, 4, 5, 6 };

    public Dice(int[] surfaces)
    {
        this.surfaces = surfaces;
    }

    public void up()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[2];
        surfaces[2] = surfaces[6];
        surfaces[6] = surfaces[5];
        surfaces[5] = surfaces[0];
    }

    public void down()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[5];
        surfaces[5] = surfaces[6];
        surfaces[6] = surfaces[2];
        surfaces[2] = surfaces[0];
    }

    public void left()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[3];
        surfaces[3] = surfaces[6];
        surfaces[6] = surfaces[4];
        surfaces[4] = surfaces[0];
    }

    public void right()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[4];
        surfaces[4] = surfaces[6];
        surfaces[6] = surfaces[3];
        surfaces[3] = surfaces[0];
    }

    public void rrotate()
    {
        surfaces[0] = surfaces[2];

        surfaces[2] = surfaces[4];
        surfaces[4] = surfaces[5];
        surfaces[5] = surfaces[3];
        surfaces[3] = surfaces[0];
    }

    public void lrotate()
    {
        surfaces[0] = surfaces[2];

        surfaces[2] = surfaces[3];
        surfaces[3] = surfaces[5];
        surfaces[5] = surfaces[4];
        surfaces[4] = surfaces[0];
    }

    public int getNum(int num)
    {
        return surfaces[num];
    }
}

class Program
{
    static void Main()
    {
        string[] Input = Console.ReadLine().Split(' ');       
        int[] iInput = new int[7];
        iInput[0] = 0;

        for(int i = 0; i < Input.Length; i++)
        {
            iInput[i + 1] = int.Parse(Input[i]); 
        }

        Dice dice = new Dice(iInput);

        int q = int.Parse(Console.ReadLine());
        int[] ans = new int[q];
        for(int i = 0; i < q; i++)
        {           
            

            string[] In = Console.ReadLine().Split(' ');

            int index1 = Array.IndexOf(Input, In[0]);
            int index2 = Array.IndexOf(Input, In[1]);

            switch (index1)
            {
                case 0:
                    switch(index2)
                    {
                        case 1:
                            ans[i] = dice.getNum(3);
                            break;
                        case 2:
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            break;
                        case 3:
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            break;
                        case 4:
                            dice.rrotate();
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            dice.lrotate();
                            break;
                    }
                    break;
                case 1:
                    dice.up();
                    switch(index2)
                    {
                        case 0:
                            dice.rrotate();
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            dice.lrotate();
                            break;
                        case 2:
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            break;
                        case 3:
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            break;
                        case 5:
                            ans[i] = dice.getNum(3);
                            break;
                    }
                    dice.down();
                    break;
                case 2:
                    dice.left();
                    switch(index2)
                    {
                        case 0:
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            break;
                        case 1:
                            ans[i] = dice.getNum(3);
                            break;
                        case 4:
                            dice.rrotate();
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            dice.lrotate();
                            break;
                        case 5:
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            break;
                    }
                    dice.right();
                    break;
                case 3:
                    dice.right();
                    switch(index2)
                    {
                        case 0:
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            break;
                        case 1:
                            ans[i] = dice.getNum(3);
                            break;
                        case 4:
                            dice.lrotate();
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            dice.rrotate();
                            break;
                        case 5:
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            break;
                    }
                    dice.left();
                    break;
                case 4:
                    dice.down();
                    switch (index2)
                    {
                        case 0:
                            ans[i] = dice.getNum(3);
                            break;
                        case 2:
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            break;
                        case 3:
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            break;
                        case 5:
                            dice.rrotate();
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            dice.lrotate();
                            break;
                    }
                    dice.up();
                    break;
                case 5:
                    dice.up();
                    dice.up();
                    switch(index2)
                    {
                        case 1:
                            dice.lrotate();
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            dice.rrotate();
                            break;
                        case 2:
                            dice.lrotate();
                            ans[i] = dice.getNum(3);
                            dice.rrotate();
                            break;
                        case 3:
                            dice.rrotate();
                            ans[i] = dice.getNum(3);
                            dice.lrotate();
                            break;
                        case 4:
                            ans[i] = dice.getNum(3);
                            break;
                    }
                    dice.down();
                    dice.down();
                    break;
            }
            
        }
        for(int i = 0; i < q; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
}
