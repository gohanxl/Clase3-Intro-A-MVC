# Tercer Clase de Práctica "Intro A MVC"

En esta clase vimos:
1. Cambiar el RouteConfig.cs para asignar otra pagina de inicio /Bienvenido/Index
2. Agregamos otra regla de ruteo para aceptar las urls Bienvenido/{action}/{nombre1}/{nombre2} y creamos una acction /Bienvenido/SaludoGrupal/nombre1/nombre2 
3. Bindings:
	1. **Binding Manual:**
		1. Usando objeto **Request**
		2. Usando objeto **FormCollection**
	2. **Binding Automatico**
4. Armamos un **ABM sencillo de Empleados** utilizando una lista estática en la clase EmpleadoServicio.cs
	1. Dividimos la solucion en 3 capas fisicas **IntroMVC (web)**, **Servicios (biblioteca de clases)** y **Entidades (biblioteca de clases)**
	2. Creamos el controller EmpleadoController.cs en la carpeta /Controllers con las acciones
		1. **Crear** (con su respectiva vista /Views/Empleado/Crear.cshtml)
		2. **Lista** (con su respectiva vista /Views/Empleado/Lista.cshtml) con links a Crear y Eliminar 
		3. **Modificar** (con su respectiva vista /Views/Empleado/Modificar.cshtml)
		4. **Eliminar**
		
# Como Ejecutar
1. Abrir el archivo **IntroMVC.sln** con el Visual Studio
2. Click derecho en la solución, Restaurar paquetes de Nuget
3. F5