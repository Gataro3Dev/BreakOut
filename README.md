🎮 Breakout 2D — Unity 6

Un juego tipo arcade desarrollado en Unity 6 con físicas, Game Manager modular, clases reutilizables y efectos visuales.

Este proyecto recrea el clásico Breakout con un enfoque moderno y educativo, ideal para aprender los principios del desarrollo 2D en Unity: física, colisiones, arquitectura limpia, manejo de estados y retroalimentación visual.

📌 Características Principales

🔵 Pelota con físicas reales usando el motor de Unity 6.

🧱 Sistema modular de ladrillos con clases heredadas para variantes (puntos, resistencia, efectos, etc.).

🎮 Game Manager centralizado para manejar:

Estados del juego (inicio, victoria, derrota).

Sistema de puntaje.

Reinicio y flujo general del gameplay.

👁️ Efectos de partículas al romper ladrillos y perder la pelota.

📐 Diseño 2D limpio y escalable (object hierarchy bien organizada).

🔊 Integración opcional de sonidos para colisiones y eventos.

📱 Preparado para PC y expansión a móviles.

🛠️ Tecnologías Utilizadas
Tecnología	Uso
Unity 6 (2023 LTS o superior)	Motor del juego
C#	Lógica y scripts
Particle System de Unity	Efectos visuales
🧩 Requisitos Previos

Unity 2023 LTS / Unity 6.

📥 Instalación del Proyecto
✅ Opción A — Clonar desde GitHub
git clone https://github.com/TU_USUARIO/breakout-unity.git
cd breakout-unity
git lfs pull   # si usas Git LFS

Descomprime y abre la carpeta en Unity.

📂 Estructura del Proyect

📁 Assets/
├── 📁 Materials/
├── 📁 Prefabs/
├── 📁 Scenes/
├── 📁 Scripts/
├── 📁 Settings/
└── 📁 InputSystem_Actions/

README.md
.gitignore
.gitattributes

▶️ Cómo Ejecutar el Juego

Abre Unity 6.

Carga la carpeta raíz del proyecto.

Ve a la carpeta Scenes/.

Abre MainScene.unity.

Presiona Play.

🎮 Controles (PC)
Acción	Tecla
Mover la paleta	← →
Iniciar partida	Barra espaciadora
Reiniciar	R
🧠 Lógica Principal del Juego
1. Ball.cs

Movimiento usando Rigidbody2D.

Rebotes controlados por vectores normalizados.

Reinicio automático al salir del mapa.

2. Paddle.cs

Movimiento horizontal basado en input.

Límites del escenario.

3. GameManager.cs

Maneja:

Puntuación.

Pérdida de vidas.

Estados: Playing, Win, Game Over.

4. Brick.cs

Clase base con puntos y vida.

Eventos al romperse (partículas + puntaje).

🧪 Escenarios Incluidos

MainScene
Escena base con:

Paleta

Pelota

Mapa de ladrillos

Interfaz de puntaje

Control y feedback visual

🛠️ Desarrollo y Buenas Prácticas
Estándares utilizados:

Clases limpias y enfocadas (Single Responsibility).

Prefabs reutilizables.

Organización por carpetas estándar de Unity.

No se almacenan objetos temporales (Library/, Logs/, etc.).


🧰 Problemas Comunes
❗ La pelota no rebota correctamente

Revisa que tenga Rigidbody2D + Collider2D.

Activa “Continuous Collision Detection” si es muy rápida.

❗ No detecta colisiones con ladrillos

Verifica que ambos objetos tengan collider.

Comprueba que al menos uno tenga Rigidbody2D.

❗ Todo aparece muy grande o muy pequeño

Ajusta Pixels Per Unit de los sprites.

Ajusta escala de cámara en modo 2D.

⚡ Próximas Mejoras (Opcional)

Power-ups (agrandar paleta, multiplicar pelotas).

Sonidos personalizados.

Multiples niveles.

Menú principal.

Guardado de score máximo.

📜 Licencia

licencia MIT
