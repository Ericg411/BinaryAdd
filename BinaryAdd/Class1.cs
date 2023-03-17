namespace BinaryAdd;
public class Class1
{
    public string AddBinary(string a, string b)
    {
        var binOne = new Stack<int>();
        var binTwo = new Stack<int>();
        int carry = 0;
        var result = new List<int>();

        foreach (char c in a)
        {
            int charNum = c - '0';
            binOne.Push(charNum);
        }
        foreach (char c in b)
        {
            int charNum = c - '0';
            binTwo.Push(charNum);
        }

        bool oneEmpty = false;
        bool twoEmpty = false;

        while (!oneEmpty || !twoEmpty)
        {
            oneEmpty = !binOne.Any();
            twoEmpty = !binTwo.Any();
            if (oneEmpty && !twoEmpty)
            {
                while (!twoEmpty)
                {
                    var onlyTwo = binTwo.Pop();
                    int onlyTwoSum = onlyTwo + carry;
                    switch (onlyTwoSum)
                    {
                        case 0:
                            result.Add(0);
                            break;
                        case 1:
                            result.Add(1);
                            carry = 0;
                            break;
                        case 2:
                            result.Add(0);
                            carry = 1;
                            break;
                        default:
                            break;
                    }
                    twoEmpty = !binTwo.Any();
                }
            }
            else if (twoEmpty && !oneEmpty)
            {
                while (!oneEmpty)
                {
                    var onlyOne = binOne.Pop();
                    int onlyOneSum = onlyOne + carry;
                    switch (onlyOneSum)
                    {
                        case 0:
                            result.Add(0);
                            break;
                        case 1:
                            result.Add(1);
                            carry = 0;
                            break;
                        case 2:
                            result.Add(0);
                            carry = 1;
                            break;
                        default:
                            break;
                    }
                    oneEmpty = !binOne.Any();
                }
            }
            else
            {
                int one = binOne.Pop();
                int two = binTwo.Pop();
                int sum = one + two + carry;
                switch (sum)
                {
                    case 0:
                        result.Add(0);
                        break;
                    case 1:
                        result.Add(1);
                        carry = 0;
                        break;
                    case 2:
                        result.Add(0);
                        carry = 1;
                        break;
                    case 3:
                        result.Add(1);
                        carry = 1;
                        break;
                    default:
                        break;
                }
                oneEmpty = !binOne.Any();
                twoEmpty = !binTwo.Any();
            }
        }

        if (carry == 1)
        {
            result.Add(carry);
        }
        result.Reverse();
        var strang = string.Join("", result);

        return strang;
    }
}
