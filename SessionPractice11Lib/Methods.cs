namespace SessionPractice11Lib
{
    public static class Methods
    {
        public static int AdditionTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public static int CountSpecChar(string line)
        {
            char[] chars = @",<.>/?';:[{]}\|=+-_)(*&^%$#@!~`№".ToCharArray();

            int count = 0;

            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (line[i] == chars[j])
                    {
                        count++;
                    }
                }  
            }

            return count;
        }
    }
}