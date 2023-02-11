namespace Basic_Core_Progams
{
    internal class Program
    {
       
        static void Main(string[] args)
        {



            Console.Write("Please enter input value : ");
            int iNo = Convert.ToInt32(Console.ReadLine());
            Factor fact = new Factor();
            fact.getFactors(iNo);



            

        }
    }
}