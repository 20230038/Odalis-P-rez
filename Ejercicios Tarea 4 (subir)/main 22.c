#include <stdio.h>

void trueque(int *x, int *y)
{
    int tem;
    tem = *x;
    *x = *y;
    *y = tem;
}

int suma(int x)
{
    return (x + x);
}

int main(void)
{
    int x, y, z;

    // Llamadas a las funciones
    x = 10;
    printf("El resultado de suma(10) es: %d\n", suma(10));

    y = suma(10);
    printf("El valor de y después de asignar suma(10) es: %d\n", y);

    x = 3;
    y = 4;
    trueque(&x, &y);
    printf("Después de trueque(&x, &y), x = %d y y = %d\n", x, y);

    return 0;
}
