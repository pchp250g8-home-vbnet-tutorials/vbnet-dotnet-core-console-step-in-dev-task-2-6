Imports System

Module Program
    Sub Main(args As String())
		Dim n As UInteger = Nothing ' Число, "корень" которого нужно найти
		'--Ввод данных с клавиатуры--
		Console.Write("Введите число: ")
		UInteger.TryParse(Console.ReadLine(), n)
		'--Поиск "корня" введённого числа
		Dim m As UInteger = n ' Начальное значение "корня" числа
		Do While m > 9 ' Внешний цикл: повторять пока число не станет однозначным
			Dim s As UInteger = 0 ' Сумма цифр введённого числа
			Do While m > 0 ' Внутренний цикл: повторять пока число больше нуля
				s = s + m Mod CUInt(10) ' Вычислить сумму цифр числа.
				m = m \ CUInt(10) ' Число уменьшить в 10 раз.
			Loop
			m = s ' Промежуточное значение "корня" числа
		Loop
		' Вывод на экран исходного числа и его "корня"
		Console.WriteLine($"""Корень"" числа {n} - {m}")
		Console.Read() ' Задержка вывода до нажатия клавиши "Ввод"
	End Sub
End Module
