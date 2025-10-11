using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChirchenkoME.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {     
        public string FindCardNameAndValue(int m, int k)
        {
     
            string suit = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => "неизвестная масть"
            };
        
            string rank = k switch
            {
                6 => "Шестерка",
                7 => "Семёрка",
                8 => "Восьмёрка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "дама",
                13 => "Король",
                14 => "Туз",
                _ => "неизвестное достоинство"
            };

            return $"{rank} {suit}";
        }
    }
}