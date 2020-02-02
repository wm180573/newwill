<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRecentGames
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
        Me.BtnView = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MongooseGamesDataSet = New Computing_NEA.MongooseGamesDataSet()
        Me.MongooseGamesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lstBoxRecent = New System.Windows.Forms.ListBox()
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.MongooseGamesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MongooseGamesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(504, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View all games recently transferred in and out of the system"
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(502, 302)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(140, 51)
        Me.BtnView.TabIndex = 1
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(531, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Developer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(421, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Genre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(332, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(208, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "GameID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Game Title:"
        '
        'MongooseGamesDataSet
        '
        Me.MongooseGamesDataSet.DataSetName = "MongooseGamesDataSet"
        Me.MongooseGamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MongooseGamesDataSetBindingSource
        '
        Me.MongooseGamesDataSetBindingSource.DataSource = Me.MongooseGamesDataSet
        Me.MongooseGamesDataSetBindingSource.Position = 0
        '
        'lstBoxRecent
        '
        Me.lstBoxRecent.FormattingEnabled = True
        Me.lstBoxRecent.Location = New System.Drawing.Point(81, 171)
        Me.lstBoxRecent.Name = "lstBoxRecent"
        Me.lstBoxRecent.Size = New System.Drawing.Size(373, 173)
        Me.lstBoxRecent.TabIndex = 22
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Location = New System.Drawing.Point(502, 228)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(140, 56)
        Me.BtnMainMenu.TabIndex = 23
        Me.BtnMainMenu.Text = "Return to main menu"
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(247, 146)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 24
        '
        'ViewRecentGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 365)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Controls.Add(Me.lstBoxRecent)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewRecentGames"
        Me.Text = "ViewRecentGames"
        CType(Me.MongooseGamesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MongooseGamesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnView As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MongooseGamesDataSetBindingSource As BindingSource
    Friend WithEvents MongooseGamesDataSet As MongooseGamesDataSet
    Friend WithEvents lstBoxRecent As ListBox
    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents TextBox1 As TextBox
End Class
