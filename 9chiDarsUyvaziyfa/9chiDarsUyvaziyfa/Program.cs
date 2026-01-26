using _9chiDarsUyvaziyfa.Services;

namespace _9chiDarsUyvaziyfa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var payservice = GetPayServise();
            payservice.GetPay();

        }

        public static IPayService GetPayServise()
        {
            IPayService payService = new PayService();

            return payService; 
        }
    }
}
