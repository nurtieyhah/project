<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployedChart
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1SelectRange = New System.Windows.Forms.ToolStripComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChartEmployed = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BptmsEmployedbystateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployedDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployedDataSet = New Employed_by_State.employedDataSet()
        Me.Bptms_Employed_by_stateTableAdapter = New Employed_by_State.employedDataSetTableAdapters.bptms_Employed_by_stateTableAdapter()
        Me.PanelChartTitle = New System.Windows.Forms.Panel()
        Me.LabelChartTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ChartEmployed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BptmsEmployedbystateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployedDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChartTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.ToolStripComboBox1SelectRange})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 27)
        Me.MenuStrip1.TabIndex = 0
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
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'RestoreDownToolStripMenuItem
        '
        Me.RestoreDownToolStripMenuItem.Name = "RestoreDownToolStripMenuItem"
        Me.RestoreDownToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RestoreDownToolStripMenuItem.Text = "Restore Down"
        '
        'ToolStripComboBox1SelectRange
        '
        Me.ToolStripComboBox1SelectRange.Items.AddRange(New Object() {"2016 (Ascending)"})
        Me.ToolStripComboBox1SelectRange.Name = "ToolStripComboBox1SelectRange"
        Me.ToolStripComboBox1SelectRange.Size = New System.Drawing.Size(150, 23)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ChartEmployed
        '
        Me.ChartEmployed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.ChartEmployed.ChartAreas.Add(ChartArea2)
        Me.ChartEmployed.DataSource = Me.BptmsEmployedbystateBindingSource
        Legend2.Name = "Legend1"
        Me.ChartEmployed.Legends.Add(Legend2)
        Me.ChartEmployed.Location = New System.Drawing.Point(24, 119)
        Me.ChartEmployed.Name = "ChartEmployed"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Employed"
        Me.ChartEmployed.Series.Add(Series2)
        Me.ChartEmployed.Size = New System.Drawing.Size(740, 310)
        Me.ChartEmployed.TabIndex = 2
        Me.ChartEmployed.Text = "Chart1"
        '
        'BptmsEmployedbystateBindingSource
        '
        Me.BptmsEmployedbystateBindingSource.DataMember = "bptms_Employed_by_state"
        Me.BptmsEmployedbystateBindingSource.DataSource = Me.EmployedDataSetBindingSource
        '
        'EmployedDataSetBindingSource
        '
        Me.EmployedDataSetBindingSource.DataSource = Me.EmployedDataSet
        Me.EmployedDataSetBindingSource.Position = 0
        '
        'EmployedDataSet
        '
        Me.EmployedDataSet.DataSetName = "employedDataSet"
        Me.EmployedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bptms_Employed_by_stateTableAdapter
        '
        Me.Bptms_Employed_by_stateTableAdapter.ClearBeforeFill = True
        '
        'PanelChartTitle
        '
        Me.PanelChartTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelChartTitle.Controls.Add(Me.LabelChartTitle)
        Me.PanelChartTitle.Location = New System.Drawing.Point(24, 43)
        Me.PanelChartTitle.Name = "PanelChartTitle"
        Me.PanelChartTitle.Size = New System.Drawing.Size(740, 56)
        Me.PanelChartTitle.TabIndex = 3
        '
        'LabelChartTitle
        '
        Me.LabelChartTitle.AutoSize = True
        Me.LabelChartTitle.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChartTitle.Location = New System.Drawing.Point(266, 15)
        Me.LabelChartTitle.Name = "LabelChartTitle"
        Me.LabelChartTitle.Size = New System.Drawing.Size(251, 27)
        Me.LabelChartTitle.TabIndex = 0
        Me.LabelChartTitle.Text = "EMPLOYED TOTAL"
        '
        'EmployedChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelChartTitle)
        Me.Controls.Add(Me.ChartEmployed)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmployedChart"
        Me.Text = "EmployedChart"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ChartEmployed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BptmsEmployedbystateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployedDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChartTitle.ResumeLayout(False)
        Me.PanelChartTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1SelectRange As ToolStripComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChartEmployed As DataVisualization.Charting.Chart
    Friend WithEvents EmployedDataSetBindingSource As BindingSource
    Friend WithEvents EmployedDataSet As employedDataSet
    Friend WithEvents BptmsEmployedbystateBindingSource As BindingSource
    Friend WithEvents Bptms_Employed_by_stateTableAdapter As employedDataSetTableAdapters.bptms_Employed_by_stateTableAdapter
    Friend WithEvents PanelChartTitle As Panel
    Friend WithEvents LabelChartTitle As Label
    Friend WithEvents RestoreDownToolStripMenuItem As ToolStripMenuItem
End Class
