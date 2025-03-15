# Sistema de Gestión para Carnicería

## Descripción
Este proyecto es una aplicación de escritorio desarrollada en **C# con WinForms**, diseñada para la gestión de ventas y stock en una carnicería, en donde se implementan principios de **POO**, **colecciones**, **herencia** y **polimorfismo**.

## Funcionalidades
- **Gestión de Usuarios:**
  - Login con correo y contraseña.
  - Diferenciación entre usuarios **Vendedor** y **Cliente**.
  - Completar automáticamente datos de usuario para agilizar el login.

- **Manejo de Productos y Stock:**
  - Listado y detalles de productos.
  - Reposición de stock (solo vendedores).
  - Configuración de precios por kilo y tipos de cortes.
  - Validación de disponibilidad antes de la venta.

- **Proceso de Venta:**
  - Validación de stock y capacidad de pago del cliente.
  - Búsqueda de productos por nombre.
  - Recargo del 5% por pago con tarjeta de crédito.
  - Confirmación de compra con generación de factura.
  - Modal de confirmación de venta.
  - Guardado del historial de ventas en archivo de texto.

- **Interfaz y Experiencia de Usuario:**
  - Aplicación distribuida en **mínimo 3 formularios**.
  - Controles intuitivos y navegación sencilla.
  - Personalización visual (sin colores ni iconos por defecto).
  - Reutilización de formularios siempre que sea posible.

- **Características Técnicas:**
  - **Clases y métodos estáticos** para optimización del código.
  - **Sobrecarga de métodos** para flexibilidad en la gestión de datos.
  - **Encapsulamiento y Polimorfismo** aplicados en la arquitectura.
  - **Enumerados** para clasificación de productos y roles de usuario.
  - **Colecciones** para almacenar y gestionar datos de clientes y productos.
  - **Control de Excepciones**, incluyendo al menos una excepción personalizada.
  - **Pruebas Unitarias** con un mínimo de 3 tests.
  - **Tipos Genéricos** para mejorar la flexibilidad del código.
  - **Interfaces** para definir contratos reutilizables.
  - **Serialización y Deserialización en JSON y XML** de productos.
  - **Implementación de CRUD** con base de datos (crear, leer, actualizar y borrar).
  - **Autenticación con base de datos**, contrastando credenciales en el login.
  - **Delegados y eventos** para mejorar la interacción entre componentes.
  - **Programación Multihilo y Concurrencia** para optimización de tareas.
  - **Métodos de Extensión**, con al menos dos implementaciones.

