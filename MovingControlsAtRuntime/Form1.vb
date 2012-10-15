Public Class Form1

    Private dragging As Boolean
    Private beginX As Integer
    Private beginY As Integer

    Private Sub Control_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) ' Handles PictureBox1.MouseDown

        Me.dragging = True
        Me.beginX = e.X
        Me.beginY = e.Y

    End Sub

    Private Sub Control_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) 'Handles PictureBox1.MouseMove

        Dim cntrl As Control = CType(sender, Control)

        If Me.dragging Then
            cntrl.Location = New Point(cntrl.Location.X + e.X - beginX, cntrl.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If

    End Sub

    Private Sub Control_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) 'Handles PictureBox1.MouseUp
        Me.dragging = False
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For Each cntrl As Control In Me.Controls
            AddHandler cntrl.MouseDown, AddressOf Control_MouseDown
            AddHandler cntrl.MouseMove, AddressOf Control_MouseMove
            AddHandler cntrl.MouseUp, AddressOf Control_MouseUp
        Next

    End Sub
End Class
