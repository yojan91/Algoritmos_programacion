Algoritmo PagofacturaAgua
	Definir MontoOriginal, recargo, montoTotal Como Real;
	Definir diasRetraso Como Entero;
	
	Escribir "Ingrese el monto original de la factura ($ - COD)";
	Leer MontoOriginal;
	
	Escribir "Ingrese los dias de retraso en el pago:";
	leer diasRetraso;
	
	montoTotal <- MontoOriginal;
	
	Si diasRetraso > 5 Entonces
		recargo <- MontoOriginal * 0.05;
		montoTotal <- MontoOriginal + recargo;
		Escribir "Se aplicado un recargo del 5% ($",recargo, ") por mora.";
	FinSi
	Escribir "Monto total definitivo a pagar: $",montoTotal;
FinAlgoritmo
