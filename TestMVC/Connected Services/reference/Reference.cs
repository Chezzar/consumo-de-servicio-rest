//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace reference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pais", Namespace="http://schemas.datacontract.org/2004/07/ServicioDePaisesBD")]
    public partial class Pais : object
    {
        
        private string gobiernoField;
        
        private string nombreField;
        
        private float territorioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gobierno
        {
            get
            {
                return this.gobiernoField;
            }
            set
            {
                this.gobiernoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float territorio
        {
            get
            {
                return this.territorioField;
            }
            set
            {
                this.territorioField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="reference.IPaisService")]
    public interface IPaisService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaisService/MetodoTest", ReplyAction="http://tempuri.org/IPaisService/MetodoTestResponse")]
        System.Threading.Tasks.Task<string> MetodoTestAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaisService/MetodoTestPais", ReplyAction="http://tempuri.org/IPaisService/MetodoTestPaisResponse")]
        System.Threading.Tasks.Task<reference.Pais> MetodoTestPaisAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IPaisServiceChannel : reference.IPaisService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PaisServiceClient : System.ServiceModel.ClientBase<reference.IPaisService>, reference.IPaisService
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PaisServiceClient() : 
                base(PaisServiceClient.GetDefaultBinding(), PaisServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPaisService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaisServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PaisServiceClient.GetBindingForEndpoint(endpointConfiguration), PaisServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaisServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PaisServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaisServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PaisServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> MetodoTestAsync(int value)
        {
            return base.Channel.MetodoTestAsync(value);
        }
        
        public System.Threading.Tasks.Task<reference.Pais> MetodoTestPaisAsync(int value)
        {
            return base.Channel.MetodoTestPaisAsync(value);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPaisService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPaisService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52733/PaisService.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PaisServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPaisService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PaisServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPaisService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPaisService,
        }
    }
}
