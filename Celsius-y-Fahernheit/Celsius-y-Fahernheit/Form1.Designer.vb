<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FahrTxt = New System.Windows.Forms.TextBox()
        Me.CelsTxt = New System.Windows.Forms.TextBox()
        Me.CelsBtn = New System.Windows.Forms.Button()
        Me.FahrBtn = New System.Windows.Forms.Button()
        Me.CelsResp = New System.Windows.Forms.Label()
        Me.FahrResp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FahrTxt
        '
        Me.FahrTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FahrTxt.Location = New System.Drawing.Point(33, 142)
        Me.FahrTxt.Multiline = True
        Me.FahrTxt.Name = "FahrTxt"
        Me.FahrTxt.Size = New System.Drawing.Size(126, 38)
        Me.FahrTxt.TabIndex = 0
        '
        'CelsTxt
        '
        Me.CelsTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CelsTxt.Location = New System.Drawing.Point(357, 142)
        Me.CelsTxt.Multiline = True
        Me.CelsTxt.Name = "CelsTxt"
        Me.CelsTxt.Size = New System.Drawing.Size(120, 38)
        Me.CelsTxt.TabIndex = 1
        '
        'CelsBtn
        '
        Me.CelsBtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CelsBtn.Location = New System.Drawing.Point(33, 214)
        Me.CelsBtn.Name = "CelsBtn"
        Me.CelsBtn.Size = New System.Drawing.Size(126, 46)
        Me.CelsBtn.TabIndex = 2
        Me.CelsBtn.Text = "Convertir a Celsius"
        Me.CelsBtn.UseVisualStyleBackColor = False
        '
        'FahrBtn
        '
        Me.FahrBtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.FahrBtn.Location = New System.Drawing.Point(357, 214)
        Me.FahrBtn.Name = "FahrBtn"
        Me.FahrBtn.Size = New System.Drawing.Size(126, 46)
        Me.FahrBtn.TabIndex = 3
        Me.FahrBtn.Text = "Convertir a Fahrenheit"
        Me.FahrBtn.UseVisualStyleBackColor = False
        '
        'CelsResp
        '
        Me.CelsResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CelsResp.Location = New System.Drawing.Point(41, 286)
        Me.CelsResp.Name = "CelsResp"
        Me.CelsResp.Size = New System.Drawing.Size(102, 39)
        Me.CelsResp.TabIndex = 4
        Me.CelsResp.Text = "-                "
        Me.CelsResp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FahrResp
        '
        Me.FahrResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FahrResp.Location = New System.Drawing.Point(368, 286)
        Me.FahrResp.Name = "FahrResp"
        Me.FahrResp.Size = New System.Drawing.Size(109, 39)
        Me.FahrResp.TabIndex = 5
        Me.FahrResp.Text = "-                 "
        Me.FahrResp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fahrenheit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Celsius"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(33, 456)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(92, 45)
        Me.BtnLimpiar.TabIndex = 10
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnSalir.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(376, 456)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(107, 45)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(526, 513)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FahrResp)
        Me.Controls.Add(Me.CelsResp)
        Me.Controls.Add(Me.FahrBtn)
        Me.Controls.Add(Me.CelsBtn)
        Me.Controls.Add(Me.CelsTxt)
        Me.Controls.Add(Me.FahrTxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertidor de temperaturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FahrTxt As TextBox
    Friend WithEvents CelsTxt As TextBox
    Friend WithEvents CelsBtn As Button
    Friend WithEvents FahrBtn As Button
    Friend WithEvents CelsResp As Label
    Friend WithEvents FahrResp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
End Class
