Imports System.Console
Imports System.Media
Module Module1


    Sub Main()
        Dim HoraFin As DateTime
        Dim diferencia As TimeSpan
        HoraFin = Now.AddSeconds(5)
        HoraFin = Now.AddMinutes(1)

        Console.CursorVisible = False


        While Now <= HoraFin
            Console.SetCursorPosition(1, 1)
            diferencia = HoraFin - Now
            WriteLine("Faltan {0} minutos y {1} segundos", diferencia.Minutes, diferencia.Seconds)
        End While

        WriteLine("Hora de levantarse!")

        Dim player As New SoundPlayer("C:\Users\LC\Documents\GitHub\Clases\Programacion II\ProgramacionI\Alarma\ConsoleApplication1\sound\gallo2.wav")

        player.Play()

    End Sub

End Module
