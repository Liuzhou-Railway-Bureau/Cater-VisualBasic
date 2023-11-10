Imports System.Text
Imports Microsoft.International.Converters.PinYinConverter

Partial Public Class PinyinHelper

    ''' <summary>
    ''' gets each char's first Pinyin letter
    ''' </summary>
    ''' <param name="s">provided string</param>
    ''' <returns>each char's first Pinyin letter</returns>
    Public Shared Function GetPinyin(s As String) As String
        Dim sb As New StringBuilder
        For Each c As Char In s
            Dim cc As New ChineseChar(c)
            sb.Append(cc.Pinyins(0)(0))
        Next
        Return sb.ToString()
    End Function
End Class
