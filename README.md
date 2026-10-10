# Student Learning Hub | ASP.NET Core MVC

A browser-first progressive lab project for a student with **two 2-hour computer sessions per week** and no permission to install software locally.

## Start in GitHub Codespaces

1. Teacher creates a **private GitHub repository** and uploads all files, including the hidden `.devcontainer` directory.
2. Teacher grants the student repository access. The student needs a GitHub account and access to Codespaces.
3. In the GitHub repository choose **Code → Codespaces → Create codespace on main**.
4. Wait for the environment to finish building. Open **Terminal** and run:

   ```bash
   dotnet run --urls http://0.0.0.0:5000
   ```

5. In the **Ports** tab, open port **5000** in the browser. Keep the forwarded port **private**.
6. Stop the running app with `Ctrl+C` before ending the session. **Commit and push** your changes, then **Stop Codespace** from GitHub. Do not delete it.

If port forwarding is unavailable on the facility network, code editing and compilation may still work, but browser preview may not.

## What is already implemented?

- .NET 10 MVC application, without a database or third-party NuGet dependencies.
- Home page and Courses list.
- `Course` model and sample in-memory data.
- `Details.cshtml` view, ready for Lab 1.

## First lab

Read [`docs/LAB_01_UA.md`](docs/LAB_01_UA.md). Complete the `TODO LAB 1` markers in `Controllers/CoursesController.cs` and `Views/Courses/Index.cshtml`.

## End-of-session checklist

- [ ] `dotnet build` succeeds.
- [ ] Test required URLs, if preview access is available.
- [ ] Commit changes with a meaningful message.
- [ ] Push changes to GitHub.
- [ ] Stop Codespace to avoid using compute time.

## Technical note

The starter was prepared for **.NET 10**. The supplied project files have not been executed or compiled in this environment because the .NET SDK is not installed here. Run `dotnet build` in Codespaces during the first session.
