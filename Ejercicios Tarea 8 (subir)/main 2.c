#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* Estructuras-2.
El programa muestra la manera en que se declara una estructura, así como la
forma en que se tiene acceso a los campos de los apuntadores de tipo estructura
tanto para lectura como para escritura. Se utiliza además una función que
recibe como parámetro un apuntador de tipo estructura. */
struct alumno /* Declaración de la estructura. */
{
    int matricula;
    char nombre[20];
    char carrera[20]; /* Campos de la estructura alumno. */
    float promedio;
    char direccion[20];
};

void Lectura(struct alumno *); /* Prototipo de función. */

int main(void)
{
    struct alumno a0 = {120, "María", "Contabilidad", 8.9, "Querétaro"};
    struct alumno *a3, *a4, *a5;
    struct alumno a6;
    /* Observa que las variables *a3, *a4 y *a5 se declaran como apuntadores de
    tipo estructura alumno. a6 es una variable de tipo estructura alumno. */
    a3 = &a0; /* En este caso al apuntador de tipo estructura alumno a3
    se le asigna la dirección de la variable de tipo estructura alumno, a0. */
    a4 = (struct alumno*)malloc(sizeof(struct alumno));
    /* Nota que al apuntador a4 es necesario asignarle una dirección de memoria.
    Para tener acceso a los campos de un apuntador de tipo estructura, utiliza uno
    de los dos formatos siguientes:
    apuntador->campo
    o bien
    (*apuntador).campo
    En la lectura de los campos de la variable a4 se utilizan como ejemplo ambos
    formatos. */
    void Lectura(struct alumno *a)
{
    printf("Ingrese la matricula del alumno: ");
    scanf("%d", &(a->matricula));
    fflush(stdin);

    printf("Ingrese el nombre del alumno: ");
    fgets(a->nombre, sizeof(a->nombre), stdin);
    a->nombre[strcspn(a->nombre, "\n")] = '\0';

    printf("Ingrese la carrera del alumno: ");
    fgets(a->carrera, sizeof(a->carrera), stdin);
    a->carrera[strcspn(a->carrera, "\n")] = '\0';

    printf("Ingrese el promedio del alumno: ");
    scanf("%f", &(a->promedio));
    fflush(stdin);

    printf("Ingrese la dirección del alumno: ");
    fgets(a->direccion, sizeof(a->direccion), stdin);
    a->direccion[strcspn(a->direccion, "\n")] = '\0';
}

    a5 = (struct alumno*)malloc(sizeof(struct alumno));
    Lectura(&a5);
    Lectura(&a6);

    printf("\nDatos del alumno 3\n");
    /* Observa la forma de escribir los campos de los apuntadores de tipo estructura. */
    printf("%d\t%s\t%s\t%.2f\t%s", a3->matricula, a3->nombre, a3->carrera,
        a3->promedio, a3->direccion);

    printf("\nDatos del alumno 4\n");
    printf("%d\t%s\t%s\t%.2f\t%s", a4->matricula, a4->nombre, a4->carrera,
        a4->promedio, a4);

        return 0;
}

