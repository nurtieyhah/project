Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployedDataSet.bptms_Employed_by_state' table. You can move, or remove it, as needed.
        Me.Bptms_Employed_by_stateTableAdapter.Fill(Me.EmployedDataSet.bptms_Employed_by_state)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BptmsEmployedbystateBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BptmsEmployedbystateBindingSource.EndEdit()
        Bptms_Employed_by_stateTableAdapter.Update(EmployedDataSet.bptms_Employed_by_state)
        MessageBox.Show(" DATA SAVE ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BptmsEmployedbystateBindingSource.AddNew()
        Bptms_Employed_by_stateTableAdapter.Update(EmployedDataSet.bptms_Employed_by_state)
        MessageBox.Show(" DATA SAVE ")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BptmsEmployedbystateBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BptmsEmployedbystateBindingSource.RemoveCurrent()
        Bptms_Employed_by_stateTableAdapter.Update(EmployedDataSet.bptms_Employed_by_state)
        MessageBox.Show(" DATA SAVE ")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub ButtonEmployedChart_Click(sender As Object, e As EventArgs) Handles ButtonEmployedChart.Click
        Dim f As New EmployedChart()
        f.ShowDialog()
    End Sub

    Private Sub ButtonEmployedChart1_Click(sender As Object, e As EventArgs) Handles ButtonEmployedChart1.Click
        Dim g As New EmployedState()
        g.ShowDialog()
    End Sub

    Private Sub ButtonEmployedChart2_Click(sender As Object, e As EventArgs) Handles ButtonEmployedChart2.Click
        Dim h As New EmployedYear()
        h.ShowDialog()
    End Sub
End Class
