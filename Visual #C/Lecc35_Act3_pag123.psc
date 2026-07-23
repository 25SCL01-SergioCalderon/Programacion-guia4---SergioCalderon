Algoritmo Lecc35_Act3_pag123
	Definir u, c Como Entero
    Definir jn Como Caracter
    
    Repetir
        Escribir "Elige una opción:"
        Escribir "1. Piedra"
        Escribir "2. Papel"
        Escribir "3. Tijeras"
        Leer u

        Mientras u < 1 O u > 3 Hacer
            Escribir "Opción inválida. Elige 1, 2 o 3:"
            Leer u
        FinMientras
        c <- Aleatorio(1, 3) 

        Si c = 1 Entonces
            Escribir "La computadora eligió: Piedra"
        Sino
            Si c = 2 Entonces
                Escribir "La computadora eligió: Papel"
            Sino
                Escribir "La computadora eligió: Tijeras"
            FinSi
        FinSi

        Si u = c Entonces
            Escribir "¡Es un empate!"
        Sino
            Si (u = 1 Y c = 3) O (u= 2 Y c = 1) O (u = 3 Y c = 2) Entonces
                Escribir "¡Ganaste tú! Felicidades."
            Sino
                Escribir "¡Ganó la computadora! Suerte para la próxima."
            FinSi
        FinSi
        
        Escribir "¿Quieres jugar de nuevo? (S/N):"
        Leer jn
        
    Hasta Que jn = "N" O jn = "n"
    
    Escribir "¡Gracias por jugar! Hasta la próxima'
FinAlgoritmo
