Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    ' This file controls the behaviour of the application.
    Partial Class MyApplication

        Public Sub New()
            MyBase.New(AuthenticationMode.Windows)
            IsSingleInstance = False
            EnableVisualStyles = True
            SaveMySettingsOnExit = True
            ShutdownStyle = ShutdownMode.AfterMainFormCloses
        End Sub

        Protected Overrides Sub OnCreateMainForm()
            MainForm = Forms.MainForm
        End Sub

    End Class

End Namespace