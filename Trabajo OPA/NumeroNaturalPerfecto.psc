Algoritmo sin_titulo
	Definir suma, n, c, i como entero
	suma=0
	n=0
	c=1
	i=0
	Mientras i<3 Hacer
		Escribir "Ingrese el número"
		leer n
		Si n<2^58 y n>0 Entonces
			Mientras c<n Hacer
				Si n%c==0 Entonces
					Escribir sin saltar (ConvertirATexto(c)+",")
					suma = suma +c
				Fin Si
				c = c +1
			Fin Mientras
			i=4
			
		SiNo
			i=i+1
			Escribir "El número invalido"
		Fin Si
	Fin Mientras
	Si i == 1000000000 Entonces
		Escribir "Error"
	SiNo
		Si suma==n Entonces
			Escribir "El número ",n " es Perfecto"
		SiNo
			Si suma<n  Entonces
				Escribir "El número ",n " es Deficiente"
			SiNo
				Escribir "El número ",n " es Abundante"
			Fin Si
		Fin Si
	Fin Si
FinAlgoritmo
