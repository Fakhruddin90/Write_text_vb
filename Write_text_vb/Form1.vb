Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filename As String = Application.StartupPath & "\test.log"
        Dim sw As StreamWriter = File.AppendText(filename)
        sw.WriteLine(Now() & "" & " sample log file entry")
        sw.Close()
    End Sub
End Class
