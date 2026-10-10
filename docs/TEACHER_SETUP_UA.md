# Інструкція викладачу

## Перед першою сесією

1. Створити приватний репозиторій GitHub, наприклад `student-learning-hub`.
2. Розпакувати архів і завантажити **вміст** папки `student-learning-hub` у корінь репозиторію. Переконатися, що прихована папка `.devcontainer` збережена.
3. Надати студенту доступ як collaborator. Переконатися, що GitHub Codespaces дозволено для цього репозиторію та акаунта студента.
4. Один раз самостійно створити Codespace і перевірити `dotnet restore`, `dotnet build`, запуск, `/Courses`, port forwarding. За потреби виправити конфігурацію.
5. Надіслати студенту URL репозиторію і файл `docs/LAB_01_UA.md`. Перевірити, що заклад дозволяє доступ до GitHub, Codespaces, WebSocket connections і preview доменів.

## Обмеження часу

План: 4 години на тиждень за комп'ютером. Не вимагати інсталяції SDK, IDE, SQL Server або Docker на локальний ноутбук.

Важливо: Codespaces може використовувати ліміти compute/storage і має власні правила billing та inactivity timeout. Перевірити актуальні умови на GitHub до запуску. Зупиняти Codespace після кожної сесії. Для економії compute не тримати його запущеним між заняттями.

## Контроль і підтримка

- Перевіряти commits після кожної сесії.
- Оцінювати не лише код, а й пояснення routing/model binding.
- Не вимагати скріншотів, якщо доступ до preview заблокований.
- Не зберігати персональні чи чутливі дані у репозиторії.
- Наступні лабораторні продовжують той самий застосунок.

## Наступні лабораторні

2. Razor Views, Layout, Partial Views, Tag Helpers.
3. Input Models, form submission, Model Binding, DataAnnotations, ModelState.
4. Services, Dependency Injection, CRUD (спочатку in-memory).
5. EF Core + SQLite, migrations і persistence.

## Перевірка стартового стану

Очікується, що до лабораторної 1 `/Courses` працює, але `/Courses/Details/1` ще не має реалізованого action. Це навмисно. `Details.cshtml` є готовим шаблоном для завдання.
