using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMP1005_CreateWebAPILogic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : Controller
    {
        /*
         * Method to Add two numbers
         * params: left: Double , right: Double
         * return: double
         */
        [HttpGet]
        public double Add(double left, double right)
        {
            return CreateWebAPILogic.Add(left, right);
        }

        /*
         * Method to Subtract two numbers
         * params: left: Double , right: Double
         * return: double
         */
        [HttpGet]
        public double Subtract(double left, double right)
        {
            return CreateWebAPILogic.Subract(left, right);
        }

        /*
         * Method to Multiply two numbers
         * params: left: Double , right: Double
         * return: double
         */
        [HttpGet]
        public double Multiply(double left, double right)
        {
            return CreateWebAPILogic.Multiply(left, right);
        }

        /*
         * Method to Divide two numbers
         * params: left: Double , right: Double
         * return: double
         */
        [HttpGet]
        public double Divide(double left, double right)
        {
            double result = -1;
            // Added try catch block to catch expection for divide by zero
            try
            {
                result = CreateWebAPILogic.Divide(left, right);
            }
            catch (DivideByZeroException)
            {
                // Added status code for divide by zero expception
                HttpContext.Response.StatusCode = 400;
            }
            catch (Exception)
            {
                // Uncaught expection
                HttpContext.Response.StatusCode = 500;
            }
            finally
            {
                result = -1;
            }
            return result;
        }
    }
}

