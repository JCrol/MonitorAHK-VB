Imports System.Data.SqlClient

Public Class frmMonitor
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myConn As New SqlConnection("User ID=MonitorAHK;Password=Monitor123;Initial Catalog=nice_storage_center;" &
                "Data Source=NICEDB1YUC;")

        Dim sql As String = "
 
 -- BACKLOG v2

-- Declaracion de variables
DECLARE @FechaLocal DATETIME
DECLARE @FechaGTM DATETIME
DECLARE @FechaInicio DATETIME

-- Obtener hora local
SET @FechaLocal = (SELECT GETDATE())

-- Convertir a horario GMT
SET @FechaGTM = (SELECT DATEADD(hour,6,@FechaLocal)) 

SET @FechaInicio = (SELECT CONVERT (char(10), @FechaGTM, 112)) 

SELECT iLoggerID AS 'LOGGER', SUM(ISNULL(CAST(iCount AS BIGINT), 0)) AS 'PENDIENTES POR ARCHIVAR'
  FROM nice_storage_center.dbo.vwScBacklog
  WHERE dtRecordingGMTStartTime BETWEEN @FechaInicio AND @FechaGTM
  GROUP BY iLoggerID 
  

"
        Dim cmd As New SqlCommand(sql, myConn)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "vwScBacklog")

            Me.backlogGridView.DataSource = ds.Tables("vwScBacklog")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        MsgBox("BACKLOG")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles tabBacklog.Click

    End Sub
End Class
