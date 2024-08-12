Imports System.Data.SqlClient
Imports Minoo.Services.Middleware
Imports Minoo.Models.Middleware

Namespace WebServiceCaller
    Public Class WebService
        Private _ErrorMessage As String = Nothing
        Private m_Url As String
        Public Event WebServiceExection(ByVal ex As String, ByVal InnerEx As Exception)

        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _ErrorMessage
            End Get
        End Property

        Public ReadOnly Property URL() As String
            Get
                Return m_Url
            End Get
        End Property

        Public Function CallWebMetod(ByVal ServerName As String, _
           ByVal VirtualDirectoryName As String, _
           ByVal WebServiceName As String, _
           ByVal MethodName As String, _
           ByVal params As Object()) As Object
            Dim pr As New ProxyClass
            _ErrorMessage = ""
            Try
                Dim _
                 StrUrl As String = _
                 String.Concat("http://", ServerName.Trim, "/" + VirtualDirectoryName + "/", WebServiceName, ".asmx?WSDL")
                m_Url = StrUrl
                Dim _uri As New Uri(StrUrl)

                CallWebMetod = pr.CallWebMethod(pr.GetWSDLInfo(_uri), MethodName, params)
            Catch ex As Exception
                _ErrorMessage = ex.Message
                RaiseEvent WebServiceExection("not Url", ex)
                CallWebMetod = Nothing
            End Try

            _ErrorMessage = _ErrorMessage + pr.Exception_msg


        End Function

        Public Function CallWebMetodByLoadURLFormDB(ByVal cn As SqlConnection, _
           ByVal VahedeTejariSN As Decimal, _
           ByVal WebServiceName As String, _
           ByVal MethodName As String, _
           ByVal params As Object()) As Object

            Dim pr As New ProxyClass
            _ErrorMessage = ""

            Try
                Dim StrUrl As String = GetUrl(cn, VahedeTejariSN, WebServiceName)
                m_Url = StrUrl
                Dim _uri As New Uri(StrUrl)
                CallWebMetodByLoadURLFormDB = pr.CallWebMethod(pr.GetWSDLInfo(_uri), MethodName, params)
            Catch ex As Exception
                _ErrorMessage = ex.Message
                RaiseEvent WebServiceExection("not Url", ex)
                CallWebMetodByLoadURLFormDB = Nothing
            End Try

            _ErrorMessage = _ErrorMessage + pr.Exception_msg

        End Function

        'Public Shared Function CallQualifiedWebMethod(ByVal MethodUrl As String, ByVal ParamArray params() As Object) As String

        '	Try
        '		Dim bs As Integer = MethodUrl.LastIndexOf("\")
        '		If bs > 0 Then
        '			Dim _uri As New Uri(MethodUrl + ".asmx?WSDL")
        '			Dim MethodName As String = MethodUrl.Substring(bs + 1)

        '			Dim pr As New ProxyClass
        '			Return CStr(pr.CallWebMethod(pr.GetWSDLInfo(_uri), MethodName, params))
        '		Else
        '			Return "وب متد قابل شناسایی نیست."
        '		End If
        '	Catch ex As Exception
        '		Return ex.Message
        '	End Try

        'End Function

        Public Function CallWebMetodByURL(ByVal URL As String, _
          ByVal VahedeTejariSN As Decimal, _
          ByVal WebServiceName As String, _
          ByVal MethodName As String, _
          ByVal params As Object()) As Object

            Dim pr As New ProxyClass
            _ErrorMessage = ""

            Try
                Dim StrUrl As String = String.Concat(URL, "/" + WebServiceName + ".asmx?WSDL")
                m_Url = StrUrl
                Dim _uri As New Uri(StrUrl)

                CallWebMetodByURL = pr.CallWebMethod(pr.GetWSDLInfo(_uri), MethodName, params)
            Catch ex As Exception
                _ErrorMessage = ex.Message
                RaiseEvent WebServiceExection("not Url", ex)
                CallWebMetodByURL = Nothing
            End Try

            _ErrorMessage = _ErrorMessage + pr.Exception_msg

        End Function

        Public Function CallWebMetodByVahedeTejariSN(ByVal cn As SqlConnection, _
            ByVal VahedeTejariSN As Decimal, _
            ByVal WebServiceName As String, _
            ByVal MethodName As String, _
            ByVal params As Object()) As Object
            Dim pr As New ProxyClass
            _ErrorMessage = ""

            Try
                Dim ServerName As String = GetServerName(cn, VahedeTejariSN)
                If ServerName <> "" Then
                    Dim _
                    StrUrl As String = _
                    String.Concat("http://", ServerName.Trim, "/MinooWebServices/" + WebServiceName + ".asmx?WSDL")
                    m_Url = StrUrl
                    Dim _uri As New Uri(StrUrl)
                    CallWebMetodByVahedeTejariSN = pr.CallWebMethod(pr.GetWSDLInfo(_uri), MethodName, params)
                Else
                    CallWebMetodByVahedeTejariSN = Nothing
                End If

            Catch ex As Exception
                _ErrorMessage = ex.Message
                RaiseEvent WebServiceExection("not servername", ex)
                CallWebMetodByVahedeTejariSN = Nothing
            End Try

            _ErrorMessage = _ErrorMessage + pr.Exception_msg

        End Function

        Private Function GetUrl(ByVal _cn As SqlConnection, _
            ByVal VahedeTejariSN As Decimal, _
            ByVal WebServiceName As String) As String

            Dim cmd As New SqlCommand
            Dim strUrl As String = Nothing

            Try
                _cn.Open()
                cmd.Connection = _cn
                Dim cmdResult As Object
                cmd.CommandText = "select Url " + _
                " from paVahedetejariUrl " + _
                " inner join Application " + _
                " on pavahedetejariurl.ApplicationKeyID=Application.ApplicationKeyID" + _
                " where VahedeTejariSN='" + CStr(VahedeTejariSN) + "'"


                cmdResult = cmd.ExecuteScalar()
                If Not cmdResult Is Nothing Then
                    strUrl = CStr(cmdResult) + "/" + WebServiceName + ".asmx?WSDL"
                End If
                _cn.Close()

            Catch ex As Exception
                _ErrorMessage = ex.Message
                RaiseEvent WebServiceExection("not strUrl", ex)
            End Try

            Return strUrl

        End Function

        Private Function GetServerName(ByVal _cn As SqlConnection, ByVal VahedeTejariSN As Decimal) As String

            Dim r_string As String = Nothing
            Try
                Dim DT As New DataTable
                _cn.Open()
                Dim DA As _
                  New SqlDataAdapter( _
                 "select top 1 ServerName from dmdatabase join dmServer on dmdatabase.ServerKeyID = dmServer.ServerKeyID " + _
                 " where VahedeTejariSN='" + CStr(VahedeTejariSN) + "'", _
                 _cn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    r_string = CStr(DT.DefaultView(0)(0))
                Else
                    r_string = ""
                End If
            Catch ex As Exception
                _ErrorMessage = ex.Message
                RaiseEvent WebServiceExection("not servername", ex)
            End Try

            Return r_string

        End Function

 
    End Class


End Namespace


