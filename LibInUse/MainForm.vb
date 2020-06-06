Imports System.IO

Partial Public Class MainForm

    Public Passphrase As String = ""
    Public Offset As Integer = 20
    Public LockedLabelForeColour As Color = Color.White
    Public LockedLabelBackColour As Color = Color.Black

    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        InitializeComponent()
    End Sub

    Sub SetButtonLocation()
        'X-value is middle of screen
        btnUnlock.Location = New Point(CType((Width / 2) - (btnUnlock.Width / 2), Integer), Offset)
        btnUnlock.Width = 200
        btnUnlock.Height = 28
    End Sub

    Sub SetLockedLabelLocations()
        Dim topLeft As New Point(Offset, Offset)
        Dim topRight As New Point(Width - lblLockedTR.Width - Offset, Offset)
        Dim botLeft As New Point(Offset, Height - lblLockedBL.Height - Offset)
        Dim botRight As New Point(topRight.X, botLeft.Y)

        lblLockedTL.Location = topLeft
        lblLockedTR.Location = topRight
        lblLockedBL.Location = botLeft
        lblLockedBR.Location = botRight
    End Sub

    Sub SetLockedLabelForeColour(value As Color)
        lblLockedTL.ForeColor = value
        lblLockedTR.ForeColor = value
        lblLockedBL.ForeColor = value
        lblLockedBR.ForeColor = value
    End Sub

    Sub SetLockedLabelBackColour(value As Color)
        lblLockedTL.BackColor = value
        lblLockedTR.BackColor = value
        lblLockedBL.BackColor = value
        lblLockedBR.BackColor = value
    End Sub

    Sub SetLockedLabelParent(_parent As Control)
        lblLockedTL.Parent = _parent
        lblLockedTR.Parent = _parent
        lblLockedBL.Parent = _parent
        lblLockedBR.Parent = _parent
    End Sub

    Sub LoadBackdrop()
        If File.Exists("default.png") Then
            picBackdrop.BackgroundImage = Image.FromFile("default.png")
            SetLockedLabelParent(picBackdrop)
            SetLockedLabelBackColour(Color.Transparent)
        End If
    End Sub

    Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'UI setup
        SetButtonLocation()
        SetLockedLabelLocations()
        SetLockedLabelForeColour(LockedLabelForeColour)
        SetLockedLabelBackColour(LockedLabelBackColour)
        LoadBackdrop()

        TopMost = False

        Dim ipt As String = InputBox("Enter a passphrase to lock the screen, or simply click cancel to exit the lock screen.", "Passphrase")

        If ipt = "" Then
            Close()
            Process.GetCurrentProcess.Kill()
        Else
            Dim ipt2 As String = InputBox("Confirm your passphrase to lock the screen, or simply click cancel to exit the lock screen.", "Passphrase")

            If ipt2 = ipt Then
                Passphrase = ipt
            ElseIf ipt2 = "" Then
                Close()
                Process.GetCurrentProcess.Kill()
            Else
                MsgBox("Your passphrase was not applied because the confirmation didn't match the original.", vbCritical, "Validation Error")
                Close()
                Process.GetCurrentProcess.Kill()
            End If
        End If

        TopMost = True

        Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule
        _objKeyboardProcess = New LowLevelKeyboardProc(AddressOf CaptureKey)
        _ptrHook = SetWindowsHookEx(13, _objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0)
    End Sub

    Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click

        TopMost = False

        Dim ipt As String = InputBox("Enter your passphrase to lock the screen, or simply click cancel to keep it locked.", "Passphrase")

        If ipt = Passphrase Then
            Close()
            Process.GetCurrentProcess.Kill()
        Else
            MsgBox("Incorrect passphrase!", vbCritical, "Validation Error")
        End If

        TopMost = True
    End Sub

End Class