using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProjectSushiShop
{
    internal class SushiRepository : SushiBase, ISushiRepository
    {
        private List<SushiBase> sushiBases = new List<SushiBase>();
        SushiBase sushiBase = new SushiBase();

        public void AddOrderSushi()
        {
            sushiBase.ChooseSushiType();

            Console.WriteLine("Plese enter your order's own ID");
            sushiBase.Id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your First Name");
            sushiBase.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name");
            sushiBase.LastName = Console.ReadLine();

            Console.WriteLine("Please enter Email");
            sushiBase.Email = Console.ReadLine();

            Console.WriteLine("Please enter amount of sushi you want");
            sushiBase.SushiAmount = Int32.Parse(Console.ReadLine());

            sushiBase.SushiValue();
            sushiBase.GetSushiDescription();

            sushiBases.Add(sushiBase);
        }
        public void EmailMessege()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("oleg.svekla.97@mail.ru", "SushiStore");
            // кому отправляем
            MailAddress to = new MailAddress(sushiBase.Email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Your Order";
            // текст письма
            m.Body = sushiBase.ToString();
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("oleg.svekla.97@mail.ru", "kgVkveVF4UdHX58HXqiA");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }

        public void SushiSerilizationAndOutProgramm()
        {
            string json = JsonSerializer.Serialize(sushiBase);
            File.WriteAllText(@"E:\path.json", json);
        }

        public void DeleteSushiOrder()
        {
            try
            {
                Console.WriteLine("Enter the order's ID you whant to find to delete: ");

                int answer = Int32.Parse(Console.ReadLine());

                foreach (var sushiBase in sushiBases)
                {
                    if (sushiBase.Id.Equals(answer))
                    {
                        sushiBases.Remove(sushiBase);
                    }
                    else
                    {
                        Console.WriteLine("There is no sushiType with this name!!");
                        throw new Exception("SushiNotFoundException");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.Message}");
            }
        }

        void ChooseParapetr()
        {
            Console.WriteLine("Choose you whant to update:  First Name - 1, Last Name - 2,  Email account - 3, SushiAmount - 4, Exit  0.");

            var parametr = Console.ReadLine();

            switch (parametr)
            {

                case "1":
                    Console.WriteLine("Enter new FirstName: ");
                    string newFirstName = Console.ReadLine();
                    sushiBase.FirstName = newFirstName;
                    ChooseParapetr();
                    break;

                case "2":
                    Console.WriteLine("Enter new LastName: ");
                    string newLastName = Console.ReadLine();
                    sushiBase.LastName = newLastName;
                    ChooseParapetr();
                    break;

                case "3":
                    Console.WriteLine("Enter new Mail Account: ");
                    string newAccount = Console.ReadLine();
                    sushiBase.Email = newAccount;
                    ChooseParapetr();
                    break;

                case "4":
                    Console.WriteLine("Enter new SushiAmount: ");
                    int newAmount = Int32.Parse(Console.ReadLine());
                    sushiBase.SushiAmount = newAmount;
                    ChooseParapetr();
                    break;

                case "0":
                    break;

                default:
                    Console.WriteLine("Wrong choose");
                    break;
            }
        }

        public void UpdateSushiOrder()
        {
            try
            {
                Console.WriteLine("Enter the sushi's ID you want to update");

                int devId = int.Parse(Console.ReadLine());

                foreach (var sushiBase in sushiBases)
                {
                    if (sushiBase.Id.Equals(devId))
                    {
                        ChooseParapetr();
                    }
                    else
                    {
                        Console.WriteLine("There is no sushi with this ID");
                        throw new Exception("SushiNotFoundException");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.Message}");
            }
        }

        public void GetViewAllOrderInformation()
        {
            sushiBases.Sort(delegate (SushiBase x, SushiBase y)
            {
                if (x.SushiAmount == null && y.SushiAmount == null) return 0;
                else if (x.SushiAmount == null) return 1;
                else if (y.SushiAmount == null) return -1;
                else return y.SushiAmount.CompareTo(x.SushiAmount);
            });

            Console.WriteLine("These are all information about your order (If you don't make order," +
                " information not view) :");
            Console.WriteLine();

            foreach (var sushiBase in sushiBases)
            {
                Console.WriteLine($"Order's information :\n {sushiBase.ToString()}");
            }
        }

        public void SushiSerilizationAndOutProgramm(string jsons)
        {
            throw new NotImplementedException();
        }
    }
}