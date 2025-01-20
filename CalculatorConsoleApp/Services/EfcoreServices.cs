using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorConsoleApp.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CalculatorConsoleApp.Services
{
    public class EfcoreServices
    {

        private readonly AppDbContext _appDbContext;

        public EfcoreServices()
        {
            _appDbContext = new AppDbContext();
        }

        int result = 0;
        public int Calculation(int number1 , int number2, string sum)
        {
            int num1 = number1;
            int num2 = number2; 
            string calculate = sum;
           
            switch (calculate)
            {
                case "+":
                    result = num1 + num2;
                    break;  
                case "-":
                  result =  num1 - num2;
                    break; 
                case "*":
                  result =  num1 * num2;
                    break;  
                case "/":
                  result =  num1 / num2;
                    break; 
            }

           Console.WriteLine("_____________________");
            return result;
        }

        
       

        public void ShowOutput()
        {
            Console.WriteLine("Your result => " + result);
            Console.WriteLine("________________________________");
        }
       
        public void AddResult()
        {
            var item = new Model
            {
                Result = result,
                date = DateTime.Now
            };
           int i =   _appDbContext.SaveChanges();

            Console.WriteLine("Your history is already saved.");
        }

       

    }
}
