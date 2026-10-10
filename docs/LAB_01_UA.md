# Лабораторна робота № 1. Controllers & Actions. Routing

**Проєкт:** Student Learning Hub  
**Тривалість:** 2 заняття по 2 години  
**Технології:** ASP.NET Core MVC, C#, Razor, GitHub Codespaces

## Мета

Навчитися розрізняти Controller та Action, приймати route/query parameters, повертати View і NotFound, використовувати conventional routing та генерувати посилання за допомогою Tag Helpers.

## Що вже готово

`CoursesController` містить метод `Index()` і список із трьох курсів. `Views/Courses/Index.cshtml` відображає цей список. `Views/Courses/Details.cshtml` уже створено, але відповідного action ще немає.

## Сесія 1. Контролери та параметри (до 120 хв)

Відкрити Codespace. Виконати `dotnet build`, запустити застосунок, відкрити `/Courses`.

**Завдання 1.** Реалізувати `Details(int id)` у `CoursesController`:

- знайти курс за `Id` у наявному списку;
- якщо курс відсутній, повернути `NotFound()`;
- інакше повернути `View(course)`.

Перевірити `/Courses/Details/1` та `/Courses/Details/999`.

**Завдання 2.** У `Views/Courses/Index.cshtml` додати посилання **Details** для кожного курсу за допомогою `asp-controller`, `asp-action`, `asp-route-id`. Не прописувати URL вручну.

**Завдання 3.** Реалізувати `ByDuration(int minWeeks)`, який повертає `View("Index", filteredCourses)`, де залишаються курси тривалістю не менше `minWeeks`. Перевірити `/Courses/ByDuration?minWeeks=8`.

`dotnet build`, commit `lab1: implement details and duration filter`, push, Stop Codespace.

## Сесія 2. Attribute routing і перевірка (до 120 хв)

Відкрити Codespace. Перевірити збережені зміни.

**Завдання 4.** Додати новий action, який обробляє `GET /catalog/{id:int}` за допомогою `[HttpGet("/catalog/{id:int}")]`. Він має знайти курс за `id`, повернути `NotFound()` для невідомого курсу або `View("Details", course)` для знайденого.

**Завдання 5.** Перевірити маршрути:

| URL | Очікуваний результат |
|---|---|
| `/Courses` | список 3 курсів |
| `/Courses/Details/1` | сторінка першого курсу |
| `/Courses/Details/999` | HTTP 404 |
| `/Courses/ByDuration?minWeeks=8` | 2 курси |
| `/catalog/2` | сторінка другого курсу |
| `/catalog/abc` | не відповідає маршруту з `int` constraint |

`dotnet build`, фінальний commit, push, Stop Codespace.

## Підготовка без комп'ютера

Перед сесією 1 прочитати теми Controllers & Actions і Routing. На папері написати сигнатури `Details(int id)` і `ByDuration(int minWeeks)`, продумати логіку `NotFound()` та приклад посилання з `asp-route-id`.

Перед сесією 2 записати route template `/catalog/{id:int}`, пояснити різницю між `/catalog/2` і `/catalog/abc` та підготувати відповіді для звіту.

## Увага

Не створювати новий проєкт. Не змінювати `.devcontainer` та `.csproj` без потреби. Усі зміни зберігати у Git. Якщо preview заблокований мережею, зафіксувати це у звіті та перевірити хоча б `dotnet build`.
