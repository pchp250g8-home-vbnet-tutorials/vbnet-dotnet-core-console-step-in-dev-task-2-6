Imports System

Module Program
    Sub Main(args As String())
		Dim n As UInteger = Nothing ' The number whose "root" is to be found
		'--Input from the keyboard--
		Console.Write("Enter a number: ")
		UInteger.TryParse(Console.ReadLine(), n)
		'--Finding the "root" of the entered number
		Dim m As UInteger = n ' Initial value of the number's "root"
		Do While m > 9 ' Outer loop: repeat until the number becomes a single digit
			Dim s As UInteger = 0 ' Sum of the digits of the entered number
			Do While m > 0 ' Inner loop: repeat while the number is greater than zero
				s = s + m Mod CUInt(10) ' Calculate the sum of the digits.
				m = m \ CUInt(10) ' Divide the number by 10.
			Loop
			m = s ' Intermediate value of the number's "root"
		Loop
		' Display the original number and its "root" on the screen
		Console.WriteLine($"The ""root"" of the number {n} is {m}")
		Console.Read() ' Pause output until the "Enter" key is pressed
	End Sub
End Module
