﻿'------------------------------------------------------------------------------
' <auto-generated>
'     這段程式碼是由工具產生的。
'     執行階段版本:4.0.30319.42000
'
'     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
'     變更將會遺失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReferenceTwMesTest
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://www.imestech.com/wsEQP", ConfigurationName:="ServiceReferenceTwMesTest.wsEQPSoap")>  _
    Public Interface wsEQPSoap
        
        'CODEGEN: 命名空間 http://www.imestech.com/wsEQP 的元素名稱  InXml 未標示為 nillable，正在產生訊息合約
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsAUTOUniCheckOut", ReplyAction:="*")>  _
        Function wsAUTOUniCheckOut(ByVal request As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest) As ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsAUTOUniCheckOut", ReplyAction:="*")>  _
        Function wsAUTOUniCheckOutAsync(ByVal request As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponse)
        
        'CODEGEN: 命名空間 http://www.imestech.com/wsEQP 的元素名稱  InXml 未標示為 nillable，正在產生訊息合約
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsTESTUniCheckOut", ReplyAction:="*")>  _
        Function wsTESTUniCheckOut(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest) As ServiceReferenceTwMesTest.wsTESTUniCheckOutResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsTESTUniCheckOut", ReplyAction:="*")>  _
        Function wsTESTUniCheckOutAsync(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTESTUniCheckOutResponse)
        
        'CODEGEN: 命名空間 http://www.imestech.com/wsEQP 的元素名稱  InXml 未標示為 nillable，正在產生訊息合約
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsTESTUniCheckOut_Test", ReplyAction:="*")>  _
        Function wsTESTUniCheckOut_Test(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest) As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsTESTUniCheckOut_Test", ReplyAction:="*")>  _
        Function wsTESTUniCheckOut_TestAsync(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponse)
        
        'CODEGEN: 命名空間 http://www.imestech.com/wsEQP 的元素名稱  InXml 未標示為 nillable，正在產生訊息合約
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsTEST2UniCheckOut", ReplyAction:="*")>  _
        Function wsTEST2UniCheckOut(ByVal request As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest) As ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/wsTEST2UniCheckOut", ReplyAction:="*")>  _
        Function wsTEST2UniCheckOutAsync(ByVal request As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponse)
        
        'CODEGEN: 命名空間 http://www.imestech.com/wsEQP 的元素名稱  UserNo 未標示為 nillable，正在產生訊息合約
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/TestDBConnection", ReplyAction:="*")>  _
        Function TestDBConnection(ByVal request As ServiceReferenceTwMesTest.TestDBConnectionRequest) As ServiceReferenceTwMesTest.TestDBConnectionResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.imestech.com/wsEQP/TestDBConnection", ReplyAction:="*")>  _
        Function TestDBConnectionAsync(ByVal request As ServiceReferenceTwMesTest.TestDBConnectionRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.TestDBConnectionResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsAUTOUniCheckOutRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsAUTOUniCheckOut", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsAUTOUniCheckOutRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public InXml As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal InXml As String)
            MyBase.New
            Me.InXml = InXml
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsAUTOUniCheckOutResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsAUTOUniCheckOutResponse", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsAUTOUniCheckOutResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public wsAUTOUniCheckOutResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal wsAUTOUniCheckOutResult As String)
            MyBase.New
            Me.wsAUTOUniCheckOutResult = wsAUTOUniCheckOutResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsTESTUniCheckOutRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsTESTUniCheckOut", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsTESTUniCheckOutRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public InXml As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal InXml As String)
            MyBase.New
            Me.InXml = InXml
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsTESTUniCheckOutResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsTESTUniCheckOutResponse", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsTESTUniCheckOutResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsTESTUniCheckOutResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsTESTUniCheckOutResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public wsTESTUniCheckOutResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal wsTESTUniCheckOutResult As String)
            MyBase.New
            Me.wsTESTUniCheckOutResult = wsTESTUniCheckOutResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsTESTUniCheckOut_TestRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsTESTUniCheckOut_Test", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsTESTUniCheckOut_TestRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public InXml As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal InXml As String)
            MyBase.New
            Me.InXml = InXml
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsTESTUniCheckOut_TestResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsTESTUniCheckOut_TestResponse", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsTESTUniCheckOut_TestResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public wsTESTUniCheckOut_TestResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal wsTESTUniCheckOut_TestResult As String)
            MyBase.New
            Me.wsTESTUniCheckOut_TestResult = wsTESTUniCheckOut_TestResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsTEST2UniCheckOutRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsTEST2UniCheckOut", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsTEST2UniCheckOutRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public InXml As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal InXml As String)
            MyBase.New
            Me.InXml = InXml
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class wsTEST2UniCheckOutResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="wsTEST2UniCheckOutResponse", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class wsTEST2UniCheckOutResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public wsTEST2UniCheckOutResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal wsTEST2UniCheckOutResult As String)
            MyBase.New
            Me.wsTEST2UniCheckOutResult = wsTEST2UniCheckOutResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class TestDBConnectionRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="TestDBConnection", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.TestDBConnectionRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.TestDBConnectionRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class TestDBConnectionRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public UserNo As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal UserNo As String)
            MyBase.New
            Me.UserNo = UserNo
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class TestDBConnectionResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="TestDBConnectionResponse", [Namespace]:="http://www.imestech.com/wsEQP", Order:=0)>  _
        Public Body As ServiceReferenceTwMesTest.TestDBConnectionResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReferenceTwMesTest.TestDBConnectionResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://www.imestech.com/wsEQP")>  _
    Partial Public Class TestDBConnectionResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public TestDBConnectionResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal TestDBConnectionResult As String)
            MyBase.New
            Me.TestDBConnectionResult = TestDBConnectionResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface wsEQPSoapChannel
        Inherits ServiceReferenceTwMesTest.wsEQPSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class wsEQPSoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReferenceTwMesTest.wsEQPSoap)
        Implements ServiceReferenceTwMesTest.wsEQPSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsAUTOUniCheckOut(ByVal request As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest) As ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponse Implements ServiceReferenceTwMesTest.wsEQPSoap.wsAUTOUniCheckOut
            Return MyBase.Channel.wsAUTOUniCheckOut(request)
        End Function
        
        Public Function wsAUTOUniCheckOut(ByVal InXml As String) As String
            Dim inValue As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest = New ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequestBody()
            inValue.Body.InXml = InXml
            Dim retVal As ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponse = CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsAUTOUniCheckOut(inValue)
            Return retVal.Body.wsAUTOUniCheckOutResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsAUTOUniCheckOutAsync(ByVal request As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponse) Implements ServiceReferenceTwMesTest.wsEQPSoap.wsAUTOUniCheckOutAsync
            Return MyBase.Channel.wsAUTOUniCheckOutAsync(request)
        End Function
        
        Public Function wsAUTOUniCheckOutAsync(ByVal InXml As String) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsAUTOUniCheckOutResponse)
            Dim inValue As ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest = New ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsAUTOUniCheckOutRequestBody()
            inValue.Body.InXml = InXml
            Return CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsAUTOUniCheckOutAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsTESTUniCheckOut(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest) As ServiceReferenceTwMesTest.wsTESTUniCheckOutResponse Implements ServiceReferenceTwMesTest.wsEQPSoap.wsTESTUniCheckOut
            Return MyBase.Channel.wsTESTUniCheckOut(request)
        End Function
        
        Public Function wsTESTUniCheckOut(ByVal InXml As String) As String
            Dim inValue As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest = New ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsTESTUniCheckOutRequestBody()
            inValue.Body.InXml = InXml
            Dim retVal As ServiceReferenceTwMesTest.wsTESTUniCheckOutResponse = CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsTESTUniCheckOut(inValue)
            Return retVal.Body.wsTESTUniCheckOutResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsTESTUniCheckOutAsync(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTESTUniCheckOutResponse) Implements ServiceReferenceTwMesTest.wsEQPSoap.wsTESTUniCheckOutAsync
            Return MyBase.Channel.wsTESTUniCheckOutAsync(request)
        End Function
        
        Public Function wsTESTUniCheckOutAsync(ByVal InXml As String) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTESTUniCheckOutResponse)
            Dim inValue As ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest = New ServiceReferenceTwMesTest.wsTESTUniCheckOutRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsTESTUniCheckOutRequestBody()
            inValue.Body.InXml = InXml
            Return CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsTESTUniCheckOutAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsTESTUniCheckOut_Test(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest) As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponse Implements ServiceReferenceTwMesTest.wsEQPSoap.wsTESTUniCheckOut_Test
            Return MyBase.Channel.wsTESTUniCheckOut_Test(request)
        End Function
        
        Public Function wsTESTUniCheckOut_Test(ByVal InXml As String) As String
            Dim inValue As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest = New ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequestBody()
            inValue.Body.InXml = InXml
            Dim retVal As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponse = CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsTESTUniCheckOut_Test(inValue)
            Return retVal.Body.wsTESTUniCheckOut_TestResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsTESTUniCheckOut_TestAsync(ByVal request As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponse) Implements ServiceReferenceTwMesTest.wsEQPSoap.wsTESTUniCheckOut_TestAsync
            Return MyBase.Channel.wsTESTUniCheckOut_TestAsync(request)
        End Function
        
        Public Function wsTESTUniCheckOut_TestAsync(ByVal InXml As String) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestResponse)
            Dim inValue As ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest = New ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsTESTUniCheckOut_TestRequestBody()
            inValue.Body.InXml = InXml
            Return CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsTESTUniCheckOut_TestAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsTEST2UniCheckOut(ByVal request As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest) As ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponse Implements ServiceReferenceTwMesTest.wsEQPSoap.wsTEST2UniCheckOut
            Return MyBase.Channel.wsTEST2UniCheckOut(request)
        End Function
        
        Public Function wsTEST2UniCheckOut(ByVal InXml As String) As String
            Dim inValue As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest = New ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequestBody()
            inValue.Body.InXml = InXml
            Dim retVal As ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponse = CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsTEST2UniCheckOut(inValue)
            Return retVal.Body.wsTEST2UniCheckOutResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_wsTEST2UniCheckOutAsync(ByVal request As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponse) Implements ServiceReferenceTwMesTest.wsEQPSoap.wsTEST2UniCheckOutAsync
            Return MyBase.Channel.wsTEST2UniCheckOutAsync(request)
        End Function
        
        Public Function wsTEST2UniCheckOutAsync(ByVal InXml As String) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.wsTEST2UniCheckOutResponse)
            Dim inValue As ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest = New ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequest()
            inValue.Body = New ServiceReferenceTwMesTest.wsTEST2UniCheckOutRequestBody()
            inValue.Body.InXml = InXml
            Return CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).wsTEST2UniCheckOutAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_TestDBConnection(ByVal request As ServiceReferenceTwMesTest.TestDBConnectionRequest) As ServiceReferenceTwMesTest.TestDBConnectionResponse Implements ServiceReferenceTwMesTest.wsEQPSoap.TestDBConnection
            Return MyBase.Channel.TestDBConnection(request)
        End Function
        
        Public Function TestDBConnection(ByVal UserNo As String) As String
            Dim inValue As ServiceReferenceTwMesTest.TestDBConnectionRequest = New ServiceReferenceTwMesTest.TestDBConnectionRequest()
            inValue.Body = New ServiceReferenceTwMesTest.TestDBConnectionRequestBody()
            inValue.Body.UserNo = UserNo
            Dim retVal As ServiceReferenceTwMesTest.TestDBConnectionResponse = CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).TestDBConnection(inValue)
            Return retVal.Body.TestDBConnectionResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReferenceTwMesTest_wsEQPSoap_TestDBConnectionAsync(ByVal request As ServiceReferenceTwMesTest.TestDBConnectionRequest) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.TestDBConnectionResponse) Implements ServiceReferenceTwMesTest.wsEQPSoap.TestDBConnectionAsync
            Return MyBase.Channel.TestDBConnectionAsync(request)
        End Function
        
        Public Function TestDBConnectionAsync(ByVal UserNo As String) As System.Threading.Tasks.Task(Of ServiceReferenceTwMesTest.TestDBConnectionResponse)
            Dim inValue As ServiceReferenceTwMesTest.TestDBConnectionRequest = New ServiceReferenceTwMesTest.TestDBConnectionRequest()
            inValue.Body = New ServiceReferenceTwMesTest.TestDBConnectionRequestBody()
            inValue.Body.UserNo = UserNo
            Return CType(Me,ServiceReferenceTwMesTest.wsEQPSoap).TestDBConnectionAsync(inValue)
        End Function
    End Class
End Namespace
