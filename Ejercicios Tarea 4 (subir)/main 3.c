#include <stdio.h>

/* Conflicto de variables con el mismo nombre. */

int K = 5; /* Variable global. */

void f1(void)
{
    int I; /* Variable local dentro de la función f1(). */
    int localK = 4; /* Valor constante de la variable local. */
    for (I = 1; I <= 3; I++)
    {
        K += K;
        printf("\n\nEl valor de la variable local es: %d", localK);

        K = K + K; /* Uso de ambas variables. */

        printf("\nEl valor de la variable global es: %d", K);
    }
}

int main(void)
{
    f1();
    return 0;
}
