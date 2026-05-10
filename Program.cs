var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => Results.Content("""
    <html>
    <head>
        <title>ApiWebAnalisis</title>
        <style>
            body { font-family: Arial; background-color: #f0f4f8; display: flex; justify-content: center; padding: 60px; }
            .card { background: white; padding: 40px; border-radius: 10px; box-shadow: 0 2px 10px rgba(0,0,0,0.1); max-width: 500px; width: 100%; }
            h1 { color: #2c3e50; }
            p { color: #555; }
            .badge { background: #27ae60; color: white; padding: 4px 12px; border-radius: 20px; font-size: 13px; }
            a { display: inline-block; margin-top: 20px; color: #2980b9; text-decoration: none; font-weight: bold; }
            a:hover { text-decoration: underline; }
        </style>
    </head>
    <body>
        <div class="card">
            <span class="badge">✔ Online</span>
            <h1>ApiWebAnalisis</h1>
            <p>Servicio REST activo y disponible para recibir solicitudes.</p>
            <p><strong>Endpoints disponibles:</strong></p>
            <a href="/datos">GET /datos</a>
        </div>
    </body>
    </html>
    """, "text/html"));

app.MapGet("/datos", () => new
{
    sistema = "ApiWebAnalisis",
    estado = "activo",
    version = "1.0.0",
    timestamp = DateTime.Now
});

app.Run();