﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteCSharp.ServicioWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.lp2soft.pucp.edu.pe/", ConfigurationName="ServicioWeb.ServicioWeb")]
    public interface ServicioWeb {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://services.lp2soft.pucp.edu.pe/).
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ServicioWeb/sumarRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ServicioWeb/sumarResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteCSharp.ServicioWeb.sumarResponse sumar(ClienteCSharp.ServicioWeb.sumarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ServicioWeb/sumarRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ServicioWeb/sumarResponse")]
        System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.sumarResponse> sumarAsync(ClienteCSharp.ServicioWeb.sumarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://services.lp2soft.pucp.edu.pe/).
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ServicioWeb/restarRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ServicioWeb/restarResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteCSharp.ServicioWeb.restarResponse restar(ClienteCSharp.ServicioWeb.restarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ServicioWeb/restarRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ServicioWeb/restarResponse")]
        System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.restarResponse> restarAsync(ClienteCSharp.ServicioWeb.restarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento name del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ServicioWeb/helloRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ServicioWeb/helloResponse")]
        ClienteCSharp.ServicioWeb.helloResponse hello(ClienteCSharp.ServicioWeb.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ServicioWeb/helloRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ServicioWeb/helloResponse")]
        System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.helloResponse> helloAsync(ClienteCSharp.ServicioWeb.helloRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sumar", WrapperNamespace="http://services.lp2soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class sumarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int b;
        
        public sumarRequest() {
        }
        
        public sumarRequest(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sumarResponse", WrapperNamespace="http://services.lp2soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class sumarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int @return;
        
        public sumarResponse() {
        }
        
        public sumarResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="restar", WrapperNamespace="http://services.lp2soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class restarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int b;
        
        public restarRequest() {
        }
        
        public restarRequest(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="restarResponse", WrapperNamespace="http://services.lp2soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class restarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int @return;
        
        public restarResponse() {
        }
        
        public restarResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public ClienteCSharp.ServicioWeb.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(ClienteCSharp.ServicioWeb.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public ClienteCSharp.ServicioWeb.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(ClienteCSharp.ServicioWeb.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioWebChannel : ClienteCSharp.ServicioWeb.ServicioWeb, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioWebClient : System.ServiceModel.ClientBase<ClienteCSharp.ServicioWeb.ServicioWeb>, ClienteCSharp.ServicioWeb.ServicioWeb {
        
        public ServicioWebClient() {
        }
        
        public ServicioWebClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioWebClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWebClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWebClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteCSharp.ServicioWeb.sumarResponse ClienteCSharp.ServicioWeb.ServicioWeb.sumar(ClienteCSharp.ServicioWeb.sumarRequest request) {
            return base.Channel.sumar(request);
        }
        
        public int sumar(int a, int b) {
            ClienteCSharp.ServicioWeb.sumarRequest inValue = new ClienteCSharp.ServicioWeb.sumarRequest();
            inValue.a = a;
            inValue.b = b;
            ClienteCSharp.ServicioWeb.sumarResponse retVal = ((ClienteCSharp.ServicioWeb.ServicioWeb)(this)).sumar(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.sumarResponse> ClienteCSharp.ServicioWeb.ServicioWeb.sumarAsync(ClienteCSharp.ServicioWeb.sumarRequest request) {
            return base.Channel.sumarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.sumarResponse> sumarAsync(int a, int b) {
            ClienteCSharp.ServicioWeb.sumarRequest inValue = new ClienteCSharp.ServicioWeb.sumarRequest();
            inValue.a = a;
            inValue.b = b;
            return ((ClienteCSharp.ServicioWeb.ServicioWeb)(this)).sumarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteCSharp.ServicioWeb.restarResponse ClienteCSharp.ServicioWeb.ServicioWeb.restar(ClienteCSharp.ServicioWeb.restarRequest request) {
            return base.Channel.restar(request);
        }
        
        public int restar(int a, int b) {
            ClienteCSharp.ServicioWeb.restarRequest inValue = new ClienteCSharp.ServicioWeb.restarRequest();
            inValue.a = a;
            inValue.b = b;
            ClienteCSharp.ServicioWeb.restarResponse retVal = ((ClienteCSharp.ServicioWeb.ServicioWeb)(this)).restar(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.restarResponse> ClienteCSharp.ServicioWeb.ServicioWeb.restarAsync(ClienteCSharp.ServicioWeb.restarRequest request) {
            return base.Channel.restarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.restarResponse> restarAsync(int a, int b) {
            ClienteCSharp.ServicioWeb.restarRequest inValue = new ClienteCSharp.ServicioWeb.restarRequest();
            inValue.a = a;
            inValue.b = b;
            return ((ClienteCSharp.ServicioWeb.ServicioWeb)(this)).restarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteCSharp.ServicioWeb.helloResponse ClienteCSharp.ServicioWeb.ServicioWeb.hello(ClienteCSharp.ServicioWeb.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            ClienteCSharp.ServicioWeb.helloRequest inValue = new ClienteCSharp.ServicioWeb.helloRequest();
            inValue.Body = new ClienteCSharp.ServicioWeb.helloRequestBody();
            inValue.Body.name = name;
            ClienteCSharp.ServicioWeb.helloResponse retVal = ((ClienteCSharp.ServicioWeb.ServicioWeb)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.helloResponse> ClienteCSharp.ServicioWeb.ServicioWeb.helloAsync(ClienteCSharp.ServicioWeb.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteCSharp.ServicioWeb.helloResponse> helloAsync(string name) {
            ClienteCSharp.ServicioWeb.helloRequest inValue = new ClienteCSharp.ServicioWeb.helloRequest();
            inValue.Body = new ClienteCSharp.ServicioWeb.helloRequestBody();
            inValue.Body.name = name;
            return ((ClienteCSharp.ServicioWeb.ServicioWeb)(this)).helloAsync(inValue);
        }
    }
}
