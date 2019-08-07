Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim key As Microsoft.Win32.RegistryKey
        'Dim subkey As Microsoft.Win32.RegistryKey
        key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("software\microsoft\windows\currentversion\run")
        If key.GetValue("This is name") Is Nothing Then
            'key.SetValue("This is name", Application.ExecutablePath, "REG_SZ")
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Dim key As Microsoft.Win32.RegistryKey
        key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("software\microsoft\windows\currentversion\run", True)
        If CheckBox1.Checked = True Then
            key.SetValue("This is name", Application.ExecutablePath)
        Else
            key.DeleteValue("This is name", True)
        End If
    End Sub
End Class