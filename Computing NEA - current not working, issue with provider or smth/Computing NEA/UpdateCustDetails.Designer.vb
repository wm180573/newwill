<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCustDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FieldName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewData = New System.Windows.Forms.TextBox()
        Me.BtnUpd = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID:"
        Me.ToolTip1.SetToolTip(Me.Label1, "Please enter the CustomerID that belongs to the customer of which record you wish" &
        " to update")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Update customer details"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(297, 94)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(117, 20)
        Me.txtCustID.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtCustID, "Please enter the CustomerID that belongs to the customer of which record you wish" &
        " to update")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Information to be updated:"
        Me.ToolTip1.SetToolTip(Me.Label3, "Please select which field of the customer you wish to update")
        '
        'FieldName
        '
        Me.FieldName.FormattingEnabled = True
        Me.FieldName.Items.AddRange(New Object() {"FirstName", "Surname", "PhoneNum", "Address", "County", "Town", "Postcode"})
        Me.FieldName.Location = New System.Drawing.Point(297, 129)
        Me.FieldName.Name = "FieldName"
        Me.FieldName.Size = New System.Drawing.Size(117, 21)
        Me.FieldName.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.FieldName, "Please select which field of the customer you wish to update")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "New field data:"
        Me.ToolTip1.SetToolTip(Me.Label4, "Please enter the data you wish to replace of the field selected")
        '
        'txtNewData
        '
        Me.txtNewData.Location = New System.Drawing.Point(297, 167)
        Me.txtNewData.Name = "txtNewData"
        Me.txtNewData.Size = New System.Drawing.Size(117, 20)
        Me.txtNewData.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtNewData, "Please enter the data you wish to replace of the field selected")
        '
        'BtnUpd
        '
        Me.BtnUpd.Location = New System.Drawing.Point(181, 202)
        Me.BtnUpd.Name = "BtnUpd"
        Me.BtnUpd.Size = New System.Drawing.Size(126, 32)
        Me.BtnUpd.TabIndex = 7
        Me.BtnUpd.Text = "Update"
        Me.BtnUpd.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Location = New System.Drawing.Point(407, 216)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(98, 42)
        Me.BtnMenu.TabIndex = 8
        Me.BtnMenu.Text = "Main menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'UpdateCustDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 261)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnUpd)
        Me.Controls.Add(Me.txtNewData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FieldName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateCustDetails"
        Me.Text = "UpdateCustDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FieldName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewData As TextBox
    Friend WithEvents BtnUpd As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
