Algoritmo ControlVelocidad
	Definir velocidad Como Real ;
	
	Escribir "ingrese la velocidad registrada del vehiculo (km/h):";
	Leer velocidad;
	
	Si velocidad > 80 Entonces
		Escribir "¡Alerta! Ha superado el limite de velocidad de 80 km/h.";
		Escribir "Se ha generado una fotomulta automaticamente.";
	FinSi
	
	Escribir "Evaluacion de trancito finalizada.";
FinAlgoritmo
