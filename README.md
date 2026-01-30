# Ayla ŞENTÜRK - Frontend Component Showcase

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![Accessibility](https://img.shields.io/badge/a11y-WCAG_2.1-green?style=for-the-badge)

---

## Dil Seçimi / Language / Sprache

[Türkçe](#-türkçe) | [English](#-english) | [Deutsch](#-deutsch)

---

## Türkçe

### Proje Hakkında

Bu çalışma, **bulud.de** başvuru süreci için özel olarak hazırlanmış, **22 interaktif bileşeni** ve profesyonel portfolyomu içeren bir **ASP.NET Core MVC** uygulamasıdır. Proje; **erişilebilirlik (WCAG 2.1)**, **responsive tasarım** ve **temiz kod mimarisi** prensipleriyle, modern e-ticaret ve web uygulaması ihtiyaçlarına yönelik ölçeklenebilir çözümler sunar.

### Teknoloji Yığını

| Katman | Teknoloji |
|--------|-----------|
| **Backend** | ASP.NET Core MVC (.NET 8) |
| **Frontend** | Razor Views, Vanilla JavaScript (ES6+) |
| **UI Framework** | Sneat Bootstrap 5 Admin Template |
| **İkonlar** | Boxicons |
| **Veri Depolama** | LocalStorage / SessionStorage |

### Proje Yapısı

```
AylaSenturk.Portfolio/
├── Controllers/
│   ├── PortfolioController.cs    (Ana Sayfa, Projeler, Makaleler, İletişim, CV)
│   ├── ToolsController.cs        (Pomodoro, Görev Takipçisi, Tarih Seçici, vb.)
│   ├── ComponentsController.cs   (UI Bileşenleri)
│   └── ApiController.cs          (GitHub, Reddit, Trafik Malzemeleri)
├── Views/
│   ├── Portfolio/    (5 sayfa)
│   ├── Tools/        (5 sayfa)
│   ├── Components/   (9 sayfa)
│   └── Api/          (3 sayfa)
└── wwwroot/          (Statik dosyalar)
```

### Sayfa Kategorileri

| Kategori | Sayfalar |
|----------|----------|
| **Portfolio** | Ana Sayfa, Projeler, Makaleler, İletişim, Özgeçmiş |
| **Araçlar** | Pomodoro Zamanlayıcı, Görev Takipçisi, Tarih Seçici, Sıcaklık Dönüştürücü, Yaş Hesaplayıcı |
| **Bileşenler** | Bilgi Kartları, Sekmeler, Tooltip, Metin Alanı, Çerez Onayı, Erişilebilir Form, Dijital Kimlik, Referans Kartları, Değişiklik Günlüğü |
| **API Entegrasyonları** | GitHub Rastgele Depo, Reddit İstemcisi, Trafik Malzemeleri Kataloğu |

### Kurulum

```bash
# Projeyi klonlayın
git clone https://github.com/aylasenturk/ayla-frontend-projects.git

# Proje dizinine gidin
cd ayla-frontend-projects

# Bağımlılıkları yükleyin
dotnet restore

# Uygulamayı çalıştırın
dotnet run

# Tarayıcıda açın
# http://localhost:5055
```

### Özellikler

- WCAG 2.1 erişilebilirlik standartlarına uygunluk
- ARIA etiketleri ve klavye navigasyonu desteği
- Responsive tasarım (mobil uyumlu)
- Türkçe arayüz
- LocalStorage ile veri kalıcılığı
- GitHub ve Reddit API entegrasyonları

**bulud.de Web Developer Aday Projesi - Ayla Şentürk (Katkı sağlayan: Enes Can Atak)**

---

## English

### About This Project

This repository is an **ASP.NET Core MVC** application featuring **22 interactive components** and a professional portfolio, specifically developed for the **bulud.de** application process. It emphasizes **accessibility (WCAG 2.1)**, **responsive design**, and **clean code architecture**, providing scalable solutions for modern e-commerce and web platforms.

### Technology Stack

| Layer | Technology |
|-------|------------|
| **Backend** | ASP.NET Core MVC (.NET 8) |
| **Frontend** | Razor Views, Vanilla JavaScript (ES6+) |
| **UI Framework** | Sneat Bootstrap 5 Admin Template |
| **Icons** | Boxicons |
| **Data Storage** | LocalStorage / SessionStorage |

### Project Structure

```
AylaSenturk.Portfolio/
├── Controllers/
│   ├── PortfolioController.cs    (Home, Projects, Articles, Contact, Resume)
│   ├── ToolsController.cs        (Pomodoro, Task Tracker, Date Picker, etc.)
│   ├── ComponentsController.cs   (UI Components)
│   └── ApiController.cs          (GitHub, Reddit, Traffic Materials)
├── Views/
│   ├── Portfolio/    (5 pages)
│   ├── Tools/        (5 pages)
│   ├── Components/   (9 pages)
│   └── Api/          (3 pages)
└── wwwroot/          (Static files)
```

### Page Categories

| Category | Pages |
|----------|-------|
| **Portfolio** | Home, Projects, Articles, Contact, Resume |
| **Tools** | Pomodoro Timer, Task Tracker, Date Picker, Temperature Converter, Age Calculator |
| **Components** | Flashcards, Tabs, Tooltip, Textarea, Cookie Consent, Accessible Form, Digital ID, Reference Cards, Changelog |
| **API Integrations** | GitHub Random Repo, Reddit Client, Traffic Materials Catalog |

### Installation

```bash
# Clone the repository
git clone https://github.com/aylasenturk/ayla-frontend-projects.git

# Navigate to project directory
cd ayla-frontend-projects

# Restore dependencies
dotnet restore

# Run the application
dotnet run

# Open in browser
# http://localhost:5055
```

### Features

- WCAG 2.1 accessibility compliance
- ARIA labels and keyboard navigation support
- Responsive design (mobile-friendly)
- Turkish interface
- Data persistence with LocalStorage
- GitHub and Reddit API integrations

**Web Developer Candidate Project for bulud.de - Ayla Şentürk (Contributed by Enes Can Atak)**

---

## Deutsch

### Über dieses Projekt

Dieses Repository ist eine **ASP.NET Core MVC**-Anwendung mit **22 interaktiven Komponenten** und einem professionellen Portfolio, das speziell für den Bewerbungsprozess bei **bulud.de** erstellt wurde. Der Fokus liegt auf **Barrierefreiheit (WCAG 2.1)**, **Responsive Design** und **sauberer Code-Architektur**, um skalierbare Lösungen für moderne E-Commerce-Plattformen zu bieten.

### Technologie-Stack

| Schicht | Technologie |
|---------|-------------|
| **Backend** | ASP.NET Core MVC (.NET 8) |
| **Frontend** | Razor Views, Vanilla JavaScript (ES6+) |
| **UI-Framework** | Sneat Bootstrap 5 Admin Template |
| **Icons** | Boxicons |
| **Datenspeicherung** | LocalStorage / SessionStorage |

### Projektstruktur

```
AylaSenturk.Portfolio/
├── Controllers/
│   ├── PortfolioController.cs    (Startseite, Projekte, Artikel, Kontakt, Lebenslauf)
│   ├── ToolsController.cs        (Pomodoro, Aufgabenverfolgung, Datumsauswahl, usw.)
│   ├── ComponentsController.cs   (UI-Komponenten)
│   └── ApiController.cs          (GitHub, Reddit, Verkehrsmaterialien)
├── Views/
│   ├── Portfolio/    (5 Seiten)
│   ├── Tools/        (5 Seiten)
│   ├── Components/   (9 Seiten)
│   └── Api/          (3 Seiten)
└── wwwroot/          (Statische Dateien)
```

### Seitenkategorien

| Kategorie | Seiten |
|-----------|--------|
| **Portfolio** | Startseite, Projekte, Artikel, Kontakt, Lebenslauf |
| **Werkzeuge** | Pomodoro-Timer, Aufgabenverfolgung, Datumsauswahl, Temperaturumrechner, Altersrechner |
| **Komponenten** | Lernkarten, Tabs, Tooltip, Textbereich, Cookie-Zustimmung, Barrierefreies Formular, Digitale ID, Referenzkarten, Änderungsprotokoll |
| **API-Integrationen** | GitHub Zufälliges Repository, Reddit-Client, Verkehrsmaterialien-Katalog |

### Installation

```bash
# Repository klonen
git clone https://github.com/aylasenturk/ayla-frontend-projects.git

# Zum Projektverzeichnis wechseln
cd ayla-frontend-projects

# Abhängigkeiten wiederherstellen
dotnet restore

# Anwendung starten
dotnet run

# Im Browser öffnen
# http://localhost:5055
```

### Funktionen

- WCAG 2.1 Barrierefreiheit-Konformität
- ARIA-Labels und Tastaturnavigation
- Responsive Design (mobilfreundlich)
- Türkische Benutzeroberfläche
- Datenpersistenz mit LocalStorage
- GitHub- und Reddit-API-Integrationen

**Web-Developer-Bewerbungsprojekt für bulud.de - Ayla Şentürk (Mitwirkung: Enes Can Atak)**

---

## Lisans / License / Lizenz

MIT License - Detaylar için [LICENSE](LICENSE) dosyasına bakın.

---

<div align="center">

**Ayla Şentürk** | [GitHub](https://github.com/aylasenturk)

</div>
