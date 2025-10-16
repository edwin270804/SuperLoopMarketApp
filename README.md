<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>SuperLoopMarketApp - README</title>
  <style>
    body {
      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
      background-color: #f9fafb;
      color: #222;
      margin: 40px;
      line-height: 1.6;
    }
    h1, h2, h3 {
      color: #0d6efd;
    }
    h1 {
      text-align: center;
      font-size: 2.2em;
      margin-bottom: 0.5em;
    }
    hr {
      border: none;
      border-top: 2px solid #0d6efd;
      margin: 20px 0;
    }
    ul {
      list-style: none;
      padding: 0;
    }
    ul li::before {
      content: "🔹 ";
    }
    pre {
      background: #f4f4f4;
      padding: 15px;
      border-radius: 10px;
      overflow-x: auto;
      font-size: 0.9em;
    }
    code {
      background: #eef;
      padding: 2px 5px;
      border-radius: 5px;
    }
    a {
      color: #0d6efd;
      text-decoration: none;
    }
    a:hover {
      text-decoration: underline;
    }
    .footer {
      text-align: center;
      margin-top: 40px;
      font-size: 0.9em;
      color: #555;
    }
  </style>
</head>
<body>

  <h1>🛒 SuperLoopMarketApp</h1>
  <p>
    <strong>SuperLoopMarketApp</strong> es una aplicación de gestión de inventario y ventas para supermercados, 
    desarrollada en <strong>C#</strong> con <strong>Windows Forms</strong>. 
    Permite controlar productos, clientes y generar reportes con una interfaz moderna y funcional.
  </p>

  <hr>

  <h2>🏷️ Características principales</h2>
  <ul>
    <li>Gestión de productos (alta, baja, edición)</li>
    <li>Control de clientes (registro, edición, eliminación)</li>
    <li>Procesamiento de ventas y control de stock</li>
    <li>Reportes e indicadores de ventas</li>
    <li>Interfaz moderna con <code>Guna.UI2.WinForms</code></li>
  </ul>

  <hr>

  <h2>🛠 Tecnologías utilizadas</h2>
  <ul>
    <li>Lenguaje: <code>C#</code></li>
    <li>Framework: <code>.NET Framework / WinForms</code></li>
    <li>UI: <code>Guna.UI2.WinForms</code></li>
    <li>Base de datos: <em>SQL Server</em></li>
    <li>Acceso a datos: <em>ADO.NET</em></li>
  </ul>

  <hr>

  <h2>📁 Estructura del proyecto</h2>
  <pre>
SuperLoopMarketApp/
 ├─ Guna.UI2.WinForms/
 ├─ Formularios/
 ├─ Clases/
 ├─ Resources/
 ├─ bin/
 ├─ obj/
 ├─ parametrosconexion.cs
 ├─ App.config
 └─ Program.cs
  </pre>

  <hr>

  <h2>⚙️ Instalación y configuración</h2>
  <ol>
    <li>Clonar el repositorio:
      <pre><code>git clone https://github.com/edwin270804/SuperLoopMarketApp.git</code></pre>
    </li>
    <li>Abrir el proyecto en <strong>Visual Studio</strong>.</li>
    <li>Restaurar los paquetes NuGet si es necesario.</li>
    <li>Configurar la conexión a la base de datos en <code>App.config</code> o en <code>parametrosconexion.cs</code>.</li>
    <li>Compilar y ejecutar la aplicación.</li>
  </ol>

  <hr>

  <h2>🚀 Uso</h2>
  <ol>
    <li>Iniciar sesión o acceder a la aplicación.</li>
    <li>Registrar productos o clientes.</li>
    <li>Realizar ventas seleccionando los productos y cantidades.</li>
    <li>Visualizar reportes e informes de ventas.</li>
  </ol>

  <hr>

  <h2>📷 Capturas de pantalla</h2>
  <p>Puedes agregar imágenes de tu interfaz aquí, por ejemplo:</p>
  <pre>![Interfaz principal](ruta/a/imagen.png)</pre>

  <hr>

  <h2>🧩 Futuras mejoras</h2>
  <ul>
    <li>Autenticación por roles (Administrador / Cajero)</li>
    <li>Modo oscuro y personalización visual</li>
    <li>Exportar reportes a PDF o Excel</li>
    <li>Historial de ventas detallado</li>
    <li>Soporte multilenguaje</li>
  </ul>

  <hr>

  <h2>👨‍💻 Autor</h2>
  <p>
    <strong>Edwin Segura</strong><br>
    <a href="https://github.com/edwin270804" target="_blank">Perfil de GitHub</a><br>
    📧 edwin270804@example.com
  </p>

  <hr>

  <h2>📄 Licencia</h2>
  <p>
    Este proyecto está bajo la licencia <strong>MIT</strong>.  
    Consulta el archivo <a href="LICENSE">LICENSE</a> para más detalles.
  </p>

  <div class="footer">
    © 2025 SuperLoopMarketApp — Creado por Edwin Segura
  </div>

</body>
</html>
