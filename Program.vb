Imports System

Public Class Student
    Public Name As String
    Public RollNo As Integer
    Public Tmarks As Integer

    Public Sub New(name As String, rollNo As Integer, tmarks As Integer)
        Me.Name = name
        Me.RollNo = rollNo
        Me.Tmarks = tmarks
    End Sub

    Public Sub DisplayDetails()
        Console.WriteLine("Name: " & Name)
        Console.WriteLine("Roll Number: " & RollNo)
        Console.WriteLine("Total Marks: " & Tmarks)
    End Sub
End Class

Module StudentDetails
    Sub Main()
        Dim students(0) As Student
        Dim i As Integer = 0
        Dim choice As Integer

        Do
            Console.WriteLine("Menu:")
            Console.WriteLine("1. Add Student")
            Console.WriteLine("2. Display All Students")
            Console.WriteLine("3. Delete All Students")
            Console.WriteLine("4. Exit")
            Console.Write("Enter your choice: ")
            choice = Console.ReadLine()

            Select Case choice
                Case 1
                    Console.Write("Enter student name: ")
                    Dim name As String = Console.ReadLine()
                    Console.Write("Enter student roll number: ")
                    Dim rollNo As Integer = Console.ReadLine()
                    Console.Write("Enter student total marks: ")
                    Dim tmarks As Integer = Console.ReadLine()

                    Dim newStudent As New Student(name, rollNo, tmarks)
                    ReDim students(i)
                    students(i) = newStudent
                    i = i + 1
                    Console.WriteLine("Student added successfully.")
                Case 2
                    If students.Count > 0 Then
                        Console.WriteLine("Details of all students:")
                        For l As Integer = 0 To students.Count - 1
                            students(l).DisplayDetails()
                        Next
                    Else
                        Console.WriteLine("No students ")
                    End If
                    Console.WriteLine()
                Case 3
                    If students.Count > 0 Then
                        students.Clear()
                        Console.WriteLine("All students successfully deleted.")
                    Else
                        Console.WriteLine("No students to delete.")
                    End If
                    Console.WriteLine()
                Case 4
                    Console.WriteLine("Exit")
                Case Else
                    Console.WriteLine("Invalid choice.")
                    Console.WriteLine()
            End Select

        Loop While choice <> 4
    End Sub
End Module