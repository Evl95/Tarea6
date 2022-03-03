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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.BtnADis = New System.Windows.Forms.Button()
        Me.BtnBDis = New System.Windows.Forms.Button()
        Me.BtnAAum = New System.Windows.Forms.Button()
        Me.BtnBAum = New System.Windows.Forms.Button()
        Me.BtnClean = New System.Windows.Forms.Button()
        Me.BtnSuma = New System.Windows.Forms.Button()
        Me.BtnResta = New System.Windows.Forms.Button()
        Me.BtnMult = New System.Windows.Forms.Button()
        Me.BtnDiv = New System.Windows.Forms.Button()
        Me.TextoImp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "B"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(247, 62)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(25, 25)
        Me.lblA.TabIndex = 3
        Me.lblA.Text = "0"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(247, 122)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(25, 25)
        Me.lblB.TabIndex = 2
        Me.lblB.Text = "0"
        '
        'BtnADis
        '
        Me.BtnADis.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnADis.Location = New System.Drawing.Point(155, 54)
        Me.BtnADis.Name = "BtnADis"
        Me.BtnADis.Size = New System.Drawing.Size(53, 47)
        Me.BtnADis.TabIndex = 4
        Me.BtnADis.Text = "-"
        Me.BtnADis.UseVisualStyleBackColor = True
        '
        'BtnBDis
        '
        Me.BtnBDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBDis.Location = New System.Drawing.Point(155, 114)
        Me.BtnBDis.Name = "BtnBDis"
        Me.BtnBDis.Size = New System.Drawing.Size(53, 47)
        Me.BtnBDis.TabIndex = 5
        Me.BtnBDis.Text = "-"
        Me.BtnBDis.UseVisualStyleBackColor = True
        '
        'BtnAAum
        '
        Me.BtnAAum.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAAum.Location = New System.Drawing.Point(314, 54)
        Me.BtnAAum.Name = "BtnAAum"
        Me.BtnAAum.Size = New System.Drawing.Size(53, 47)
        Me.BtnAAum.TabIndex = 6
        Me.BtnAAum.Text = "+"
        Me.BtnAAum.UseVisualStyleBackColor = True
        '
        'BtnBAum
        '
        Me.BtnBAum.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBAum.Location = New System.Drawing.Point(314, 114)
        Me.BtnBAum.Name = "BtnBAum"
        Me.BtnBAum.Size = New System.Drawing.Size(53, 47)
        Me.BtnBAum.TabIndex = 7
        Me.BtnBAum.Text = "+"
        Me.BtnBAum.UseVisualStyleBackColor = True
        '
        'BtnClean
        '
        Me.BtnClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClean.Location = New System.Drawing.Point(208, 167)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(97, 29)
        Me.BtnClean.TabIndex = 8
        Me.BtnClean.Text = "Limpiar"
        Me.BtnClean.UseVisualStyleBackColor = True
        '
        'BtnSuma
        '
        Me.BtnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuma.Location = New System.Drawing.Point(404, 54)
        Me.BtnSuma.Name = "BtnSuma"
        Me.BtnSuma.Size = New System.Drawing.Size(120, 23)
        Me.BtnSuma.TabIndex = 9
        Me.BtnSuma.Text = "Suma"
        Me.BtnSuma.UseVisualStyleBackColor = True
        '
        'BtnResta
        '
        Me.BtnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResta.Location = New System.Drawing.Point(404, 99)
        Me.BtnResta.Name = "BtnResta"
        Me.BtnResta.Size = New System.Drawing.Size(120, 23)
        Me.BtnResta.TabIndex = 10
        Me.BtnResta.Text = "Resta"
        Me.BtnResta.UseVisualStyleBackColor = True
        '
        'BtnMult
        '
        Me.BtnMult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMult.Location = New System.Drawing.Point(404, 149)
        Me.BtnMult.Name = "BtnMult"
        Me.BtnMult.Size = New System.Drawing.Size(120, 26)
        Me.BtnMult.TabIndex = 11
        Me.BtnMult.Text = "Multiplicación"
        Me.BtnMult.UseVisualStyleBackColor = True
        '
        'BtnDiv
        '
        Me.BtnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDiv.Location = New System.Drawing.Point(404, 201)
        Me.BtnDiv.Name = "BtnDiv"
        Me.BtnDiv.Size = New System.Drawing.Size(120, 23)
        Me.BtnDiv.TabIndex = 12
        Me.BtnDiv.Text = "División"
        Me.BtnDiv.UseVisualStyleBackColor = True
        '
        'TextoImp
        '
        Me.TextoImp.AutoSize = True
        Me.TextoImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoImp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TextoImp.Location = New System.Drawing.Point(12, 238)
        Me.TextoImp.Name = "TextoImp"
        Me.TextoImp.Size = New System.Drawing.Size(384, 29)
        Me.TextoImp.TabIndex = 13
        Me.TextoImp.Text = "El resultado de la operación es:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Erick Majus 201602858"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 406)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextoImp)
        Me.Controls.Add(Me.BtnDiv)
        Me.Controls.Add(Me.BtnMult)
        Me.Controls.Add(Me.BtnResta)
        Me.Controls.Add(Me.BtnSuma)
        Me.Controls.Add(Me.BtnClean)
        Me.Controls.Add(Me.BtnBAum)
        Me.Controls.Add(Me.BtnAAum)
        Me.Controls.Add(Me.BtnBDis)
        Me.Controls.Add(Me.BtnADis)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents BtnADis As Button
    Friend WithEvents BtnBDis As Button
    Friend WithEvents BtnAAum As Button
    Friend WithEvents BtnBAum As Button
    Friend WithEvents BtnClean As Button
    Friend WithEvents BtnSuma As Button
    Friend WithEvents BtnResta As Button
    Friend WithEvents BtnMult As Button
    Friend WithEvents BtnDiv As Button
    Friend WithEvents TextoImp As Label
    Friend WithEvents Label3 As Label
End Class
