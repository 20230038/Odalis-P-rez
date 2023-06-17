#include <stdio.h>
#include <ctype.h>

/* Decodifica.
El programa decodifica una cadena de caracteres compuesta por n�meros y letras. */

void interpreta(char *); /* Prototipo de funci�n. */

void main(void)
{
    char cad[50];
    printf("\nIngrese la cadena de caracteres: ");
    gets(cad);
    interpreta(cad);
}

void interpreta(char *cadena)
{
    /* Esta funci�n se utiliza para decodificar la cadena de caracteres. */

    int i = 0, j, k;

    while (cadena[i] != '\0')
    {
        if (isalpha(cadena[i]))
        {
            k = cadena[i - 1] - '0';
            /* En la variable entera k se almacena el valor num�rico correspondiente al
               car�cter que nos interesa. Restamos '0' para obtener ese valor. */

            for (j = 0; j < k; j++)
                putchar(cadena[i]);
        }

        i++;
    }
}
