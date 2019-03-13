using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioDePaisesBD
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPaisService
    {

        [OperationContract]
        string MetodoTest(int value);

        [OperationContract]
        Pais MetodoTestPais(int value);

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Pais
    {
        [DataMember]
        public string nombre;
        [DataMember]
        public string gobierno;
        [DataMember]
        public float territorio;

       /*[DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public string Gobierno
        {
            get { return gobierno; }
            set { gobierno = value; }
        }

        [DataMember]
        public float Territorio
        {
            get { return territorio; }
            set { territorio = value; }
        }*/
    }
}
