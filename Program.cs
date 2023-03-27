using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftClient;
using MinecraftClient.Mapping;
using MinecraftClient.Inventory;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //接收指令
            if (JudgementScripts.IsPainting(input)) //是painting指令
            {
                Console.WriteLine(JudgementScripts.PaintingNumber(input)); //输出地图画编号
                switch (JudgementScripts.PaintingNumber(input)) //根据编号进行后续操作
                {
                    case "1":
                        Console.WriteLine("1");
                        break;
                    default:
                        Console.WriteLine("invalid painting number");
                        break;
                }
            }
            else //不是painting指令
            {
                Console.WriteLine("null");
            }
        }
    }
    class JudgementScripts
    {
        public static bool IsPainting(string text) //判断是否为painting指令
        {   
            if (text.Length <=10)
            {
                return false;
            }
            else
            {
                string subOfIInput = text.Substring(0, 9);
                if (subOfIInput == "!painting")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string PaintingNumber(string text) //读取地图画编号
        {
            string latterOfInput = text.Substring(10);
            return latterOfInput;
        }
    }
    class CommandsInGame
    {
        public static void TeleportToPlayer(string playerID) //传送到玩家
        {

        }
        public static void GetItem(int x, int y, int num) //拿取地图画
        {

        }
        public static void DropItem(int num) //扔出地图画
        {

        }
    }
}
