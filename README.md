# apiPrueba

Prueba técnica de Api web desarrollada en .net 6 utilizando el patrón de diseño Repository y Unit of Work, se implementó JWT (JSON Web Token) para la autentificación de usuario, se realiza un CRUD para la entidad persona donde se lista todos los registros de la entidad, se puede ver a detalle cada registro, modificar o eliminar, en la entidad usuario se permite ver los registros y crear usuarios, por el lado de cliente se implemento angular 15 y angular material para el desarrollo de componentes, se implementó los guatd, servicio de autenticación y un interceptor para guardar el token recibido desde la api, para la base de datos se uso SQL Server 2019.


### Ejecución de Proyecto

-	Contar con SDK de .net 6
-	NodeJS versión 18.12.1
-	CLI de angular 15.0.4


En la carpeta DataBase se encuentra el script y backup de la base de datos con unos registros de prueba, un usuario: username y contraseña: password, se puede ejecutar ambos proyectos desde consola (api .net: dotnet run) (api Angular: npm start) pero antes en el proyecto angular se debe restaurar el paquete node con npm install.