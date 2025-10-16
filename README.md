<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>SuperLoopMarketApp - README</title>
  <style>
    
    body {
      font-family: 'Poppins', sans-serif;
      background: linear-gradient(180deg, #f7f9fc 0%, #eef3f7 100%);
      color: #2c3e50;
      margin: 0;
      padding: 0;
    }

    header {
      background: linear-gradient(135deg, #007bff, #00b4d8);
      color: white;
      text-align: center;
      padding: 60px 20px;
      box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
    }

    header h1 {
      font-size: 2.8em;
      margin: 0;
    }

    header p {
      font-size: 1.2em;
      opacity: 0.9;
    }

    section {
      max-width: 1000px;
      margin: 60px auto;
      background: white;
      padding: 40px;
      border-radius: 20px;
      box-shadow: 0 8px 20px rgba(0, 0, 0, 0.05);
    }

    h2 {
      color: #007bff;
      border-left: 5px solid #00b4d8;
      padding-left: 10px;
      font-size: 1.6em;
      margin-top: 0;
    }

    ul {
      list-style: none;
      padding: 0;
    }

    ul li {
      background: #f0f8ff;
      margin: 8px 0;
      padding: 10px 15px;
      border-radius: 10px;
      transition: 0.3s;
    }

    ul li:hover {
      background: #dff3ff;
      transform: translateX(5px);
    }

    code, pre {
      background: #f4f4f4;
      padding: 8px 12px;
      border-radius: 10px;
      font-family: 'Courier New', monospace;
    }

    pre {
      overflow-x: auto;
    }

    a {
      color: #007bff;
      text-decoration: none;
      font-weight: bold;
    }

    a:hover {
      text-decoration: underline;
    }

    footer {
      text-align: center;
      padding: 20px;
      font-size: 0.9em;
      color: #555;
      background-color: #f5f7fa;
      margin-top: 60px;
      border-top: 2px solid #e5e9f0;
    }

    .tag {
      display: inline-block;
      background: #007bff;
      color: white;
      border-radius: 10px;
      padding: 2px 10px;
      font-size: 0.9em;
      margin-right: 8px;
    }

    .highlight {
      background: linear-gradient(90deg, #00b4d8, #007bff);
      color: white;
      padding: 3px 8px;
      border-radius: 6px;
      font-weight: bold;
    }

    @media (max-width: 700px) {
      section {
        margin: 20px;
        padding: 25px;
      }
      header h1 {
        font-size: 2em;
      }
    }
  </style>
</head>
<body>

  <header>
    <h1>🛒 SuperLoopMarketApp</h1>
    <p>Aplicación moderna de gestión para supermercados desarrollada en C#</p>
  </header>

  <section>
    <h2>🏷️ Descripción</h2>
    <p>
      <strong>SuperLoopMarketApp</strong> es una aplicación de escritorio creada para la 
      <span class="highlight">gestión completa de inventario, clientes y ventas</span> 
      en supermercados. Su diseño combina eficiencia y una interfaz visual moderna usando 
      <code>Guna.UI2.WinForms</code>.
    </p>
  </section>

  <section>
    <h2>🚀 Características principales</h2>
    <ul>
      <li>Gestión completa de productos (alta, baja y edición)</li>
      <li>Control de clientes con CRUD intuitivo</li>
      <li>Registro de ventas y cálculo automático de totales</li>
      <li>Reportes y estadísticas personalizadas</li>
      <li>Diseño moderno con <code>Guna.UI2</code></li>
    </ul>
  </section>

  <section>
    <h2>🧰 Tecnologías utilizadas</h2>
    <p>
      <span class="tag">C#</span>
      <span class="tag">.NET Framework</span>
      <span class="tag">Windows Forms</span>
      <span class="tag">SQL Server</span>
      <span class="tag">Guna.UI2</span>
      <span class="tag">iTextSharp (reportes)</span>
    </p>
  </section>

  <section>
    <h2>📦 Instalación y configuración</h2>
    <ol>
      <li>Clonar el repositorio:
        <pre><code>git clone https://github.com/edwin270804/SuperLoopMarketApp.git</code></pre>
      </li>
      <li>Abrir el proyecto en <strong>Visual Studio</strong>.</li>
      <li>Restaurar paquetes NuGet (si los hay).</li>
      <li>Configurar la cadena de conexión en <code>App.config</code> o <code>parametrosconexion.cs</code>.</li>
      <li>Ejecutar la aplicación.</li>
    </ol>
  </section>

  <section>
    <h2>💡 Uso</h2>
    <ol>
      <li>Inicia sesión o abre la aplicación.</li>
      <li>Registra productos y clientes.</li>
      <li>Realiza ventas y genera reportes automáticos.</li>
      <li>Consulta el historial de transacciones.</li>
    </ol>
  </section>

  <section>
    <h2>🔮 Próximas mejoras</h2>
    <ul>
      <li>Sistema de login con roles (administrador/cajero)</li>
      <li>Exportación de reportes a PDF y Excel</li>
      <li>Modo oscuro y temas personalizados</li>
      <li>Soporte multilenguaje</li>
      <li>Notificaciones y alertas visuales</li>
    </ul>
  </section>

  <section>
    <h2>👨‍💻 Autor</h2>
    <p>
      Desarrollado por <strong>Edwin Segura</strong><br>
      <a href="https://github.com/edwin270804" target="_blank">🌐 GitHub: edwin270804</a><br>
      📧 <a href="mailto edwin.moreno1184@gmail.com">edwin270804@example.com</a>
    </p>
  </section>

  <footer>
    © 2025 SuperLoopMarketApp — Creado con ❤️ por Edwin Segura
  </footer>

</body>
</html>
