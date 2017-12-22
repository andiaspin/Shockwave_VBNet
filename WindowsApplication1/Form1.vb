Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxShockwaveFlash1.Movie = Application.StartupPath & "\flash\well.swf"
        AxShockwaveFlash2.Movie = Application.StartupPath & "\flash\DILARANG.swf"
    End Sub
End Class
