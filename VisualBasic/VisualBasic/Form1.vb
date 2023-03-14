Public Class Form1

    '주석'
    ' 정수 타입으로 변수 i를 선언하고 초기값 = 0'
    Dim i As Integer = 0


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = 1 - i
        If i = 1 Then ' 변수 i의 값이 1이라면 Label1이라는 이름을 갖는 라벨에 안녕세상아 i=  문자열 출력'
            '비베에서 문자열 연결 출력 시 & 사용
            Label1.Text = "안녕세상아 i = " & i
        Else
            Label1.Text = "Hello World i= " & i
        End If
    End Sub
End Class
