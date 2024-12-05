# Projecte-Prova-2
1. Detalla el càlcul del mètode recursiu següent pels valors de num indicats, tal com hem fet a classe. Quina funcionalitat executa el mètode? (2 punts):
num = 2
num = 12

public static int RecMethod(int num)
{
	int total = 0;

	if (num < 10) return num;

	while (num > 0)
	{
    	    total += num % 10;
    	    num /= 10;
	}

	return RecMethod(total);
}

Iniciamos con la funcion recursiva , en este caso nuestro numero sera 2 
- Se crea una variable llamada int total incializada que nos ayuda para guardar el calculo de los numeros y mas adelante presentar el numero final 
- se crea un if que nos ayuda a saber si el numero es mayor que 10 en el caso de ser 2 , el if sera true y devolvera 2 acabando con la funcion
- En el caso de que el numero sea mayor a 10 en este caso 12 , entraremos a un while con un argumento para validar si el numero es mayor que 0 en el caso de que sea asi , sera true y entraremos dentro del while
- Dentro del While se ejecutara los calculos en este caso 
 -  total += num % 10;
   -  0 += 12 % 10 = 2
 - num /= 10;
 - 12 /=10 = 1.2
  
- Una ves acabado entramos nuevamente al while
  - total += num % 10;
  - 2 += 1 % 10 = 3
  - num /= 10;
  - 1 /=10 = 0
  - al acabar el while y cumplir con el argumento de si num > 0 en este caso es 0
  - Ya no entramos en el while y se hace el return donde llamaremos a la misma funcion dando el valor que esta dentro de total , al llamarse a si misma total se vuelve num
  - Inicia de nuevo el proceso , entra dentro del if donde el numero es menor que 10 y devuelve 3
  - Esta funcion recursiva se encarga de sumar los digitos de numeros de dos o mas digitos .
