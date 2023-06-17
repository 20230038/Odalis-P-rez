#include <stdio.h>
#include <ctype.h>

/* Decodifica.
El programa decodifica una cadena de caracteres compuesta por números y letras. */

void interpreta(char *); /* Prototipo de función. */

void main(void)
{
    char cad[50];
    printf("\nIngrese la cadena de caracteres: ");
    gets(cad);
    interpreta(cad);
}

void interpreta(char *cadena)
{
    /* Esta función se utiliza para decodificar la cadena de caracteres. */

    int i = 0, j, k;

    while (cadena[i] != '\0')
    {
        if (isalpha(cadena[i]))
        {
            k = cadena[i - 1] - '0';
            /* En la variable entera k se almacena el valor numérico correspondiente al
               carácter que nos interesa. Restamos '0' para obtener ese valor. */

            for (j = 0; j < k; j++)
                putchar(cadena[i]);
        }

        i++;
    }
}
