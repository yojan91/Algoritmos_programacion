Algoritmo AlertaTemperatura
	Definir temp Como Real ;
	
	Escribir "Ingrese la temperatura actual en grados Celsius (°C):";
	Leer temp;
	
	Si temp < 0 Entonces
		Escribir "ADVERTENCIA: Temperatura bajo cero detectada.";
		Escribir "Riesgo de congelamiento en carreteras. ", "Condusca con precaucion.";
	FinSi
	
	Escribir "Registro meteorologico completado.";
	FinAlgoritmo
