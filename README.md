# PruebaTecnica-IS
 --------
 
 Este proyecto es una prueba técnica para la empresa innovation strategies, por el cuál explico a continuación su estructura

----------

Definición
-----------
Tenemos una libreta de direcciones de teléfono que se encuentra en un fichero de texto, contienen nombres de personas, nombres de ciudades y números de teléfono tal que:

   Miguel Fernan | Tenerife | 971456789
   
   Cati Rier | Palma de Mallorca | 45673928
   
   Miguel Castán | Madrid | 2234234252
   
   Juan Padil | Lugo | 223432423
   
Se pide generar un fichero grande de texto sobre unas 200k registros y tener la posibilidad de buscar por nombre, apellidos, ciudad con las siguientes operaciones. Puedes usar [http://www.generatedata.com/]

Listar(texto) y buscar(texto, cuidad).

Para ello deberás escribir un programa que dado el fichero telefónico ejecute y responda a nuestras consultas. Recuerda que valoraremos la rapidez en la respuesta así que es necesario que busques la mejor forma de recorrer la libreta.

Estructura
----------

- __Controllers__ --> Encontramos la capa lógica de la aplicación e interpreta la acción del usuario con el modelo.
  * _PersonController_
      * _Index_ -> Controlalor parametrizado, lista y busca al mismo tiempo

- __Models__ --> En esta capa se encuentran los modelos de nuestra aplicación.
  * _Person_
  * _ErrorViewModel_
  * _PagedResultBase_
  * _PagedResult_ -> Clase devuleto por el controlador
  * _AFile_
  * _TextFile_ -> Clase encargada de gestionar ficheros **.txt**
  * _JsonFile_ -> Clase encargada de gestionar ficheros **.json**
  
- __Utils__ --> En ella encontramos los recursos que se han ido necesitando, todo ello para nutrir nuestra aplicación.
  * _dataset.txt_ -> Fichero telefónico de 200k registros
  * _dataset.json_ -> Fichero telefónico de 200k registros
  
- __ViewComponents__ --> Se ha creado para inyectar al PagedResultBase la paginación

- __View__ --> Es el directorio donde se ubican todas las vistas de la aplicación

Lógica
-------
__Leemos el fichero --> Lista de Objetos --> Aceptamos Peticiones --> Ejecutamos --> Mostramos__


Tecnologías Usadas
------------------
- __[Newtonsoft](<https://www.newtonsoft.com/json>)__
- __SDK de .NET Core 3.1__


Comentarios
------------
Con la gestión utilizada de lectura de ficheros telefónicos, podremos gestionar cualquier tipo de fichero telefónico con la siguiente estructura:

     Name        -> Nombre y apellidos de la persona, tipo: string,
     City        -> Nombre de la ciudad, tipo: string,
     PhoneNumber -> Número de teléfono, tipo: string
