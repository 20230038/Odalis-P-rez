using System;
using System.Collections.Generic;

namespace AMJOA
{
    public class CondicionMedica
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tratamiento { get; set; }
        public string Indicaciones { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<CondicionMedica> condicionesMedicas = new List<CondicionMedica>
            {
                new CondicionMedica
                {
                    Nombre = "Fiebre",
                    Descripcion = "Algunas veces es el único signo de infección.",
                    Tratamiento = "Descanso, hidratación y medicamentos para bajar la fiebre como acetaminofén.",
                    Indicaciones = "Si la fiebre persiste por varios días o se acompaña de otros síntomas, consulta a un médico."
                },
                new CondicionMedica
                {
                    Nombre = "Asma",
                    Descripcion = "Falta de aire, sibilancias, opresión en el pecho.",
                    Tratamiento = "Uso de inhaladores broncodilatadores y corticosteroides según indicación médica.",
                    Indicaciones = "Evitar desencadenantes, mantener el inhalador de alivio rápido a mano y seguir el plan de tratamiento."
                },
                new CondicionMedica
                {
                    Nombre = "Hipotension",
                    Descripcion = "Presión arterial es mucho más baja de lo normal.",
                    Tratamiento = "Al estar sentado o acostado, levantarse lentamente.Evitar el alcohol, tomar mucha agua y realizar comidas pequeñas bajas en carbohidratos, junto con frutas y vegetales, también puede ayudar.",
                    Indicaciones = "Tomar mucho líquido. Incorporarse lentamente después de estar sentado o acostado. No beber alcohol. Evitar permanecer de pie por mucho tiempo (si presenta hipotensión mediada neuralmente). Usar medias de compresión de manera que la sangre no se acumule en las piernas."
                },
                new CondicionMedica
                {
                    Nombre = "Hipertension",
                    Descripcion = "Presión arterial es mucho más alta de lo normal.",
                    Tratamiento = "Seguir una dieta saludable con menos sal, ejercitarse regularmente y tomar medicamentos puede ayudar a bajar la presión arterial.",
                    Indicaciones = "Reducir la cantidad de sodio (sal) que consume. Procure que sean menos de 1,500 mg por día. Reducir la cantidad de alcohol que toma, no más de 1 trago al día para las mujeres y 2 para los hombres. Consumir una dieta saludable para el corazón que incluya las cantidades recomendadas de potasio y fibra."
                },

            };

           


            CondicionMedica condicionDiagnostico = null;

            Console.WriteLine("Bienvenido al sistema médico de diagnóstico.");

            Console.Write("¿Está experimentando fiebre? (s/n): ");
            char respuestaFiebre = Console.ReadLine()[0];

            Console.Write("¿Está teniendo dificultad para respirar? (s/n): ");
            char respuestaDificultadRespirar = Console.ReadLine()[0];




            // Diagnostico Hipertension
            if (condicionDiagnostico == null)
                {
                    Console.Write("¿Presenta dolores de cabeza? (s/n): ");
                    char respuestaDoloresCabeza = Console.ReadLine()[0];
                    Console.Write("¿Falta de aire? (s/n): ");
                    char respuestaSedExcesiva = Console.ReadLine()[0];
                    



                    // Diagnóstico de Hipotension
                    if (condicionDiagnostico == null)
                    {
                        Console.Write("¿El paciente presenta confusión? (s/n): ");
                        char respuestaConfusionFrecuente = Console.ReadLine()[0];
                        Console.Write("¿Presenta piel fría y húmeda? (s/n): ");
                        char respuestaPielFria = Console.ReadLine()[0];
                        Console.Write("¿Presenta respiración superficial y rápida? (s/n): ");
                        char respuestaRespiracionSyR = Console.ReadLine()[0];
                        Console.Write("Presenta sangrados nasales? (s/n): ");
                        char respuestaSangradoNasal = Console.ReadLine()[0];


                    if (respuestaFiebre == 's')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    } 
                    else if (respuestaPielFria == 'n')
                    { 
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaConfusionFrecuente == 'n')
                    { 
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre"); 
                    }
                    else if (respuestaDoloresCabeza == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaRespiracionSyR == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaSangradoNasal == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaSedExcesiva == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }












                    if (respuestaConfusionFrecuente == 's')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaPielFria == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaConfusionFrecuente == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaDoloresCabeza == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaRespiracionSyR == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaSangradoNasal == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                    else if (respuestaSedExcesiva == 'n')
                    {
                        condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Fiebre");
                    }
                }

                    // Diagnóstico de Hipertensíón
                    if (condicionDiagnostico == null)
                    {
                        Console.Write("¿Aumento de la sed y de las ganas de orinar? (s/n): ");
                        char respuestaSedGanasOrinar = Console.ReadLine()[0];
                        Console.Write("¿Se siente cansado? (s/n): ");
                        char respuestaCansancio = Console.ReadLine()[0];



                        if (respuestaSedGanasOrinar == 's' && respuestaCansancio == 's')
                        {
                            condicionDiagnostico = condicionesMedicas.Find(c => c.Nombre == "Diabetes Tipo 2");
                        }
                    }




                    if (condicionDiagnostico != null)
                    {
                        Console.WriteLine($"Diagnóstico: {condicionDiagnostico.Nombre}");
                        Console.WriteLine($"Descripción: {condicionDiagnostico.Descripcion}");
                        Console.WriteLine($"Tratamiento: {condicionDiagnostico.Tratamiento}");
                        Console.WriteLine($"Indicaciones: {condicionDiagnostico.Indicaciones}");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo determinar un diagnóstico basado en las respuestas proporcionadas. Se le aconseja buscar ayuda médica profesional.");
                    }
                }
            }
        }
    }







