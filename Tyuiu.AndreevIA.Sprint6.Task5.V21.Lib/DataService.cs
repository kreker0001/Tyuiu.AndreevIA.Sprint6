using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AndreevIA.Sprint6.Task5.V21.Lib
{
    public class DataService : ISprint6Task5V21
    {

        public int index = 0;
        public double[] LoadFromDataFile(string path)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    len++;
                }
            }

            double[] data = new double[len];

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    data[index] = Convert.ToDouble(line);
                    index++;
                }

            }

            data = data.Where(value => value % 3 == 0).ToArray();
            index = data.Length;
            return data;
        }
    }
}