using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityConverter.CustomAttribute;
using entityConverter.testEntity.Model;


namespace entityConverter.testEntity.DTO
{
    public class AgenteDTO : BaseDTO<Agente>
    {
        [ProperyEntity(Name = "Codigo")]
        public long AGECODIGO { get; set; }

        [ProperyEntity(Name = "Nome")]
        public String AGEDESCRICAO { get; set; }
    }
}
