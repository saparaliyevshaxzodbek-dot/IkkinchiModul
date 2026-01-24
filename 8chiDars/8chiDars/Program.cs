using _8chiDars.Models;
using _8chiDars.Services;

namespace _8chiDars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            emailService.SendNotification();

            TeamsService teamsService = new TeamsService();
            teamsService.SendDotNation();

        }
    }

     //public static IEmailServise GetEmailService()
     //   {
     //       IEmailServise EmailService = new EmailService();
     //       return EmailService;
     //   }


    }

