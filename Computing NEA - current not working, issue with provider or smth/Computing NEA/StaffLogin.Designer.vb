<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtStaffPassword = New System.Windows.Forms.TextBox()
        Me.BtnStaffLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username:"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(155, 115)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(170, 20)
        Me.TxtUsername.TabIndex = 4
        '
        'TxtStaffPassword
        '
        Me.TxtStaffPassword.Location = New System.Drawing.Point(155, 189)
        Me.TxtStaffPassword.Name = "TxtStaffPassword"
        Me.TxtStaffPassword.Size = New System.Drawing.Size(170, 20)
        Me.TxtStaffPassword.TabIndex = 5
        '
        'BtnStaffLogin
        '
        Me.BtnStaffLogin.Location = New System.Drawing.Point(146, 249)
        Me.BtnStaffLogin.Name = "BtnStaffLogin"
        Me.BtnStaffLogin.Size = New System.Drawing.Size(136, 27)
        Me.BtnStaffLogin.TabIndex = 8
        Me.BtnStaffLogin.Text = "Login"
        Me.BtnStaffLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Staff Login"
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 303)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStaffLogin)
        Me.Controls.Add(Me.TxtStaffPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "StaffLogin"
        Me.Text = "StaffLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtStaffPassword As TextBox
    Friend WithEvents BtnStaffLogin As Button
    Friend WithEvents Label1 As Label
End Class
