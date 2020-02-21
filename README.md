# PruebaTecnica-IS
 --------
 
 Este proyecto es una prueba técnica para la empresa innovation strategies, por el cuál explico a continuación su estructura

----------

Estructura
----------

- __Controllers__ --> Encontramos la capa lógica de la aplicación e interpreta la acción del usuario con el modelo.
  * _PersonController_

- __Models__ --> En esta capa se encuntran los modelos de nuestra aplicación.
  * _Person_
  * _ErrorViewModel_
  * _PagedResultBase_
  * _PagedResult_
  
- __Utils__ --> En ella encontramos los recursos que se han ido necesitando, todo ello para nutrir más nuestra aplicación.
  * _ReadFile_ -> Clase diseñada para la lectura del fichero
  * _persons.json_
  
- __ViewComponents__ --> Se ha creado para inyectar al PagedResultBase la paginación en la View

- __View__ --> Es el directorio donde se ubican todas las Views

Lógica
-------
__Leemos el fichero --> Lista de Objetos --> Aceptamos Peticiones --> Ejecutamos --> Mostramos__


Tecnologías Usadas
------------------
- __[Newtonsoft](<https://www.newtonsoft.com/json>)__
