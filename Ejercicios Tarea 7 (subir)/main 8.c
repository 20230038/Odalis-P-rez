#include <stdio.h>
#include <string.h>

/* Cadena invertida.
El programa obtiene la cadena invertida. */
char *inverso(char *); /* Prototipo de funci�n. */

int main(void)
{
    char fra[50], aux[50];

    printf("\nIngrese la linea de texto: ");
    fgets(fra, sizeof(fra), stdin);
    fra[strcspn(fra, "\n")] = '\0'; // Elimina el salto de l�nea del final

    strcpy(aux, inverso(fra)); /* Se copia a aux el resultado de la funci�n inverso. */

    printf("\nEscribe la l�nea de texto en forma inversa: ");
    puts(aux);

    return 0;
}

char *inverso(char *cadena)
/* La funci�n calcula el inverso de una cadena y regresa el resultado al programa principal. */
{
    int i = 0, j, lon;
    char cad;

    lon = strlen(cadena);
    j = lon - 1;

    while (i < ((lon) / 2))
    {
        cad = cadena[i];
        cadena[i] = cadena[j];
        cadena[j] = cad;
        i++;
        j--;
    }

    return cadena;
}
