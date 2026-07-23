Algoritmo Lecc32_Act1_pag116 
	Definir m,op,r Como Real
	Escribir "Ingrese la cantidad de metros"
	Leer m
	Escribir "Seleccione una opcion"
	Escribir "1. milimetros"
	Escribir "2. centimetros"
	Escribir "3. decimetros"
	Escribir "4. hectometros"
	Escribir "5. kilometros"
	Leer op
	Segun op Hacer
		1: r=m*1000
			Escribir r, " milimetros"
		2: r=m*100
			Escribir r, " centimetros"
		3: r=m*10
			Escribir r, " decimetros"
		4: r=m/100
			Escribir r, " hectometros"
		5: r=m/1000
			Escribir r, " kilometros"
		De Otro Modo:
			Escribir "Opcion invalida"
	FinSegun
FinAlgoritmo
