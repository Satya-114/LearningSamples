namespace DependencyInversionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {

        }
        public string GetCustomerNameDataAccess()
        {
            return "CustomerName";
        }


    }

    public interface ICustomerDataAccess
    {
        string GetCustomerNameDataAccess();
    }

    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerName()
        {
            return new CustomerDataAccess();
        }
    }


    public class CustomerBL
    {
        public CustomerBL()
        {

        }
        public void GetCustomerName()
        {
            ICustomerDataAccess obj = DataAccessFactory.GetCustomerName();
            obj.GetCustomerNameDataAccess();
        }

    }

}