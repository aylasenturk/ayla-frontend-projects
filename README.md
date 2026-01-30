# Ayla ŞENTÜRK - Frontend Component Showcase
<script src="https://platform.linkedin.com/badges/js/profile.js" async defer type="text/javascript"></script>

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![Accessibility](https://img.shields.io/badge/a11y-WCAG_2.1-green?style=for-the-badge)

---
<a id="lang"></a>
## Dil Seçimi / Language / Sprache

[English](#english) | [Deutsch](#deutsch)

---

## Türkçe

### Proje Hakkında

Bu çalışma, **bulud.de** web developer iş başvurum sürecinde tarafıma özel hazırlanmış, **22 interaktif bileşeni** ve profesyonel portfolyomu içeren bir **ASP.NET Core MVC** tabanlı web uygulamasıdır. Projem; **erişilebilirlik (WCAG 2.1)**, **responsive tasarım** ve **temiz kod mimarisi** prensipleriyle, istenildiği takdirde modern e-ticaret ve web uygulamalarının genel ihtiyaçlarına yönelik analizlere göre ölçeklenebilir yapıdadır. Böylece kurumsal ya da bireysel beklentiler için istenen çözümler, hızlı ve etkili bir şekilde oluşturulmaktadır.

Projemdeki iş parçacıklarını geliştirmemde, web tasarım bilgilerimi günümüzde giderek önem kazanan AI apps prompt engineering ile birleştirmemde katkı sağlayan, desteğini ne zaman istesem esirgemeyen değerli hocam Ufuk Bey'e, en önemlisi de iş başvurusu sürecimde Jr. seviye birisi olmama rağmen sabrını her zaman koruyan, aslında bir nevi hocam diyebileceğim Enes Can Ak Bey'e de teşekkürlerimi sunarım.

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

**bulud.de Web Developer Aday Projesi - Ayla Şentürk (Katkı sağlayan: Enes Can Ak)**

---
<a id="english"></a>
## English
[Choose Other Languages](#lang)
### About This Project

This project is an **ASP.NET Core MVC** web application specifically prepared for my **bulud.de** web developer job application, featuring **22 interactive components** and my professional portfolio. My project follows the principles of **accessibility (WCAG 2.1)**, **responsive design**, and **clean code architecture**, and is designed to be scalable according to the general needs of modern e-commerce and web applications when required. Thus, desired solutions for corporate or individual expectations can be created quickly and effectively.

I would like to express my gratitude to my dear mentor Ufuk Bey, who contributed to developing my project components and combining my web design knowledge with AI apps prompt engineering, which is becoming increasingly important today, and who never withheld his support whenever I needed it. Most importantly, I would also like to thank Enes Can Ak Bey, who always maintained his patience during my job application process despite me being a junior-level candidate, and whom I can actually call a mentor of mine.

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

**Web Developer Candidate Project for bulud.de - Ayla Şentürk (Contributed by Enes Can Ak)**

---
<a id="deutsch"></a>
## Deutsch
[Andere Sprachen auswählen](#lang)
### Über dieses Projekt

Dieses Projekt ist eine **ASP.NET Core MVC**-Webanwendung, die speziell für meine **bulud.de** Web-Developer-Bewerbung erstellt wurde und **22 interaktive Komponenten** sowie mein professionelles Portfolio enthält. Mein Projekt folgt den Prinzipien der **Barrierefreiheit (WCAG 2.1)**, des **Responsive Designs** und der **sauberen Code-Architektur** und ist bei Bedarf entsprechend den allgemeinen Anforderungen moderner E-Commerce- und Webanwendungen skalierbar. So können gewünschte Lösungen für unternehmerische oder individuelle Erwartungen schnell und effektiv erstellt werden.

Ich möchte meinem geschätzten Mentor Ufuk Bey meinen Dank aussprechen, der zur Entwicklung meiner Projektkomponenten beigetragen und mir geholfen hat, mein Webdesign-Wissen mit AI Apps Prompt Engineering zu verbinden, das heutzutage immer wichtiger wird, und der mir seine Unterstützung nie verwehrt hat, wann immer ich sie brauchte. Vor allem möchte ich auch Enes Can Ak Bey danken, der während meines Bewerbungsprozesses trotz meines Junior-Levels stets Geduld bewahrt hat und den ich eigentlich als meinen Mentor bezeichnen kann.

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

**Web-Developer-Bewerbungsprojekt für bulud.de - Ayla Şentürk (Mitwirkung: Enes Can Ak)**

---

## Lisans / License / Lizenz

MIT License - Detaylar için [LICENSE](LICENSE) dosyasına bakın.

---

<div align="center">

**Ayla Şentürk** | [GitHub](https://github.com/aylasenturk)

</div>
