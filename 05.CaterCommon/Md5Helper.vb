Imports System.Security.Cryptography
Imports System.Text

Partial Public Class Md5Helper

    ''' <summary>
    ''' encrypts string
    ''' </summary>
    ''' <param name="s">string to be encrypted</param>
    ''' <returns>encrypted string</returns>
    Public Shared Function Encrypt(s As String) As String
        ' universal encode: UTF-8, x2

        ' ways of creating objects
        '   1.constructor
        '   2.shared method (factory)

        ' creates encryption object
        Dim md5 As MD5 = MD5.Create()
        ' converts string to byte array
        Dim byteOld As Byte() = Encoding.UTF8.GetBytes(s)
        ' calls encryption method
        Dim byteNew As Byte() = md5.ComputeHash(byteOld)
        ' converts what was encrypted to string
        Dim sb As New StringBuilder
        For Each b As Byte In byteNew
            ' converts byte to hexadecimal string (two digits per byte)
            sb.Append(b.ToString("x2")) ' two digits per byte, zero-filling
        Next
        ' returns encrypted string
        Return sb.ToString()
    End Function
End Class
