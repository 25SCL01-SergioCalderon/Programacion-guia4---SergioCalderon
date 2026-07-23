Algoritmo Lecc33_Act2_pag119 
	Definir f,fi Como Cadena
	Definir lf,i Como Entero
	Escribir "Ingrese una frase"
	Leer f
	
	fi=""
	lf=Longitud(f)
	
	para i =lf Hasta 1 Con Paso -1 Hacer
		fi=fi+Subcadena(f,i,i)
	FinPara
	Escribir "La frase invertida es: ", fi
	
FinAlgoritmo
