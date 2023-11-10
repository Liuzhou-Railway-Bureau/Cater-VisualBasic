Imports System.Configuration
Imports System.Data.SQLite

Public Class SqliteHelper

#Region "gets connection string"
    ''' <summary>
    ''' gets connection string
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>connection string</returns>
    Public Shared Function GetConnectionString(conn As String) As String
        Return ConfigurationManager.ConnectionStrings(conn).ConnectionString
    End Function
#End Region

#Region "executes non-query and returns the number of rows affected"
    ''' <summary>
    ''' executes non-query statement
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>the number of rows affected</returns>
    Public Shared Function ExecuteNonQuery(connStr As String, sqlText As String, ParamArray parameters As SQLiteParameter()) As Integer
        Dim num As Integer = 0
        Using connection As New SQLiteConnection(connStr)
            Using command As New SQLiteCommand(sqlText, connection)
                connection.Open()
                command.Parameters.AddRange(parameters)
                num = command.ExecuteNonQuery()
            End Using
        End Using
        Return num
    End Function
#End Region

#Region "executes query and returns the first column of the first row"
    ''' <summary>
    ''' executes query statement
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>the first column of the first row</returns>
    Public Shared Function ExecuteScalar(connStr As String, sqlText As String, ParamArray parameters As SQLiteParameter()) As Object
        Dim value As Object = Nothing
        Using connection As New SQLiteConnection(connStr)
            Using command As New SQLiteCommand(sqlText, connection)
                connection.Open()
                command.Parameters.AddRange(parameters)
                value = command.ExecuteScalar()
            End Using
        End Using
        Return value
    End Function

    ''' <summary>
    ''' executes query statement
    ''' </summary>
    ''' <typeparam name="T">a class</typeparam>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>the first column of the first row</returns>
    Public Shared Function ExecuteScalar(Of T As Class)(connStr As String, sqlText As String, ParamArray parameters As SQLiteParameter()) As T
        ' As constrains T
        Dim value As T = Nothing
        Using connection As New SQLiteConnection(connStr)
            Using command As New SQLiteCommand(sqlText, connection)
                connection.Open()
                command.Parameters.AddRange(parameters)
                value = DirectCast(command.ExecuteScalar(), T)
            End Using
        End Using
        Return value
    End Function
#End Region

#Region "executes a SQL and returns a data table or a data set"
    ''' <summary>
    ''' executes a SQL
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="tableName">table name</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>a data table with data</returns>
    Public Shared Function ExecuteTable(connStr As String, sqlText As String, tableName As String, ParamArray parameters As SQLiteParameter()) As DataTable
        Return ExecuteTable(connStr, sqlText, tableName, CommandType.Text, parameters)
    End Function

    ''' <summary>
    ''' executes a SQL
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="dataSetName">data set name</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>a data set with data</returns>
    Public Shared Function ExecuteSet(connStr As String, sqlText As String, dataSetName As String, ParamArray parameters As SQLiteParameter()) As DataSet
        Return ExecuteSet(connStr, sqlText, dataSetName, CommandType.Text, parameters)
    End Function
#End Region

#Region "executes a SQL and returns a data reader"
    ''' <summary>
    ''' executes a SQL
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>a data reader</returns>
    Public Shared Function ExecuteReader(connStr As String, sqlText As String, ParamArray parameters As SQLiteParameter()) As SQLiteDataReader
        ' DataReader occupies Connection when reading data
        Dim connection As New SQLiteConnection(connStr) ' don't release Connection for it will be needed later
        Dim command As New SQLiteCommand(sqlText, connection)
        connection.Open()
        command.Parameters.AddRange(parameters)
        ' CommandBehavior.CloseConnection: incidentally releases Connection when releasing DataReader
        Return command.ExecuteReader(CommandBehavior.CloseConnection)
    End Function
#End Region

#Region "executes special command"
    ''' <summary>
    ''' executes special command
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="tableName">table name</param>
    ''' <param name="commandType">SQL command type</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>a data table with data</returns>
    Public Shared Function ExecuteTable(connStr As String, sqlText As String, tableName As String, commandType As CommandType, ParamArray parameters As SQLiteParameter()) As DataTable
        Dim dt As DataTable = Nothing
        Using adapter As New SQLiteDataAdapter(sqlText, connStr)
            dt = New DataTable(tableName)
            adapter.SelectCommand.CommandType = commandType
            adapter.SelectCommand.Parameters.AddRange(parameters)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    ''' <summary>
    ''' executes special command
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="dataSetName">data set name</param>
    ''' <param name="commandType">SQL command type</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>a data table with data</returns>
    Public Shared Function ExecuteSet(connStr As String, sqlText As String, dataSetName As String, commandType As CommandType, ParamArray parameters As SQLiteParameter()) As DataSet
        Dim ds As DataSet = Nothing
        Using adapter As New SQLiteDataAdapter(sqlText, connStr)
            ds = New DataSet(dataSetName)
            adapter.SelectCommand.CommandType = commandType
            adapter.SelectCommand.Parameters.AddRange(parameters)
            adapter.Fill(ds)
        End Using
        Return ds
    End Function
#End Region

#Region "executes transaction and returns the number of rows affected"
    ''' <summary>
    ''' executes transaction
    ''' </summary>
    ''' <param name="connStr">connection string</param>
    ''' <param name="sqlText">SQL statement</param>
    ''' <param name="parameters">SQL parameters</param>
    ''' <returns>the number of rows affected</returns>
    Public Shared Function ExecuteTransaction(connStr As String, sqlText As String, ParamArray parameters As SQLiteParameter()) As Integer
        Dim num As Integer = 0
        Using connection As New SQLiteConnection(connStr)
            Using command As New SQLiteCommand(sqlText, connection)
                connection.Open()
                Dim transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    command.Transaction = transaction
                    command.Parameters.AddRange(parameters)
                    num = command.ExecuteNonQuery()
                    transaction.Commit()
                Catch
                    num = 0
                    transaction.Rollback()
                End Try
            End Using
        End Using
        Return num
    End Function
#End Region
End Class
