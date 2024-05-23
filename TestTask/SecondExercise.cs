namespace TestTask;

public class SecondExercise
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var ans = new List<int>();
        int left = 0;
        int right = matrix[0].Length;
        int top = 0;
        int bottom = matrix.Length;

        while (left < right && top < bottom)
        {
            for (int i = top; i < bottom; i++)
            {
                ans.Add(matrix[i][left]);
            }
            left++;

            for (int i = left; i < right; i++)
            {
                ans.Add(matrix[bottom - 1][i]);
            }
            bottom--;

            if (!(left < right && top < bottom))
            {
                break;
            }

            for (int i = bottom - 1; i > top - 1; i--)
            {
                ans.Add(matrix[i][right - 1]);
            }
            right--;

            for (int i = right - 1; i > left - 1; i--)
            {
                ans.Add(matrix[top][i]);
            }
            top++;
        }

        return ans;
    }
}