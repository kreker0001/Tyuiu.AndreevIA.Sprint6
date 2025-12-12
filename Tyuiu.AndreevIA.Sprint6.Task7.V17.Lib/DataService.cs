using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AndreevIA.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            int columns;
            int rows;
            string[] lines = File.ReadAllLines(path);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] values = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    int value = Convert.ToInt32(values[c]);
                    if (r == 1 && value % 2 == 0)
                    {
                        value = 4;
                    }
                    matrix[r, c] = value;
                }
            }
            return matrix;
        }
    }
}