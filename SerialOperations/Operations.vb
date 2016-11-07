Public Class Operations

    Dim ran As New Random

    Public Function GenerateSerial() As String
        Dim serial As String
        Dim key As Long = ran.Next(0, 60466175)
        Dim lst As New List(Of List(Of String))
        Dim arr1() As String = {"A", "A", "B", "C", "C", "D", "E", "E", "F", "G", "G", "H", "I", "I", "J", "K", "K", "L", "M", "M", "N", "O", "O", "P", "Q", "Q", "R", "S", "S", "T", "U", "U", "V", "W", "W", "X", "Y", "Y", "Z", "0", "0", "1", "2", "2", "3", "4", "4", "5", "6", "6", "7", "8", "8", "9"}
        Dim arr2() As String = {"B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim arr3() As String = {"A", "E", "I", "O", "U", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim arr4() As String = {"0", "2", "4", "6", "8", "A", "C", "E", "G", "I", "K", "M", "O", "Q", "S", "U", "W", "Y"}
        Dim arr5() As String = {"0", "1", "2", "6", "7", "8", "A", "B", "C", "G", "H", "I", "M", "N", "O", "S", "T", "U", "Y", "Z"}
        Dim arr6() As String = {"L", "X", "M", "N", "T", "O", "P", "U", "V", "Q", "W", "A", "K", "0", "2", "4", "5", "6", "8", "9"}
        Dim arr7() As String = {"N", "T", "O", "S", "P", "R", "I", "E", "L", "X", "Q", "Z", "C", "B", "H", "8", "7", "2", "1", "6", "0", "3"}
        Dim arr8() As String = {"L", "S", "D", "M", "N", "O", "Q", "R", "S", "N", "V", "Q", "Y", "Q", "K", "X", "C", "A", "4", "5", "9", "2"}
        Dim arr9() As String = {"9", "7", "6", "4", "3", "1", "Q", "E", "T", "U", "O", "A", "S", "F", "H", "K", "Z", "C", "B", "M"}
        Dim arr10() As String = {"9", "8", "7", "3", "2", "1", "5", "5", "5", "W", "R", "Y", "I", "P", "S", "F", "H", "K", "Z", "C", "B", "M"}
        Dim arr11() As String = {"Q", "R", "I", "A", "F", "J", "Z", "V", "M", "E", "U", "P", "D", "H", "L", "C", "N", "0", "2", "3", "5", "7", "8"}
        Dim arr12() As String = {"Q", "A", "Z", "E", "D", "C", "T", "G", "B", "U", "J", "M", "O", "L", "7", "4", "5", "6", "3", "2"}
        Dim arr13() As String = {"Q", "A", "S", "E", "R", "F", "G", "H", "Y", "U", "J", "K", "I", "O", "L", "Z", "X", "S", "D", "F", "V", "B", "G", "H", "J", "M", "K", "9", "5", "1", "7", "5", "3"}
        Dim arr14() As String = {"Q", "W", "E", "T", "Y", "U", "O", "P", "A", "D", "F", "G", "J", "K", "L", "X", "C", "V", "N", "M", "1", "4", "6", "9"}
        Dim arr15() As String = {"Q", "A", "Z", "X", "C", "D", "E", "R", "T", "G", "B", "N", "M", "J", "U", "I", "O", "L", "1", "5", "4", "8", "6", "2", "3"}
        Dim arr16() As String = {"W", "E", "D", "C", "V", "B", "G", "T", "Y", "U", "J", "M", "K", "L", "O", "H", "F", "S", "1", "5", "4", "2", "3"}
        Dim arr17() As String = {"O", "I", "U", "T", "G", "B", "C", "X", "Z", "Q", "W", "E", "R", "F", "V", "B", "N", "M"}
        Dim arr18() As String = {"Q", "A", "Z", "X", "S", "D", "C", "V", "F", "R", "T", "G", "B", "N", "H", "J", "M", "K", "I", "O", "L", "P", "1", "3", "2", "5", "6", "7", "9"}
        Dim arr19() As String = {"L", "I", "A", "M", "I", "S", "C", "O", "O", "L", "I", "S", "N", "T", "H", "E", "3", "3", "3"}
        Dim arr20() As String = {"L", "S", "D", "I", "S", "C", "O", "O", "L", "S", "O", "I", "S", "C", "O", "C", "A", "I", "N", "E", "A", "N", "D", "P", "O", "T", "A", "N", "D", "M", "E", "T", "H"}
        lst.Add(New List(Of String)(arr1))
        lst.Add(New List(Of String)(arr2))
        lst.Add(New List(Of String)(arr3))
        lst.Add(New List(Of String)(arr4))
        lst.Add(New List(Of String)(arr5))
        lst.Add(New List(Of String)(arr6))
        lst.Add(New List(Of String)(arr7))
        lst.Add(New List(Of String)(arr8))
        lst.Add(New List(Of String)(arr9))
        lst.Add(New List(Of String)(arr10))
        lst.Add(New List(Of String)(arr11))
        lst.Add(New List(Of String)(arr12))
        lst.Add(New List(Of String)(arr13))
        lst.Add(New List(Of String)(arr14))
        lst.Add(New List(Of String)(arr15))
        lst.Add(New List(Of String)(arr16))
        lst.Add(New List(Of String)(arr17))
        lst.Add(New List(Of String)(arr18))
        lst.Add(New List(Of String)(arr19))
        lst.Add(New List(Of String)(arr20))
        serial &= CConvert.ToBase36(key)
        Do Until serial.Length = 5
            serial = "0" + serial
        Loop
        Dim r1 As New Random(key)
        Dim x As Integer
        Do Until serial.Length = 29
            x = serial.Length
            If x Mod 6 = 5 Then
                serial &= "-"
            Else
                serial &= lst.Item(x - (5 + (x + 1) \ 6)).Item(r1.Next(0, lst.Item(x - (5 + (x + 1) \ 6)).Count - 1))
            End If
        Loop
        Return serial
    End Function

    Public Function VerifyCode(ByVal Serial As String) As Boolean
        Serial = Serial.Trim(" ")
        If Not Serial.Length = 29 Then
            Return False
        End If
        Dim lst As New List(Of List(Of String))
        Dim arr1() As String = {"A", "A", "B", "C", "C", "D", "E", "E", "F", "G", "G", "H", "I", "I", "J", "K", "K", "L", "M", "M", "N", "O", "O", "P", "Q", "Q", "R", "S", "S", "T", "U", "U", "V", "W", "W", "X", "Y", "Y", "Z", "0", "0", "1", "2", "2", "3", "4", "4", "5", "6", "6", "7", "8", "8", "9"}
        Dim arr5() As String = {"0", "1", "2", "6", "7", "8", "A", "B", "C", "G", "H", "I", "M", "N", "O", "S", "T", "U", "Y", "Z"}
        Dim arr9() As String = {"9", "7", "6", "4", "3", "1", "Q", "E", "T", "U", "O", "A", "S", "F", "H", "K", "Z", "C", "B", "M"}
        Dim arr10() As String = {"9", "8", "7", "3", "2", "1", "5", "5", "5", "W", "R", "Y", "I", "P", "S", "F", "H", "K", "Z", "C", "B", "M"}
        Dim arr19() As String = {"L", "I", "A", "M", "I", "S", "C", "O", "O", "L", "I", "S", "N", "T", "H", "E", "3", "3", "3"}
        lst.Add(New List(Of String)(arr1))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String)(arr5))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String)(arr9))
        lst.Add(New List(Of String)(arr10))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String)(arr19))
        lst.Add(New List(Of String))
        Dim r1 As Random
        Try
            r1 = New Random(CConvert.FromBase36(Serial.Substring(0, 5)))
        Catch
            Return False
        End Try
        Dim x As Integer
        Dim chk As String = Serial.Substring(0, 5)
        Do Until chk.Length = 29
            x = chk.Length
            If x Mod 6 = 5 Then
                chk &= "-"
            Else
                If lst.Item(x - (5 + (x + 1) \ 6)).Count = 0 Then
                    chk &= "."
                    r1.Next(0, 1)
                Else
                    chk &= lst.Item(x - (5 + (x + 1) \ 6)).Item(r1.Next(0, lst.Item(x - (5 + (x + 1) \ 6)).Count - 1))
                End If
            End If
        Loop
        Return System.Text.RegularExpressions.Regex.IsMatch(Serial, chk)
    End Function

End Class
