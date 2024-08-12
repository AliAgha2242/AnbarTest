Imports System.Reflection
Imports System.Net
Imports System.IO
Imports System.Web.Services.Description
Imports System.CodeDom
Imports System.Globalization
Imports System.CodeDom.Compiler

Namespace WebServiceCaller
	Friend Class ProxyClass
		Public Exception_msg As String

		'get WSDL information of this uri address,uri must be address of WSDL file for example("http://localhost/AraWfDef/AWFWebService/WorkFFF.asmx?WSDL")
		'this function return a Type of requested service that can used for getting methods list,parameters or invoking webmethods...
		Public Function GetWSDLInfo(ByVal _uri As Uri) As Type

			'get WSDL information
			Dim webReq As WebRequest = WebRequest.Create(_uri)


			webReq.Timeout = -1
			Dim reqStrm As Stream = webReq.GetResponse.GetResponseStream()
			Dim _serviceDesc As ServiceDescription = ServiceDescription.Read(reqStrm)
			Dim _serviceName As String = _serviceDesc.Services(0).Name

			'generating proxy class...
			Dim servImport As New ServiceDescriptionImporter
			servImport.AddServiceDescription(_serviceDesc, String.Empty, String.Empty)
			servImport.ProtocolName = "Soap"
			''servImport.CodeGenerationOptions = CodeGenerationOptions.GenerateProperties

			'compile tree of class
			Dim ns As New CodeNamespace
			Dim ccu As New CodeCompileUnit
			ccu.Namespaces.Add(ns)
			Dim warnings As ServiceDescriptionImportWarnings
			warnings = servImport.Import(ns, ccu)

			'generate exact code of proxy class 
			Dim sw As New StringWriter(CultureInfo.CurrentCulture)
			Dim prov As New VBCodeProvider
			prov.GenerateCodeFromNamespace(ns, sw, Nothing)
			'prov.CreateGenerator(sw).GenerateCodeFromNamespace(ns, sw, Nothing)

			'compile proxy class and code
			Dim param As New CompilerParameters(New String() _
			   {"System.Web.Services.dll", "System.Xml.dll", _
			   "System.dll", "System.Data.dll", _
			 "Microsoft.VisualBasic.dll" _
				})
			param.GenerateExecutable = False
			param.GenerateInMemory = True
			param.TreatWarningsAsErrors = False
			param.WarningLevel = 4
			Dim results As CompilerResults
			'results = prov.CompileAssemblyFromSource(param, sw.ToString())
			'results = prov.CreateCompiler().CompileAssemblyFromSource(param, sw.ToString())
			results = prov.CompileAssemblyFromDom(param, ccu)

			Dim _proxyAssembly As Assembly = results.CompiledAssembly

			'getting proxy of webservice
			Dim service As Type
			service = _proxyAssembly.GetType(_serviceName)

			Return service
		End Function

		'get webmethods information of current service,and return an array of methodinfo
		Public Function GetWebMethodsInfo(ByVal service As Type) As MethodInfo()
			Dim minf As MethodInfo() = service.GetMethods(BindingFlags.DeclaredOnly Or _
					   BindingFlags.IgnoreCase Or BindingFlags.Instance Or _
					   BindingFlags.InvokeMethod Or BindingFlags.Public)
			Return minf
		End Function

		'get paramateres of selected webmethod in requested web service, and return an array of parametersinfo
		Public Function GetWebMethodParameters(ByVal serviceType As Type, ByVal MethodName_str As String) _
		 As ParameterInfo()
			'Return serviceType.GetMethod(MethodName_str).GetParameters()
			Return serviceType.GetMethod(MethodName_str, _
				  BindingFlags.DeclaredOnly Or _
				  BindingFlags.IgnoreCase Or BindingFlags.Instance Or _
				  BindingFlags.InvokeMethod Or BindingFlags.Public).GetParameters()
		End Function

		'call a webmethod in requested webservice ,you must enter method name and paramateres,this function return Object (return from calling webmethod)
		Public Function CallWebMethod(ByVal assemblyType As Type, _
			   ByVal MethodName_str As String, _
			   ByVal params As Object()) _
		 As Object
			Try
				Dim methodInfo As MethodInfo = assemblyType.GetMethod(MethodName_str, _
			  BindingFlags.DeclaredOnly Or _
			  BindingFlags.IgnoreCase Or _
			  BindingFlags.Instance Or _
			  BindingFlags.InvokeMethod Or _
			  BindingFlags.Public)
				Dim instance As Object = Activator.CreateInstance(assemblyType)
				Return methodInfo.Invoke(instance, params)
			Catch ex As Exception
				'MsgBox(assemblyType.GetType().ToString & " ____ " & ex.Message)
				Exception_msg = assemblyType.GetType().ToString & " __ " & ex.Message
			End Try
			Return Nothing
			'CoWaitForMultipleHandle()
		End Function

		'Is URL correct?
		Public Function IsValidWebService(ByVal _uri As Uri) As Boolean
			'get WSDL information
			Dim webReq As WebRequest = WebRequest.Create(_uri)
			If webReq.GetResponse() Is Nothing Then
				Return False
			Else
				Return True
			End If
        End Function

	End Class
End Namespace