<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddGame = New System.Windows.Forms.Button()
        Me.BtnSearchGame = New System.Windows.Forms.Button()
        Me.BtnRecentGames = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnViewDetails = New System.Windows.Forms.Button()
        Me.BtnUpdateDetails = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnResell = New System.Windows.Forms.Button()
        Me.BtnQuotaCalc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSuitCheck = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnInform = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mongoose Games system for staff"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Game transactions:"
        '
        'BtnAddGame
        '
        Me.BtnAddGame.Location = New System.Drawing.Point(43, 70)
        Me.BtnAddGame.Name = "BtnAddGame"
        Me.BtnAddGame.Size = New System.Drawing.Size(140, 40)
        Me.BtnAddGame.TabIndex = 4
        Me.BtnAddGame.Text = "Add/remove game to/from system"
        Me.BtnAddGame.UseVisualStyleBackColor = True
        '
        'BtnSearchGame
        '
        Me.BtnSearchGame.Location = New System.Drawing.Point(44, 174)
        Me.BtnSearchGame.Name = "BtnSearchGame"
        Me.BtnSearchGame.Size = New System.Drawing.Size(140, 40)
        Me.BtnSearchGame.TabIndex = 5
        Me.BtnSearchGame.Text = "View and search all available games"
        Me.BtnSearchGame.UseVisualStyleBackColor = True
        '
        'BtnRecentGames
        '
        Me.BtnRecentGames.Location = New System.Drawing.Point(44, 220)
        Me.BtnRecentGames.Name = "BtnRecentGames"
        Me.BtnRecentGames.Size = New System.Drawing.Size(140, 48)
        Me.BtnRecentGames.TabIndex = 7
        Me.BtnRecentGames.Text = "View games recently sold/bought to/from customers"
        Me.BtnRecentGames.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Customer data:"
        '
        'BtnViewDetails
        '
        Me.BtnViewDetails.Location = New System.Drawing.Point(208, 70)
        Me.BtnViewDetails.Name = "BtnViewDetails"
        Me.BtnViewDetails.Size = New System.Drawing.Size(140, 29)
        Me.BtnViewDetails.TabIndex = 9
        Me.BtnViewDetails.Text = "View customer details"
        Me.BtnViewDetails.UseVisualStyleBackColor = True
        '
        'BtnUpdateDetails
        '
        Me.BtnUpdateDetails.Location = New System.Drawing.Point(208, 105)
        Me.BtnUpdateDetails.Name = "BtnUpdateDetails"
        Me.BtnUpdateDetails.Size = New System.Drawing.Size(140, 26)
        Me.BtnUpdateDetails.TabIndex = 10
        Me.BtnUpdateDetails.Text = "Update customer details"
        Me.BtnUpdateDetails.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Other:"
        '
        'BtnResell
        '
        Me.BtnResell.Location = New System.Drawing.Point(43, 313)
        Me.BtnResell.Name = "BtnResell"
        Me.BtnResell.Size = New System.Drawing.Size(140, 28)
        Me.BtnResell.TabIndex = 12
        Me.BtnResell.Text = "Resell price calculator"
        Me.BtnResell.UseVisualStyleBackColor = True
        '
        'BtnQuotaCalc
        '
        Me.BtnQuotaCalc.Location = New System.Drawing.Point(43, 343)
        Me.BtnQuotaCalc.Name = "BtnQuotaCalc"
        Me.BtnQuotaCalc.Size = New System.Drawing.Size(140, 27)
        Me.BtnQuotaCalc.TabIndex = 13
        Me.BtnQuotaCalc.Text = "Buying price calculator"
        Me.BtnQuotaCalc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Game information:"
        '
        'BtnSuitCheck
        '
        Me.BtnSuitCheck.Location = New System.Drawing.Point(43, 116)
        Me.BtnSuitCheck.Name = "BtnSuitCheck"
        Me.BtnSuitCheck.Size = New System.Drawing.Size(140, 26)
        Me.BtnSuitCheck.TabIndex = 16
        Me.BtnSuitCheck.Text = "Game suitability checker"
        Me.ToolTip1.SetToolTip(Me.BtnSuitCheck, "Checks if game is suitable to be bought from a customer")
        Me.BtnSuitCheck.UseVisualStyleBackColor = True
        '
        'BtnInform
        '
        Me.BtnInform.Location = New System.Drawing.Point(217, 174)
        Me.BtnInform.Name = "BtnInform"
        Me.BtnInform.Size = New System.Drawing.Size(140, 40)
        Me.BtnInform.TabIndex = 21
        Me.BtnInform.Text = "Inform customer of advancement on request"
        Me.ToolTip1.SetToolTip(Me.BtnInform, "Let the customer know of the next steps of action / what you've done in response " &
        "to their request")
        Me.BtnInform.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Customer communications:"
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(361, 338)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(69, 32)
        Me.BtnLogout.TabIndex = 22
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 40)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "View customer requests"
        Me.ToolTip1.SetToolTip(Me.Button1, "Let the customer know that a game they have added onto their wishlist is now in s" &
        "tock")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnInform)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnSuitCheck)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnQuotaCalc)
        Me.Controls.Add(Me.BtnResell)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnUpdateDetails)
        Me.Controls.Add(Me.BtnViewDetails)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRecentGames)
        Me.Controls.Add(Me.BtnSearchGame)
        Me.Controls.Add(Me.BtnAddGame)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffMenu"
        Me.Text = "StaffMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAddGame As Button
    Friend WithEvents BtnSearchGame As Button
    Friend WithEvents BtnRecentGames As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnViewDetails As Button
    Friend WithEvents BtnUpdateDetails As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnResell As Button
    Friend WithEvents BtnQuotaCalc As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSuitCheck As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnInform As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Button1 As Button
End Class
