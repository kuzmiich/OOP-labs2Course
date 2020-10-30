using static System.Math;

namespace Lab2.Tasks
{
    public static class Task2
    {
        public static void StartTask()
        {
            IOservice.ShowMessage("Input bytes: ");
            if (long.TryParse(IOservice.GetUserInputStr(), out long bytesAmount))
            {
                IOservice.ShowMessage
                (
                   $"Bytes amount = {bytesAmount}\n" + 
                   $"{Converter.GetConvertionResult(bytesAmount,  (int)Pow(2, (int)ConvertCoefEnum.KiloBytes))} kB\n"+
                   $"{Converter.GetConvertionResult(bytesAmount, (int)Pow(2,(int)ConvertCoefEnum.MegaBytes))} mB\n"+
                   $"{Converter.GetConvertionResult(bytesAmount, (int)Pow(2,(int)ConvertCoefEnum.GigaBytes))} gB\n"+
                   $"{Converter.GetConvertionResult(bytesAmount, (int)Pow(2,(int)ConvertCoefEnum.TeraBytes))} tB\n"
                );
            }
            else
            {
                IOservice.ShowMessage("Error!");
            }
        }
    }
}
