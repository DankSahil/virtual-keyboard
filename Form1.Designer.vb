Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Channels

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnSpaceBar = New System.Windows.Forms.Button()
        Me.btnTab = New System.Windows.Forms.Button()
        Me.btnCapsLk = New System.Windows.Forms.Button()
        Me.btnShiftL = New System.Windows.Forms.Button()
        Me.btnCTRLL = New System.Windows.Forms.Button()
        Me.btnWIN = New System.Windows.Forms.Button()
        Me.btnALTL = New System.Windows.Forms.Button()
        Me.btnALTR = New System.Windows.Forms.Button()
        Me.btnFN = New System.Windows.Forms.Button()
        Me.btnMENU = New System.Windows.Forms.Button()
        Me.btn_sqrBrc_bracOpn = New System.Windows.Forms.Button()
        Me.btn_sqrBrc_bracCls = New System.Windows.Forms.Button()
        Me.btn_colans = New System.Windows.Forms.Button()
        Me.btn_quotations = New System.Windows.Forms.Button()
        Me.btn_comma_angularBrcOpn = New System.Windows.Forms.Button()
        Me.btn_period_angularBrcCls = New System.Windows.Forms.Button()
        Me.btn_slash_question = New System.Windows.Forms.Button()
        Me.btn_backWrdSlash_Bar = New System.Windows.Forms.Button()
        Me.btnEnter1 = New System.Windows.Forms.Button()
        Me.btnShiftR = New System.Windows.Forms.Button()
        Me.btnCTRLR = New System.Windows.Forms.Button()
        Me.btn2_at = New System.Windows.Forms.Button()
        Me.btn3_hash = New System.Windows.Forms.Button()
        Me.btn4_dollar = New System.Windows.Forms.Button()
        Me.btn5_perc = New System.Windows.Forms.Button()
        Me.btn6_exp = New System.Windows.Forms.Button()
        Me.btn8_star = New System.Windows.Forms.Button()
        Me.btn9_opnBrc = New System.Windows.Forms.Button()
        Me.btn0_clsBrc = New System.Windows.Forms.Button()
        Me.btn_hyphen_underScore = New System.Windows.Forms.Button()
        Me.btn_equal_plus = New System.Windows.Forms.Button()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.btnPrime_Tild = New System.Windows.Forms.Button()
        Me.btn1_excla = New System.Windows.Forms.Button()
        Me.btn7_amp = New System.Windows.Forms.Button()
        Me.btnF2 = New System.Windows.Forms.Button()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.btnF4 = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.btnF6 = New System.Windows.Forms.Button()
        Me.btnF8 = New System.Windows.Forms.Button()
        Me.btnF9 = New System.Windows.Forms.Button()
        Me.btnF10 = New System.Windows.Forms.Button()
        Me.btnF11 = New System.Windows.Forms.Button()
        Me.btnF12 = New System.Windows.Forms.Button()
        Me.btnESc = New System.Windows.Forms.Button()
        Me.btnF1 = New System.Windows.Forms.Button()
        Me.btnF7 = New System.Windows.Forms.Button()
        Me.btnPtrSc = New System.Windows.Forms.Button()
        Me.btnScrLk = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnNum = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn_decimal_del = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEnter2 = New System.Windows.Forms.Button()
        Me.LightContainer = New System.Windows.Forms.Button()
        Me.btnNumL = New System.Windows.Forms.Button()
        Me.btnCapsL = New System.Windows.Forms.Button()
        Me.btnScrollL = New System.Windows.Forms.Button()
        Me.btnWinL = New System.Windows.Forms.Button()
        Me.btnPageUp = New System.Windows.Forms.Button()
        Me.btnPageDown = New System.Windows.Forms.Button()
        Me.container = New System.Windows.Forms.GroupBox()
        Me.ShowText = New System.Windows.Forms.TextBox()
        Me.container.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStart.Location = New System.Drawing.Point(90, 17)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(225, 50)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Keyboard"
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnQ
        '
        Me.btnQ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnQ.Location = New System.Drawing.Point(96, 116)
        Me.btnQ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(42, 32)
        Me.btnQ.TabIndex = 1
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnW.Location = New System.Drawing.Point(143, 116)
        Me.btnW.Margin = New System.Windows.Forms.Padding(2)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(42, 32)
        Me.btnW.TabIndex = 2
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnE.Location = New System.Drawing.Point(190, 116)
        Me.btnE.Margin = New System.Windows.Forms.Padding(2)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(42, 32)
        Me.btnE.TabIndex = 3
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnR.Location = New System.Drawing.Point(236, 116)
        Me.btnR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(42, 32)
        Me.btnR.TabIndex = 4
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnT.Location = New System.Drawing.Point(282, 116)
        Me.btnT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(42, 32)
        Me.btnT.TabIndex = 5
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnY.Location = New System.Drawing.Point(328, 116)
        Me.btnY.Margin = New System.Windows.Forms.Padding(2)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(42, 32)
        Me.btnY.TabIndex = 6
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnU.Location = New System.Drawing.Point(374, 116)
        Me.btnU.Margin = New System.Windows.Forms.Padding(2)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(42, 32)
        Me.btnU.TabIndex = 7
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnI.Location = New System.Drawing.Point(423, 116)
        Me.btnI.Margin = New System.Windows.Forms.Padding(2)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(42, 32)
        Me.btnI.TabIndex = 8
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnA.Location = New System.Drawing.Point(106, 158)
        Me.btnA.Margin = New System.Windows.Forms.Padding(2)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(41, 32)
        Me.btnA.TabIndex = 9
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnS.Location = New System.Drawing.Point(151, 158)
        Me.btnS.Margin = New System.Windows.Forms.Padding(2)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(41, 32)
        Me.btnS.TabIndex = 10
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnD.Location = New System.Drawing.Point(196, 158)
        Me.btnD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(41, 32)
        Me.btnD.TabIndex = 11
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF.Location = New System.Drawing.Point(241, 158)
        Me.btnF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(41, 32)
        Me.btnF.TabIndex = 12
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnG.Location = New System.Drawing.Point(286, 158)
        Me.btnG.Margin = New System.Windows.Forms.Padding(2)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(41, 32)
        Me.btnG.TabIndex = 13
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnH.Location = New System.Drawing.Point(334, 158)
        Me.btnH.Margin = New System.Windows.Forms.Padding(2)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(41, 32)
        Me.btnH.TabIndex = 14
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnJ.Location = New System.Drawing.Point(383, 158)
        Me.btnJ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(41, 32)
        Me.btnJ.TabIndex = 15
        Me.btnJ.Text = "J" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnK.Location = New System.Drawing.Point(428, 158)
        Me.btnK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(41, 32)
        Me.btnK.TabIndex = 16
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnZ.Location = New System.Drawing.Point(130, 199)
        Me.btnZ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(41, 32)
        Me.btnZ.TabIndex = 17
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnX.Location = New System.Drawing.Point(175, 199)
        Me.btnX.Margin = New System.Windows.Forms.Padding(2)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(41, 32)
        Me.btnX.TabIndex = 18
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnC.Location = New System.Drawing.Point(220, 199)
        Me.btnC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(40, 32)
        Me.btnC.TabIndex = 19
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnV.Location = New System.Drawing.Point(264, 199)
        Me.btnV.Margin = New System.Windows.Forms.Padding(2)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(41, 32)
        Me.btnV.TabIndex = 20
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnB.Location = New System.Drawing.Point(309, 199)
        Me.btnB.Margin = New System.Windows.Forms.Padding(2)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(41, 32)
        Me.btnB.TabIndex = 21
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnN.Location = New System.Drawing.Point(354, 199)
        Me.btnN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(41, 32)
        Me.btnN.TabIndex = 22
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnM.Location = New System.Drawing.Point(400, 199)
        Me.btnM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(41, 32)
        Me.btnM.TabIndex = 23
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnO.Location = New System.Drawing.Point(469, 116)
        Me.btnO.Margin = New System.Windows.Forms.Padding(2)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(42, 32)
        Me.btnO.TabIndex = 33
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnP.Location = New System.Drawing.Point(515, 116)
        Me.btnP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(42, 32)
        Me.btnP.TabIndex = 34
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnL.Location = New System.Drawing.Point(473, 158)
        Me.btnL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(41, 32)
        Me.btnL.TabIndex = 35
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnSpaceBar
        '
        Me.btnSpaceBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSpaceBar.Location = New System.Drawing.Point(205, 241)
        Me.btnSpaceBar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpaceBar.Name = "btnSpaceBar"
        Me.btnSpaceBar.Size = New System.Drawing.Size(272, 35)
        Me.btnSpaceBar.TabIndex = 37
        Me.btnSpaceBar.Text = "_______"
        Me.btnSpaceBar.UseVisualStyleBackColor = True
        '
        'btnTab
        '
        Me.btnTab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTab.Location = New System.Drawing.Point(28, 116)
        Me.btnTab.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTab.Name = "btnTab"
        Me.btnTab.Size = New System.Drawing.Size(57, 32)
        Me.btnTab.TabIndex = 41
        Me.btnTab.Text = "TAB"
        Me.btnTab.UseVisualStyleBackColor = True
        '
        'btnCapsLk
        '
        Me.btnCapsLk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCapsLk.Location = New System.Drawing.Point(28, 158)
        Me.btnCapsLk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCapsLk.Name = "btnCapsLk"
        Me.btnCapsLk.Size = New System.Drawing.Size(69, 32)
        Me.btnCapsLk.TabIndex = 42
        Me.btnCapsLk.Text = "CAPSLK"
        Me.btnCapsLk.UseVisualStyleBackColor = True
        '
        'btnShiftL
        '
        Me.btnShiftL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShiftL.Location = New System.Drawing.Point(28, 199)
        Me.btnShiftL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShiftL.Name = "btnShiftL"
        Me.btnShiftL.Size = New System.Drawing.Size(93, 32)
        Me.btnShiftL.TabIndex = 43
        Me.btnShiftL.Text = "SHIFT"
        Me.btnShiftL.UseVisualStyleBackColor = True
        '
        'btnCTRLL
        '
        Me.btnCTRLL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCTRLL.Location = New System.Drawing.Point(28, 241)
        Me.btnCTRLL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCTRLL.Name = "btnCTRLL"
        Me.btnCTRLL.Size = New System.Drawing.Size(55, 35)
        Me.btnCTRLL.TabIndex = 44
        Me.btnCTRLL.Text = "CTRL"
        Me.btnCTRLL.UseVisualStyleBackColor = True
        '
        'btnWIN
        '
        Me.btnWIN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWIN.Location = New System.Drawing.Point(86, 241)
        Me.btnWIN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWIN.Name = "btnWIN"
        Me.btnWIN.Size = New System.Drawing.Size(55, 35)
        Me.btnWIN.TabIndex = 45
        Me.btnWIN.Text = "WIN"
        Me.btnWIN.UseVisualStyleBackColor = True
        '
        'btnALTL
        '
        Me.btnALTL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnALTL.Location = New System.Drawing.Point(145, 241)
        Me.btnALTL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnALTL.Name = "btnALTL"
        Me.btnALTL.Size = New System.Drawing.Size(55, 35)
        Me.btnALTL.TabIndex = 46
        Me.btnALTL.Text = "ALT"
        Me.btnALTL.UseVisualStyleBackColor = True
        '
        'btnALTR
        '
        Me.btnALTR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnALTR.Location = New System.Drawing.Point(483, 241)
        Me.btnALTR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnALTR.Name = "btnALTR"
        Me.btnALTR.Size = New System.Drawing.Size(55, 35)
        Me.btnALTR.TabIndex = 48
        Me.btnALTR.Text = "ALT"
        Me.btnALTR.UseVisualStyleBackColor = True
        '
        'btnFN
        '
        Me.btnFN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFN.Location = New System.Drawing.Point(543, 241)
        Me.btnFN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFN.Name = "btnFN"
        Me.btnFN.Size = New System.Drawing.Size(55, 35)
        Me.btnFN.TabIndex = 49
        Me.btnFN.Text = "FN"
        Me.btnFN.UseVisualStyleBackColor = True
        '
        'btnMENU
        '
        Me.btnMENU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMENU.Location = New System.Drawing.Point(603, 241)
        Me.btnMENU.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMENU.Name = "btnMENU"
        Me.btnMENU.Size = New System.Drawing.Size(55, 35)
        Me.btnMENU.TabIndex = 50
        Me.btnMENU.Text = "MENU"
        Me.btnMENU.UseVisualStyleBackColor = True
        '
        'btn_sqrBrc_bracOpn
        '
        Me.btn_sqrBrc_bracOpn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_sqrBrc_bracOpn.Location = New System.Drawing.Point(564, 116)
        Me.btn_sqrBrc_bracOpn.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sqrBrc_bracOpn.Name = "btn_sqrBrc_bracOpn"
        Me.btn_sqrBrc_bracOpn.Size = New System.Drawing.Size(42, 32)
        Me.btn_sqrBrc_bracOpn.TabIndex = 51
        Me.btn_sqrBrc_bracOpn.Text = "[  {"
        Me.btn_sqrBrc_bracOpn.UseVisualStyleBackColor = True
        '
        'btn_sqrBrc_bracCls
        '
        Me.btn_sqrBrc_bracCls.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_sqrBrc_bracCls.Location = New System.Drawing.Point(610, 116)
        Me.btn_sqrBrc_bracCls.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sqrBrc_bracCls.Name = "btn_sqrBrc_bracCls"
        Me.btn_sqrBrc_bracCls.Size = New System.Drawing.Size(42, 32)
        Me.btn_sqrBrc_bracCls.TabIndex = 52
        Me.btn_sqrBrc_bracCls.Text = "]  }"
        Me.btn_sqrBrc_bracCls.UseVisualStyleBackColor = True
        '
        'btn_colans
        '
        Me.btn_colans.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_colans.Location = New System.Drawing.Point(520, 158)
        Me.btn_colans.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_colans.Name = "btn_colans"
        Me.btn_colans.Size = New System.Drawing.Size(41, 32)
        Me.btn_colans.TabIndex = 53
        Me.btn_colans.Text = ";  :"
        Me.btn_colans.UseVisualStyleBackColor = True
        '
        'btn_quotations
        '
        Me.btn_quotations.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_quotations.Location = New System.Drawing.Point(565, 158)
        Me.btn_quotations.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_quotations.Name = "btn_quotations"
        Me.btn_quotations.Size = New System.Drawing.Size(41, 32)
        Me.btn_quotations.TabIndex = 54
        Me.btn_quotations.Text = "'  """
        Me.btn_quotations.UseVisualStyleBackColor = True
        '
        'btn_comma_angularBrcOpn
        '
        Me.btn_comma_angularBrcOpn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_comma_angularBrcOpn.Location = New System.Drawing.Point(446, 199)
        Me.btn_comma_angularBrcOpn.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_comma_angularBrcOpn.Name = "btn_comma_angularBrcOpn"
        Me.btn_comma_angularBrcOpn.Size = New System.Drawing.Size(41, 32)
        Me.btn_comma_angularBrcOpn.TabIndex = 55
        Me.btn_comma_angularBrcOpn.Text = ",  <"
        Me.btn_comma_angularBrcOpn.UseVisualStyleBackColor = True
        '
        'btn_period_angularBrcCls
        '
        Me.btn_period_angularBrcCls.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_period_angularBrcCls.Location = New System.Drawing.Point(492, 199)
        Me.btn_period_angularBrcCls.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_period_angularBrcCls.Name = "btn_period_angularBrcCls"
        Me.btn_period_angularBrcCls.Size = New System.Drawing.Size(41, 32)
        Me.btn_period_angularBrcCls.TabIndex = 56
        Me.btn_period_angularBrcCls.Text = ".  >"
        Me.btn_period_angularBrcCls.UseVisualStyleBackColor = True
        '
        'btn_slash_question
        '
        Me.btn_slash_question.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_slash_question.Location = New System.Drawing.Point(539, 199)
        Me.btn_slash_question.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_slash_question.Name = "btn_slash_question"
        Me.btn_slash_question.Size = New System.Drawing.Size(41, 32)
        Me.btn_slash_question.TabIndex = 57
        Me.btn_slash_question.Text = "/  ?"
        Me.btn_slash_question.UseVisualStyleBackColor = True
        '
        'btn_backWrdSlash_Bar
        '
        Me.btn_backWrdSlash_Bar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_backWrdSlash_Bar.Location = New System.Drawing.Point(661, 116)
        Me.btn_backWrdSlash_Bar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_backWrdSlash_Bar.Name = "btn_backWrdSlash_Bar"
        Me.btn_backWrdSlash_Bar.Size = New System.Drawing.Size(57, 32)
        Me.btn_backWrdSlash_Bar.TabIndex = 58
        Me.btn_backWrdSlash_Bar.Text = "\  |"
        Me.btn_backWrdSlash_Bar.UseVisualStyleBackColor = True
        '
        'btnEnter1
        '
        Me.btnEnter1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnter1.Location = New System.Drawing.Point(612, 158)
        Me.btnEnter1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnter1.Name = "btnEnter1"
        Me.btnEnter1.Size = New System.Drawing.Size(106, 32)
        Me.btnEnter1.TabIndex = 59
        Me.btnEnter1.Text = "<-----------::"
        Me.btnEnter1.UseVisualStyleBackColor = True
        '
        'btnShiftR
        '
        Me.btnShiftR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShiftR.Location = New System.Drawing.Point(590, 199)
        Me.btnShiftR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShiftR.Name = "btnShiftR"
        Me.btnShiftR.Size = New System.Drawing.Size(128, 32)
        Me.btnShiftR.TabIndex = 60
        Me.btnShiftR.Text = "SHIFT"
        Me.btnShiftR.UseVisualStyleBackColor = True
        '
        'btnCTRLR
        '
        Me.btnCTRLR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCTRLR.Location = New System.Drawing.Point(663, 241)
        Me.btnCTRLR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCTRLR.Name = "btnCTRLR"
        Me.btnCTRLR.Size = New System.Drawing.Size(55, 35)
        Me.btnCTRLR.TabIndex = 61
        Me.btnCTRLR.Text = "CTRL"
        Me.btnCTRLR.UseVisualStyleBackColor = True
        '
        'btn2_at
        '
        Me.btn2_at.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn2_at.Location = New System.Drawing.Point(123, 78)
        Me.btn2_at.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2_at.Name = "btn2_at"
        Me.btn2_at.Size = New System.Drawing.Size(41, 32)
        Me.btn2_at.TabIndex = 62
        Me.btn2_at.Text = "2  @"
        Me.btn2_at.UseVisualStyleBackColor = True
        '
        'btn3_hash
        '
        Me.btn3_hash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn3_hash.Location = New System.Drawing.Point(167, 78)
        Me.btn3_hash.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3_hash.Name = "btn3_hash"
        Me.btn3_hash.Size = New System.Drawing.Size(41, 32)
        Me.btn3_hash.TabIndex = 63
        Me.btn3_hash.Text = "3  #"
        Me.btn3_hash.UseVisualStyleBackColor = True
        '
        'btn4_dollar
        '
        Me.btn4_dollar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn4_dollar.Location = New System.Drawing.Point(212, 78)
        Me.btn4_dollar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn4_dollar.Name = "btn4_dollar"
        Me.btn4_dollar.Size = New System.Drawing.Size(41, 32)
        Me.btn4_dollar.TabIndex = 64
        Me.btn4_dollar.Text = "4  $"
        Me.btn4_dollar.UseVisualStyleBackColor = True
        '
        'btn5_perc
        '
        Me.btn5_perc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn5_perc.Location = New System.Drawing.Point(257, 78)
        Me.btn5_perc.Margin = New System.Windows.Forms.Padding(2)
        Me.btn5_perc.Name = "btn5_perc"
        Me.btn5_perc.Size = New System.Drawing.Size(41, 32)
        Me.btn5_perc.TabIndex = 65
        Me.btn5_perc.Text = "5  %"
        Me.btn5_perc.UseVisualStyleBackColor = True
        '
        'btn6_exp
        '
        Me.btn6_exp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn6_exp.Location = New System.Drawing.Point(302, 78)
        Me.btn6_exp.Margin = New System.Windows.Forms.Padding(2)
        Me.btn6_exp.Name = "btn6_exp"
        Me.btn6_exp.Size = New System.Drawing.Size(41, 32)
        Me.btn6_exp.TabIndex = 66
        Me.btn6_exp.Text = "6  ^"
        Me.btn6_exp.UseVisualStyleBackColor = True
        '
        'btn8_star
        '
        Me.btn8_star.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn8_star.Location = New System.Drawing.Point(399, 78)
        Me.btn8_star.Margin = New System.Windows.Forms.Padding(2)
        Me.btn8_star.Name = "btn8_star"
        Me.btn8_star.Size = New System.Drawing.Size(41, 32)
        Me.btn8_star.TabIndex = 68
        Me.btn8_star.Text = "8  *"
        Me.btn8_star.UseVisualStyleBackColor = True
        '
        'btn9_opnBrc
        '
        Me.btn9_opnBrc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn9_opnBrc.Location = New System.Drawing.Point(444, 78)
        Me.btn9_opnBrc.Margin = New System.Windows.Forms.Padding(2)
        Me.btn9_opnBrc.Name = "btn9_opnBrc"
        Me.btn9_opnBrc.Size = New System.Drawing.Size(41, 32)
        Me.btn9_opnBrc.TabIndex = 69
        Me.btn9_opnBrc.Text = "9  ("
        Me.btn9_opnBrc.UseVisualStyleBackColor = True
        '
        'btn0_clsBrc
        '
        Me.btn0_clsBrc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn0_clsBrc.Location = New System.Drawing.Point(489, 78)
        Me.btn0_clsBrc.Margin = New System.Windows.Forms.Padding(2)
        Me.btn0_clsBrc.Name = "btn0_clsBrc"
        Me.btn0_clsBrc.Size = New System.Drawing.Size(41, 32)
        Me.btn0_clsBrc.TabIndex = 70
        Me.btn0_clsBrc.Text = "0  )"
        Me.btn0_clsBrc.UseVisualStyleBackColor = True
        '
        'btn_hyphen_underScore
        '
        Me.btn_hyphen_underScore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_hyphen_underScore.Location = New System.Drawing.Point(536, 78)
        Me.btn_hyphen_underScore.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hyphen_underScore.Name = "btn_hyphen_underScore"
        Me.btn_hyphen_underScore.Size = New System.Drawing.Size(41, 32)
        Me.btn_hyphen_underScore.TabIndex = 71
        Me.btn_hyphen_underScore.Text = "-  _"
        Me.btn_hyphen_underScore.UseVisualStyleBackColor = True
        '
        'btn_equal_plus
        '
        Me.btn_equal_plus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_equal_plus.Location = New System.Drawing.Point(581, 78)
        Me.btn_equal_plus.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_equal_plus.Name = "btn_equal_plus"
        Me.btn_equal_plus.Size = New System.Drawing.Size(41, 32)
        Me.btn_equal_plus.TabIndex = 72
        Me.btn_equal_plus.Text = "=  +"
        Me.btn_equal_plus.UseVisualStyleBackColor = True
        '
        'btnBackSpace
        '
        Me.btnBackSpace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBackSpace.Location = New System.Drawing.Point(631, 78)
        Me.btnBackSpace.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(86, 32)
        Me.btnBackSpace.TabIndex = 73
        Me.btnBackSpace.Text = "<-------"
        Me.btnBackSpace.UseVisualStyleBackColor = True
        '
        'btnPrime_Tild
        '
        Me.btnPrime_Tild.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrime_Tild.Location = New System.Drawing.Point(28, 78)
        Me.btnPrime_Tild.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrime_Tild.Name = "btnPrime_Tild"
        Me.btnPrime_Tild.Size = New System.Drawing.Size(41, 32)
        Me.btnPrime_Tild.TabIndex = 74
        Me.btnPrime_Tild.Text = "`  ~"
        Me.btnPrime_Tild.UseVisualStyleBackColor = True
        '
        'btn1_excla
        '
        Me.btn1_excla.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn1_excla.Location = New System.Drawing.Point(76, 78)
        Me.btn1_excla.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1_excla.Name = "btn1_excla"
        Me.btn1_excla.Size = New System.Drawing.Size(41, 32)
        Me.btn1_excla.TabIndex = 75
        Me.btn1_excla.Text = "1  !"
        Me.btn1_excla.UseVisualStyleBackColor = True
        '
        'btn7_amp
        '
        Me.btn7_amp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn7_amp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7_amp.Location = New System.Drawing.Point(350, 78)
        Me.btn7_amp.Margin = New System.Windows.Forms.Padding(2)
        Me.btn7_amp.Name = "btn7_amp"
        Me.btn7_amp.Size = New System.Drawing.Size(44, 32)
        Me.btn7_amp.TabIndex = 76
        Me.btn7_amp.Text = "7amp"
        Me.btn7_amp.UseVisualStyleBackColor = True
        '
        'btnF2
        '
        Me.btnF2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF2.Location = New System.Drawing.Point(171, 31)
        Me.btnF2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(41, 32)
        Me.btnF2.TabIndex = 77
        Me.btnF2.Text = "F2"
        Me.btnF2.UseVisualStyleBackColor = True
        '
        'btnF3
        '
        Me.btnF3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF3.Location = New System.Drawing.Point(215, 31)
        Me.btnF3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(41, 32)
        Me.btnF3.TabIndex = 78
        Me.btnF3.Text = "F3"
        Me.btnF3.UseVisualStyleBackColor = True
        '
        'btnF4
        '
        Me.btnF4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF4.Location = New System.Drawing.Point(260, 31)
        Me.btnF4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(41, 32)
        Me.btnF4.TabIndex = 79
        Me.btnF4.Text = "F4"
        Me.btnF4.UseVisualStyleBackColor = True
        '
        'btnF5
        '
        Me.btnF5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF5.Location = New System.Drawing.Point(329, 31)
        Me.btnF5.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(41, 32)
        Me.btnF5.TabIndex = 80
        Me.btnF5.Text = "F5"
        Me.btnF5.UseVisualStyleBackColor = True
        '
        'btnF6
        '
        Me.btnF6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF6.Location = New System.Drawing.Point(374, 31)
        Me.btnF6.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF6.Name = "btnF6"
        Me.btnF6.Size = New System.Drawing.Size(41, 32)
        Me.btnF6.TabIndex = 81
        Me.btnF6.Text = "F6"
        Me.btnF6.UseVisualStyleBackColor = True
        '
        'btnF8
        '
        Me.btnF8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF8.Location = New System.Drawing.Point(471, 31)
        Me.btnF8.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF8.Name = "btnF8"
        Me.btnF8.Size = New System.Drawing.Size(41, 32)
        Me.btnF8.TabIndex = 82
        Me.btnF8.Text = "F8"
        Me.btnF8.UseVisualStyleBackColor = True
        '
        'btnF9
        '
        Me.btnF9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF9.Location = New System.Drawing.Point(539, 31)
        Me.btnF9.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF9.Name = "btnF9"
        Me.btnF9.Size = New System.Drawing.Size(41, 32)
        Me.btnF9.TabIndex = 83
        Me.btnF9.Text = "F9"
        Me.btnF9.UseVisualStyleBackColor = True
        '
        'btnF10
        '
        Me.btnF10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF10.Location = New System.Drawing.Point(584, 31)
        Me.btnF10.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF10.Name = "btnF10"
        Me.btnF10.Size = New System.Drawing.Size(41, 32)
        Me.btnF10.TabIndex = 84
        Me.btnF10.Text = "F10"
        Me.btnF10.UseVisualStyleBackColor = True
        '
        'btnF11
        '
        Me.btnF11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF11.Location = New System.Drawing.Point(631, 31)
        Me.btnF11.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF11.Name = "btnF11"
        Me.btnF11.Size = New System.Drawing.Size(41, 32)
        Me.btnF11.TabIndex = 85
        Me.btnF11.Text = "F11"
        Me.btnF11.UseVisualStyleBackColor = True
        '
        'btnF12
        '
        Me.btnF12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF12.Location = New System.Drawing.Point(676, 31)
        Me.btnF12.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF12.Name = "btnF12"
        Me.btnF12.Size = New System.Drawing.Size(41, 32)
        Me.btnF12.TabIndex = 86
        Me.btnF12.Text = "F12"
        Me.btnF12.UseVisualStyleBackColor = True
        '
        'btnESc
        '
        Me.btnESc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnESc.Location = New System.Drawing.Point(28, 31)
        Me.btnESc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnESc.Name = "btnESc"
        Me.btnESc.Size = New System.Drawing.Size(41, 32)
        Me.btnESc.TabIndex = 87
        Me.btnESc.Text = "ESc"
        Me.btnESc.UseVisualStyleBackColor = True
        '
        'btnF1
        '
        Me.btnF1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF1.Location = New System.Drawing.Point(124, 31)
        Me.btnF1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF1.Name = "btnF1"
        Me.btnF1.Size = New System.Drawing.Size(41, 32)
        Me.btnF1.TabIndex = 88
        Me.btnF1.Text = "F1"
        Me.btnF1.UseVisualStyleBackColor = True
        '
        'btnF7
        '
        Me.btnF7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnF7.Location = New System.Drawing.Point(422, 31)
        Me.btnF7.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(44, 32)
        Me.btnF7.TabIndex = 89
        Me.btnF7.Text = "F7"
        Me.btnF7.UseVisualStyleBackColor = True
        '
        'btnPtrSc
        '
        Me.btnPtrSc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPtrSc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPtrSc.Location = New System.Drawing.Point(736, 31)
        Me.btnPtrSc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPtrSc.Name = "btnPtrSc"
        Me.btnPtrSc.Size = New System.Drawing.Size(41, 32)
        Me.btnPtrSc.TabIndex = 90
        Me.btnPtrSc.Text = "ptrSc"
        Me.btnPtrSc.UseVisualStyleBackColor = True
        '
        'btnScrLk
        '
        Me.btnScrLk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnScrLk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScrLk.Location = New System.Drawing.Point(781, 31)
        Me.btnScrLk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnScrLk.Name = "btnScrLk"
        Me.btnScrLk.Size = New System.Drawing.Size(41, 32)
        Me.btnScrLk.TabIndex = 91
        Me.btnScrLk.Text = "scrLk"
        Me.btnScrLk.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.Location = New System.Drawing.Point(829, 31)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(44, 32)
        Me.btnPause.TabIndex = 92
        Me.btnPause.Text = "pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(736, 78)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(41, 32)
        Me.btnInsert.TabIndex = 93
        Me.btnInsert.Text = "ins"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(781, 78)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 32)
        Me.btnHome.TabIndex = 94
        Me.btnHome.Text = "home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(736, 116)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(41, 32)
        Me.btnDelete.TabIndex = 96
        Me.btnDelete.Text = "del"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(781, 116)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(41, 32)
        Me.btnEnd.TabIndex = 97
        Me.btnEnd.Text = "end"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLeft.Location = New System.Drawing.Point(736, 242)
        Me.btnLeft.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(41, 32)
        Me.btnLeft.TabIndex = 99
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDown.Location = New System.Drawing.Point(781, 242)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(45, 32)
        Me.btnDown.TabIndex = 100
        Me.btnDown.Text = "down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRight.Location = New System.Drawing.Point(828, 242)
        Me.btnRight.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(41, 32)
        Me.btnRight.TabIndex = 101
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUp.Location = New System.Drawing.Point(781, 199)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(41, 32)
        Me.btnUp.TabIndex = 102
        Me.btnUp.Text = "^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnNum
        '
        Me.btnNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum.Location = New System.Drawing.Point(891, 78)
        Me.btnNum.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNum.Name = "btnNum"
        Me.btnNum.Size = New System.Drawing.Size(41, 32)
        Me.btnNum.TabIndex = 103
        Me.btnNum.Text = "Num"
        Me.btnNum.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDiv.Location = New System.Drawing.Point(936, 78)
        Me.btnDiv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(41, 32)
        Me.btnDiv.TabIndex = 104
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMult.Location = New System.Drawing.Point(983, 78)
        Me.btnMult.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(41, 32)
        Me.btnMult.TabIndex = 105
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn7.Location = New System.Drawing.Point(891, 121)
        Me.btn7.Margin = New System.Windows.Forms.Padding(2)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(41, 32)
        Me.btn7.TabIndex = 106
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn8.Location = New System.Drawing.Point(936, 121)
        Me.btn8.Margin = New System.Windows.Forms.Padding(2)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(41, 32)
        Me.btn8.TabIndex = 107
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn9.Location = New System.Drawing.Point(983, 121)
        Me.btn9.Margin = New System.Windows.Forms.Padding(2)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(41, 32)
        Me.btn9.TabIndex = 108
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn4.Location = New System.Drawing.Point(891, 162)
        Me.btn4.Margin = New System.Windows.Forms.Padding(2)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(41, 32)
        Me.btn4.TabIndex = 109
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn5.Location = New System.Drawing.Point(936, 162)
        Me.btn5.Margin = New System.Windows.Forms.Padding(2)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(41, 32)
        Me.btn5.TabIndex = 110
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn6.Location = New System.Drawing.Point(983, 162)
        Me.btn6.Margin = New System.Windows.Forms.Padding(2)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(41, 32)
        Me.btn6.TabIndex = 111
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn1.Location = New System.Drawing.Point(891, 199)
        Me.btn1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(41, 32)
        Me.btn1.TabIndex = 112
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn2.Location = New System.Drawing.Point(936, 199)
        Me.btn2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(41, 32)
        Me.btn2.TabIndex = 113
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn3.Location = New System.Drawing.Point(983, 199)
        Me.btn3.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(41, 32)
        Me.btn3.TabIndex = 114
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn0.Location = New System.Drawing.Point(891, 241)
        Me.btn0.Margin = New System.Windows.Forms.Padding(2)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(86, 32)
        Me.btn0.TabIndex = 115
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn_decimal_del
        '
        Me.btn_decimal_del.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_decimal_del.Location = New System.Drawing.Point(983, 242)
        Me.btn_decimal_del.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_decimal_del.Name = "btn_decimal_del"
        Me.btn_decimal_del.Size = New System.Drawing.Size(41, 32)
        Me.btn_decimal_del.TabIndex = 117
        Me.btn_decimal_del.Text = ". Del"
        Me.btn_decimal_del.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMinus.Location = New System.Drawing.Point(1033, 78)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(41, 32)
        Me.btnMinus.TabIndex = 118
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.Location = New System.Drawing.Point(1033, 121)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(41, 73)
        Me.btnAdd.TabIndex = 119
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEnter2
        '
        Me.btnEnter2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnter2.Location = New System.Drawing.Point(1033, 200)
        Me.btnEnter2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnter2.Name = "btnEnter2"
        Me.btnEnter2.Size = New System.Drawing.Size(41, 74)
        Me.btnEnter2.TabIndex = 120
        Me.btnEnter2.Text = "<--::"
        Me.btnEnter2.UseVisualStyleBackColor = True
        '
        'LightContainer
        '
        Me.LightContainer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LightContainer.Location = New System.Drawing.Point(887, 30)
        Me.LightContainer.Name = "LightContainer"
        Me.LightContainer.Size = New System.Drawing.Size(186, 37)
        Me.LightContainer.TabIndex = 121
        Me.LightContainer.UseVisualStyleBackColor = True
        '
        'btnNumL
        '
        Me.btnNumL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNumL.Location = New System.Drawing.Point(894, 38)
        Me.btnNumL.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNumL.Name = "btnNumL"
        Me.btnNumL.Size = New System.Drawing.Size(42, 23)
        Me.btnNumL.TabIndex = 122
        Me.btnNumL.Text = "Num"
        Me.btnNumL.UseVisualStyleBackColor = True
        '
        'btnCapsL
        '
        Me.btnCapsL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCapsL.Location = New System.Drawing.Point(937, 38)
        Me.btnCapsL.Name = "btnCapsL"
        Me.btnCapsL.Size = New System.Drawing.Size(44, 23)
        Me.btnCapsL.TabIndex = 123
        Me.btnCapsL.Text = "Caps"
        Me.btnCapsL.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCapsL.UseVisualStyleBackColor = True
        '
        'btnScrollL
        '
        Me.btnScrollL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnScrollL.Location = New System.Drawing.Point(983, 38)
        Me.btnScrollL.Name = "btnScrollL"
        Me.btnScrollL.Size = New System.Drawing.Size(46, 23)
        Me.btnScrollL.TabIndex = 124
        Me.btnScrollL.Text = "Scroll"
        Me.btnScrollL.UseVisualStyleBackColor = True
        '
        'btnWinL
        '
        Me.btnWinL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWinL.Location = New System.Drawing.Point(1031, 38)
        Me.btnWinL.Name = "btnWinL"
        Me.btnWinL.Size = New System.Drawing.Size(37, 23)
        Me.btnWinL.TabIndex = 125
        Me.btnWinL.Text = "Win"
        Me.btnWinL.UseVisualStyleBackColor = True
        '
        'btnPageUp
        '
        Me.btnPageUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPageUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPageUp.Location = New System.Drawing.Point(829, 78)
        Me.btnPageUp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPageUp.Name = "btnPageUp"
        Me.btnPageUp.Size = New System.Drawing.Size(44, 32)
        Me.btnPageUp.TabIndex = 126
        Me.btnPageUp.Text = "pgUp"
        Me.btnPageUp.UseVisualStyleBackColor = True
        '
        'btnPageDown
        '
        Me.btnPageDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPageDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPageDown.Location = New System.Drawing.Point(829, 116)
        Me.btnPageDown.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPageDown.Name = "btnPageDown"
        Me.btnPageDown.Size = New System.Drawing.Size(44, 32)
        Me.btnPageDown.TabIndex = 127
        Me.btnPageDown.Text = "pgDn"
        Me.btnPageDown.UseVisualStyleBackColor = True
        '
        'container
        '
        Me.container.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.container.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.container.Controls.Add(Me.btnPageDown)
        Me.container.Controls.Add(Me.btnPageUp)
        Me.container.Controls.Add(Me.btnWinL)
        Me.container.Controls.Add(Me.btnScrollL)
        Me.container.Controls.Add(Me.btnCapsL)
        Me.container.Controls.Add(Me.btnNumL)
        Me.container.Controls.Add(Me.LightContainer)
        Me.container.Controls.Add(Me.btnEnter2)
        Me.container.Controls.Add(Me.btnAdd)
        Me.container.Controls.Add(Me.btnMinus)
        Me.container.Controls.Add(Me.btn_decimal_del)
        Me.container.Controls.Add(Me.btn0)
        Me.container.Controls.Add(Me.btn3)
        Me.container.Controls.Add(Me.btn2)
        Me.container.Controls.Add(Me.btn1)
        Me.container.Controls.Add(Me.btn6)
        Me.container.Controls.Add(Me.btn5)
        Me.container.Controls.Add(Me.btn4)
        Me.container.Controls.Add(Me.btn9)
        Me.container.Controls.Add(Me.btn8)
        Me.container.Controls.Add(Me.btn7)
        Me.container.Controls.Add(Me.btnMult)
        Me.container.Controls.Add(Me.btnDiv)
        Me.container.Controls.Add(Me.btnNum)
        Me.container.Controls.Add(Me.btnUp)
        Me.container.Controls.Add(Me.btnRight)
        Me.container.Controls.Add(Me.btnDown)
        Me.container.Controls.Add(Me.btnLeft)
        Me.container.Controls.Add(Me.btnEnd)
        Me.container.Controls.Add(Me.btnDelete)
        Me.container.Controls.Add(Me.btnHome)
        Me.container.Controls.Add(Me.btnInsert)
        Me.container.Controls.Add(Me.btnPause)
        Me.container.Controls.Add(Me.btnScrLk)
        Me.container.Controls.Add(Me.btnPtrSc)
        Me.container.Controls.Add(Me.btnF7)
        Me.container.Controls.Add(Me.btnF1)
        Me.container.Controls.Add(Me.btnESc)
        Me.container.Controls.Add(Me.btnF12)
        Me.container.Controls.Add(Me.btnF11)
        Me.container.Controls.Add(Me.btnF10)
        Me.container.Controls.Add(Me.btnF9)
        Me.container.Controls.Add(Me.btnF8)
        Me.container.Controls.Add(Me.btnF6)
        Me.container.Controls.Add(Me.btnF5)
        Me.container.Controls.Add(Me.btnF4)
        Me.container.Controls.Add(Me.btnF3)
        Me.container.Controls.Add(Me.btnF2)
        Me.container.Controls.Add(Me.btn7_amp)
        Me.container.Controls.Add(Me.btn1_excla)
        Me.container.Controls.Add(Me.btnPrime_Tild)
        Me.container.Controls.Add(Me.btnBackSpace)
        Me.container.Controls.Add(Me.btn_equal_plus)
        Me.container.Controls.Add(Me.btn_hyphen_underScore)
        Me.container.Controls.Add(Me.btn0_clsBrc)
        Me.container.Controls.Add(Me.btn9_opnBrc)
        Me.container.Controls.Add(Me.btn8_star)
        Me.container.Controls.Add(Me.btn6_exp)
        Me.container.Controls.Add(Me.btn5_perc)
        Me.container.Controls.Add(Me.btn4_dollar)
        Me.container.Controls.Add(Me.btn3_hash)
        Me.container.Controls.Add(Me.btn2_at)
        Me.container.Controls.Add(Me.btnCTRLR)
        Me.container.Controls.Add(Me.btnShiftR)
        Me.container.Controls.Add(Me.btnEnter1)
        Me.container.Controls.Add(Me.btn_backWrdSlash_Bar)
        Me.container.Controls.Add(Me.btn_slash_question)
        Me.container.Controls.Add(Me.btn_period_angularBrcCls)
        Me.container.Controls.Add(Me.btn_comma_angularBrcOpn)
        Me.container.Controls.Add(Me.btn_quotations)
        Me.container.Controls.Add(Me.btn_colans)
        Me.container.Controls.Add(Me.btn_sqrBrc_bracCls)
        Me.container.Controls.Add(Me.btn_sqrBrc_bracOpn)
        Me.container.Controls.Add(Me.btnMENU)
        Me.container.Controls.Add(Me.btnFN)
        Me.container.Controls.Add(Me.btnALTR)
        Me.container.Controls.Add(Me.btnALTL)
        Me.container.Controls.Add(Me.btnWIN)
        Me.container.Controls.Add(Me.btnCTRLL)
        Me.container.Controls.Add(Me.btnShiftL)
        Me.container.Controls.Add(Me.btnCapsLk)
        Me.container.Controls.Add(Me.btnTab)
        Me.container.Controls.Add(Me.btnSpaceBar)
        Me.container.Controls.Add(Me.btnL)
        Me.container.Controls.Add(Me.btnP)
        Me.container.Controls.Add(Me.btnO)
        Me.container.Controls.Add(Me.btnM)
        Me.container.Controls.Add(Me.btnN)
        Me.container.Controls.Add(Me.btnB)
        Me.container.Controls.Add(Me.btnV)
        Me.container.Controls.Add(Me.btnC)
        Me.container.Controls.Add(Me.btnX)
        Me.container.Controls.Add(Me.btnZ)
        Me.container.Controls.Add(Me.btnK)
        Me.container.Controls.Add(Me.btnJ)
        Me.container.Controls.Add(Me.btnH)
        Me.container.Controls.Add(Me.btnG)
        Me.container.Controls.Add(Me.btnF)
        Me.container.Controls.Add(Me.btnD)
        Me.container.Controls.Add(Me.btnS)
        Me.container.Controls.Add(Me.btnA)
        Me.container.Controls.Add(Me.btnI)
        Me.container.Controls.Add(Me.btnU)
        Me.container.Controls.Add(Me.btnY)
        Me.container.Controls.Add(Me.btnT)
        Me.container.Controls.Add(Me.btnR)
        Me.container.Controls.Add(Me.btnE)
        Me.container.Controls.Add(Me.btnW)
        Me.container.Controls.Add(Me.btnQ)
        Me.container.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.container.ForeColor = System.Drawing.SystemColors.ControlText
        Me.container.Location = New System.Drawing.Point(90, 189)
        Me.container.Name = "container"
        Me.container.Size = New System.Drawing.Size(1106, 305)
        Me.container.TabIndex = 129
        Me.container.TabStop = False
        Me.container.Text = "Virtual Keyboard"
        '
        'ShowText
        '
        Me.ShowText.AcceptsReturn = True
        Me.ShowText.AcceptsTab = True
        Me.ShowText.AllowDrop = True
        Me.ShowText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShowText.Font = New System.Drawing.Font("Mongolian Baiti", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowText.Location = New System.Drawing.Point(331, 20)
        Me.ShowText.MaximumSize = New System.Drawing.Size(865, 141)
        Me.ShowText.Multiline = True
        Me.ShowText.Name = "ShowText"
        Me.ShowText.Size = New System.Drawing.Size(865, 47)
        Me.ShowText.TabIndex = 130
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1317, 506)
        Me.Controls.Add(Me.container)
        Me.Controls.Add(Me.ShowText)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Virtual KeyBoard"
        Me.container.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents ShowText As TextBox
    Friend WithEvents btnQ As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnSpaceBar As Button
    Friend WithEvents btnTab As Button
    Friend WithEvents btnCapsLk As Button
    Friend WithEvents btnShiftL As Button
    Friend WithEvents btnCTRLL As Button
    Friend WithEvents btnWIN As Button
    Friend WithEvents btnALTL As Button
    Friend WithEvents btnALTR As Button
    Friend WithEvents btnFN As Button
    Friend WithEvents btnMENU As Button
    Friend WithEvents btn_sqrBrc_bracOpn As Button
    Friend WithEvents btn_sqrBrc_bracCls As Button
    Friend WithEvents btn_colans As Button
    Friend WithEvents btn_quotations As Button
    Friend WithEvents btn_comma_angularBrcOpn As Button
    Friend WithEvents btn_period_angularBrcCls As Button
    Friend WithEvents btn_slash_question As Button
    Friend WithEvents btn_backWrdSlash_Bar As Button
    Friend WithEvents btnEnter1 As Button
    Friend WithEvents btnShiftR As Button
    Friend WithEvents btnCTRLR As Button
    Friend WithEvents btn2_at As Button
    Friend WithEvents btn3_hash As Button
    Friend WithEvents btn4_dollar As Button
    Friend WithEvents btn5_perc As Button
    Friend WithEvents btn6_exp As Button
    Friend WithEvents btn8_star As Button
    Friend WithEvents btn9_opnBrc As Button
    Friend WithEvents btn0_clsBrc As Button
    Friend WithEvents btn_hyphen_underScore As Button
    Friend WithEvents btn_equal_plus As Button
    Friend WithEvents btnBackSpace As Button
    Friend WithEvents btnPrime_Tild As Button
    Friend WithEvents btn1_excla As Button
    Friend WithEvents btn7_amp As Button
    Friend WithEvents btnF2 As Button
    Friend WithEvents btnF3 As Button
    Friend WithEvents btnF4 As Button
    Friend WithEvents btnF5 As Button
    Friend WithEvents btnF6 As Button
    Friend WithEvents btnF8 As Button
    Friend WithEvents btnF9 As Button
    Friend WithEvents btnF10 As Button
    Friend WithEvents btnF11 As Button
    Friend WithEvents btnF12 As Button
    Friend WithEvents btnESc As Button
    Friend WithEvents btnF1 As Button
    Friend WithEvents btnF7 As Button
    Friend WithEvents btnPtrSc As Button
    Friend WithEvents btnScrLk As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnNum As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn_decimal_del As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEnter2 As Button
    Friend WithEvents LightContainer As Button
    Friend WithEvents btnNumL As Button
    Friend WithEvents btnCapsL As Button
    Friend WithEvents btnScrollL As Button
    Friend WithEvents btnWinL As Button
    Friend WithEvents btnPageUp As Button
    Friend WithEvents btnPageDown As Button
    Friend WithEvents container As GroupBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'container.ForeColor = Color.White
        For Each btn As Control In container.Controls
            If TypeOf btn Is Button Then
                btn.ForeColor = Color.Black
            End If
        Next
        ShowText.Cursor = Cursors.Arrow
        ShowText.AutoSize() = True
        ShowText.Multiline = True
        ShowText.WordWrap = True
        ShowText.Enabled = True
        ' Set initial text for the TextBox
        ShowText.Text = "type"
        ShowText.ForeColor = Color.Gray ' Optional: Change color to indicate placeholder

        container.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'MoveCursorToEnd()
        container.ForeColor = Color.White
        ShowText.Cursor = Cursors.Default
        container.Enabled = True

        Try
            ' Set the cursor to WaitCursor while processing
            ShowText.Cursor = Cursors.WaitCursor
            ' Simulate a long-running operation
            System.Threading.Thread.Sleep(1000) ' Replace this with your actual processing logic
        Finally
            ' Reset the cursor back to Default
            ShowText.Cursor = Cursors.Default
        End Try
    End Sub

    ' Declare a boolean variable to track shift state
    Dim isShiftPressed As Boolean = False


    ' click event handler for the Shift button
    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShiftL.Click, btnShiftR.Click
        ' Toggle Shift state on click
        isShiftPressed = Not isShiftPressed

        ' Update the shift button's appearance (optional visual cue)
        If isShiftPressed Then
            btnShiftL.BackColor = Color.LightBlue
            btnShiftR.BackColor = Color.LightBlue ' Change color to indicate Shift is active
        Else
            btnShiftL.BackColor = SystemColors.Control
            btnShiftR.BackColor = SystemColors.Control ' Reset to default color
        End If
    End Sub
    'declare a boolean variable to track CapsLk state
    Dim isCapsLkPressed As Boolean = False
    Private Sub btnCapsLk_Click(sender As Object, e As EventArgs) Handles btnCapsLk.Click
        isCapsLkPressed = Not isCapsLkPressed
        If isCapsLkPressed Then
            btnCapsLk.BackColor = Color.LightBlue
            btnCapsL.BackColor = Color.Blue
            btnCapsL.ForeColor = Color.White
        Else
            btnCapsLk.BackColor = SystemColors.Control
            btnCapsL.BackColor = SystemColors.Control
            btnCapsL.ForeColor = Color.Black
        End If

    End Sub

    'declare a boolean variable to track Num tate
    Dim isNumPressed As Boolean = False
    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        isNumPressed = Not isNumPressed
        If isNumPressed Then
            btnNum.BackColor = Color.LightBlue
            btnNumL.BackColor = Color.Blue
            btnNumL.ForeColor = Color.White
        Else
            btnNum.BackColor = SystemColors.Control
            btnNumL.BackColor = SystemColors.Control
            btnNumL.ForeColor = Color.Black
        End If

    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Dim currentLineIndex As Integer = ShowText.GetLineFromCharIndex(ShowText.SelectionStart)
        Dim previousLineIndex As Integer = currentLineIndex - 1

        ' Check if the previous line exists
        If previousLineIndex >= 0 Then
            ' Get the index of the first character in the previous line
            Dim previousLineStart As Integer = ShowText.GetFirstCharIndexFromLine(previousLineIndex)

            ' Preserve the cursor's position within the current line
            Dim cursorPositionInLine As Integer = ShowText.SelectionStart - ShowText.GetFirstCharIndexFromLine(currentLineIndex)
            Dim previousLineLength As Integer = ShowText.Lines(previousLineIndex).Length

            ' Set the cursor position to the same position in the previous line, or the end of the line if shorter
            ShowText.SelectionStart = previousLineStart + Math.Min(cursorPositionInLine, previousLineLength)
        End If
        ShowText.Focus()
        ShowText.SelectionLength = 0
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        Dim currentLineIndex As Integer = ShowText.GetLineFromCharIndex(ShowText.SelectionStart)
        Dim nextLineIndex As Integer = currentLineIndex + 1

        ' Check if the next line exists
        If nextLineIndex < ShowText.Lines.Length Then
            ' Get the index of the first character in the next line
            Dim nextLineStart As Integer = ShowText.GetFirstCharIndexFromLine(nextLineIndex)

            ' Preserve the cursor's position within the current line
            Dim cursorPositionInLine As Integer = ShowText.SelectionStart - ShowText.GetFirstCharIndexFromLine(currentLineIndex)
            Dim nextLineLength As Integer = ShowText.Lines(nextLineIndex).Length

            ' Set the cursor position to the same position in the next line, or the end of the line if shorter
            ShowText.SelectionStart = nextLineStart + Math.Min(cursorPositionInLine, nextLineLength)
        End If
        ShowText.Focus()
        ShowText.SelectionLength = 0
    End Sub

    ' Helper function to map numbers to their shifted symbols
    Private Function GetShiftedSymbol(key As String) As String
        Select Case key
            Case "1" : Return "!"
            Case "2" : Return "@"
            Case "3" : Return "#"
            Case "4" : Return "$"
            Case "5" : Return "%"
            Case "6" : Return "^"
            Case "7" : Return "&"
            Case "8" : Return "*"
            Case "9" : Return "("
            Case "0" : Return ")"
            Case "-" : Return "_"
            Case "=" : Return "+"
            Case "[" : Return "{"
            Case "]" : Return "}"
            Case "\" : Return "|"
            Case ";" : Return ":"
            Case "'" : Return """"
            Case "," : Return "<"
            Case "." : Return ">"
            Case "/" : Return "?"
            Case "`" : Return "~"
            Case Else : Return key ' If no shift mapping, return the key itself
        End Select
    End Function


    Private Sub Button_click(sender As Object, e As EventArgs) Handles _
    btnESc.Click, btnF1.Click, btnF2.Click, btnF3.Click, btnF4.Click, btnF5.Click, btnF6.Click, btnF7.Click, btnF8.Click, btnF9.Click,
    btnF10.Click, btnF11.Click, btnF12.Click, btnPrime_Tild.Click, btn1_excla.Click, btn2_at.Click, btn3_hash.Click, btn4_dollar.Click,
    btn5_perc.Click, btn6_exp.Click, btn7_amp.Click, btn8_star.Click, btn9_opnBrc.Click, btn0_clsBrc.Click, btn_hyphen_underScore.Click,
    btn_equal_plus.Click, btnTab.Click, btnQ.Click, btnW.Click, btnE.Click, btnR.Click, btnT.Click, btnY.Click,
    btnU.Click, btnI.Click, btnO.Click, btnP.Click, btn_sqrBrc_bracOpn.Click, btn_sqrBrc_bracCls.Click, btn_backWrdSlash_Bar.Click,
    btnCapsLk.Click, btnA.Click, btnS.Click, btnD.Click, btnF.Click, btnG.Click, btnH.Click, btnJ.Click, btnK.Click, btnL.Click,
    btn_colans.Click, btn_quotations.Click, btnEnter1.Click, btnShiftL.Click, btnZ.Click, btnX.Click, btnC.Click, btnV.Click,
    btnB.Click, btnN.Click, btnM.Click, btn_comma_angularBrcOpn.Click, btn_period_angularBrcCls.Click, btn_slash_question.Click,
    btnShiftR.Click, btnCTRLL.Click, btnWIN.Click, btnALTL.Click, btnSpaceBar.Click, btnALTR.Click, btnFN.Click, btnMENU.Click,
    btnCTRLR.Click, btnPtrSc.Click, btnScrLk.Click, btnPause.Click, btnInsert.Click, btnHome.Click, btnPageUp.Click, btnDelete.Click,
    btnEnd.Click, btnPageDown.Click, btnDiv.Click,
    btnMult.Click, btnMinus.Click, btnAdd.Click, btnEnter2.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn4.Click, btn5.Click,
    btn1.Click, btn2.Click, btn3.Click, btn0.Click, btn_decimal_del.Click


        ' Check if the TextBox contains the placeholder text
        If ShowText.Text = "type" Then
            ShowText.Text = "" ' Clear the text
            ShowText.ForeColor = Color.Black ' Change color back to normal (optional)
        End If

        ' Get the button that was clicked
        Dim btn As Button = CType(sender, Button)
        Dim key As String = btn.Text

        Dim cursorposition As Integer = ShowText.SelectionStart
        Select Case key

            Case "<-----------::", "<--::"
                ShowText.Focus()
                cursorposition = ShowText.SelectionStart
                ShowText.SelectionLength = 0
                ShowText.Text = ShowText.Text.Insert(cursorposition, Environment.NewLine)
                AutoResizeTextBox(ShowText)
                ShowText.SelectionStart = cursorposition + Environment.NewLine.Length
            '    ShowText.SelectionLength = 0

            Case "_______"

                ShowText.Text = ShowText.Text.Insert(cursorposition, " ")
                ShowText.SelectionStart = cursorposition + 1
                ShowText.Focus()

            Case "TAB"
                ShowText.Text = ShowText.Text.Insert(cursorposition, "  ")
                ShowText.SelectionStart = cursorposition + 2

            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                ShowText.Focus() ' Set focus to the TextBox
                cursorposition = ShowText.SelectionStart
                ShowText.SelectionLength = 0

                ' Check if num is pressed
                If isNumPressed Then
                    ShowText.Text = ShowText.Text.Insert(cursorposition, key)
                Else
                    ' Insert the number itself if Shift is not pressed
                    'ShowText.Text = ShowText.Text.Insert(cursorposition, "")'
                End If

                ' Update the cursor position after inserting the character
                ShowText.SelectionStart = cursorposition + 1
                cursorposition = ShowText.SelectionStart

            Case "del"

                cursorposition = ShowText.SelectionStart
                Dim selectedLength As Integer = ShowText.SelectionLength

                If selectedLength > 0 Then
                    ' Delete selected text
                    ShowText.Text = ShowText.Text.Remove(cursorposition, selectedLength)
                    ShowText.SelectionStart = cursorposition ' Move cursor to the start of the deletion
                End If

            Case "ESc"
                ShowText.Text = ""

            Case "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"
                Select Case key
                    Case "F4"
                        Me.Close()
                    Case "F5"
                        ShowText.Text = ""
                    Case "F11"
                        Me.WindowState = If(Me.WindowState = FormWindowState.Maximized, FormWindowState.Normal, FormWindowState.Maximized)
                End Select

            Case Else
                If key.Length <= 4 Then
                    ShowText.Focus()
                    cursorposition = ShowText.SelectionStart
                    ShowText.SelectionLength = 0
                    ' Check if the key is a letter
                    If Char.IsLetter(key) Then

                        If isShiftPressed = True Or isCapsLkPressed = True Then
                            ' Send the uppercase letter when Shift is pressed
                            ShowText.Text = ShowText.Text.Insert(cursorposition, key.ToString().ToUpper())
                            'cursorPosition = ShowText.SelectionStart
                        Else
                            ' Send the lowercase letter when Shift is not pressed
                            ShowText.Text = ShowText.Text.Insert(cursorposition, key.ToString().ToLower())

                        End If

                        ShowText.SelectionStart = cursorposition + 1
                        cursorposition = ShowText.SelectionStart
                    Else
                        ' Handle special characters (numbers and symbols)
                        If isShiftPressed = True Then
                            ' Map shifted numbers to symbols (like Shift + 1 -> !)
                            Dim shiftedKey As String = GetShiftedSymbol(key(0))
                            ShowText.Text = ShowText.Text.Insert(cursorposition, shiftedKey)

                        Else
                            ' Send the regular number or symbol
                            ShowText.Text = ShowText.Text.Insert(cursorposition, key(0))
                        End If
                        ShowText.SelectionStart = cursorposition + 1
                        cursorposition = ShowText.SelectionStart
                    End If

                End If
        End Select
        AutoResizeTextBox(ShowText)

        If String.IsNullOrWhiteSpace(ShowText.Text) Then
            ShowText.Text = "type"
            ShowText.ForeColor = Color.Gray ' Change color back to indicate placeholder
            ShowText.SelectionStart = ShowText.Text.Length ' Move the cursor to the end
        End If

    End Sub

    Dim WithEvents backspaceTimer As New Timer()
    Dim isBackspacePressed As Boolean = False
    'Dim cursorPosition As Integer = 0'
    Private Sub InitializeBackspaceTimer()
        backspaceTimer.Interval = 100 ' Adjust interval as needed
    End Sub

    Private Sub btnBackspace_MouseDown(sender As Object, e As EventArgs) Handles btnBackSpace.MouseDown
        Dim cursorposition As Integer = ShowText.SelectionStart
        isBackspacePressed = True
        cursorposition = ShowText.SelectionStart
        PerformBackspace() ' Perform immediate backspace on press
        backspaceTimer.Start() ' Start continuous deletion
    End Sub
    Private Sub btnBackspace_MouseUp(sender As Object, e As EventArgs) Handles btnBackSpace.MouseUp
        isBackspacePressed = False
        backspaceTimer.Stop() ' Stop continuous deletion
    End Sub
    Private Sub backspaceTimer_Tick(sender As Object, e As EventArgs) Handles backspaceTimer.Tick
        If isBackspacePressed Then
            PerformBackspace()

        End If
    End Sub

    Private Sub PerformBackspace()
        Dim cursorposition As Integer = ShowText.SelectionStart
        cursorposition = ShowText.SelectionStart
        Dim selectedLength As Integer = ShowText.SelectionLength

        If selectedLength > 0 Then
            ' Delete selected text
            ShowText.Text = ShowText.Text.Remove(cursorPosition, selectedLength)
            ShowText.SelectionStart = cursorPosition ' Move cursor to the start of the deletion
        Else
            If cursorPosition > 0 Then
                ' Delete one character before the cursor
                ShowText.Text = ShowText.Text.Remove(cursorposition - 1, 1)
                ShowText.SelectionStart = cursorPosition - 1 ' Move cursor back
            End If
        End If
        cursorposition = ShowText.SelectionStart
        ShowText.SelectionLength = 0 ' Ensure no text is selected
        ShowText.Focus()
        ' Optionally, update the size of the TextBox if needed
        AutoResizeTextBox(ShowText)
    End Sub
    Private Sub btnRight_click(sender As Object, e As EventArgs) Handles btnRight.Click
        MoveCursorRight()
    End Sub
    Private Sub btnLeft_click(sender As Object, e As EventArgs) Handles btnLeft.Click
        MoveCursorLeft()
    End Sub
    ' Move cursor one character to the left
    Sub MoveCursorLeft()
        Dim cursorPosition As Integer = ShowText.SelectionStart
        ShowText.Cursor = Cursors.IBeam
        ShowText.Focus()
        ShowText.SelectionStart = cursorPosition
        ShowText.SelectionLength = 0
        If ShowText.SelectionStart > 0 Then
            ShowText.SelectionStart = cursorPosition - 1
            cursorPosition = ShowText.SelectionStart
        End If
        ShowText.SelectionStart = cursorPosition
    End Sub

    ' Move cursor one character to the right
    Private Sub MoveCursorRight()
        Dim cursorPosition As Integer = ShowText.SelectionStart
        ShowText.Focus() ' Set focus to the TextBox
        ShowText.SelectionStart = cursorPosition ' Move the caret to the current position
        ShowText.SelectionLength = 0 ' Ensure no text is selected

        ShowText.Cursor = Cursors.IBeam
        If ShowText.SelectionStart < ShowText.Text.Length Then
            ShowText.SelectionStart = ShowText.SelectionStart + 1
            cursorPosition = ShowText.SelectionStart
        End If
        ShowText.SelectionStart = cursorPosition
    End Sub

    ' Handle the TextChanged event to dynamically resize the TextBox when content changes
    Private Sub ShowText_TextChanged(sender As Object, e As EventArgs)
        ' Auto-resize the TextBox based on its content (both expand and shrink)
        AutoResizeTextBox(ShowText)
    End Sub

    'Function to auto-resize the TextBox based On its content (expand Or shrink)
    Private Sub AutoResizeTextBox(txtBox As TextBox)
        ' Get the number of lines currently in the TextBox
        Dim numLines As Integer = txtBox.GetLineFromCharIndex(txtBox.TextLength) + 1

        ' Set the maximum number of lines the TextBox can have
        Dim maxLines As Integer = 3 ' For example, max 3 lines

        ' Calculate the required height based on the current number of lines
        Dim requiredHeight As Integer = txtBox.Font.Height * numLines

        ' Set the TextBox height to either the required height or the height for maxLines
        txtBox.Height = Math.Min(txtBox.Font.Height * maxLines, requiredHeight)

    End Sub

End Class