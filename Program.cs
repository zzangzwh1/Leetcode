using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Resolve
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static string[,] tickets = { { "MUC", "LHR" }, { "JFK", "MUC" }, { "SFO", "SJC" }, { "LHR", "SFO" } };

        static void Main(string[] args)
        {
            //int[] arr = {9,9,9,3,3,2,4};
            //int value = func(arr);
            // Console.WriteLine(Math.Floor(Math.Sqrt(8)));

            Console.WriteLine(1^4);

            Console.ReadLine();

        }
        private static int[] PlusOneArr(int[] digits)
        {
            string s = "";

                for(int i = digits.Length-1; i>=0; i--)
                {
                  if(digits[i]<9)
                    {
                        digits[i]++;
                        
                         return digits;
                    }
                    digits[i] = 0;
                }
                int[] temp = new int[digits.Length + 1];
                temp[0] = 1;

                return temp;


        }
        public static int func(int[] nums)
        {
            string s = "";
            Array.Sort(nums);
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    ++i;
                    nums[i] = nums[j];
                }
           
            }
            Console.WriteLine(i + 1);
            return i + 1;
        }
       
   
        private static void OccurrencyInString(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach(char c in str)
            {
                char upper = Char.ToUpper(c);
                if (!map.ContainsKey(upper))
                {
                    map.Add(upper, 1);
                }
                else
                {
                    map[upper] += 1;
                }
            }
            foreach(var a in map)
            {
                Console.Write($"{a.Key}{a.Value}");
            }
            
        }
     
        private static bool IsPangram(string str)
        {
            int index = 0;
            bool[] mark = new bool[26];
            for(int i =0; i<str.Length; i++)
            {
                char currentStr = str[i];
                if(currentStr >='A' && currentStr <= 'Z')
                {
                    index = currentStr - 'A';
                }
                else if(currentStr >= 'a' && currentStr <= 'z')
                {
                    index = currentStr - 'a';
                }
             
               // Console.WriteLine(mark[index]);
                mark[index] = true;
            }
           
            for(int i =0; i<=25; i++)
            {
                if (mark[i] == false)
                {
                    Console.WriteLine(mark[i]);
                    return false;
                }
            }
            return true;

           
        }

        private static int[] ResolveQuestion(int[] A)
        {
            string s = "";
            int[] resultArr = A;
            int[] arr = new int[A.Length];
            int count = 0;
            arr[0] = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if(A[i]% A[i-1] == 1)
                {
                    ++count;
                    arr[i] = A[i];
                    Console.WriteLine($"arr[i] {arr[i]}");
                }

          
            }
            foreach(int a in arr)
            {
                Console.WriteLine($"count : {count} , arr[i]  : {a}");
            }
            return arr;
        }
      public static int Csolution(int N)
        {
            // Implement your solution here
            string s = ""; 
            int maxValue = 0;
            int minValue = 0;
            int divide = 0;
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    divide = N / i;
                    if (i < divide)
                    {
                        maxValue = Math.Max(i, maxValue);
                        minValue = divide;
                    }
                    if (i > divide)
                    {
                        minValue = Math.Min(i, minValue);
                    }

                }
            }
            Console.WriteLine($"MAX : {maxValue} MIN : {minValue}");
            sum = (maxValue + minValue) *2;
            Console.WriteLine($"Result: {sum}");
            return sum;
        }
        private static int MaxSliceSumsolution(int[] A)
        {
            string s = "";
            int absoluteMax = A[0];
            int localMax = A[0];
            int nextSum = 0;
            int currentElement = 0;

            for (int i = 1; i < A.Length; i++)
            {
                currentElement = A[i];
          
                Console.WriteLine($"A[i] : {currentElement}");
                nextSum = localMax + currentElement;
                Console.WriteLine($"nextSum : {nextSum}");

                localMax = Math.Max(A[i], nextSum);
                Console.WriteLine($"localMax : {localMax}");
                absoluteMax = Math.Max(absoluteMax, localMax);
                Console.WriteLine($"absoluteMax : {absoluteMax}");
            }
            Console.WriteLine($"Returning Value {absoluteMax}");
            return absoluteMax;
        }
        public static int Hashsolution(int[] A)
        {
            // Implement your solution here
           
            int result = 0;
            Array.Sort(A);
            HashSet<int> hash = new HashSet<int>(A);
            int retunResult = 0;
            int n = hash.Last();
            int total = 0;

            foreach (int i in hash)
            {
                //21 16

            result = (n * (n + 1)) / 2;
                total += i;
                //Result : 21 16
            retunResult = result - total;
                if (retunResult == 0)
                {
                  
                    return A[A.Length - 1] + 1;
                }
                else if (total < 0)
                {
                    Console.WriteLine(1);
                    return 1;
                }
                else
                {
                    continue;
                }


            }

            Console.WriteLine($"Returning Value :{retunResult}");
            return retunResult;


        }
        public static int RemoveDuplicateNumInArr(int[] A)
        {
            // Implement your solution here
            
            string s = "";
            var has = new HashSet<int>();
            foreach (var i in A)
            {
                  if (has.Contains(i))
                      has.Remove(i);
                  else
                      has.Add(i);
               
            }
            int sum = 0;
            foreach (int i in has)
            {
                s += i;
              
                Console.WriteLine($"Returing Value {i} {s}");
 
            }
          
            return 0;

        }
        //34125 , 2   //12534
        private static int[] RotateLeft(int[] arr, int k)
        {
            string s = "";
            int[] newArr = new int[arr.Length];

            if (arr.Length == 0) return arr;
            k = k % arr.Length;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                //3,4,1,2,5
                //5- 2 / 5
                newArr[i] = arr[(i + (arr.Length - k)) % (arr.Length)];

            }

            return newArr;
        }

        private static int[] RotateRight(int[] arr, int k)
        {
            string s = "";
            int[] newArr = new int[arr.Length];

            if (arr.Length == 0) return arr;
            k = k % arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                //3,4,1,2,5
                newArr[i] = arr[(i + (arr.Length - k)) % (arr.Length)];

            }

            return newArr;
        }



        private static string DisappearingPairs(string s)
        {
            StringBuilder sb = new StringBuilder();
            char[] cArr = s.ToCharArray();

            for (int i = 1; i < cArr.Length; i++)
            {
                if (cArr[i] == cArr[i - 1] && cArr[i - 1] > 1)
                {
                    sb.Remove(cArr[i - 1], cArr[i]);
                    continue;
                }
                else
                {
                    sb.Append(cArr[i]);

                }

            }
            return sb.ToString();



        }
        private static void IsPalindrome(string s)
        {
            string S = "raceCar";
            string ss = "";
            // Implement your solution here
            int n = S.Length;
            if (n % 2 == 0)
            {
                Console.WriteLine(-1);
            }
            int r = n / 2;
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"S[i]={S[i]}--- S[n - i - 1]={ S[n - i - 1]}");
                if (S[i] != S[n - i - 1])
                {
                    Console.WriteLine(-1);
                }
            }

        }

        private static int MaxAreas(int[] height)
        {

            int maximumArea = 0;
            // Left and right pointers
            int left = 0;
            int right = height.Length - 1;
            // Loop until left and right meet
            while (left < right)
            {

                // Shorter pole/vertical line
                int shorterLine = Math.Min(height[left], height[right]);
                // Update maximum area if required
                maximumArea = Math.Max(maximumArea, shorterLine * (right - left));
                // If there is a longer vertical line present
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine($"MAX AREA: {maximumArea}");
            return maximumArea;
        }
        #region add distinct two array



        #endregion
        //33

        private static bool IsAnagram(string s, string t)
        {

            char[] ca = s.ToCharArray();
            char[] ct = t.ToCharArray();
            Array.Sort(ca);
            Array.Sort(ct);
            String ss = new String(ca);
            String st = new String(ct);

            if (ss == st)
                return true;
            else
                return false;

        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var myDictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (myDictionary.ContainsKey(nums[i]))
                {
                    if (i - myDictionary[nums[i]] <= k)
                        return true;
                    else
                        myDictionary[nums[i]] = i;
                }
                else
                    myDictionary.Add(nums[i], i);
            }



            return false;
        }
        private static string ConvertToString(int n)
        {
            string s = "";

            string result = "";
            while (n > 0)
            {
                n--;
                char letter = (char)(n % 26 + 'A');
                result = letter + result;

                n = n / 26;
            }
            return result;
        }

        #region Pascal Triangle
        private static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            IList<int> row = new List<int>();
            while (numRows > 0)
            {
                row = GenNextRow(row);
                result.Add(row);
                numRows--;
            }
            foreach (IList<int> a in result)
            {

                foreach (int ab in a)
                {
                    Console.WriteLine(ab);
                }

            }
            return result;
        }
        private static IList<int> GenNextRow(IList<int> row)
        {
            IList<int> nextRow = new List<int>();
            nextRow.Add(1);
            if (row.Count > 0)
            {
                for (int i = 0; i < row.Count - 1; i++)
                {
                    int val = row[i] + row[i + 1];
                    nextRow.Add(val);
                }
                nextRow.Add(1);
            }


            return nextRow;
        }
        #endregion
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            // idea 1: brute force, generate all possible combination which has 2^N possibilities and check whether 
            // each combination's sum equals target. This doesn't work though as one element can be used multi times.

            // idea 2: backtracking, potential optimazition, sort the candidates first. Memorization probably will help
            // but it's a little bit hard to check dup output
            string s = "";
            var result = new List<IList<int>>();

            Array.Sort(candidates);
            if (candidates.Length == 0 || target < candidates[0]) return result;

            DFS(candidates, target, 0, new List<int>(), result);


            return result;
        }
        private static void DFS(int[] candidates, int target, int sum, IList<int> res, IList<IList<int>> result)
        {
            if (target < sum) return;
            if (target == sum)
            {
                result.Add(new List<int>(res));
                return;
            }

            for (int i = sum; i < candidates.Length; i++)
            {
                /*    if (sum + candidates[i] > target)
                    {
                        break;
                    }*/

                // to make sure the output result is always sorted to avoid duplicate
                if (i == sum || candidates[i] != candidates[i - 1])
                {
                    res.Add(candidates[i]);
                    DFS(candidates, i + 1, target - candidates[i], res, result);
                    res.Remove(res.Count - 1);

                }


            }
        }





        #region Plus One

        private static int[] PlusOne2(int[] digits)
        {
            if (digits.Length == 0)
            {
                List<int> value = new List<int>(digits);
                value.Insert(0, 1);

                return value.ToArray();
            }
            if (digits.Length == 1 && digits[0] == 9)
            {
                return new int[] { 1, 0 };
            }
            else
            {
                int result = 0;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    result = digits[i] + 1;
                    digits[i] = result % 10;

                }
                return digits;
            }



            return digits;
        }

        #endregion

        #region Reverse Vowels

        private static string ReverseVowels(string s)
        {
            string result = "";
            HashSet<char> vowels = new HashSet<char>() { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'U', 'u' };
            char[] cArr = s.ToCharArray();

            int left = 0;
            int right = cArr.Length - 1;

            while (left < right)
            {
                if (!vowels.Contains(cArr[left]))
                {
                    left++;
                    continue;
                }
                if (!vowels.Contains(cArr[right]))
                {
                    right--;
                    continue;
                }
                char temp = cArr[left];
                cArr[left] = cArr[right];
                cArr[right] = temp;
                left++;
                right--;
            }

            result = new string(cArr);

            return result;

        }
        #endregion


        #region Valid SudoKU
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!isParticallyValid(board, i, 0, i, 8))
                    return false;
                if (!isParticallyValid(board, 0, i, 8, i))
                    return false;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!isParticallyValid(board, i * 3, j * 3, i * 3 + 2, j * 3 + 2))
                        return false;
                }
            }

            return true;
        }

        bool isParticallyValid(char[][] board, int x1, int y1, int x2, int y2)
        {
            var set = new HashSet<char>();
            for (int row = x1; row <= x2; row++)
            {
                for (int col = y1; col <= y2; col++)
                {
                    if (board[row][col] != '.')
                    {
                        if (!set.Add(board[row][col]))
                            return false;
                    }
                }
            }

            return true;
        }

        #endregion

        #region Remove Element

        private static int RemoveElement(int[] nums, int val)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[result] = nums[i];
                    Console.WriteLine(nums[result]);
                    result++;
                    Console.WriteLine("++" + result);
                }
            }

            return result;
        }

        #endregion

        #region Set Matrix Zeros
        private static void SetZeroes(int[][] matrix)
        {
            if (matrix == null || matrix[0].Length == 0)
                return;
            int m = matrix.Length, n = matrix[0].Length;
            bool firstRowHasZero = false, firstColHasZero = false;
            // check if first column has 0
            for (int row = 0; row < m; row++)
            {
                if (matrix[row][0] == 0)
                {
                    firstColHasZero = true;
                    break;
                }
            }
            // check if first row has 0
            for (int col = 0; col < n; col++)
            {
                if (matrix[0][col] == 0)
                {
                    firstRowHasZero = true;
                    break;
                }
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }
            for (int row = 1; row < m; row++)
            {
                for (int col = 1; col < n; col++)
                {
                    if (matrix[row][0] == 0 || matrix[0][col] == 0)
                        matrix[row][col] = 0;
                }
            }
            if (firstRowHasZero)
            {
                for (int c = 0; c < n; c++)
                    matrix[0][c] = 0;
            }
            if (firstColHasZero)
            {
                for (int r = 0; r < m; r++)
                    matrix[r][0] = 0;
            }
        }





        #endregion

        #region Simplyfiy Path

        private static string SimplyfyPath(string str)
        {
            string result = "";
            result = str;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Contains(".."))
                    result = "/";
                if (str.Contains("//"))
                {
                    result = str.Replace("//", "/");
                }

            }
            if (result.Length > 1 && result.Length - 1 == result.LastIndexOf('/'))
            {
                result = result.Remove(result.LastIndexOf('/'));
            }
            Console.WriteLine(result);

            return result;

        }

        #endregion 

        #region Container with Most Water
        private static int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int maxArea = 0;
            while (left <= right)
            {
                int len = right - left;
                int area = 0;
                if (height[left] < height[right])
                {
                    area = height[left++] * len;
                }
                else
                {
                    area = height[right--] * len;
                }
                maxArea = Math.Max(area, maxArea);
            }

            return maxArea;
        }

        #endregion


        #region Reverse INT
        public static int ReverseInt(int x)
        {
            int reverX = 0;
            int negative = 1;
            if (x < 10)
            {
                negative = -1;
                x *= -1;
            }

            while (x > 0)
            {
                reverX = reverX * 10 + x % 10;
                x /= 10;

            }
            return reverX * negative;

        }
        #endregion


        #region ZigZag
        private static string Convert(string s, int numRows)
        {
            string result = "";
            if (numRows <= 1)
            {
                return s;
            }
            List<StringBuilder> sbList = new List<StringBuilder>();
            int i = 0;
            int index = 0;
            bool reversed = true;
            while (i < s.Length)
            {
                if (i == s.Length)
                    break;
                if (index == sbList.Count)
                {
                    sbList.Add(new StringBuilder());
                }
                sbList[index].Append(s[i]);
                if (i % (numRows - 1) == 0)
                {
                    reversed = !reversed;
                }
                index += reversed ? -1 : 1;
                i++;
            }
            var sb = new StringBuilder();
            foreach (var a in sbList)
            {
                sb.Append(a.ToString());
            }
            result = sb.ToString();
            Console.WriteLine(result);
            return result;
        }
        #endregion

        #region Kth Smallest


        public static int KthSmallest(TreeNode root, int k)
        {
            int[] nums = new int[2];
            InOrder(root, nums, k);
            return nums[1];

        }
        private static void InOrder(TreeNode root, int[] nums, int k)
        {
            if (root == null)
                return;
            InOrder(root.left, nums, k);
            if (++nums[0] == k)
            {
                nums[1] = root.val;
                return;
            }
            InOrder(root.right, nums, k);

        }


        #endregion


        #region ClimbStarts
        private static int ClimbStairs(int n)
        {
            // stair1 = 1;
            // stair2 = 2;
            // starir3 == 3;
            if (n <= 1)
                return n;


            int[] stairs = new int[n + 1];
            stairs[1] = 1;
            stairs[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                stairs[i] = stairs[i - 1] + stairs[i - 2];
            }
            return stairs[n];

        }
        #endregion

        #region SQRT(X)
        private static int MySqrt(int x)
        {
            int result = 0;

            result = (int)Math.Sqrt(x);
            Console.WriteLine($"This is Result {result}");

            return result;
        }
        #endregion


        #region Plus One
        private static int[] PlusOne(int[] digits)
        {

            if (digits.Length == 0)
            {

                List<int> value = new List<int>(digits);
                value.Insert(0, 1);
                return value.ToArray();
            }
            else if (digits.Length == 1 && digits[0] == 9)
            {
                return new int[] { 1, 0 };
            }
            else
            {
                int increase = 1;
                int result = 0;
                //197
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    //8
                    result = digits[i] + increase;
                    Console.WriteLine($"This is Reulst : {result}");
                    //8
                    digits[i] = result % 10;
                    Console.WriteLine($"This is Digits {digits[i]}");
                    //0
                    increase = result / 10;
                }
                return digits;
            }

        }
        #endregion

        #region LengthOf The Last Word
        public static int LengthOfLastWord(string s)
        {
            int count = 0;

            string result = s.Trim();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] == ' ')
                {
                    count = 0;
                }
                else
                {
                    ++count;
                }
            }
            Console.WriteLine(count);

            return count;

        }
        #endregion

        #region PalindromeNumber
        private static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int number = x;
            int reverseNumber = 0;

            //121
            while (number > 0)
            {
                //number121
                reverseNumber = reverseNumber * 10 + number % 10;
                Console.WriteLine($"This is Revernumber: {reverseNumber}");
                number /= 10;
                Console.WriteLine($"This is Number :{number}");
            }
            if (x == reverseNumber)
            {
                return true;
            }
            else
            {
                return false;
            }




        }


        #endregion

        #region 1.Two Sum 
        private static void TwoSum(int[] nums, int target)
        {
            //Two Sum using for loops only
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine(i + ":" + j);
                    }

                }
            }
            // Two sum using Dictionary
            /* var dic = new Dictionary<int, int>();

             for (int i = 0; i < nums.Length; i++)
             {

                 var tempKey = target - nums[i];
                 if (dic.TryGetValue(tempKey, out var index))
                 {
                     return new int[] { index, i };
                 }


                 dic[nums[i]] = i;
             }*/



        }

        #endregion

        #region RomanToInteger
        private static int RomanToInt(string s)
        {
            string result = s.ToUpper();
            int sum = 0;

            for (int i = 0; i < result.Length; i++)
            {

                int firstLetter = RomanCalculate(result[i]);
                if (i + 1 < result.Length)
                {

                    int secondLetter = RomanCalculate(result[i + 1]);
                    if (firstLetter > secondLetter)
                        sum = sum + firstLetter;
                    else if (firstLetter == secondLetter)
                    {
                        sum = sum + secondLetter;
                    }
                    else
                    {
                        sum = sum + secondLetter - firstLetter;
                        i++;
                    }

                }
                else
                {
                    sum = sum + firstLetter;
                    i++;

                }



            }
            return sum;
        }
        private static int RomanCalculate(char c)
        {

            if (c == 'I')
                return 1;
            if (c == 'V')
                return 5;
            if (c == 'X')
                return 10;
            if (c == 'L')
                return 50;
            if (c == 'C')
                return 100;
            if (c == 'D')
                return 500;
            if (c == 'M')
                return 1000;
            else
                return -1;

        }

        #endregion

        #region LongestCommonPrefix
        private static string LongestCommonPrefix(string[] strs)
        {
            //{"geeksforgeeks", "geeks","geek", "geezer"}

            if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
                return "";
            string result = strs[0];
            int i = result.Length;
            foreach (string word in strs)
            {
                int j = 0;
                foreach (char c in word)
                {
                    if (j >= i || result[j] != c)
                        break;
                    j += 1;
                }
                i = Math.Min(i, j);
            }
            return result.Substring(0, i);

        }
        #endregion

        #region ValidParentheses
        private static bool IsValid(string s)
        {
            int test = 0;
            while (s.Length != test)
            {
                test = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0) return true;
            else return false;
        }
        #endregion

        #region RemoveDuplicatesFromSortedArray

        public static int RemoveDulplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j++] = nums[i];
                }
                nums[j++] = nums[nums.Length - 1];
            }


            return j;

        }


        #endregion

    }
}
