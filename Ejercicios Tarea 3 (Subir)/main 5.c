#include <stdio.h>
#include <math.h>
/* Función.
El programa, al recibir como dato un valor entero, calcula el resultado de
➥una función.
Y: variable de tipo entero.
X: variable de tipo real. */

void main(void)
{
  float x;
  int y;
     printf("Ingrese el valor de y: ");
     scanf("%d", &y);
  if (y < 0 || y > 50)
    x = 0;
    else
  if (y <= 10)
    x = 4 / y - y;
    else
  if (y <= 25)
    x = pow(y, 3) - 12;
    else
       x = pow(y, 2) + pow(y, 3) - 18;
printf("\n\ny = %d\tx = %8.2f", y, x);
}
