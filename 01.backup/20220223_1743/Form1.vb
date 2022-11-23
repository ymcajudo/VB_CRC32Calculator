Imports System.Text

Public Class Form1

    Dim SelectHex As Boolean = False
    Dim SelectASCII As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_Hex.Checked = True           'CRC32 계산은 기본적으로 Hex로 선택

    End Sub

    Private Sub bt_CRC32_Click(sender As Object, e As EventArgs) Handles bt_CRC32.Click

        Dim InputData As String = tb_InputData.Text.Trim()

        Try
            If SelectHex = True Then
                Dim tmpary As Byte() = New Byte((InputData.Length / 2) - 1) {}
                Dim i As Integer

                For i = 0 To tmpary.Length - 1
                    tmpary(i) = Convert.ToByte(InputData.Substring((i * 2), 2), &H10)     'char 2개를 각각 Hex 값으로 변환 후 하나(1byte)로 합침, 예: 01 => 0x01, 0A => 0x0A, 86 => 0x86, E9 => 0xE9
                Next i

                tb_CRCResult.Text = Hex(Crc32.ComputeChecksum(tmpary))

            ElseIf SelectASCII = True Then
                tb_CRCResult.Text = Hex(Crc32.ComputeChecksum(Encoding.ASCII.GetBytes(InputData)))
            Else
                MessageBox.Show("Please, select Hex or ASCII")
            End If
        Catch ex As Exception
            MessageBox.Show("Please, check the input data. It should be Hex string and the length of it should be also an even number.")
        End Try

    End Sub

    Public Class Crc32
        'CRC32 변환 클래스
        Shared table As UInteger()

        Shared Sub New()
            Dim poly As UInteger = &HEDB88320UI     'Polynomial value   : 04C11DB7 (Mirror value = EDB88320) 'VB.Net code에선 Mirror value 사용
            table = New UInteger(255) {}
            Dim temp As UInteger = 0
            For i As UInteger = 0 To table.Length - 1
                temp = i
                For j As Integer = 8 To 1 Step -1
                    If (temp And 1) = 1 Then
                        temp = CUInt((temp >> 1) Xor poly)
                    Else
                        temp >>= 1
                    End If
                Next
                table(i) = temp
            Next
        End Sub

        Public Shared Function ComputeChecksum(bytes As Byte()) As UInteger
            Dim crc As UInteger = &HFFFFFFFFUI      'Mirror algorithm을 사용해서 Initialise가 &H0인데 &HFFFFFFFF로 표기
            For i As Integer = 0 To bytes.Length - 1
                Dim index As Byte = CByte(((crc) And &HFF) Xor bytes(i))
                crc = CUInt((crc >> 8) Xor table(index))
            Next
            Return Not crc
        End Function
    End Class

    Private Sub rb_Hex_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Hex.CheckedChanged
        SelectHex = True
        SelectASCII = False

    End Sub

    Private Sub rb_ASCII_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ASCII.CheckedChanged
        SelectASCII = True
        SelectHex = False

    End Sub
End Class
