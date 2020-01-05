<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployedState
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartState = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BptmsEmployedbystateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployedDataSet = New Employed_by_State.employedDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1SelectRange1 = New System.Windows.Forms.ToolStripComboBox()
        Me.PanelChartTitle = New System.Windows.Forms.Panel()
        Me.LabelChartTitle = New System.Windows.Forms.Label()
        Me.Bptms_Employed_by_stateTableAdapter = New Employed_by_State.employedDataSetTableAdapters.bptms_Employed_by_stateTableAdapter()
        CType(Me.ChartState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BptmsEmployedbystateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelChartTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartState
        '
        Me.ChartState.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.ChartState.ChartAreas.Add(ChartArea1)
        Me.ChartState.DataSource = Me.BptmsEmployedbystateBindingSource
        Legend1.Name = "Legend1"
        Me.ChartState.Legends.Add(Legend1)
        Me.ChartState.Location = New System.Drawing.Point(68, 138)
        Me.ChartState.Name = "ChartState"
        Series1.ChartArea = "ChartArea1"
        Series1.LabelForeColor = System.Drawing.Color.Gray
        Series1.Legend = "Legend1"
        Series1.Name = "State"
        Me.ChartState.Series.Add(Series1)
        Me.ChartState.Size = New System.Drawing.Size(664, 300)
        Me.ChartState.TabIndex = 0
        Me.ChartState.Text = "Chart1"
        '
        'BptmsEmployedbystateBindingSource
        '
        Me.BptmsEmployedbystateBindingSource.DataMember = "bptms_Employed_by_state"
        Me.BptmsEmployedbystateBindingSource.DataSource = Me.EmployedDataSet
        '
        'EmployedDataSet
        '
        Me.EmployedDataSet.DataSetName = "employedDataSet"
        Me.EmployedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.ToolStripComboBox1SelectRange1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizeToolStripMenuItem, Me.RestoreDownToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'RestoreDownToolStripMenuItem
        '
        Me.RestoreDownToolStripMenuItem.Name = "RestoreDownToolStripMenuItem"
        Me.RestoreDownToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestoreDownToolStripMenuItem.Text = "Restore Down"
        '
        'ToolStripComboBox1SelectRange1
        '
        Me.ToolStripComboBox1SelectRange1.Items.AddRange(New Object() {"KEDAH (Ascending)", "KELANTAN (Descending)", "PAHANG (Decending)", "PERLIS (Descending)", "PERAK (Descending)", "PULAU PINANG (Descending)", "W.P.KUALA LMPUR (Descending)", "W.P PUTRAJAYA (Descending)", "W.P.LABUAN (Descending)", "JOHOR (Descending)", "MELAKA (Descending)", "NEGERI SEMBILAN (Descending)", "SABAH (Descending)", "SARAWAK (Descending)", "SELANGOR (Descending)", "TERENGGANU (Descending)"})
        Me.ToolStripComboBox1SelectRange1.Name = "ToolStripComboBox1SelectRange1"
        Me.ToolStripComboBox1SelectRange1.Size = New System.Drawing.Size(121, 23)
        '
        'PanelChartTitle
        '
        Me.PanelChartTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelChartTitle.Controls.Add(Me.LabelChartTitle)
        Me.PanelChartTitle.Location = New System.Drawing.Point(68, 50)
        Me.PanelChartTitle.Name = "PanelChartTitle"
        Me.PanelChartTitle.Size = New System.Drawing.Size(664, 52)
        Me.PanelChartTitle.TabIndex = 2
        '
        'LabelChartTitle
        '
        Me.LabelChartTitle.AutoSize = True
        Me.LabelChartTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelChartTitle.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChartTitle.ForeColor = System.Drawing.Color.White
        Me.LabelChartTitle.Location = New System.Drawing.Point(223, 18)
        Me.LabelChartTitle.Name = "LabelChartTitle"
        Me.LabelChartTitle.Size = New System.Drawing.Size(229, 24)
        Me.LabelChartTitle.TabIndex = 0
        Me.LabelChartTitle.Text = "EMPLOYED STATE"
        '
        'Bptms_Employed_by_stateTableAdapter
        '
        Me.Bptms_Employed_by_stateTableAdapter.ClearBeforeFill = True
        '
        'EmployedState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelChartTitle)
        Me.Controls.Add(Me.ChartState)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmployedState"
        Me.Text = "EmployedState"
        CType(Me.ChartState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BptmsEmployedbystateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelChartTitle.ResumeLayout(False)
        Me.PanelChartTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChartState As DataVisualization.Charting.Chart
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1SelectRange1 As ToolStripComboBox
    Friend WithEvents PanelChartTitle As Panel
    Friend WithEvents LabelChartTitle As Label
    Friend WithEvents EmployedDataSet As employedDataSet
    Friend WithEvents BptmsEmployedbystateBindingSource As BindingSource
    Friend WithEvents Bptms_Employed_by_stateTableAdapter As employedDataSetTableAdapters.bptms_Employed_by_stateTableAdapter
End Class
