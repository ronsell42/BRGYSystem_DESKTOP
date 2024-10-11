<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncrement
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
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.TblIncrementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblIncrementsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblIncrementsTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.TblPrintIndigencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPrintIndigencyTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblPrintIndigencyTableAdapter()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncrementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPrintIndigencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbBrgySystemDataSet
        '
        Me.DbBrgySystemDataSet.DataSetName = "dbBrgySystemDataSet"
        Me.DbBrgySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblIncrementsBindingSource
        '
        Me.TblIncrementsBindingSource.DataSource = Me.DbBrgySystemDataSet
        Me.TblIncrementsBindingSource.Position = 0
        '
        'TblIncrementsTableAdapter
        '
        Me.TblIncrementsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBlotterTableAdapter = Nothing
        Me.TableAdapterManager.tblDatabaseTableAdapter = Nothing
        Me.TableAdapterManager.tblHistoryTableAdapter = Nothing
        Me.TableAdapterManager.tblOrganizationTableAdapter = Nothing
        Me.TableAdapterManager.tblPrintIndigencyTableAdapter = Me.TblPrintIndigencyTableAdapter
        Me.TableAdapterManager.tblResidentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPrintIndigencyBindingSource
        '
        Me.TblPrintIndigencyBindingSource.DataMember = "tblPrintIndigency"
        Me.TblPrintIndigencyBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'TblPrintIndigencyTableAdapter
        '
        Me.TblPrintIndigencyTableAdapter.ClearBeforeFill = True
        '
        'frmIncrement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 439)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIncrement"
        Me.Text = "frmIncrement"
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncrementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPrintIndigencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblIncrementsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblIncrementsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblIncrementsTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPrintIndigencyTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblPrintIndigencyTableAdapter
    Friend WithEvents TblPrintIndigencyBindingSource As System.Windows.Forms.BindingSource
End Class
