Algoritmo DescuentoEspecial
	Definir montoCompra, descuento, montofinal Como Real;
	
	Escribir "Ingrese el valor total de su compra ($):";
	Leer montoCompra;
	
	montofinal <- montoCompra;
	Si montoCompra > 350 Entonces
		descuento <- montoCompra * 0.10;
		montofinal <- montoCompra - descuento
		Escribir "¡Felicidades! Ha recibido un descuento de: $", descuento;
	FinSi
	
	Escribir "El total a pagar es: $", montofinal;
	FinAlgoritmo
