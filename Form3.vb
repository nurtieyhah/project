Public Class EmployedState
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployedDataSet.bptms_Employed_by_state' table. You can move, or remove it, as needed.
        Me.Bptms_Employed_by_stateTableAdapter.Fill(Me.EmployedDataSet.bptms_Employed_by_state)

        LabelChartTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffb90f")
        PanelChartTitle.BackColor = Color.DarkGray

        'setup Employed Chart
        ChartState.ChartAreas(0).AxisX.LabelStyle.Interval = 1

        'axis X 
        ChartState.ChartAreas(0).AxisX.TitleFont = New Font("oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        ChartState.ChartAreas(0).AxisX.Title = "State of Employed"

        'axis Y
        ChartState.ChartAreas(0).AxisY.TitleFont = New Font("Oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        ChartState.ChartAreas(0).AxisY.Title = "Employed Total"

        ChartState.ChartAreas(0).AxisY.TitleForeColor = Color.FromName("DodgerBlue")

        'Hide legend label1
        ChartState.Series("State").IsVisibleInLegend = False

        ' Show number value in bar / column chart
        ChartState.Series("State").IsValueShownAsLabel = True

        ' Value member
        ChartState.Series("State").XValueMember = "State/Country"
        ChartState.Series("State").YValueMembers = "Total"

        ' ChartEmployed.DataSource = Nothing

        'Selected items = KEDAH (Ascending)
        ToolStripComboBox1SelectRange1.SelectedIndex = 0
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RestoreDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDownToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class