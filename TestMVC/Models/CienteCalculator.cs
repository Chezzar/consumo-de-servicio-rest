using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Services;

namespace TestMVC.Models
{
    
    public class ClienteCalculator
    {
        public enum operacion_tipo {suma,resta,divi,multi }

        private float resultado;

        public float Resultado { get => resultado; set => resultado = value; }

        public float operacion(operacion_tipo op, int num1, int num2) {

            float resultado = 0;

            resultado = hacerConsultaWebservice(op,num1,num2);

            Resultado = resultado;

            return resultado;
        }

        private float hacerConsultaWebservice(operacion_tipo op, int num1, int num2) {

            //creamos la configuracion para el servicio
            CalculatorService.CalculatorSoapClient.EndpointConfiguration end = new CalculatorService.CalculatorSoapClient.EndpointConfiguration();

            //creamos el cliente de el servicio por SOAP
            CalculatorService.CalculatorSoapClient client = new CalculatorService.CalculatorSoapClient(end);

            float resultadoWebService = 0;

            switch (op){
                case operacion_tipo.suma:
                    {
                       Task<int> res = client.AddAsync(num1,num2);

                        resultadoWebService = res.Result;

                        break;
                    }

                case operacion_tipo.resta:
                    {
                        Task<int> res = client.SubtractAsync(num1, num2);

                        resultadoWebService = res.Result;

                        break;
                    }

                case operacion_tipo.divi:
                    {
                        Task<int> res = client.DivideAsync(num1, num2);

                        resultadoWebService = res.Result;

                        break;
                    }

                case operacion_tipo.multi:
                    {
                        Task<int> res = client.MultiplyAsync(num1, num2);

                        resultadoWebService = res.Result;

                        break;
                    }
            };

            return resultadoWebService;

        }
    }
}
