namespace DSAAlogrithmPro
{
    public class Program
    {

        public static void Display()
        {
            int i;
            Console.WriteLine("Enter the N value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            for (i = 0; i < N; i++)
            {
                var temp = (int)Math.Pow(2, i);
                // Console.WriteLine(temp);
                foreach (int x in arr)
                {
                    arr[i] = temp;
                    Console.WriteLine(arr[i]);
                    break;

                }

   
            }
            Console.WriteLine("Enter the Value to be Search in Array : ");
            int user = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == user)
                {
                    
                    Console.WriteLine("Number is exist");
                    break;
                }


            }
        }
        
        public static void Main(string[] args) 
        {
            Program.Display();
           

        }
      


    }
}
