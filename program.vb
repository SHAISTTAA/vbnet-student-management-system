Imports System
Imports System.Collections.Generic

Module Program

    Class Student

        Public Id As Integer
        Public Name As String
        Public Marks As Integer

    End Class

    Dim students As New List(Of Student)

    Sub AddStudent()

        Dim s As New Student()

        Console.Write("Enter Student Id: ")
        s.Id = Convert.ToInt32(Console.ReadLine())

        Console.Write("Enter Student Name: ")
        s.Name = Console.ReadLine()

        Console.Write("Enter Marks: ")
        s.Marks = Convert.ToInt32(Console.ReadLine())

        students.Add(s)

    End Sub

    Sub ShowStudents()

        Console.WriteLine(vbCrLf & "Student Records")

        For Each s In students
            Console.WriteLine("ID: " & s.Id &
                              " Name: " & s.Name &
                              " Marks: " & s.Marks)
        Next

    End Sub

    Sub Main()

        While True

            Console.WriteLine(vbCrLf & "1 Add Student")
            Console.WriteLine("2 Show Students")
            Console.WriteLine("3 Exit")

            Dim choice = Console.ReadLine()

            If choice = "1" Then
                AddStudent()

            ElseIf choice = "2" Then
                ShowStudents()

            ElseIf choice = "3" Then
                Exit While
            End If

        End While

    End Sub

End Module
