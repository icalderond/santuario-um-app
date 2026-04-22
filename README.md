# SantuarioUM

## Overview

SantuarioUM is a cross-platform mobile application built with .NET MAUI that provides an educational experience about the biblical sanctuary. The app explores the sanctuary's structure, furniture, and symbolic significance in God's plan of salvation, drawing from biblical teachings and historical context.

## Features

- **Interactive Exploration**: Navigate through the three main areas of the sanctuary:
  - Atrio (Court)
  - Lugar Santo (Holy Place)
  - Lugar Santísimo (Most Holy Place)

- **Detailed Content**: Learn about each piece of sanctuary furniture including:
  - Altar del Sacrificio (Altar of Sacrifice)
  - Lavacro (Laver)
  - Mesa de los Panes (Table of Showbread)
  - Candelabro (Candlestick)
  - Altar del Incienso (Altar of Incense)
  - Arca del Pacto (Ark of the Covenant)

- **Liturgical Dimensions**: Each item includes explanations of its:
  - Rito (Ritual/Practice)
  - Cumplimiento (Fulfillment)
  - Aplicación (Application)

- **Rich Media**: Includes images and biblical references for each element

## Screenshots

📁 **[View Screenshots Folder](screenshots/)**

The `screenshots/` directory contains visual demonstrations of the app's interface. To view the screenshots:

1. Navigate to the [screenshots/](screenshots/) folder in this repository
2. Screenshots include:
   - App launch and splash screens
   - Main dashboard navigation
   - Article content views
   - Detailed sanctuary information displays

*Note: Screenshots are optimized for web display (400px width) to ensure fast loading. If screenshots are missing, run the app on an emulator and capture new images.*

## Architecture

The application follows the MVVM (Model-View-ViewModel) architectural pattern and is structured as follows:

- **Models**: Data structures for sanctuary information (`SantuarioData.cs`, `ItemMenu.cs`)
- **ViewModels**: Business logic and data binding (`ArticleViewModel.cs`, `DashViewModel.cs`, etc.)
- **Views/Pages**: XAML-based user interfaces (`ArticlePage.xaml`, `DashPage.xaml`, etc.)
- **Services**: Data access and navigation services (`SantuarioService.cs`, `NavigationService.cs`)
- **Utilities**: Enums, extensions, and interfaces for type safety and code organization

## Technology Stack

- **Framework**: .NET MAUI (Multi-platform App UI)
- **Language**: C# with XAML
- **Target Platforms**: Android (primary), iOS, macOS, Windows
- **Data Format**: JSON for content storage
- **Architecture**: MVVM pattern

## Project Structure

```
SantuarioUM/
├── Models/           # Data models
├── ViewModels/       # MVVM view models
├── Views/           # XAML views
├── Pages/           # XAML pages
├── Services/        # Business logic services
├── Utilities/       # Enums, extensions, interfaces
├── Resources/       # Images, fonts, raw data
│   └── Raw/
│       └── santuario_data_large.json  # Sanctuary content data
└── Platforms/       # Platform-specific code
```

## Getting Started

### Prerequisites

- .NET 10.0 SDK
- Visual Studio 2022 or Rider with MAUI workload
- Android SDK (for Android development)

### Building the Project

1. Clone the repository
2. Open `SantuarioUM.sln` in your IDE
3. Restore NuGet packages
4. Build the solution
5. Run on your target platform

### Data Source

The application content is stored in `Resources/Raw/santuario_data_large.json`, containing detailed information about the sanctuary's areas and furniture with biblical references and explanations.

## Contributing

This educational app aims to provide accurate biblical teaching about the sanctuary's role in God's plan of salvation. Contributions should maintain theological accuracy and educational value.

## License

[Add license information here]

## Acknowledgments

- Biblical content based on Scripture and historical study
- Built with .NET MAUI framework
- Educational purpose for understanding God's sanctuary plan