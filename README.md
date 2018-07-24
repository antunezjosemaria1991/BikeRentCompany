# BikeRentCompany

Bike company

## La clase bill posee la siguente estructura:

### Constructor:
**Bill(string name, string dir, string phone)**: requiere 3 argumentos obligatorios no null, no blank y no whitespaced

### Methods:
* **int Add(float amount, string desc, RentType type)**: Amount es la cantidad de horas/dias/semanas, desc esta relacionado al vehiculo y type es el modo de renta hora/dia/semana
**Return value**: devuelve la cantidad de elementos en lista.
* **void Remove(int Index)**: index >= 1 y ademas debe ser menor o igual a la cantidad de elementos agregados a bill. Remueve el elemento en esa posicion.
**Return value**: void. 

### Properties:
* **float SubTotal** *(read-only)*: retorna el total parcial de la factura.
* **float Discount** *(read-only)*: retorna la cantidad total descontada al cliente.
* **flota Total** *(read-only)*: retorna la cantidad neta a pagar por el cliente.
* **string Name** *(read-only)*: retorna a nombre de quien se encuentra la factura.
* **string Address** *(read-only)*: retorna la direccion proporcionada por el cliente.
* **string Contact** *(read-only)*: retorna el número de contacto proprocionado.

## La clase 'Rent' posee la siguente structura:

### Constructor:
**Rent(float amount, string desc, RentType type)**: amount debe ser > 0, desc debe ser != null

### Properties:
* **string Description** *(read-only)*: Descripcion del vehiculo.
* **RentType mode** *(read-only)*: Como esta siendo rentado.
* **float Amount** *(read-only)*: Cantidad de renta.
* **float SubTotal** *(read-only)*: Costo.

## Clase RentConst
Constantes utilizadas por las clases Rent y Bill, como son los porcentajes de Family Rent, tambien los costos de los modos de renta. 

