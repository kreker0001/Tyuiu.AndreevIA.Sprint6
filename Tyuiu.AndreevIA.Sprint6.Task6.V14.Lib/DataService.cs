using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AndreevIA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder resStr = new StringBuilder();
            string input = File.ReadAllText(path);
            string[] inputSplit = input.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in inputSplit)
            {
                if (word.IndexOf('z') >= 0)
                {
                    resStr.Append(word + " ");
                }
            }


            return resStr.ToString().Trim();
        }
    }
}