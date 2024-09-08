# WEB-APIs-Problema-2.3

## Crear proyecto Web API sobre .Net utilizando IDE Visual Studio. 

### La API debe contener:

- Un controlador llamado TemperaturaController.
  
- Una implementación de un patrón Singleton que exponga los
comportamientos de una un único objeto de tipo RegistroTemp que
represente el repositorio de temperaturas registradas.

- De cada temperatura se registran los datos: identificador IOT (int),
fechaHora (datetime) y valor (float).

Programación II Guía de estudio – U2 Pág. 3
- 1 método GET: que permita obtener todas las lecturas de temperatura
registradas. En caso de haber lecturas registradas, devolver una lista
vacía.
- 1 método GET/1: que permita obtener todas las lecturas de temperatura
enviadas por un dispositivo en particular (se recibe el número de
identificación IOT). En caso de haber lecturas registradas, devolver una
lista vacía.
- 1 método POST que permita registrar los datos de una temperatura. Se
devuelve siempre un mensaje de confirmación.
- Probar la API utilizando POSTMAN.
