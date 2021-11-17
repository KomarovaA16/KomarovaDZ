using System;

namespace КомароваЗадание6._3
{
    class Program
    { //Два коня
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положение белого коня");
            var whiteKnightPosition = Console.ReadLine();

            Console.WriteLine("Введите положение черного коня");
            var blackKnightPosition = Console.ReadLine();

            if (!IsFiguresPositionsCorrect(whiteKnightPosition,blackKnightPosition))
            {
                Console.WriteLine("Позиции фигур не соответствуют условиям задачи");
            }
            else

            Console.WriteLine("Введите хoд белого коня");
            var move = Console.ReadLine();

            if (IsWKnightCanMakeSafeMove(whiteKnightPosition, blackKnightPosition, move))
                Console.WriteLine($"Белый конь {whiteKnightPosition} может безопасно пойти на клутку {move}");
            else
                Console.WriteLine($"Белый конь {whiteKnightPosition} не может пойти на эту клетку {move}");

            Console.ReadKey();
        }
        static bool IsFiguresPositionsCorrect( string wknightPosition, string bknightPosition)
        {
            return !IsEqualPositions(wknightPosition, bknightPosition) &&
                IsBKnightPositionCorrect(bknightPosition) &&
                !IsWKnightStrikesBKnight(wknightPosition, bknightPosition) &&
                !IsBKnightStrikesWKnight(wknightPosition, bknightPosition);
        }
        static bool IsWKnightCanMakeSafeMove(string wknightPosition, string bknightPosition, string move)
        {
            return IsEqualPositions(wknightPosition, move) &&
                !IsBKnightStrikesWKnight(move, bknightPosition);
        }

        static bool IsEqualPositions(string position1, string position2)
        {
            return position1 == position2;
        }

        static bool IsBKnightStrikesWKnight(string wknightPosition,string bknightPosition)
        {
            int wkx, wky, bkx, bky;

            GetCoordinates(wknightPosition, out wky, out wkx);
            GetCoordinates(bknightPosition, out bky, out bkx);

            return (Math.Abs(bky - wky) == 2 && Math.Abs(bkx - wkx) == 1) || (Math.Abs(bkx - wkx) == 2 && Math.Abs(bky - wky) == 1);

        }
        static bool IsWKnightStrikesBKnight ( string wknightPosition, string bknightPosition)
        {
            return IsWKnightCanMove(wknightPosition, bknightPosition);
        }

        static bool IsBKnightPositionCorrect(string bknightPosition)
        {
            int bkx, bky;
            GetCoordinates(bknightPosition, out bky, out bkx);
            return bky > 0 && bky < 7;
        }
        static bool IsWKnightCanMove(string wknightPosition,string move)
        {
            int wkx, wky, mx, my;

            GetCoordinates(wknightPosition,out wky,out wkx);
            GetCoordinates(move,out my,out mx);

            return wky == my || wkx == mx || Math.Abs(wky - my) == Math.Abs(wkx - mx);
        }

        static void GetCoordinates(string position, out int row, out int column)
        {
            row = (int)position[1] - 0x31;
            column = (int)position[0] - 0x61;
        }
    }
}