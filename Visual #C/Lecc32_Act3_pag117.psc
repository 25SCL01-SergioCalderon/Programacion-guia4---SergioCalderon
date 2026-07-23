Algoritmo Lecc32_Act3_pag117
	Definir l1, l2, l3 Como Real
    
    Escribir "Ingrese la medida del lado 1:"
    Leer l1
    Escribir "Ingrese la medida del lado 2:"
    Leer l2
    Escribir "Ingrese la medida del lado 3:"
    Leer l3
    Si (l1 + l2 > l3) Y (l1 + l3 > l2) Y (l2 + l3 > l1) Entonces
        
        Si lado1 = lado2 Y lado2 = lado3 Entonces
            Escribir "El triángulo es: EQUILÁTERO"
        Sino
            Si lado1 = lado2 O lado1 = lado3 O lado2 = lado3 Entonces
                Escribir "El triángulo es: ISÓSCELES"
            Sino
                Escribir "El triángulo es: ESCALENO"
            FinSi
        FinSi
        
    Sino
        Escribir "Error: Las medidas ingresadas no pueden formar un triángulo."
    FinSi
FinAlgoritmo
