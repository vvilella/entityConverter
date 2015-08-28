using entityConverter.testEntity.DTO;
using entityConverter.testEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            AgenteDTO agenteDto = new AgenteDTO();

            agenteDto.AGECODIGO = 0;
            agenteDto.AGEDESCRICAO = "Farmacia do José!!!";

            Agente model = agenteDto.getModel();

            Console.WriteLine(model.Codigo);
            Console.WriteLine(model.Nome);
            
        }
    }
}
