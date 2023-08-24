using Exceptions.CustomExceptions;
using Exceptions.Validatons;

namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmailValidator validator = new EmailValidator();
            try
            {
                bool isValid = validator.Validate("sadasdd@mil.com");
                Console.WriteLine(isValid);
            }
            catch (ShortEmailException ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            catch (NotAnEmailAdressException ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            finally
            { 
                Console.WriteLine("Execute the finally block..."); 
            }
        }
    }
}