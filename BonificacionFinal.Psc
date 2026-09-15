Algoritmo BonificacionFinal
	Definir UnidadesVendidas, antiguedad Como Entero;
	Definir sueldoBase, bonificacion, sueldofinal Como Real;
	
	sueldoBase <- 2200000 
	bonificacion <- 200000
	sueldofinal <- sueldoBase
	
	Escribir "Ingrese la cantidad de UnidadesVendidas en el mes:";
	Leer UnidadesVendidas;
	Escribir "Ingrese los años de antiguedad en la empresa: ";
	Leer antiguedad;
	
	Si UnidadesVendidas > 50 Y antiguedad > 2 Entonces
		sueldofinal <- sueldoBase + bonificacion;
		Escribir "!Felicidades! Ha cumplido con las metas de ventas! tienes una bonificacion de: ", bonificacion ;
	FinSi
	Escribir "Tu salario este mes es de: $",sueldofinal;
FinAlgoritmo
