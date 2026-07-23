Algoritmo Lecc35_Act2_pag123
	Definir p,pa,c,r,m Como Real
	Definir b200,b100,b50,b20 Como Real
	
	Escribir "Ingrese el precio del producto"
	Leer p
	Escribir "Ingrese el billete con el que pago el cliente"
	Leer pa
	si pa<p Entonces
		Escribir "EL dinero es insuficiente para la compra"
	SiNo
		c=pa-p
		Escribir "El cambio total es de: Q",c
		r=c
		b200 = r / 200
        r = r Mod 200
		
		b100 = r / 100
        r = r Mod 100
		
		b50 = r / 50
        r = r Mod 50
		
		b20 = r / 20
        residuo = r Mod 20
		m=r
		
		Escribir "--------------------------------------'
		Escribir"Cambio"
		si b200>0 Entonces
			Escribir 'Billetes de 200: ',b200
		FinSi
		si b100>0 Entonces
			Escribir 'Billetes de 100: ',b100
		FinSi
		si b50>0 Entonces
			Escribir 'Billetes de 50: ',b50
		FinSi
		si b20>0 Entonces
			Escribir 'Billetes de 20: ',b20
		FinSi
		si m>0 Entonces
			Escribir 'El cambio restante es de Q: ',m
		FinSi
		Escribir "--------------------------------------'
	FinSi
FinAlgoritmo
