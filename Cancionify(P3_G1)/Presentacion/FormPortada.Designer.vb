<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPortada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPortada))
        Me.ALBUMES = New System.Windows.Forms.Button()
        Me.ARTISTAS = New System.Windows.Forms.Button()
        Me.CANCIONES = New System.Windows.Forms.Button()
        Me.USUARIOS = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALBUMES
        '
        Me.ALBUMES.Location = New System.Drawing.Point(35, 153)
        Me.ALBUMES.Name = "ALBUMES"
        Me.ALBUMES.Size = New System.Drawing.Size(200, 80)
        Me.ALBUMES.TabIndex = 0
        Me.ALBUMES.Text = "ALBUMES"
        Me.ALBUMES.UseVisualStyleBackColor = True
        '
        'ARTISTAS
        '
        Me.ARTISTAS.Location = New System.Drawing.Point(565, 153)
        Me.ARTISTAS.Name = "ARTISTAS"
        Me.ARTISTAS.Size = New System.Drawing.Size(200, 80)
        Me.ARTISTAS.TabIndex = 1
        Me.ARTISTAS.Text = "ARTISTAS"
        Me.ARTISTAS.UseVisualStyleBackColor = True
        '
        'CANCIONES
        '
        Me.CANCIONES.Location = New System.Drawing.Point(565, 314)
        Me.CANCIONES.Name = "CANCIONES"
        Me.CANCIONES.Size = New System.Drawing.Size(200, 80)
        Me.CANCIONES.TabIndex = 2
        Me.CANCIONES.Text = "CANCIONES"
        Me.CANCIONES.UseVisualStyleBackColor = True
        '
        'USUARIOS
        '
        Me.USUARIOS.Location = New System.Drawing.Point(35, 314)
        Me.USUARIOS.Name = "USUARIOS"
        Me.USUARIOS.Size = New System.Drawing.Size(200, 80)
        Me.USUARIOS.TabIndex = 3
        Me.USUARIOS.Text = "USUARIOS"
        Me.USUARIOS.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(173, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(447, 93)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FormPortada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.USUARIOS)
        Me.Controls.Add(Me.CANCIONES)
        Me.Controls.Add(Me.ARTISTAS)
        Me.Controls.Add(Me.ALBUMES)
        Me.Name = "FormPortada"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ALBUMES As Button
    Friend WithEvents ARTISTAS As Button
    Friend WithEvents CANCIONES As Button
    Friend WithEvents USUARIOS As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
