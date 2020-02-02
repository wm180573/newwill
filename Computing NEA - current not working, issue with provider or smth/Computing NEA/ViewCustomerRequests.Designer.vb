<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCustomerRequests
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
        Me.CustomerRequestDataGridView = New System.Windows.Forms.DataGridView()
        Me.MongooseGamesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MongooseGamesDataSet = New Computing_NEA.MongooseGamesDataSet()
        Me.BtnMenu = New System.Windows.Forms.Button()
        CType(Me.CustomerRequestDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MongooseGamesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MongooseGamesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Requests received from customers"
        '
        'CustomerRequestDataGridView
        '
        Me.CustomerRequestDataGridView.AllowUserToAddRows = False
        Me.CustomerRequestDataGridView.AllowUserToDeleteRows = False
        Me.CustomerRequestDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CustomerRequestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerRequestDataGridView.Location = New System.Drawing.Point(74, 77)
        Me.CustomerRequestDataGridView.Name = "CustomerRequestDataGridView"
        Me.CustomerRequestDataGridView.ReadOnly = True
        Me.CustomerRequestDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerRequestDataGridView.Size = New System.Drawing.Size(1230, 431)
        Me.CustomerRequestDataGridView.TabIndex = 1
        '
        'MongooseGamesDataSetBindingSource
        '
        Me.MongooseGamesDataSetBindingSource.DataSource = Me.MongooseGamesDataSet
        Me.MongooseGamesDataSetBindingSource.Position = 0
        '
        'MongooseGamesDataSet
        '
        Me.MongooseGamesDataSet.DataSetName = "MongooseGamesDataSet"
        Me.MongooseGamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnMenu
        '
        Me.BtnMenu.Location = New System.Drawing.Point(1326, 476)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(91, 68)
        Me.BtnMenu.TabIndex = 2
        Me.BtnMenu.Text = "Main Menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'ViewCustomerRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1429, 556)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.CustomerRequestDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewCustomerRequests"
        Me.Text = "ViewCustomerRequests"
        CType(Me.CustomerRequestDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MongooseGamesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MongooseGamesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerRequestDataGridView As DataGridView
    Friend WithEvents MongooseGamesDataSetBindingSource As BindingSource
    Friend WithEvents MongooseGamesDataSet As MongooseGamesDataSet
    Friend WithEvents BtnMenu As Button
End Class
