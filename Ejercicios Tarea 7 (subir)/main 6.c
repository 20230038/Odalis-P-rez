#include <stdio.h>
#include <string.h>

/* Cuenta cadenas.
El programa, al recibir dos cadenas de caracteres, calcula e imprime cuántas veces se encuentra la segunda cadena en la primera. */

int main(void)
{
    char cad1[50], cad2[50], cad0[50] = "";
    int i = 0;

    printf("\nIngrese la primera cadena de caracteres: ");
    fgets(cad1, sizeof(cad1), stdin);
    cad1[strcspn(cad1, "\n")] = '\0'; // Elimina el salto de línea del final

    printf("\nIngrese la cadena a buscar: ");
    fgets(cad2, sizeof(cad2), stdin);
    cad2[strcspn(cad2, "\n")] = '\0'; // Elimina el salto de línea del final

    strcpy(cad0, cad1); /* Se copia la cadena original a cad0. */
    char *ptr = strstr(cad0, cad2);
    /* En ptr se asigna el apuntador a la primera ocurrencia de la cadena cad2.
       Si no existe se almacena NULL.*/

    while (ptr != NULL)
    {
        i++;
        ptr = strstr(ptr + strlen(cad2), cad2);
        /* Se modifica nuevamente la cadena, moviendo el apuntador una posición después de la ocurrencia actual. */
    }

    printf("\nEl número de veces que aparece la segunda cadena es: %d", i);

    return 0;
}
