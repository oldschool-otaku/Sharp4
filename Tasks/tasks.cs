using System;
using System.Linq;

namespace Sharp4
{
    public static class Tasks
    {
        public static int GetSquare()
        {
            int[] answers = Array.Empty<int>();
            
            for (int i = 10; i <= 21; i++)
            {
                answers[i-10] = i*i;
            }

            return answers.FirstOrDefault();
        }

        public static int GetSum(int max)
        {
            int answer = 0;
            
            for (int i = 1; i <= max; i++)
            {
                answer = answer + i;
            }
            
            return answer;
        }
        
        public static int GetMultiply(int max)
        {
            int answer = 1;
            
            for (int i = 1; i <= max; i++)
            {
                answer = answer * i;
            }

            return answer - 1;
        }
        
        public static int CheckDivideByThreeNotFive()
        {
            int[] nums = new int[]
            {
                20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 
                35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50
            };
            
            int[] answer = Array.Empty<int>();

            foreach (int t in nums)
            {
                if (t % 3 == 0 && t! % 5 == 0)
                {
                    answer[t] = t;
                }
            }

            return answer.FirstOrDefault();
        }

        public static int CheckDivide()
        {
            int[] nums = new int[]
            {
                35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
                61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86,
                87
            };

            return nums.FirstOrDefault(t => t % 7 == 1 || t % 7 == 2 || t % 7 == 5);
        }
        
        public static int CheckDivideByTenFive()
        {
            int[] nums = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 
                27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50
            };
            int[] answer = Array.Empty<int>();
            
            for (int i = 1; i <= nums.Length; i++)
            {
                if (nums[i] % 5 == 0 || nums[i] % 7 == 0)
                {
                    answer[i] = i;
                }
            }

            return answer.Select(t => t + t).FirstOrDefault();
        }
        
    }
}