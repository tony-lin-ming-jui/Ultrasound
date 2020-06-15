Imports System.IO.Ports '條碼槍要import IO
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class Form1
    Dim strWriteReSet As String
    Dim strWriteSet As String

    Dim strWriteTime As String
    Dim strReadTime As String
    Dim DoubleTime As Double

    Dim strWritePower As String
    Dim strReadPower As String
    Dim DoublePower As Double

    Dim strWriteBarCode As String
    Dim strReadBarCode As String
    Dim uint16BarCode As UInt32

    Dim strWriteResult As String
    Dim strReadResult As String
    Dim uint16Result As String

    Dim strWriteM1900 As String
    Dim strReadM1900 As String
    Dim uint16M1900 As String

    Dim m_wsMesTwTest As New ServiceReferenceTwMesTest.wsEQPSoapClient '測試區
    Dim m_wsMesTwProduction As New ServiceReferenceTwMesProduction.wsEQPSoapClient '正式區
    Dim m_strMesResult As String
    Dim AllInXmlStr As String

    Dim FilePath As String
    Dim time As String

    Dim strData As String
    Dim strSerialRead As String = ""
    Dim x As Integer = 0
    Dim comport(2) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer3.Enabled = True
        LblTotal.Text = 0
        LblPASS.Text = 0
        LblNG.Text = 0
        TestNoNg.Visible = False
        ProductionNoNg.Visible = False
    End Sub
    '條碼槍要能掃描作業員工號
    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        'timer2讀COMPORT可能不能用 他抓的是線而不是儀器
        Try
            If BtnConnect.Text = "連線" Then
                BtnConnect.Text = "中斷連線"
                TextBox1.Text = ""
                SerialPort1.ReadTimeout = 1500
                SerialPort1.PortName = UltrasoundCom.Text
                SerialPort1.NewLine = Chr(&H3)
                SerialPort1.Open()
                SerialPort2.PortName = BarcodeCom.Text
                SerialPort2.Open()
                Timer1.Enabled = True
                Timer2.Enabled = True
                Timer3.Enabled = False
                UltrasoundCom.Enabled = False
                BarcodeCom.Enabled = False


                modelNam.Enabled = False
                OrderNum.Enabled = False
                WkorderNum.Enabled = False
                Quantity.Enabled = False
                WkStationNam.Enabled = False
                TxtOpCode.Enabled = False


                RadioNoMes.Enabled = False
                RadioMesTest.Enabled = False
                RadioMesProduction.Enabled = False

                TestNoNg.Enabled = False
                ProductionNoNg.Enabled = False

                If modelNam.Text = "" Or OrderNum.Text = "" Or WkorderNum.Text = "" Or Quantity.Text = "" Or WkStationNam.Text = "" Or TxtOpCode.Text = "" Then
                    If modelNam.Text = "" Then
                        TextBox1.Text &= "機種名稱未填" & vbNewLine
                    End If
                    If OrderNum.Text = "" Then
                        TextBox1.Text &= "訂單號碼未填" & vbNewLine
                    End If
                    If WkorderNum.Text = "" Then
                        TextBox1.Text &= "工單號碼未填" & vbNewLine
                    End If
                    If Quantity.Text = "" Then
                        TextBox1.Text &= "排定生產數量未填" & vbNewLine
                    End If
                    If WkStationNam.Text = "" Then
                        TextBox1.Text &= "工作站站名未填" & vbNewLine
                    End If
                    If TxtOpCode.Text = "" Then
                        TextBox1.Text &= "作業員代碼未填" & vbNewLine
                    End If
                    'MsgBox("匯出檔案失敗", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                    TextBox1.Text &= "啟動失敗，請確認表單是否填寫" & vbNewLine
                    MsureError()
                Else
                    '抓資料 抓產品NG和PASS的資料
                    Dim Passtotal, NGtotal As Long
                    Dim PassFile, NgFile As String
                    Dim csvpassdata, csvngdata, Arrp(), Arrn() As String
                    Dim srp, srn As StreamReader
                    'My.Computer.FileSystem.CreateDirectory("D:\34972A_Measure\" & modelNam.Text)
                    PassFile = "D:\UltraSound\" & modelNam.Text & "\" & WkorderNum.Text & "_PASS" & ".CSV"
                    NgFile = "D:\UltraSound\" & modelNam.Text & "\" & WkorderNum.Text & "_NG" & ".CSV"
                    If File.Exists(PassFile) = True Then
                        Dim flp As New FileInfo(PassFile)

                        srp = flp.OpenText
                        Do While srp.Peek() >= 0
                            'If sr.Peek() = -1 Then
                            csvpassdata = (srp.ReadLine()) & vbNewLine '迴圈不用& 就只會抓到最後一個值
                            'End If
                        Loop
                        srp.Close()
                        Arrp = Split(csvpassdata, ",")
                        Passtotal = Arrp(10)
                    Else
                        Passtotal = 0
                    End If

                    If File.Exists(NgFile) = True Then
                        Dim fln As New FileInfo(NgFile)

                        srn = fln.OpenText
                        Do While srn.Peek() >= 0
                            'If sr.Peek() = -1 Then
                            csvngdata = (srn.ReadLine()) & vbNewLine '迴圈不用& 就只會抓到最後一個值
                            'End If
                        Loop
                        srn.Close()
                        Arrn = Split(csvngdata, ",")
                        NGtotal = Arrn(10)
                    Else
                        NGtotal = 0
                    End If

                    '抓以生產的總數最大的表示就是最後一筆
                    If Passtotal = 0 And NGtotal = 0 Then
                        LblPASS.Text = 0
                        LblNG.Text = 0
                        LblTotal.Text = 0
                    ElseIf Passtotal > NGtotal Then
                        LblPASS.Text = Arrp(8)
                        LblNG.Text = Arrp(9)
                        LblTotal.Text = Arrp(10)
                    Else
                        LblPASS.Text = Arrn(8)
                        LblNG.Text = Arrn(9)
                        LblTotal.Text = Arrn(10)
                    End If


                    '設定停止PLC啟動開關
                    strWriteSet = Chr(&H2) & "01423M1901" & "14" & Chr(&H3)
                    SerialPort1.Write(strWriteSet)
                    strReadM1900 = SerialPort1.ReadLine()
                End If
            Else
                MsureError()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")  '可以改如果comport錯誤想要輸入的文字  有兩種情況 空白和COM錯誤 先別改這個除非能判斷'
            'MsgBox("COM Port 錯誤或未連接設備", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
            Form2.Show()
            Form2.Focus()

            Form2.Label1.Text = "COM Port 錯誤或未連接設備"

            MsureError()
        End Try
    End Sub
    Sub MsureError()
        BtnConnect.Text = "連線"
        SerialPort1.Close()
        SerialPort2.Close()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = True
        UltrasoundCom.Enabled = True
        BarcodeCom.Enabled = True


        modelNam.Enabled = True
        OrderNum.Enabled = True
        WkorderNum.Enabled = True
        Quantity.Enabled = True
        WkStationNam.Enabled = True
        TxtOpCode.Enabled = True

        RadioNoMes.Enabled = True
        RadioMesTest.Enabled = True
        RadioMesProduction.Enabled = True

        TestNoNg.Enabled = True
        ProductionNoNg.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '條碼槍再開一個Timer 一直讀 timer3
        '如果有讀到條碼 
        '啟動
        Try
            strWriteM1900 = Chr(&H2) & "014401M1900" & "43" & Chr(&H3)
            SerialPort1.Write(strWriteM1900)
            strReadM1900 = SerialPort1.ReadLine()
            uint16M1900 = Strings.Mid(strReadM1900, 7, 1) '從第6個開始往後數一個傳回

            If uint16M1900 = 1 Then
                strWriteTime = Chr(&H2) & "014601R03750" & "7F" & Chr(&H3)
                SerialPort1.Write(strWriteTime)
                strReadTime = SerialPort1.ReadLine()

                DoubleTime = (CDbl(Convert.ToUInt16(Strings.Mid(strReadTime, 7, 4), 16))) * 0.01 '第7位開始往後數4位  轉16
                'If DoubleTime = lastuint16Time Then
                '    Exit Sub
                'Else

                Dim strTemp As String


                strWritePower = Chr(&H2) & "014602R03746" & "85" & Chr(&H3)
                SerialPort1.Write(strWritePower)
                strReadPower = SerialPort1.ReadLine()

                strTemp = Strings.Mid(strReadPower, 7, 8)
                '
                TextBox1.Text &= strTemp & vbNewLine
                '
                strTemp = Strings.Right(strTemp, 4) & Strings.Left(strTemp, 4)

                DoublePower = (CDbl(Convert.ToUInt32(strTemp, 16))) * 0.1

                strWriteBarCode = Chr(&H2) & "014602D00202" & "67" & Chr(&H3)
                SerialPort1.Write(strWriteBarCode)
                strReadBarCode = SerialPort1.ReadLine()
                strTemp = Strings.Mid(strReadBarCode, 7, 8)
                '
                TextBox1.Text &= strTemp & vbNewLine
                '
                strTemp = Strings.Right(strTemp, 4) & Strings.Left(strTemp, 4)
                uint16BarCode = Convert.ToUInt32(strTemp, 16)

                strWriteResult = Chr(&H2) & "014601D00200" & "64" & Chr(&H3)
                SerialPort1.Write(strWriteResult)
                strReadResult = SerialPort1.ReadLine()
                uint16Result = Strings.Mid(strReadResult, 7, 4)

                Label36.Text = "上次產品測量時間: " & time
                time = Now.ToString("yyyy-MM-dd HH:mm:ss")
                Label38.Text = "本次產品測量時間: " & time

                If uint16Result = "4B4F" Then
                    uint16Result = "Pass"
                    LblPASS.Text = Int(LblPASS.Text) + 1
                    If RadioMesTest.Checked Or RadioMesProduction.Checked Then
                        Dim strMesResponse As String
                        strMesResponse = mesTestTESTUniCheckOut(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text, "Pass")
                        If strMesResponse <> "OK" Then
                            'TextBox1.Text = "MES發生錯誤，請排除錯誤再測試" & strMesResponse
                            Form2.Show()
                            Form2.Focus()
                            Form2.Label1.Text = "MES錯誤請確認工單、條碼、工作站" & strMesResponse
                        End If
                    End If
                    MyWriteFile(1)
                Else
                    uint16Result = "Ng"
                    LblNG.Text = Int(LblNG.Text) + 1
                    'If RadioMesTest.Checked Or RadioMesProduction.Checked Then
                    If (RadioMesTest.Checked And TestNoNg.Checked = False) Or (RadioMesProduction.Checked And ProductionNoNg.Checked = False) Then

                        Dim strMesResponse As String
                        strMesResponse = mesTestTESTUniCheckOut(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text, "Ng")
                        If strMesResponse <> "OK" Then
                            'TextBox1.Text = "MES發生錯誤，請排除錯誤再測試" & strMesResponse
                            Form2.Show()
                            Form2.Focus()
                            Form2.Label1.Text = "MES錯誤請確認工單、條碼、工作站" & strMesResponse
                        End If
                    End If

                    MyWriteFile(0)
                End If

                strWriteM1900 = Chr(&H2) & "01424M1900" & "14" & Chr(&H3)
                SerialPort1.Write(strWriteM1900)
                strReadM1900 = SerialPort1.ReadLine()
                '設定停止PLC啟動開關
                strWriteSet = Chr(&H2) & "01423M1901" & "14" & Chr(&H3)
                SerialPort1.Write(strWriteSet)
                strReadM1900 = SerialPort1.ReadLine()
            End If


        Catch ex As TimeoutException
            BtnConnect_Click(New Object, New EventArgs)
            'TextBox1.Text = "超音波熔接機未連接"
            Form2.Show()
            Form2.Focus()
            Form2.Label1.Text = "超音波熔接機未連接"

        End Try

        Label1.Text = "熔接時間:" & DoubleTime
        Label2.Text = "熔接能量:" & DoublePower
        Label3.Text = "總數量:" & uint16BarCode
        Label4.Text = "熔接結果:" & uint16Result
        'End If

    End Sub
    Sub MyWriteFile(WtF As Integer)
        LblTotal.Text = Int(LblNG.Text) + Int(LblPASS.Text)
        If WtF = 1 Then
            FilePath = "D:\UltraSound\" & modelNam.Text & "\" & WkorderNum.Text & "_PASS" & ".CSV"
        ElseIf WtF = 0 Then
            FilePath = "D:\UltraSound\" & modelNam.Text & "\" & WkorderNum.Text & "_NG" & ".CSV"
        End If

        If File.Exists(FilePath) = True Then
            Using fs As IO.FileStream = New IO.FileStream(FilePath, FileMode.Append)
                Using sw As StreamWriter = New StreamWriter(fs, Encoding.Default)

                    ' sw.Write(str)   '第一行
                    strData &= time & "," & "=" & Chr(34) & modelNam.Text & Chr(34) & "," & "=" & Chr(34) & OrderNum.Text & Chr(34) &
                        "," & "=" & Chr(34) & WkorderNum.Text & Chr(34) & "," & Quantity.Text &
                        "," & "=" & Chr(34) & WkStationNam.Text & Chr(34) & "," & "=" & Chr(34) & TxtOpCode.Text & Chr(34) &
                        "," & "=" & Chr(34) & uint16BarCode & Chr(34) & "," & LblPASS.Text & "," & LblNG.Text &
                        "," & LblTotal.Text & "," & "=" & Chr(34) & DoubleTime & Chr(34) & "," & "=" & Chr(34) & DoublePower & Chr(34) &
                        "," & "=" & Chr(34) & uint16Result & Chr(34) & "," & "=" & Chr(34) & LblBarCode.Text & Chr(34) & ","
                    sw.WriteLine(strData)
                    sw.Flush()
                    sw.Close()
                End Using
            End Using
        Else
            My.Computer.FileSystem.CreateDirectory("D:\UltraSound\" & modelNam.Text)
            Using fs As IO.FileStream = New IO.FileStream(FilePath, FileMode.Append)
                Using sw As StreamWriter = New StreamWriter(fs, Encoding.Default)
                    sw.WriteLine("時間日期,機種名稱,訂單編號,工單號碼,工單排定生產數量,工作站站名,作業員代碼,產品編號,PASS總數,NG總數,已生產總數," &
                     "熔接時間,熔接能量,熔接結果,產品條碼")


                    strData &= time & "," & "=" & Chr(34) & modelNam.Text & Chr(34) & "," & "=" & Chr(34) & OrderNum.Text & Chr(34) &
                        "," & "=" & Chr(34) & WkorderNum.Text & Chr(34) & "," & Quantity.Text &
                        "," & "=" & Chr(34) & WkStationNam.Text & Chr(34) & "," & "=" & Chr(34) & TxtOpCode.Text & Chr(34) &
                        "," & "=" & Chr(34) & uint16BarCode & Chr(34) & "," & LblPASS.Text & "," & LblNG.Text &
                        "," & LblTotal.Text & "," & "=" & Chr(34) & DoubleTime & Chr(34) & "," & "=" & Chr(34) & DoublePower & Chr(34) &
                        "," & "=" & Chr(34) & uint16Result & Chr(34) & "," & "=" & Chr(34) & LblBarCode.Text & Chr(34) & ","
                    sw.WriteLine(strData)
                    sw.Flush()
                    sw.Close()
                End Using
            End Using
        End If
    End Sub

    Private Function mesProductionTestDBConnection() As Boolean
        Dim responseStr As String
        If x = 1 Then
            responseStr = m_wsMesTwTest.TestDBConnection("iMES")
        ElseIf x = 2 Then
            responseStr = m_wsMesTwProduction.TestDBConnection("iMES")
        End If
        If responseStr = "Test successfully, UserName:IMES, DataBase is oracle !" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function mesTestTESTUniCheckOutAsk(usernoStr As String, curusernoStr As String, opnoStr As String, monoStr As String, lotnoStr As String) As String
        Dim InXmlStr, responseStr As String
        InXmlStr = My.Resources.InXmlTemplateString
        InXmlStr = Replace(InXmlStr, "transactionidReplace", Now.Millisecond.ToString)
        InXmlStr = Replace(InXmlStr, "moduleidReplace", "請改自己模組名稱縮寫")
        InXmlStr = Replace(InXmlStr, "functionidReplace", "mesTestTESTUniCheckOut")
        InXmlStr = Replace(InXmlStr, "computernameReplace", My.Computer.Name)
        InXmlStr = Replace(InXmlStr, "curusernoReplace", curusernoStr)
        InXmlStr = Replace(InXmlStr, "sendtimeReplace", Format(Now, "yyyy-MM-dd HH:mm:ss"))
        InXmlStr = Replace(InXmlStr, "languagemodeReplace", "zh-CHT")
        InXmlStr = Replace(InXmlStr, "usernoReplace", usernoStr)
        InXmlStr = Replace(InXmlStr, "equitmentnoReplace", "")
        InXmlStr = Replace(InXmlStr, "monoReplace", monoStr)
        InXmlStr = Replace(InXmlStr, "opnoReplace", opnoStr)
        InXmlStr = Replace(InXmlStr, "lotnoReplace", lotnoStr)
        InXmlStr = Replace(InXmlStr, "resultReplace", "")
        'responseStr = m_wsMesTwTest.wsTESTUniCheckOut(InXmlStr)
        If x = 1 Then
            responseStr = m_wsMesTwTest.wsTESTUniCheckOut(InXmlStr)
        ElseIf x = 2 Then
            responseStr = m_wsMesTwProduction.wsTESTUniCheckOut(InXmlStr)
        End If
        If InStr(responseStr, "<result>1</result>") > 0 Then
            Return "OK"
        Else
            Return responseStr
        End If
    End Function
    Private Function mesTestTESTUniCheckOut(usernoStr As String, curusernoStr As String, opnoStr As String, monoStr As String, lotnoStr As String, resultStr As String) As String
        Dim InXmlStr, responseStr As String
        InXmlStr = My.Resources.InXmlTemplateString
        InXmlStr = Replace(InXmlStr, "transactionidReplace", Now.Millisecond.ToString)
        InXmlStr = Replace(InXmlStr, "moduleidReplace", "請改自己模組名稱縮寫")
        InXmlStr = Replace(InXmlStr, "functionidReplace", "mesTestTESTUniCheckOut")
        InXmlStr = Replace(InXmlStr, "computernameReplace", My.Computer.Name)
        InXmlStr = Replace(InXmlStr, "curusernoReplace", curusernoStr)
        InXmlStr = Replace(InXmlStr, "sendtimeReplace", Format(Now, "yyyy-MM-dd HH:mm:ss"))
        InXmlStr = Replace(InXmlStr, "languagemodeReplace", "zh-CHT")
        InXmlStr = Replace(InXmlStr, "usernoReplace", usernoStr)
        InXmlStr = Replace(InXmlStr, "equitmentnoReplace", "")
        InXmlStr = Replace(InXmlStr, "monoReplace", monoStr)
        InXmlStr = Replace(InXmlStr, "opnoReplace", opnoStr)
        InXmlStr = Replace(InXmlStr, "lotnoReplace", lotnoStr)
        InXmlStr = Replace(InXmlStr, "resultReplace", resultStr)
        If x = 1 Then
            responseStr = m_wsMesTwTest.wsTESTUniCheckOut(InXmlStr)
        ElseIf x = 2 Then
            responseStr = m_wsMesTwProduction.wsTESTUniCheckOut(InXmlStr)
        End If
        If InStr(responseStr, "<result>success</result>") > 0 Then
            Return "OK"
        Else
            Return responseStr
        End If
    End Function
    Private Sub SignalDBGenerate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '表單關閉的動作
        SerialPort1.Close()
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If strSerialRead <> "" Then
            '如果有條碼 跑下面
            '清除停止PLC啟動開關
            LblBarCode.Text = strSerialRead
            LblBarCode.Text = Replace(LblBarCode.Text, vbCr, "")
            LblBarCode.Text = Replace(LblBarCode.Text, vbLf, "")
            strSerialRead = ""
            'If CheckBox1.Checked Then
            If RadioNoMes.Checked Then
                strWriteReSet = Chr(&H2) & "01424M1901" & "15" & Chr(&H3)
                SerialPort1.Write(strWriteReSet)
                strReadM1900 = SerialPort1.ReadLine()
            End If

            If RadioMesTest.Checked Or RadioMesProduction.Checked Then
                Dim strMesResponse As String
                strMesResponse = mesTestTESTUniCheckOutAsk(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text)
                If strMesResponse = "OK" Then
                    strWriteReSet = Chr(&H2) & "01424M1901" & "15" & Chr(&H3)
                    SerialPort1.Write(strWriteReSet)
                    strReadM1900 = SerialPort1.ReadLine()
                Else
                    'TextBox1.Text = "這個條碼不在此工作站"
                    Form2.Show()
                    Form2.Focus()

                    Form2.Label1.Text = "MES錯誤請確認工單、條碼、工作站" & strMesResponse
                End If
            End If
            '正式區
            'If RadioMesProduction.Checked Then
            '    Dim strMesResponse As String
            '    strMesResponse = mesTestTESTUniCheckOutAsk(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text)
            '    If strMesResponse = "OK" Then
            '        strWriteReSet = Chr(&H2) & "01424M1901" & "15" & Chr(&H3)
            '        SerialPort1.Write(strWriteReSet)
            '        strReadM1900 = SerialPort1.ReadLine()
            '    Else
            '        MsgBox("這個條碼不在此工作站") '這裡不用EXIT SUB?
            '    End If
            'End If
        End If
    End Sub
    Private Sub SerialPort2_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim strTemp As String
        strTemp = sp.ReadExisting() '讀到serialporrt的文字'
        ''''''''strTemp = sp.ReadLine()

        '''''''strTemp = sp.ReadExisting()
        strSerialRead = strTemp
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            Dim wmi As Object = GetObject("winmgmts:\\.\root\cimv2")
            Dim devices As Object = wmi.ExecQuery("Select DeviceID, Name from Win32_PnPEntity") '只抓DeviceID和Name
            '測試時抓全部資料要 Select * from Win32_PnPEntity
            Dim strDeviceId As String
            'textboxCOM.Text = "N/A"
            For Each d As Object In devices
                strDeviceId = IIf(IsDBNull(d.DeviceID), "N/A", d.DeviceID)
                If Strings.InStr(strDeviceId, "VID_0C2E&PID_090A") > 0 Then
                    If Strings.InStr(d.Name, "(") > 0 Then
                        Dim rm As MatchCollection
                        rm = Regex.Matches(d.Name, "\b(COM\w+)\b")
                        BarcodeCom.Text = rm(0).Value
                    End If
                End If
            Next
            '2擇一COMPORT無法使用
            'Try
            '    Dim i = 0
            '    For Each sp As String In My.Computer.Ports.SerialPortNames
            '        comport(i) = sp
            '        i = i + 1
            '    Next
            '    If i = 2 Then
            '        i = 0
            '    End If
            '    If comport(0) = BarcodeCom.Text Then
            '        UltrasoundCom.Text = comport(1)
            '    ElseIf comport(1) = BarcodeCom.Text Then
            '        UltrasoundCom.Text = comport(0)
            '    End If
            'Catch ex As Exception

            'End Try
        Catch ex As Exception
            'textboxCOM.Text = "N/A"
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strSerialRead = ComboBox1.Text
    End Sub
    Private Sub RadioNoMes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNoMes.CheckedChanged
        If RadioNoMes.Checked Then
            x = 0
        End If
    End Sub
    Private Sub RadioMesTest_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMesTest.CheckedChanged
        If RadioMesTest.Checked Then 'MES測試區被選擇 x=1 顯示是否開啟NG不上傳
            TestNoNg.Visible = True
            x = 1
        Else
            TestNoNg.Visible = False
            TestNoNg.Checked = False
        End If

    End Sub

    Private Sub RadioMesProduction_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMesProduction.CheckedChanged
        If RadioMesProduction.Checked Then 'MES正式區被選擇 x=1 顯示是否開啟NG不上傳
            ProductionNoNg.Visible = True
            x = 2
        Else
            ProductionNoNg.Visible = False
            ProductionNoNg.Checked = False
        End If

    End Sub
End Class
