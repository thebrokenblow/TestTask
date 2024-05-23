using System.Text;

namespace TestTask;

public class FirstExercise
{
    public string CompressString(string input)
    {
        var compressed = new StringBuilder();
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                if (count > 1)
                {
                    compressed.Append(input[i - 1]);
                    compressed.Append(count);
                }
                else
                {
                    compressed.Append(input[i - 1]);
                }
                count = 1;
            }
        }

        if (count > 1)
        {
            compressed.Append(input[^1]);
            compressed.Append(count);
        }
        else
        {
            compressed.Append(input[^1]);
        }

        return compressed.ToString();
    }

    public string DecompressString(string input)
    {
        var decompressed = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                decompressed.Append(input[i]);
            }
            else if (char.IsDigit(input[i]))
            {
                int count = Convert.ToInt32(Convert.ToString(input[i]));
                decompressed.Append(new string(input[i - 1], count - 1));
            }
        }

        return decompressed.ToString();
    }
}