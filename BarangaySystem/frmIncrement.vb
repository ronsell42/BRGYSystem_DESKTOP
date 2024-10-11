Public Class frmIncrement

    Private Sub TblIncrementsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblIncrementsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub

    Private Sub frmIncrement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblPrintIndigency' table. You can move, or remove it, as needed.
        Me.TblPrintIndigencyTableAdapter.Fill(Me.DbBrgySystemDataSet.tblPrintIndigency)
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblIncrements' table. You can move, or remove it, as needed.
        Me.TblIncrementsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblIncrements)
    

    End Sub

    Private Sub TblIncrementsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblIncrementsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub
End Class