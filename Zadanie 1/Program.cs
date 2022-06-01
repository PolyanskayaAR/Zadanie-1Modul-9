using System;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Method();
                throw new Exception("Собственное исключение");
            }

            catch (Exception ex) when (ex.Message == "Собственное исключение")
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex) when (ex is FormatException)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex) when (ex is ArgumentException)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex) when (ex is IndexOutOfRangeException)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex) when (ex is OverflowException)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Блок finally");
            }

            static void Method()
            {
                //Тело метода
            }
        }
    }
}