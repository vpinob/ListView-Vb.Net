<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormList
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.lblDescripción = New System.Windows.Forms.Label()
        Me.lblPresio = New System.Windows.Forms.Label()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.TextPrecio = New System.Windows.Forms.TextBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ListProducto = New System.Windows.Forms.ListView()
        Me.colCódigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescript = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbCodigo
        '
        Me.lbCodigo.Location = New System.Drawing.Point(10, 20)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(70, 20)
        Me.lbCodigo.TabIndex = 0
        Me.lbCodigo.Text = "Código"
        Me.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripción
        '
        Me.lblDescripción.Location = New System.Drawing.Point(10, 50)
        Me.lblDescripción.Name = "lblDescripción"
        Me.lblDescripción.Size = New System.Drawing.Size(70, 20)
        Me.lblDescripción.TabIndex = 1
        Me.lblDescripción.Text = "Descripción"
        Me.lblDescripción.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPresio
        '
        Me.lblPresio.Location = New System.Drawing.Point(10, 80)
        Me.lblPresio.Name = "lblPresio"
        Me.lblPresio.Size = New System.Drawing.Size(70, 20)
        Me.lblPresio.TabIndex = 2
        Me.lblPresio.Text = "Precio"
        Me.lblPresio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextCodigo
        '
        Me.TextCodigo.BackColor = System.Drawing.Color.White
        Me.TextCodigo.Location = New System.Drawing.Point(90, 20)
        Me.TextCodigo.MaxLength = 12
        Me.TextCodigo.Multiline = True
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.ReadOnly = True
        Me.TextCodigo.Size = New System.Drawing.Size(240, 25)
        Me.TextCodigo.TabIndex = 3
        Me.TextCodigo.TabStop = False
        Me.TextCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(90, 50)
        Me.TextDescripcion.MaxLength = 30
        Me.TextDescripcion.Multiline = True
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(240, 25)
        Me.TextDescripcion.TabIndex = 0
        '
        'TextPrecio
        '
        Me.TextPrecio.Location = New System.Drawing.Point(90, 80)
        Me.TextPrecio.MaxLength = 12
        Me.TextPrecio.Multiline = True
        Me.TextPrecio.Name = "TextPrecio"
        Me.TextPrecio.Size = New System.Drawing.Size(240, 25)
        Me.TextPrecio.TabIndex = 1
        Me.TextPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(340, 20)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(100, 25)
        Me.ButtonAgregar.TabIndex = 2
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(340, 50)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(100, 25)
        Me.ButtonEliminar.TabIndex = 3
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ListProducto
        '
        Me.ListProducto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCódigo, Me.colDescript, Me.colPrecio})
        Me.ListProducto.FullRowSelect = True
        Me.ListProducto.Location = New System.Drawing.Point(10, 120)
        Me.ListProducto.Name = "ListProducto"
        Me.ListProducto.Size = New System.Drawing.Size(440, 190)
        Me.ListProducto.TabIndex = 8
        Me.ListProducto.UseCompatibleStateImageBehavior = False
        Me.ListProducto.View = System.Windows.Forms.View.Details
        '
        'colCódigo
        '
        Me.colCódigo.Text = "Código"
        Me.colCódigo.Width = 121
        '
        'colDescript
        '
        Me.colDescript.Text = "Descripción"
        Me.colDescript.Width = 146
        '
        'colPrecio
        '
        Me.colPrecio.Text = "Precio"
        Me.colPrecio.Width = 187
        '
        'FormList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 321)
        Me.Controls.Add(Me.ListProducto)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.TextPrecio)
        Me.Controls.Add(Me.TextDescripcion)
        Me.Controls.Add(Me.TextCodigo)
        Me.Controls.Add(Me.lblPresio)
        Me.Controls.Add(Me.lblDescripción)
        Me.Controls.Add(Me.lbCodigo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 360)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 360)
        Me.Name = "FormList"
        Me.Text = "List View "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescripción As System.Windows.Forms.Label
    Friend WithEvents lblPresio As System.Windows.Forms.Label
    Friend WithEvents TextCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TextDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TextPrecio As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAgregar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ListProducto As System.Windows.Forms.ListView
    Public WithEvents colCódigo As System.Windows.Forms.ColumnHeader
    Public WithEvents colDescript As System.Windows.Forms.ColumnHeader
    Public WithEvents colPrecio As System.Windows.Forms.ColumnHeader

End Class
