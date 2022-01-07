# ProyectoWebNexos
Proyecto de la aplicacion web de Nexos

Esa es una aplicacion web .net Framework aplicando varias librerias de front con bootstrap, Kendo, Jquery.


Esa es la presentación inicial de la aplicacion, se visualiza la lista de Autores registrados
![imagen](https://user-images.githubusercontent.com/45147668/148486162-0654924c-6415-43ad-acc4-2d54fced8bd8.png)


Tiene la visualizacion de registro de Autores, se valida que el autor no tenga el mismo nombre, los campos son obligatorios, la fecha está implementada con datepicker de KendoUI, 
y el campo de correo electronico
![imagen](https://user-images.githubusercontent.com/45147668/148486559-fe4c5af3-47d6-4c73-bc7f-c16878ae5758.png)

al registrar los datos aparece el mensaje de validación para confirmar cambios, ese mensaje está implemetnado con Sweet alert

![imagen](https://user-images.githubusercontent.com/45147668/148486645-891738ea-d52e-4f2c-b60a-aefd6fca0209.png)

Es la confirmacion del registro del autor y fue exitoso al no existir el autor con el mismo nombre

![imagen](https://user-images.githubusercontent.com/45147668/148486787-6868b776-e6ff-439d-8ce1-3121badef98e.png)

Cuando es exitoso, se redirige a la vista de autores para confirmar el registro

![imagen](https://user-images.githubusercontent.com/45147668/148486895-12de4efc-758d-45c1-bf82-3bdc49cf09e7.png)


Ahora vamos por el lado de los libros

![imagen](https://user-images.githubusercontent.com/45147668/148486950-0503a9d7-1b6b-4b4a-bf32-f68a6f2fac2a.png)

Esa vista tiene la lista de los libros registrados, los campos para haer busquedas filtradas según titulo, nombre de autor y año.

Al hacer la busqueda por cada criterio se filtra la tabla, en esa caso con el título del libro

![imagen](https://user-images.githubusercontent.com/45147668/148487155-b42f8385-c751-4e8b-aa8c-80cb937f2cd1.png)

En ese caso, con el nombre del Autor.

![imagen](https://user-images.githubusercontent.com/45147668/148487307-89b89fb5-d8b4-4c60-9af8-3a2359415023.png)


Ahora vamos con el registro  del libro, tambien tiene validación de campos obligatorio, en el caso del campo año, se 
hizo la configuracion para implementar solo el año, el autor no se coloca el nombre, si no, el id del mismo.

![imagen](https://user-images.githubusercontent.com/45147668/148487542-00746012-ce40-438b-b561-be36ce83315f.png)


Al registrar el libro, se muestra la alerta de Swwt alert para confirmar el registro.
![imagen](https://user-images.githubusercontent.com/45147668/148487696-81f83ade-f125-4f61-b8f8-016e7d355eb3.png)

al aceptar, se muestra el mensaje exitoso si el autor existe.

![imagen](https://user-images.githubusercontent.com/45147668/148487755-43568d8b-cd2d-4f3b-9fc4-e47d3ff9e44b.png)

y se visualiza en el registro de los libros


![imagen](https://user-images.githubusercontent.com/45147668/148487858-3f2dfdf4-68f5-40d3-94dd-0770ca643e34.png)

en el registro se valida si el autor no existe y no se procede a hacer el cambio.
en ese caso colocamos el id inexistente de un autor.

![imagen](https://user-images.githubusercontent.com/45147668/148488080-52f8d2a6-f9e1-4223-af2b-1cdc4c295965.png)

se valida el numero maximo de libros permitidos por el autor, esa vez con el autor registrado.

![imagen](https://user-images.githubusercontent.com/45147668/148488165-98119a63-cc0a-4433-9aaa-02b880b9a667.png)

Eso sería todo para la presentación de la aplicación web











