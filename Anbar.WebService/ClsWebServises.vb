Imports System
Imports System.Data
Imports System.Data.SqlClient

'Imports Minoo.Applications.Common

Public Class ClsWebServises

    Public Function GetHavaleErsalBeShoab(sender As Decimal, Receiver As String, KalaSN As Decimal, strSanadStatus As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet
        Dim DV As DataView = New DataView

        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSpr_GetHavaleErsalBeShoab " + sender.ToString() + ",'" + Receiver + "'," + (IIf(KalaSN = 0, "NULL", KalaSN.ToString())) + ",'" + strSanadStatus + "'"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()
            Return DS

        Catch ex As Exception
            'SharedItems.tp.LogStr(ex.Message)
            MsgBox(ex.Message)
            Return Nothing
        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

            If Not DV Is Nothing Then
                DV.Dispose()
                DV = Nothing
            End If

        End Try

    End Function

    Public Function GetHavaleDarRah(sender As Decimal, Receiver As String, KalaSN As Decimal, ConnectionString As String) As DataSet
        Dim DS As DataSet = New DataSet
        Dim DV As DataView = New DataView

        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "exec _abSpG_GetHavaleDarRah " + sender.ToString() + ",'" + Receiver + "'," + (IIf(KalaSN = 0, "NULL", KalaSN.ToString()))
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            MsgBox(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

            If Not DV Is Nothing Then
                DV.Dispose()
                DV = Nothing
            End If
        End Try

    End Function

    Public Function GetKalaMojoodiForForoosh(sender As Decimal, KalaSN As Decimal, ToDate As String, ConnectionString As String) As Decimal

        Dim Result As Decimal
        Dim DS As DataSet = New DataSet
        Dim DV As DataView = New DataView
        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "SELECT dbo.abFn_GetMojoodiKalaByVahedeTejari( " + sender.ToString() + "," + KalaSN.ToString() + ",'" + ToDate + "')"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            DV = DS.Tables(0).DefaultView

            mcn.Close()

            If DV.Count <> 0 Then
                Result = DV(0)(0)
            Else
                Result = 0
            End If

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()

            Return Result

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return 0
        Finally
            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If
            If Not DV Is Nothing Then
                DV.Dispose()
                DV = Nothing
            End If

        End Try

    End Function

    Public Function GetKalaMojoodiForForooshByAnbar(sender As Decimal, AnbarSN As Decimal, KalaSN As Decimal, ToDate As String, ConnectionString As String) As Decimal

        Dim DV As DataView = New DataView
        Dim DS As DataSet = New DataSet
        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "SELECT dbo.abFn_GetMojoodiKala( " + sender.ToString() + "," + AnbarSN.ToString() + ",2," + KalaSN.ToString() + ",'" + ToDate + "',NULL)"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)


            DV = DS.Tables(0).DefaultView

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()

            If DV.Count <> 0 Then
                Return DV(0)(0)
            Else
                Return 0
            End If

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return 0

        Finally

            If Not DV Is Nothing Then
                DV.Dispose()
                DV = Nothing
            End If

        End Try
    End Function

    Public Function GetKalaHaMojoodiForForoosh(sender As Decimal, AnbarSN As Decimal, TaminKonandehSN As Decimal, KalaSN As String, ToDate As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSpr_GetKalaHaMojoodiForForoosh " + sender.ToString() + "," + AnbarSN.ToString() + "," + TaminKonandehSN.ToString() + "," + KalaSN + "," + ToDate
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

        End Try
    End Function

    Public Function GetAnbarDarkhast(sender As Decimal, Receiver As Decimal, KalaSN As Decimal, FromDate As String, ToDate As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet
        Dim DV As DataView = New DataView

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSpr_abDarkhastKala " + sender.ToString() + "," + Receiver.ToString() + "," + KalaSN.ToString() + ",'" + FromDate + "','" + ToDate + "'"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If
        End Try
    End Function

    Public Function GetMojoodiWithoutRahgiri(VahedeTejariSN As Decimal, AnbarSN As Decimal, KalaSN As Decimal, ToDate As String, ConnectionString As String) As Decimal

        Dim DS As DataSet = New DataSet
        'Dim DV As DataView = New DataView
        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "Exec _abSpG_GetMojoodiWithoutRahgiri " + VahedeTejariSN.ToString() + "," + AnbarSN.ToString() + "," + KalaSN.ToString() + "," + ToDate.ToString()
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            'DV = DS.Tables(0).DefaultView

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()

            If DS.Tables(0).Rows.Count <> 0 Then
                Return DS.Tables(0).Rows(0).Item(1)
            Else
                Return 0
            End If

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return 0

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If
            'If Not DV Is Nothing Then
            '    DV.Dispose()
            '    DV = Nothing
            'End If
        End Try

    End Function

    Public Function GetListMojoodiKala(VahedeTejariSN As Decimal, AnbarSN As String, KalaSN As String, ToDate As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet
        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "Exec _abSpG_GetListMojoodiKala " + VahedeTejariSN.ToString() + ",'" + AnbarSN.ToString() + "','" + KalaSN.ToString() + "','" + ToDate.ToString() + "'"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

        End Try

    End Function

    Public Function GetDarkhasteErsalNashodeh(SenderVahedeTejariSN As Decimal, RecieverVahedeTejariSN As String, KalaSN As Decimal, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "Exec _abSpG_GetDarkhastErsalNashode " + SenderVahedeTejariSN.ToString() + ",' " + RecieverVahedeTejariSN + "'," + KalaSN.ToString()
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            'SharedItems.tp.LogStr("ExecuteQuery(" + _txt + ")")

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If
        End Try

    End Function

    Public Function GetMojoodiWithEnghezaDate(VahedeTejariSN As Decimal, vVahedeTejariSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _IsRooz As Integer, _TRooz As Integer, TaEnghezaDate As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSpr_GetKalahaMojoodiEnghezaDate " + VahedeTejariSN.ToString() + ",'" + vVahedeTejariSN.ToString() + _
                "','" + TaminKonandehSN.ToString() + "','" + NoeTaminKonandehSN.ToString() + "','" + KalaSN.ToString() + _
                "','" + NoeMahsoolSN.ToString() + "'," + _IsRooz.ToString() + "," + _TRooz.ToString() + ",'" + TaEnghezaDate.ToString() + "'"

            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

        End Try
    End Function


    ''' متد جهت ارسال حواله به شعب از طریق میدل ورhttp:''localhost:5522/Ab.WebServices/App_Code/AnbarWebService.cs
    'change by yekta 920716
    Public Function DO_ErsaleHavleBeShoab(Packet As String, Sender As Decimal, Receiver As Decimal, ConnectionString As String) As String

        Dim ErrMsg As String = "FALSE"
        Dim i As Integer
        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            'Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSp_ErsaleHavleBeShoab"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@SenderVahedeTejariSN", Sender)
            Cmnd.Parameters.AddWithValue("@ReceiverVahedeTejariSN", Receiver)
            Cmnd.Parameters.AddWithValue("@Packet", Packet)
            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Direction = ParameterDirection.Output
            parameter2.Value = ErrMsg
            parameter2.Size = 5000
            parameter2.SqlValue = ErrMsg
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)
            Try
                i = Cmnd.ExecuteNonQuery
            Catch ex As Exception
                ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
                Return ErrMsg
            End Try
            ErrMsg = Cmnd.Parameters.Item(3).Value()

            mcn.Close()
            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try

    End Function

    Public Function CreateXmlByApp(ConnectionString As String) As String

        Dim DS As DataSet = New DataSet

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Cmnd.CommandText = "abSpG_CreateXmlByApp"
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            mcn.Close()

            If DS.Tables.Count > 0 Then
                If DS.Tables(0).Rows.Count > 0 Then
                    Return DS.Tables(0).DefaultView(0)(0).ToString
                End If
            End If


        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return "False"

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If
        End Try

    End Function

    Public Function DO_SabteResidByApp(Packet As String, Sender As Decimal, Receiver As Decimal, Type As Integer, ConnectionString As String) As String

        Dim ErrMsg As String = "FALSE"
        Dim i As Integer
        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            'Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSp_SabteResidByApp"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@SenderVahedeTejariSN", Sender)
            Cmnd.Parameters.AddWithValue("@ReceiverVahedeTejariSN", Receiver)
            Cmnd.Parameters.AddWithValue("@Packet", Packet)
            Cmnd.Parameters.AddWithValue("@Type", Type)
            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Direction = ParameterDirection.Output
            parameter2.Value = ErrMsg
            parameter2.Size = 5000
            parameter2.SqlValue = ErrMsg
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)
            Try
                i = Cmnd.ExecuteNonQuery
            Catch ex As Exception
                ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
                Return ErrMsg
            End Try
            ErrMsg = Cmnd.Parameters.Item(4).Value()

            mcn.Close()
            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try

    End Function

    ''Add by Dehghani For Service Method GhateeSazi Sanad - 980220


    Public Function GhateeSaziSanad(SanadSN As Decimal, SanadStatus As Short, ByVal UserIdSabtKonandeh As Integer, ByVal UserNameSabtKonandeh As String, ByVal ConnectionString As String) As String

        Dim ErrMsg As String = ""
        Dim i As Integer

        Dim mcn As New SqlClient.SqlConnection
        mcn.ConnectionString = ConnectionString
        mcn.Open()
        Dim myTrans As SqlClient.SqlTransaction = mcn.BeginTransaction()

        Try

            Dim Cmnd As SqlClient.SqlCommand = mcn.CreateCommand()
            Cmnd.Transaction = myTrans

            Dim _txt As String = "_abSPC_Change_SanadStatus"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@SanadSN", SanadSN)
            Cmnd.Parameters.AddWithValue("@New_SanadStatus", SanadStatus)
            Cmnd.Parameters.AddWithValue("@UserID", UserIdSabtKonandeh)
            Cmnd.Parameters.AddWithValue("@UserID_Name", UserNameSabtKonandeh)

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Direction = ParameterDirection.Output
            parameter2.Value = ErrMsg
            parameter2.Size = 5000
            parameter2.SqlValue = ErrMsg
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)
            Cmnd.Parameters.AddWithValue("@NoCtrlKardex", DBNull.Value)

            Try
                i = Cmnd.ExecuteNonQuery
            Catch ex As Exception
                ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
                myTrans.Rollback()
                mcn.Close()
                Return ErrMsg
            End Try

            ErrMsg = Cmnd.Parameters.Item("@ErrMsg").Value.ToString

            mcn.Close()
            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            myTrans.Rollback()
            mcn.Close()
            Return ErrMsg
        End Try

    End Function

    Public Function ChangeSanadStatusServiceMethod(SanadSN As Decimal, ReceiverVahedeTejariSN As Decimal, SanadStatus As Short, ByVal UserIdSabtKonandeh As Integer, ByVal UserNameSabtKonandeh As String) As String
        Dim ErrMsg As String = ""

        Dim ConnectionString As String = "Server=ASP;DataBase=GOD;Integrated Security=no;User ID=serviceAnbar; password=1"

        Try
            Minoo.Applications.Anbar.CSanad.ChangeSanadStatusServiceMethod(SanadSN, ReceiverVahedeTejariSN, SanadStatus, UserIdSabtKonandeh, UserNameSabtKonandeh, ConnectionString)

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try
        If ErrMsg = "" Then
            ErrMsg = "TRUE"
        End If
        Return ErrMsg
    End Function

    '''''''''''''''''''''''''''''''''متد اولیه برای زمانبندی اجرا در میدل ور
    Public Function SabtResidTaminkonandegan(ByVal ConnectionString As String) As String
        Dim ErrMsg As String = ""

        If ConnectionString Is Nothing OrElse ConnectionString = "" Then
            ConnectionString = "Server=ASP;DataBase=GOD;Integrated Security=no;User ID=serviceAnbar; password=1"

        End If
        Try
            Minoo.Applications.Anbar.CSanad.SabtResidTaminkonandegan(ConnectionString)

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try
        If ErrMsg = "" Then
            ErrMsg = "TRUE"
        End If
        Return ErrMsg

    End Function
    '''''''''''ثبت رسید تامین کنندگان
    Public Function DO_SabteResidDarShoab(ByVal Packet As String, ByVal Sender As Decimal, ByVal Receiver As Decimal, ByVal ConnectionString As String) As String

        Dim ErrMsg As String = "FALSE"
        Dim i As Integer
        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            'Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSp_SabteResidDarShoab"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@SenderVahedeTejariSN", Sender)
            Cmnd.Parameters.AddWithValue("@ReceiverVahedeTejariSN", Receiver)
            Cmnd.Parameters.AddWithValue("@Packet", Packet)
            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Direction = ParameterDirection.Output
            parameter2.Value = ErrMsg
            parameter2.Size = 5000
            parameter2.SqlValue = ErrMsg
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)
            Try
                i = Cmnd.ExecuteNonQuery
            Catch ex As Exception
                ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
                Return ErrMsg
            End Try
            ErrMsg = Cmnd.Parameters.Item(3).Value()

            mcn.Close()
            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try

    End Function
    '' متد ارسال بارنامه به دریافت پرداخت
    'Public Function ErsalBeDP(Packet As String, Sender As Decimal, Receiver As Decimal, ConnectionString As String) As String

    '    Dim ErrMsg As String = "FALSE"
    '    Try
    '        Dim ds As New DataSet()
    '        Dim mcn As New SqlClient.SqlConnection

    '        mcn.ConnectionString = ConnectionString
    '        mcn.Open()

    '        Dim sda As New SqlDataAdapter

    '        Dim Cmnd As New SqlCommand
    '        Dim _txt As String = "exec _abSp_ErsaleBarnamehBeDP " & Sender & "," & Receiver & ",'" & Packet & "'"
    '        Cmnd.CommandText = _txt
    '        Cmnd.Connection = mcn
    '        Cmnd.CommandType = CommandType.Text

    '        Cmnd.CommandTimeout = mcn.ConnectionTimeout
    '        sda.SelectCommand = Cmnd

    '        sda.Fill(ds)

    '        mcn.Close()

    '        ErrMsg = ds.Tables(0).Rows(0)("ErrMsg")

    '        If ErrMsg = "" Then
    '            ErrMsg = "TRUE"
    '        Else
    '            Throw New Exception(ErrMsg)
    '        End If

    '        Return ErrMsg

    '    Catch ex As Exception
    '        ErrMsg = "خطا در ارسال بارنامه به دریافت پرداخت: " + ex.Message
    '        Return ErrMsg
    '    End Try

    'End Function

    ' متد زدن تیک بارنامه ای که به دریافت پرداخت ارسال شده است

    ' متد ارسال بارنامه به دریافت پرداخت  new function add by yekta for mohseni request '920502'  change in 920727
    Public Function ErsalBeDP(Packet As String, Sender As Decimal, Receiver As Decimal, ConnectionString As String) As String

        Using mcn As New SqlConnection(ConnectionString)
            Using Cmnd As New SqlCommand()

                Dim ErrMsg As String = "FALSE"
                Try

                    Dim _txt As String = "_abSp_ErsaleBarnamehBeDP"
                    Cmnd.CommandText = _txt
                    Cmnd.Connection = mcn
                    Cmnd.CommandType = CommandType.StoredProcedure
                    Cmnd.Parameters.AddWithValue("@SenderVahedeTejariSN", Sender)
                    Cmnd.Parameters.AddWithValue("@ReceiverVahedeTejariSN", Receiver)
                    Cmnd.Parameters.AddWithValue("@Packet", Packet)
                    Cmnd.CommandTimeout = mcn.ConnectionTimeout

                    mcn.Open()

                    ErrMsg = Cmnd.ExecuteScalar()

                    'mcn.Close()

                    If ErrMsg = "" Then
                        ErrMsg = "TRUE"
                    Else
                        Throw New Exception(ErrMsg)
                    End If

                    Return ErrMsg

                Catch ex As Exception
                    ErrMsg = "خطا در ارسال بارنامه به دریافت پرداخت: " & ex.Message
                    Return ErrMsg
                End Try

            End Using
        End Using
    End Function

    Public Function ErsalBeDP_Taeed(BarnamehSN As String, UserID_Name As String, ConnectionString As String) As String

        Dim ErrMsg As String = "FALSE"
        Dim i As Integer
        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim Cmnd As New SqlCommand
            Dim _txt As String = "UPDATE abBarnameh SET ErsalBeDP = 1 where BarnamehSN = " & BarnamehSN
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout

            i = Cmnd.ExecuteNonQuery()

            mcn.Close()

            If i > 0 Then
                ErrMsg = "TRUE"
            Else
                Throw New Exception(ErrMsg)
            End If

            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در زدن تیک بارنامه ای که به دریافت پرداخت ارسال شده است: " + ex.Message
            Return ErrMsg
        End Try

    End Function

    ''' متد جهت ارسال حواله کسری و اضافه به شعب از طریق میدل ورhttp:''localhost:5522/Ab.WebServices/App_Code/AnbarWebService.cs
    Public Function DO_ErsaleHavaleKasriEzafehBeShoab(Packet As String, Sender As Decimal, Receiver As Decimal, ConnectionString As String) As String

        Dim ErrMsg As String = "FALSE"
        Dim i As Integer
        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            'Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSp_ErsaleHavaleKasriEzafehBeShoab"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@SenderVahedeTejariSN", Sender)
            Cmnd.Parameters.AddWithValue("@ReceiverVahedeTejariSN", Receiver)
            Cmnd.Parameters.AddWithValue("@Packet", Packet)
            Cmnd.Parameters.AddWithValue("@ErrMsg", ErrMsg).Direction = ParameterDirection.Output
            Dim _retparam As New SqlParameter
            _retparam.Value = ""
            _retparam.Direction = ParameterDirection.ReturnValue
            Cmnd.Parameters.Add(_retparam)
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            i = Cmnd.ExecuteNonQuery()

            mcn.Close()

            If CInt(_retparam.Value) = 0 Then
                ErrMsg = "TRUE"
            ElseIf CInt(_retparam.Value) = 1 Then
                ErrMsg = "خطا در ثبت سند بعلت وجود شماره ارجاع تکراری"
            End If

            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try

    End Function

    ''' متد جهت ارسال درخواست برنامه ریزی به ستاد از طریق میدل ور
    Public Function DO_ProductionPlanningDarkhast(Packet As String, Sender As Decimal, Receiver As Decimal, ConnectionString As String) As String

        Dim ErrMsg As String = "FALSE"
        Dim i As Integer

        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSp_ProductionPlanningDarkhast"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@SenderVahedeTejariSN", Sender)
            Cmnd.Parameters.AddWithValue("@ReceiverVahedeTejariSN", Receiver)
            Cmnd.Parameters.AddWithValue("@Packet", Packet)
            Cmnd.Parameters.AddWithValue("@ErrMsg", ErrMsg).Direction = ParameterDirection.Output
            Dim _retparam As New SqlParameter
            _retparam.Value = ""
            _retparam.Direction = ParameterDirection.ReturnValue
            Cmnd.Parameters.Add(_retparam)
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            i = Cmnd.ExecuteNonQuery()

            mcn.Close()

            If CInt(_retparam.Value) = 0 Then
                ErrMsg = "TRUE"
            End If

            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try

    End Function

    ''' متد جهت ارسال حواله به شرکتهای گروه از طریق میدل ور
    Public Function DO_ErsaleHavaleBeSherkateGorooh(Packet As String, Sender As Decimal, Receiver As Decimal, ConnectionString As String) As String

        Dim ErrMsg As String = "خطا در اجرای اس پی در انبار مقصد"
        Dim i As Integer

        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSp_ErsaleHavaleBeSherkateGorooh"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@SenderVahedeTejariSN", Sender)
            Cmnd.Parameters.AddWithValue("@ReceiverVahedeTejariSN", Receiver)
            Cmnd.Parameters.AddWithValue("@Packet", Packet)
            Cmnd.Parameters.AddWithValue("@ErrMsg", ErrMsg).Direction = ParameterDirection.Output
            Dim _retparam As New SqlParameter
            _retparam.Value = ""
            _retparam.Direction = ParameterDirection.ReturnValue
            Cmnd.Parameters.Add(_retparam)
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            i = Cmnd.ExecuteNonQuery()

            mcn.Close()

            If CInt(_retparam.Value) = 0 Then
                ErrMsg = "TRUE"
            ElseIf CInt(_retparam.Value) = 1 Then
                ErrMsg = "خطا در ثبت سند بعلت وجود شماره ارجاع تکراری"
            End If

            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try
    End Function

    Public Function GetMojoodiForMinooApp(KalaNo As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet

        Try
            Dim mcn As New SqlClient.SqlConnection


            If ConnectionString Is Nothing OrElse ConnectionString = "" Then
                ConnectionString = "Server=Tehoff;DataBase=MIS_Daroo;Integrated Security=no;User ID=ServiceOnlineReports; password=1"
            End If

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "abSPG_GetMojoodiForMinooApp"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@KalaNo", KalaNo)
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            Return DS

        Catch ex As Exception
            Return DS
        End Try

    End Function

    Public Function GetBudgetMojoodiVaredeh(VahedeTejariSN As String, KalaSN As String, Fdate As String, Tdate As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSpG_GetBudgetMojoodiVaredeh '" & VahedeTejariSN &
                "','" & KalaSN &
                "','" & Fdate &
                "','" & Tdate & "'"

            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

        End Try
    End Function

    Public Function GetDarkhastErsalNashodeTaminKonandeh(SenderVahedeTejariSN As Decimal, RecieverVahedeTejariSN As String, TaminKonandehSN As Decimal, KalaSN As Decimal, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSpG_GetDarkhastErsalNashodeTaminKonandeh " & SenderVahedeTejariSN &
                ",'" & RecieverVahedeTejariSN &
                "'," & TaminKonandehSN &
                "," & KalaSN & "'"

            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

        End Try
    End Function

    Public Function GetMojoodiKalahayeTaminKonandeh(Vahedetejarisn As Decimal, AnbarSN As Decimal, TaminKonandehSN As Decimal, KalaSN As Decimal, TDate As String, ConnectionString As String) As DataSet

        Dim DS As DataSet = New DataSet

        Try

            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSpG_GetMojoodiKalahayeTaminKonandeh " & Vahedetejarisn &
                "," & AnbarSN &
                "," & TaminKonandehSN &
                "," & KalaSN &
                ",'" & TDate & "'"

            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(DS)

            mcn.Close()

            Return DS

        Catch ex As Exception

            'SharedItems.tp.LogStr(ex.Message)
            Return Nothing

        Finally

            If Not DS Is Nothing Then
                DS.Dispose()
                DS = Nothing
            End If

        End Try
    End Function

    '-----Add By Yekta 920609
    Public Function GetMojoodiAndEnghezaDate(VahedeTejariSN As Decimal, AnbarSN As Decimal, TaminKonandehSN As Decimal, NoeTaminKonandehSN As Decimal, KalaSN As Decimal, NoeMahsoolSN As Decimal, _TRooz As Integer, TaEnghezaDate As String, TarakoneshSN As Integer, _IsRooz As Integer, _Type As Integer, ConnectionString As String) As DataSet


        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        Try
            mcn.ConnectionString = ConnectionString

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_GetMojoodiAndEnghezaDate"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@NoeTaminKonandehSN", NoeTaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@NoeMahsoolSN", NoeMahsoolSN)
            Cmnd.Parameters.AddWithValue("@TRooz", _TRooz)
            Cmnd.Parameters.AddWithValue("@TaEnghezaDate", TaEnghezaDate)
            Cmnd.Parameters.AddWithValue("@TarakoneshSN", TarakoneshSN)
            Cmnd.Parameters.AddWithValue("@IsRooz", _IsRooz)
            Cmnd.Parameters.AddWithValue("@Type", _Type)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

        '''''''''''''''''''' Direct Connection ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Function

    '-----Add By Yekta 930911
    Public Function DO_SabteMarjooei(Packet As String, ConnectionString As String) As String

        Dim ErrMsg As String = "FALSE"
        Dim i As Integer
        Try
            Dim mcn As New SqlClient.SqlConnection

            mcn.ConnectionString = ConnectionString
            mcn.Open()

            'Dim sda As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim _txt As String = "_abSp_SabteMarjooei"
            Cmnd.CommandText = _txt
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@Packet", Packet)
            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Direction = ParameterDirection.Output
            parameter2.Value = ErrMsg
            parameter2.Size = 5000
            parameter2.SqlValue = ErrMsg
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)
            Try
                i = Cmnd.ExecuteNonQuery
            Catch ex As Exception
                ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
                Return ErrMsg
            End Try

            ErrMsg = Cmnd.Parameters.Item("@ErrMsg").Value.ToString

            mcn.Close()
            Return ErrMsg

        Catch ex As Exception
            ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
            Return ErrMsg
        End Try

    End Function

    'Public Shared Function DO_ErsaleHavleBeShoab1(Packet As String, Sender As Decimal, Receiver As Decimal, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As String

    '    Dim ErrMsg As String = "FALSE"
    '    Dim i As Integer
    '    Try
    '        Dim mcn As New SqlClient.SqlConnection

    '        mcn.ConnectionString = cn.ConnectionString + "; password=" & cn.SQLPassword
    '        mcn.Open()

    '        'Dim sda As New SqlDataAdapter
    '        Dim Cmnd As New SqlCommand
    '        Dim _txt As String = "_abSp_ErsaleHavleBeShoab"
    '        Cmnd.CommandText = _txt
    '        Cmnd.Connection = mcn
    '        Cmnd.CommandType = CommandType.StoredProcedure
    '        Cmnd.Parameters.Add("@SenderVahedeTejariSN", Sender)
    '        Cmnd.Parameters.Add("@ReceiverVahedeTejariSN", Receiver)
    '        Cmnd.Parameters.Add("@Packet", Packet)
    '        Dim parameter2 As New SqlClient.SqlParameter
    '        parameter2.ParameterName = "@ErrMsg"
    '        parameter2.SqlDbType = SqlDbType.NVarChar
    '        parameter2.Direction = ParameterDirection.Output
    '        parameter2.Value = ErrMsg
    '        parameter2.Size = 5000
    '        parameter2.SqlValue = ErrMsg
    '        parameter2.SourceColumn = "ErrMsg"
    '        Cmnd.Parameters.Add(parameter2)
    '        Try
    '            i = Cmnd.ExecuteNonQuery
    '        Catch ex As Exception

    '        End Try
    '        ErrMsg = Cmnd.Parameters.Item(3).Value()

    '        mcn.Close()
    '        Return ErrMsg

    '    Catch ex As Exception
    '        ErrMsg = "خطا در اجرای وب سرویس انبار در مقصد : " + ex.Message
    '        Return ErrMsg
    '    End Try

    'End Function

End Class