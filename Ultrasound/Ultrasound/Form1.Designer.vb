<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.UltrasoundCom = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.WkStationNam = New System.Windows.Forms.TextBox()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LblNG = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LblPASS = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtOpCode = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.WkorderNum = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.OrderNum = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.modelNam = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblBarCode = New System.Windows.Forms.Label()
        Me.BarcodeCom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioNoMes = New System.Windows.Forms.RadioButton()
        Me.RadioMesTest = New System.Windows.Forms.RadioButton()
        Me.RadioMesProduction = New System.Windows.Forms.RadioButton()
        Me.TestNoNg = New System.Windows.Forms.CheckBox()
        Me.ProductionNoNg = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.DataBits = 7
        Me.SerialPort1.Parity = System.IO.Ports.Parity.Even
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "熔接時間:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 171)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "熔接能量:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 236)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "總數量:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "熔接結果:"
        '
        'BtnConnect
        '
        Me.BtnConnect.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnConnect.Location = New System.Drawing.Point(984, 21)
        Me.BtnConnect.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(91, 76)
        Me.BtnConnect.TabIndex = 116
        Me.BtnConnect.Text = "連線"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'UltrasoundCom
        '
        Me.UltrasoundCom.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.UltrasoundCom.Location = New System.Drawing.Point(236, 41)
        Me.UltrasoundCom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.UltrasoundCom.Name = "UltrasoundCom"
        Me.UltrasoundCom.Size = New System.Drawing.Size(212, 35)
        Me.UltrasoundCom.TabIndex = 118
        Me.UltrasoundCom.Text = "COM5"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label26.Location = New System.Drawing.Point(39, 45)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(177, 24)
        Me.Label26.TabIndex = 117
        Me.Label26.Text = "超音波COM Port"
        '
        'Timer2
        '
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(977, 239)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 408)
        Me.TextBox1.TabIndex = 133
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label40.Location = New System.Drawing.Point(284, 694)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(850, 72)
        Me.Label40.TabIndex = 134
        Me.Label40.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "如果有問題需要協助請找 張老師(分機742) 或 明叡(分機743) 或俊緯(分機744)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'WkStationNam
        '
        Me.WkStationNam.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WkStationNam.Location = New System.Drawing.Point(672, 468)
        Me.WkStationNam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WkStationNam.Name = "WkStationNam"
        Me.WkStationNam.Size = New System.Drawing.Size(223, 35)
        Me.WkStationNam.TabIndex = 152
        Me.WkStationNam.Text = "A-TEST-01(WEB)"
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Quantity.Location = New System.Drawing.Point(417, 468)
        Me.Quantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(213, 35)
        Me.Quantity.TabIndex = 151
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblTotal.Location = New System.Drawing.Point(672, 546)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(223, 34)
        Me.LblTotal.TabIndex = 150
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label37.Location = New System.Drawing.Point(683, 520)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(130, 24)
        Me.Label37.TabIndex = 149
        Me.Label37.Text = "已生產總數"
        '
        'LblNG
        '
        Me.LblNG.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNG.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblNG.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblNG.Location = New System.Drawing.Point(459, 546)
        Me.LblNG.Name = "LblNG"
        Me.LblNG.Size = New System.Drawing.Size(167, 34)
        Me.LblNG.TabIndex = 148
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label35.Location = New System.Drawing.Point(492, 520)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(90, 24)
        Me.Label35.TabIndex = 147
        Me.Label35.Text = "NG總數"
        '
        'LblPASS
        '
        Me.LblPASS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPASS.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblPASS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblPASS.Location = New System.Drawing.Point(249, 546)
        Me.LblPASS.Name = "LblPASS"
        Me.LblPASS.Size = New System.Drawing.Size(166, 34)
        Me.LblPASS.TabIndex = 146
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label33.Location = New System.Drawing.Point(265, 520)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(113, 24)
        Me.Label33.TabIndex = 145
        Me.Label33.Text = "PASS總數"
        '
        'TxtOpCode
        '
        Me.TxtOpCode.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtOpCode.Location = New System.Drawing.Point(33, 546)
        Me.TxtOpCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtOpCode.Name = "TxtOpCode"
        Me.TxtOpCode.Size = New System.Drawing.Size(168, 35)
        Me.TxtOpCode.TabIndex = 144
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label32.Location = New System.Drawing.Point(33, 520)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(130, 24)
        Me.Label32.TabIndex = 143
        Me.Label32.Text = "作業員工號"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label31.Location = New System.Drawing.Point(683, 441)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(130, 24)
        Me.Label31.TabIndex = 142
        Me.Label31.Text = "工作站站名"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label30.Location = New System.Drawing.Point(413, 441)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(226, 24)
        Me.Label30.TabIndex = 141
        Me.Label30.Text = "工單排定的生產數量"
        '
        'WkorderNum
        '
        Me.WkorderNum.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WkorderNum.Location = New System.Drawing.Point(37, 468)
        Me.WkorderNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WkorderNum.Name = "WkorderNum"
        Me.WkorderNum.Size = New System.Drawing.Size(356, 35)
        Me.WkorderNum.TabIndex = 140
        Me.WkorderNum.Text = "JB20200225002"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label29.Location = New System.Drawing.Point(35, 441)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 24)
        Me.Label29.TabIndex = 139
        Me.Label29.Text = "工單號碼"
        '
        'OrderNum
        '
        Me.OrderNum.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OrderNum.Location = New System.Drawing.Point(335, 388)
        Me.OrderNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OrderNum.Name = "OrderNum"
        Me.OrderNum.Size = New System.Drawing.Size(560, 35)
        Me.OrderNum.TabIndex = 138
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label28.Location = New System.Drawing.Point(339, 362)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(106, 24)
        Me.Label28.TabIndex = 137
        Me.Label28.Text = "訂單號碼"
        '
        'modelNam
        '
        Me.modelNam.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.modelNam.Location = New System.Drawing.Point(37, 388)
        Me.modelNam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.modelNam.Name = "modelNam"
        Me.modelNam.Size = New System.Drawing.Size(276, 35)
        Me.modelNam.TabIndex = 136
        Me.modelNam.Text = "9HS3089-2"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label27.Location = New System.Drawing.Point(35, 362)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(106, 24)
        Me.Label27.TabIndex = 135
        Me.Label27.Text = "機種名稱"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label38.Location = New System.Drawing.Point(39, 655)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(160, 24)
        Me.Label38.TabIndex = 155
        Me.Label38.Text = "本次測量時間:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label36.Location = New System.Drawing.Point(35, 622)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(160, 24)
        Me.Label36.TabIndex = 154
        Me.Label36.Text = "上次測量時間:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(641, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "產品條碼"
        '
        'LblBarCode
        '
        Me.LblBarCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBarCode.Font = New System.Drawing.Font("新細明體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblBarCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblBarCode.Location = New System.Drawing.Point(761, 116)
        Me.LblBarCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBarCode.Name = "LblBarCode"
        Me.LblBarCode.Size = New System.Drawing.Size(511, 79)
        Me.LblBarCode.TabIndex = 157
        '
        'BarcodeCom
        '
        Me.BarcodeCom.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BarcodeCom.Location = New System.Drawing.Point(704, 45)
        Me.BarcodeCom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BarcodeCom.Name = "BarcodeCom"
        Me.BarcodeCom.Size = New System.Drawing.Size(212, 35)
        Me.BarcodeCom.TabIndex = 159
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(480, 45)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 24)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "條碼機COM Port"
        '
        'SerialPort2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 3000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(631, 311)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 52)
        Me.Button1.TabIndex = 160
        Me.Button1.Text = "測試"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"015", "A003", "A004", "A007", "A008", "A009", "A010", "A012"})
        Me.ComboBox1.Location = New System.Drawing.Point(720, 326)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 23)
        Me.ComboBox1.TabIndex = 162
        '
        'RadioNoMes
        '
        Me.RadioNoMes.AutoSize = True
        Me.RadioNoMes.Checked = True
        Me.RadioNoMes.Location = New System.Drawing.Point(506, 226)
        Me.RadioNoMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioNoMes.Name = "RadioNoMes"
        Me.RadioNoMes.Size = New System.Drawing.Size(133, 19)
        Me.RadioNoMes.TabIndex = 164
        Me.RadioNoMes.TabStop = True
        Me.RadioNoMes.Text = "我不要MESˋˊ"
        Me.RadioNoMes.UseVisualStyleBackColor = True
        '
        'RadioMesTest
        '
        Me.RadioMesTest.AutoSize = True
        Me.RadioMesTest.Location = New System.Drawing.Point(669, 226)
        Me.RadioMesTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioMesTest.Name = "RadioMesTest"
        Me.RadioMesTest.Size = New System.Drawing.Size(89, 19)
        Me.RadioMesTest.TabIndex = 165
        Me.RadioMesTest.Text = "MES_Test"
        Me.RadioMesTest.UseVisualStyleBackColor = True
        '
        'RadioMesProduction
        '
        Me.RadioMesProduction.AutoSize = True
        Me.RadioMesProduction.Location = New System.Drawing.Point(771, 226)
        Me.RadioMesProduction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioMesProduction.Name = "RadioMesProduction"
        Me.RadioMesProduction.Size = New System.Drawing.Size(127, 19)
        Me.RadioMesProduction.TabIndex = 166
        Me.RadioMesProduction.Text = "MES_Production"
        Me.RadioMesProduction.UseVisualStyleBackColor = True
        '
        'TestNoNg
        '
        Me.TestNoNg.AutoSize = True
        Me.TestNoNg.Location = New System.Drawing.Point(672, 252)
        Me.TestNoNg.Name = "TestNoNg"
        Me.TestNoNg.Size = New System.Drawing.Size(79, 19)
        Me.TestNoNg.TabIndex = 169
        Me.TestNoNg.Text = "NG不上"
        Me.TestNoNg.UseVisualStyleBackColor = True
        '
        'ProductionNoNg
        '
        Me.ProductionNoNg.AutoSize = True
        Me.ProductionNoNg.Location = New System.Drawing.Point(771, 252)
        Me.ProductionNoNg.Name = "ProductionNoNg"
        Me.ProductionNoNg.Size = New System.Drawing.Size(79, 19)
        Me.ProductionNoNg.TabIndex = 171
        Me.ProductionNoNg.Text = "NG不上"
        Me.ProductionNoNg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 799)
        Me.Controls.Add(Me.ProductionNoNg)
        Me.Controls.Add(Me.TestNoNg)
        Me.Controls.Add(Me.RadioMesProduction)
        Me.Controls.Add(Me.RadioMesTest)
        Me.Controls.Add(Me.RadioNoMes)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BarcodeCom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblBarCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.WkStationNam)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.LblNG)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.LblPASS)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TxtOpCode)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.WkorderNum)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.OrderNum)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.modelNam)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UltrasoundCom)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "超音波熔接機"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnConnect As Button
    Friend WithEvents UltrasoundCom As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents WkStationNam As TextBox
    Friend WithEvents Quantity As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents LblNG As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents LblPASS As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtOpCode As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents WkorderNum As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents OrderNum As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents modelNam As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblBarCode As Label
    Friend WithEvents BarcodeCom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioNoMes As RadioButton
    Friend WithEvents RadioMesTest As RadioButton
    Friend WithEvents RadioMesProduction As RadioButton
    Friend WithEvents TestNoNg As CheckBox
    Friend WithEvents ProductionNoNg As CheckBox
End Class
