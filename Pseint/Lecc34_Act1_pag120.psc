Algoritmo Lecc34_Act1_pag120 
	Definir nd,ed Como Entero
	Definir b Como Cadena
	n=""
	
	Escribir "Reciba un numero decimal"
	Leer nd
	
	Si nd=0 Entonces
		b="0'
	SiNo
		Mientras nd > 0 Hacer
			r= nd Mod 2
			b=ConvertirATexto(r)+b
			nd=Trunc(nd/2)
		FinMientras
	FinSi
	Escribir "El numero en binario es: ",b
FinAlgoritmo
