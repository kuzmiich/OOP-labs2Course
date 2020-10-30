namespace Lab2.Tasks
{
    public static class Task4
    {
        public static void StartTask()
        {
            int a = 5, 
                b = 10;
            IOservice.ShowMessage($"a = {a}, b = {b}");
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            IOservice.ShowMessage($"Swapped a = {a}, b = {b}");
            IOservice.ShowMessage($"a = {a}, b = {b}");
            a = a + b; 
            b = a - b;
            a = a - b;
            IOservice.ShowMessage($"Swapped a = {a}, b = {b}");
        }
    }
}
