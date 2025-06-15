# ⚽ TPI | CLUB DEPORTIVO | GRUPO 9

![STATUS](https://img.shields.io/badge/Status-En%20Desarrollo-green)
![VS Code](https://img.shields.io/badge/IDE-Visual%20Studio-blueviolet?logo=visualstudio)
![C#](https://img.shields.io/badge/C%23-.NET-blueviolet?logo=csharp)
![MySQL](https://img.shields.io/badge/Database-MySQL-lightblue?logo=mysql)
![Git](https://img.shields.io/badge/Git-Control-red?logo=git)

#### **📍 Integrantes del GRUPO 9**

| Nº | Nombre y Apellido       | Comisión | Correo Electrónico            |
|----|-------------------------|----------|-------------------------------|
| 1  | Marcela Herrera         |    D     | mfh.jea1814@gmail.com         |
| 2  | Neyel Vilaseco          |    D     | neyelvilaseco@gmail.com       |
| 3  | Sebastián Puche         |    D     | sebasterco10@gmail.com        |
| 4  | Ailén Páez              |    D     | a.jorgelinapaez@gmail.com     |

-------------------------------------------------------------------------------

![UnionDesarrolloSoftware](https://pbs.twimg.com/media/Gque8-_XEAA2NBG?format=jpg&name=large)


***Este es el primer entregable de nuestro proyecto integrador de DSOO, con C# y conexión a base de datos MySQL.***

## 📁 Estructura general
 - ClubDeportivo/
    - Datos/
      - Actividades.cs
      - Clientes.cs
      - Conexion.cs
      - Cuotas.cs
      - NoSocios.cs
      - NoSocios_Actividades.cs
      - Socios.cs
      - Usuarios.cs
    - Documentacion/
      - ManualTecnico_ClubDeportivo.docx
      - ManualTecnico_ClubDeportivo.pdf
      - ManualUsuario_ClubDeportivo.docx
      - ManualUsuario_ClubDeportivo.pdf
    - Entidades/
      - CuotaConSocioDTO.cs
      - E_Actividad.cs
      - E_Cuota.cs
      - E_NoSocio.cs
      - E_Persona.cs
      - E_Socio.cs
      - E_Usuario.cs
    - Gui/
      - Carnet.cs
      - Cobros.cs
      - Comprobante.cs
      - ListadoVencimientos.cs
      - Login.cs
      - MenuPrincipal.cs
      - RegistroCliente.cs
    - Img/
    - ClubDeportivo.csproj
    - ClubDeportivo.sln
    - global.json
    - Program.cs
  - .gitignore
  - clubdeportivo.sql
  - README.md
----------------------------------------------------------------------------------------

## 🔹 Funcionalidades a entregar:

#### 📍 Login del Usuario: 

* El sistema permite el **inicio de sesión** mediante un formulario conectado a la base de datos.
* Se valida que los datos que ingresa el usuario coincidan con un usuario existente.
* En caso de datos incorrectos, se informa al usuario mediante una alerta.

#### 📍 Registro de Clientes: 
#### 📍 Cobros: 
#### 📍 Vencimiento de cuotas: 

---------------------------------------------------------------------------
## 🔹 Procesos del sistema: (estado al momento de la entrega)

| Proceso                          | Estado           |
|----------------------------------|------------------|
| Registro de socios               | 🟢 Activo        |
| Registro de no socios            | 🟢 Activo        |
| Pago de cuota mensual            | 🟢 Activo        |
| Pago por actividad               | 🟢 Activo        |
| Emisión de carnet                | 🟢 Activo        |
| Listado de vencimientos de cuota | 🟢 Activo        |
| Login de usuario                 | 🟢 Activo        |

---------------------------------------------------------------------------
## 🔹 Clases principales del sistema

| Clase      | Atributos principales                                     |
|------------|-----------------------------------------------------------|
| Persona    | nombre, dni, fechaNacimiento, telefono, email             |
| Socio      | nroSocio, fechaInscripcion, activo, carnetFisico, etc.    |
| NoSocio    | idNoSocio                                                 |
| Cuota      | estado, fechaPago, fechaVencimiento, valor                |
| Actividad  | nombre, cupo, día, horario, arancel                       |

---------------------------------------------------------------------------
## 🔹 Prioridad y orden de los procesos en la construcción del sistema

⚠ ***Estos procesos se irán desarrollando a lo largo del trabajo del sistema, también se agregaran según futuros requerimientos.***

| Proceso                                  | Prioridad | Motivo de la prioridad                                  |
|------------------------------------------|-----------|---------------------------------------------------------|
| Login de usuario                         | Alta      | Necesario para acceder y ver los datos.                 |
| Acceso a la ventana principal del sistema| Alta      | Objetivo principal del entregable                       |
| Gestión de socios existentes             | Media     | Complementaria y posterior al alta de socios            |
| Validación y control de acceso           | Media     | Mejora la seguridad y consistencia del sistema          |
| Generación de reportes o listados        | Baja      | Funcionalidad complementaria                            |


---------------------------------------------------------------------------

## 🔹 Casos de uso

Los casos de uso se encuentran desarrollados en el documento entregado en las oficinas. Adjuntamos el link con todo el desarrollo de este proceso.

📍 [Desarrollo de Sistemas Orientado a Objetos - Grupo 9 | Comisión D](https://docs.google.com/document/d/11EGTQu7RfuVlG3PAYEG3ZxoX7xYTdSuf6Pp8_0kT8d0/edit?usp=sharing)


---------------------------------------------------------------------------
## ⚙️ Tecnologías utilizadas
[![My Skills](https://skillicons.dev/icons?i=cs,visualstudio,mysql,git,github)](https://skillicons.dev)
- **Lenguaje**: C#
- **IDE**: Visual Studio Community
- **Base de datos**: MySQL
- **Control de versiones**: Git/Github
