namespace ClassFunctions
{
    public static class TestPO
    {
        public static void Merge(int[] mas, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] leftmas = new int[n1];
            int[] rightmas = new int[n2];

            for (int g = 0; g < n1; g++) leftmas[g] = mas[left + g];

            for (int f = 0; f < n2; f++) rightmas[f] = mas[mid + 1 + f];

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftmas[i] <= rightmas[j])
                {
                    mas[k] = leftmas[i];
                    i++;
                }
                else
                {
                    mas[k] = rightmas[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                mas[k] = leftmas[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                mas[k] = rightmas[j];
                j++;
                k++;
            }
        }

        public static void MergeSort(int[] mas, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(mas, left, mid);
                MergeSort(mas, mid + 1, right);
                Merge(mas, left, mid, right);
            }
        }

        public static bool Palindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - 1 - i])
                    return false;
            }
            return true;
        }

        public static int Factorial(int n)
        {
            if (n < 0) return -1;

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int Fibonacci(int n)
        {
          
            if (n <= 0) throw new ArgumentException("n должно быть положительным числом", nameof(n));

            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;

            int x = 0, y = 1, z = 0;
            for (int i = 3; i <= n; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            return y;
        }

        public static bool ContainsSubstring(string s, string sub)
        {
            if (s == null || sub == null) throw new ArgumentException("Строки не должны быть null", nameof(s));
            if (sub.Length == 0) return true;

            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                int j;
                // Для текущей позиции i проверяем, совпадают ли все символы подстроки
                for (j = 0; j < sub.Length; j++)
                {
                    if (s[i + j] != sub[j])
                        break;
                }
                // Если дошли до конца подстроки, значит, все символы совпали
                if (j == sub.Length)
                    return true;
            }
            return false;


        }


        public static bool Prostoe(int n)
        {
            if (n <= 1)return false;
             
            int limit = (int)Math.Sqrt(n);
            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static int ReverseInt(int x)
        {
            long reversed = 0;
            int sign = x < 0 ? -1 : 1;
            x = Math.Abs(x);

            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;

                
            }

            reversed *= sign;

            if (reversed < int.MinValue || reversed > int.MaxValue)
                return 0;

            return (int)reversed;
        }
        public static string Rim(int number)
        {
            if (number <= 0 || number > 3999)
                throw new ArgumentOutOfRangeException(nameof(number), "Число должно быть в диапазоне от 1 до 3999");
            var romanNumerals = new[]
            {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900,  Symbol = "CM" },
            new { Value = 500,  Symbol = "D" },
            new { Value = 400,  Symbol = "CD" },
            new { Value = 100,  Symbol = "C" },
            new { Value = 90,   Symbol = "XC" },
            new { Value = 50,   Symbol = "L" },
            new { Value = 40,   Symbol = "XL" },
            new { Value = 10,   Symbol = "X" },
            new { Value = 9,    Symbol = "IX" },
            new { Value = 5,    Symbol = "V" },
            new { Value = 4,    Symbol = "IV" },
            new { Value = 1,    Symbol = "I" }
        };
            var result = new System.Text.StringBuilder();
            foreach (var item in romanNumerals)
            {
                while (number >= item.Value)
                {
                    result.Append(item.Symbol);
                    number -= item.Value;
                }
            }
            return result.ToString();
        }

    }

}