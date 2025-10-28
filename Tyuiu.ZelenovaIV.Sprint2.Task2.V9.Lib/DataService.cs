using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZelenovaIV.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                if ((x == 3) && (y >= 5) && (y <= 10)) return false;
                if ((x == 5) && (y >= 5) && (y <= 10)) return false;
                if ((x >= 3) && (x <= 6) && (y == 12)) return false;
                if ((x == 6) && (y >= 3) && (y <= 8)) return false;
                if ((x == 7) && (y >= 3) && (y <= 5) && (y == 7) && (y == 8)) return false;
                if ((x == 8) && (y >= 3) && (y <= 4)) return false;
                if ((x >= 11) && (x <= 13) && (y == 12)) return false;
                if ((x == 13) && (y >= 3) && (y <= 5)) return false;
                if ((x == 13) && (y >= 9) && (y <= 11)) return false;


                return true;
            }
            else
            {
                return false;
            }
        }
    }
}