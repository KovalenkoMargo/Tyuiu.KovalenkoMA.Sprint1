using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KovalenkoMA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string a)
        {
            if (string.IsNullOrEmpty(a)) 
                return string.Empty;

            string[] parts = a.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (string part in parts)
            {
                if (part.Length > 0)
                    {
                    result += part[part.Length - 1];
                    }
            }
            return result;

        }
    }
}
