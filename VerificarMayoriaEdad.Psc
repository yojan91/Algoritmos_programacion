Algoritmo VerificarMayoriaEdad
    // yojan Sarmiento 
	Escribir "Ingrese el año actual:"
	Leer anioActual
	Escribir "Ingrese su año de nacimiento:"
	Leer anioNacimiento
	edad <- anioActual - anioNacimiento
	si edad >= 18 Entonces
		Escribir "Es mayor de edad. edad:", edad
	SiNo
		Escribir "Es menor de edad. edad:", edad
	FinSi
FinAlgoritmo
