Algoritmo Lecc35_Act1_pag122
	Definir cL,d,e,yen,pM,pA Como Real
	Definir r Como Caracter
	td = 0.13
	te = 0.11
	tyen = 21.16
	tpM= 2.29
	tpA = 193.56
	
	Repetir
		Limpiar Pantalla
		Escribir "<<<Convertidor de Monedas>>>"
		Escribir "Ingrese la cantidad de moneda"
		Leer cL
		
		d=cL*td
		e=cL*te
		yen=cL*tyen
		pM=cL*tpM
		pA=cL*tpA
		
		Escribir "---------------------------------------"
		Escribir "El equivalente en dolares es de: ",d
		Escribir "El equivalente en dolares es de: ",e
		Escribir "El equivalente en dolares es de: ",yen
		Escribir "El equivalente en dolares es de: ",pM
		Escribir "El equivalente en dolares es de: ",pA
		Escribir "---------------------------------------"
		
		Escribir "Desea hacer otra convercion"
		leer r
	Hasta Que r="N" o r="n'
FinAlgoritmo
