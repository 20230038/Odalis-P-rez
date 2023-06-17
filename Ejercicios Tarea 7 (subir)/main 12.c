#include <stdio.h>
#include <string.h>

void intercambia(char FRA[][30], int); /* Prototipo de funci�n. */

int main(void)
{
    int i, n;
    char FRA[20][30];

    printf("\nIngrese el numero de filas del arreglo: ");
    scanf("%d", &n);

    for (i = 0; i < n; i++)
    {
        printf("Ingrese la linea de texto numero %d: ", i + 1);
        fflush(stdin);
        fgets(FRA[i], sizeof(FRA[i]), stdin);
        FRA[i][strcspn(FRA[i], "\n")] = '\0'; // Elimina el salto de l�nea del final
    }

    printf("\n\n");

    intercambia(FRA, n);

    for (i = 0; i < n; i++)
    {
        printf("Impresi�n de la l�nea de texto %d: %s\n", i + 1, FRA[i]);
    }

    return 0;
}

void intercambia(char FRA[][30], int n)
{
    /* Esta funci�n intercambia las filas del arreglo. */
    int i, j;
    j = n - 1;
    char cad[30];

    for (i = 0; i < (n / 2); i++)
    {
        strcpy(cad, FRA[i]);
        strcpy(FRA[i], FRA[j]);
        strcpy(FRA[j], cad);
        j--;
    }
}
