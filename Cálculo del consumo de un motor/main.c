#include <stdio.h>
#include <locale.h>

#define MAXIMA_LONGITUD 100

int main() {
    int Res;
    char nombre[50];
    char apellido[50];

    // Establecer la configuración de caracteres a UTF-8
    setlocale(LC_ALL, "spanish");

    do {
        printf("El programa obtiene el gasto promedio de galones por kilómetro recorrido con respecto a su precio.\n");
        printf("Gastos por kilometraje con respecto a la eficiencia de su motor.\n");
        printf("Gasto total (Monto) que invierte en el mantenimiento, seguro y gastos variados en su vehículo.\n");
        printf("Considere la tabla en función al tiempo en que está asignando los datos (Depende de usted si es mensual o anual).\n");


        printf("\nIngrese su primer nombre y apeliido: ");
        scanf("%s", nombre);
        scanf("%s", apellido);

        int eficiencia_min; //Eficiencia mínima
        int eficiencia_max;  // Eficiencia máxima

        do {
            printf("\nIngrese la eficiencia mínima de litros por cada 100 km: ");
            scanf("%d", &eficiencia_min);

            printf("\nIngrese la eficiencia máxima de litros por cada 100 km: ");
            scanf("%d", &eficiencia_max);

            if (eficiencia_min > eficiencia_max) {
                printf("La eficiencia mínima no puede ser mayor a la eficiencia máxima ¿Desea volver a intentarlo? Si(1) No (2): ");
                scanf("%d", &Res);
            } else {
                break; // Salir del bucle si la eficiencia minima es menor o igual que la eficiencia máxima
            }
        } while (Res == 1);

        float consumo;
        int distancia;
        printf("\nIngrese la distancia recorrida en KM: ");
        scanf("%d", &distancia);

        float valorVehiculo;
        printf("\nIngrese el valor del vehículo (Mayor o igual a 200,000 DOP): ");
        scanf("%f", &valorVehiculo);


        int incremento = 50000;
        float valor_inicial = 0.82;
        float prima;


        int incrementos_completos = (valorVehiculo / incremento) - 4;
        float incremento_total = incrementos_completos * 0.18;
        float valor_con_incremento = valor_inicial + incremento_total;
        if (valorVehiculo > 200000){
        prima = 1000 + (valor_con_incremento * distancia);
        }
        if (valorVehiculo <200000){
                prima= 0;
            printf("La prima no es aplicable en este valor.\n");
        }


        int valor_neumatico;
        int vida_neumatico = 60000;
        int cantidad_de_neumaticos;
        float gasto_cambio_aceite;
        float gasto_mantenimiento;
        float gasto_banda;
        float gasto_filtros;

        float Desgaste_neumatico;
        float gasto_neumatico;
        printf("\nIngrese el valor del neumático: ");
        scanf("%d", &valor_neumatico);
         Desgaste_neumatico = distancia / vida_neumatico;

        if (Desgaste_neumatico >= 0) {
             gasto_neumatico = Desgaste_neumatico * valor_neumatico;
        }


        printf("\nIngrese el gasto del cambio de aceite: ");
        scanf("%f", &gasto_cambio_aceite);

        printf("\nIngrese el gasto de bandas: ");
        scanf("%f", &gasto_banda);

        printf("\nIngrese el gasto de filtros: ");
        scanf("%f", &gasto_filtros);


        char nombreapellidoArchivo[100];
        sprintf(nombreapellidoArchivo, "%s%s.txt", nombre, apellido);

        FILE *archivo;
        archivo = fopen(nombreapellidoArchivo, "w+");

        if (archivo == NULL) {
            printf("No se pudo abrir el archivo.\n");
            return 1;
        }



        printf("\n|----------------------------------------------------------------------------------------------------|\n");
        printf("|   Cliente %s %s, esta es su tabla de relación con respecto al Consumo promedio del motor    |\n", nombre, apellido);
        printf("|----------------------------------------------------------------------------------------------------|\n");
        printf("| % --5s | % --5s | % --5s | % --5s | % --5s | % --5s|% --8s|\n",
            "Consumo Promedio",
            "(km)",
            "Consumo Gal",
            "(km/galones)",
            "Gasto por km(DOP)",
            "Gastos (DOP)",
            "Monto(DOP)");

             for (int eficiencia_actual = eficiencia_min; eficiencia_actual <= eficiencia_max; eficiencia_actual++) {
            float consumo_por_distancia_Litros = (eficiencia_actual * distancia) / 100.00;
            float consumo_por_distancia_Galones = consumo_por_distancia_Litros * 0.264172; // Conversión de litros a galones
            float Gasto_Combustible_Promedio = consumo_por_distancia_Galones * 192.00;
            gasto_mantenimiento = prima + gasto_neumatico + gasto_cambio_aceite + gasto_banda + gasto_filtros;
            float eficiencia_Litros = distancia / consumo_por_distancia_Litros;
            float eficiencia_Galones = distancia / consumo_por_distancia_Galones;
            int monto= (Gasto_Combustible_Promedio * distancia) + gasto_mantenimiento;

            printf("|----------------------------------------------------------------------------------------------------|\n");
            printf("|%--18d| % --5d |% --12.2f |% --14.2f|% -19.2f|%-13.2f|%-10d|\n",
                eficiencia_actual,
                distancia,
                consumo_por_distancia_Litros,
                consumo_por_distancia_Galones,
                Gasto_Combustible_Promedio,
                gasto_mantenimiento,
                monto);

printf("|----------------------------------------------------------------------------------------------------|\n");
}
 // Guardar los resultados en el archivo
        fprintf(archivo,"\n|----------------------------------------------------------------------------------------------------|\n");
        fprintf(archivo,"|   Cliente %s %s, esta es su tabla de relación con respecto al Consumo promedio del motor    |\n", nombre, apellido);
        fprintf(archivo,"|----------------------------------------------------------------------------------------------------|\n");
        fprintf(archivo,"| % --5s | % --5s | % --5s | % --5s | % --5s | % --5s|% --8s|\n",
            "Consumo Promedio",
            "(km)",
            "Consumo Gal",
            "(km/galones)",
            "Gasto por km(DOP)",
            "Gastos (DOP)",
            "Monto(DOP)");

             for (int eficiencia_actual = eficiencia_min; eficiencia_actual <= eficiencia_max; eficiencia_actual++) {
            float consumo_por_distancia_Litros = (eficiencia_actual * distancia) / 100.00;
            float consumo_por_distancia_Galones = consumo_por_distancia_Litros * 0.264172; // Conversión de litros a galones
            float Gasto_Combustible_Promedio = consumo_por_distancia_Galones * 192.00;
            gasto_mantenimiento = prima + gasto_neumatico + gasto_cambio_aceite + gasto_banda + gasto_filtros;
            float eficiencia_Litros = distancia / consumo_por_distancia_Litros;
            float eficiencia_Galones = distancia / consumo_por_distancia_Galones;
            int monto= (Gasto_Combustible_Promedio * distancia) + gasto_mantenimiento;

            fprintf(archivo,"|----------------------------------------------------------------------------------------------------|\n");
            fprintf(archivo,"|%--18d| % --5d |% --12.2f |% --14.2f|% -19.2f|%-13.2f|%-10d|\n",
                eficiencia_actual,
                distancia,
                consumo_por_distancia_Litros,
                consumo_por_distancia_Galones,
                Gasto_Combustible_Promedio,
                gasto_mantenimiento,
                monto);
        }
fprintf(archivo,"|----------------------------------------------------------------------------------------------------|\n");

        // Cerrar el archivo
fclose(archivo);
        printf("El expediente se ha guardado en el archivo: %s\n\n", nombreapellidoArchivo);

        printf("¿Desea ingresar más datos? Si(1) No (2): ");
        scanf("%d", &Res);
    } while (Res == 1);

    return 0;
}
