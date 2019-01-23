Public Class FormList

    Public ListViewItem1 As ListViewItem
    Public EachTextBox As Control
    Public ProductCounter As Integer = 0
    Public CodeLength As String = "000000"

    'Only numbers in TextPrecio
    Private Sub TextPrecio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextPrecio.KeyPress

        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True

        End If

    End Sub

    'ButtonAgregar calls InsertData() and set the focus to TextDescription
    Private Sub ButtonAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAgregar.Click

        InsertData()
        TextDescripcion.Focus()

    End Sub


    'Insert the information into ListView
    Private Sub InsertData()

        ListViewItem1 = New ListViewItem(New String() {TextCodigo.Text, TextDescripcion.Text, TextPrecio.Text}, -1)
        ListProducto.Items.AddRange(New ListViewItem() {ListViewItem1})
        ResetTextBox()

    End Sub

    'Reset all TextBoxs in the form and create a new code
    Private Sub ResetTextBox()

        For Each EachTextBox In Me.Controls
            If TypeOf EachTextBox Is TextBox Then EachTextBox.Text = ""
        Next
        CreateNewCode()

    End Sub
    'Generate a new code after user insert a new register
    Private Sub CreateNewCode()

        ProductCounter += 1
        TextCodigo.Text = String.Concat(CodeLength.Substring(0, CodeLength.Length - ProductCounter.ToString.Length), ProductCounter)

    End Sub

    'Delete a selected row in ListView
    Private Sub ButtonEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonEliminar.Click

        ListProducto.Items.Remove(ListProducto.SelectedItems(0))

    End Sub

    'When the program starts a new code generates 
    Private Sub FormList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateNewCode()

    End Sub
End Class
