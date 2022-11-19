using FinalProjectSushiShop;
using Serilog;

Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.File("logs/HW.11..txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();

var logTime = DateTime.UtcNow;

try
{
    Log.Information($"Programm started at: {Convert.ToString(logTime)}");

    SushiRepository sushiRepository = new SushiRepository();

    Choose();

    void Choose()
    {
        sushiRepository.StartMenu();
        var answer = Console.ReadLine();

        switch (answer)
        {
            case "1":
                sushiRepository.AddOrderSushi();
                Log.Debug(answer);
                Log.Information(messageTemplate: "Sushi's order created; Class : Program; Method : Choose.");
                Choose();
                break;

            case "2":
                sushiRepository.GetViewAllOrderInformation();
                Log.Debug(answer);
                Log.Information(messageTemplate: "Process of screening information about sushi's order started; Class : Program; Method : Choose.");
                Log.Information(messageTemplate: "User viewed all information about order; Class : Program; Method : Choose.");
                Choose();
                break;

            case "3":
                sushiRepository.UpdateSushiOrder();
                Log.Debug(answer);
                Log.Information(messageTemplate: "User updated order; Class : Program; Method : Choose.");
                Choose();
                break;

            case "4":
                sushiRepository.DeleteSushiOrder();
                Log.Debug(answer);
                Log.Information(messageTemplate: "User deleted order; Class : Program; Method : Choose. ");
                Choose();
                break;

            case "0":
                sushiRepository.SushiSerilizationAndOutProgramm();
                Log.Debug(answer);
                Log.Information(messageTemplate: "Order's serilization ended; Class : Program; Method : Choose.");
                sushiRepository.EmailMessege();
                Log.Information(messageTemplate: "Messege for user sent; Class : Program; Method : Choose.");
                Log.Information(messageTemplate: "Programm ended; Class : Program; Method : Choose.");
                Console.WriteLine("\n");
                Console.WriteLine("Thank's for your order");
                break;

            default:
                Console.WriteLine("Wrong choose");
                Log.Debug(answer);
                Log.Error(messageTemplate: "Something went wrong. Class : Program; Methode : Choose. ");
                Choose();
                break;
        }
    }
}
catch (Exception ex)
{
    Log.Error(ex, "Something went wrong; Class : Program; Method : Choose.");
}
finally
{
    Log.Information($"Programm succesfully ended at: {Convert.ToString(logTime)}");
    Log.CloseAndFlush();
}