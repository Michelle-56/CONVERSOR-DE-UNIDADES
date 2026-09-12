Este proyecto consiste en un programa sencillo de consola desarrollado en C#,
cuya función es realizar conversiones básicas de temperatura y distancia.
El usuario puede seleccionar una opción desde un menú y realizar varias
conversiones hasta decidir finalizar el programa.

Opciones disponibles
Convertir Celsius a Fahrenheit
Convertir Fahrenheit a Celsius
Convertir kilómetros a millas
Convertir millas a kilómetros
Salir del programa


Instrucciones para ejecutarlo
- Primero, descarga o clona el repositorio en tu computadora.
- Abre el proyecto utilizando Visual Studio Community .
- Verifica que el archivo Program.cs se encuentre dentro del proyecto.
- Ejecuta el programa presionando F5. También puedes utilizar Ctrl + F5 si prefieres ejecutar la aplicación sin que la ventana de la consola se cierre automáticamente.
- Al iniciar, aparecerá el menú principal. Escribe el número correspondiente a la conversión que deseas realizar y presiona Enter.
Cuando el programa solicite un valor, introduce la cantidad utilizando números, por ejemplo: 25 o 98.6.
Si deseas terminar la ejecución, selecciona la opción 5.

Manejo de errores

--también cuenta con una validación para evitar que se cierre 
cuando se introduce información incorrecta. Si se escribe un dato que no 
corresponde a un número, aparecerá el mensaje "Valor inválido." y el programa
volverá a mostrar el menú.

-- si se selecciona un número que no corresponde a ninguna
de las opciones disponibles, se mostrará "Opción no válida." y podrás
continuar utilizando el conversor normalmente.
