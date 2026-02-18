# 🍔 GrantFoods - Cross-Platform Food Delivery App

[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-7.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/apps/maui)
[![C#](https://img.shields.io/badge/C%23-11.0-239120?style=flat-square&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS%20%7C%20Windows%20%7C%20macOS-blue?style=flat-square)](https://dotnet.microsoft.com/apps/maui)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)

A modern, cross-platform food ordering and delivery application built with .NET MAUI. This app provides a seamless experience for browsing restaurants, ordering food, and managing your cart across Android, iOS, Windows, and macOS platforms.

![App Banner](https://via.placeholder.com/1200x400/512BD4/FFFFFF?text=GrantFoods+-+Order+Your+Favorite+Food)

## 📋 Table of Contents

- [Features](#-features)
- [Screenshots](#-screenshots)
- [Technologies](#-technologies)
- [Architecture](#-architecture)
- [Getting Started](#-getting-started)
- [Project Structure](#-project-structure)
- [Database](#-database)
- [Dependencies](#-dependencies)
- [Build & Run](#-build--run)
- [Contributing](#-contributing)
- [License](#-license)
- [Contact](#-contact)

## ✨ Features

### 🔐 User Authentication

- User registration with validation
- Secure login system
- User profile management
- Account settings

### 🏪 Restaurant & Menu Browsing

- Browse restaurants by categories (Burgers, Pizza, Sushi, Mexican, Vegan, Desserts)
- View restaurant details with ratings and location
- Explore menus with product images and descriptions
- Real-time restaurant data updates

### 🛒 Shopping Cart

- Add/remove items from cart
- Adjust quantities
- View total cost calculation
- Persistent cart across sessions

### 📦 Order Management

- Place orders
- View order history
- Track order status
- Order confirmation with animations

### 🎨 Modern UI/UX

- Beautiful, responsive design
- Custom fonts (Teko, Nexa, Bebas, Roboto)
- Smooth animations using Lottie
- Platform-specific optimizations
- Dark/Light theme support

### 🌐 Multi-Platform Support

- **Android** (21.0+)
- **iOS** (11.0+)
- **Windows** (10.0.17763.0+)
- **macOS** (13.1+)

## 📱 Screenshots

> Add your app screenshots here

| Home Screen               | Restaurant View                 | Cart                      | Order Confirmation         |
| ------------------------- | ------------------------------- | ------------------------- | -------------------------- |
| ![Home](placeholder1.png) | ![Restaurant](placeholder2.png) | ![Cart](placeholder3.png) | ![Order](placeholder4.png) |

## 🛠 Technologies

### Core Framework

- **.NET MAUI 7.0** - Cross-platform framework
- **C# 11** - Programming language
- **XAML** - UI markup

### Architecture & Patterns

- **MVVM (Model-View-ViewModel)** - Clean separation of concerns
- **Dependency Injection** - Service registration and resolution
- **Command Pattern** - Using CommunityToolkit.Mvvm

### Data & Storage

- **SQLite** - Local database for offline data
- **Firebase Realtime Database** - Cloud data synchronization
- **Entity-based data models**

### UI Libraries

- **CommunityToolkit.Maui** - Enhanced MAUI controls
- **SkiaSharp** - 2D graphics rendering
- **Lottie Animations** - High-quality animations

### Development Tools

- **Visual Studio 2022** - IDE
- **Git** - Version control
- **NuGet** - Package management

## 🏗 Architecture

The application follows the **MVVM (Model-View-ViewModel)** pattern with a clean architecture approach:

```
GrantFoods/
│
├── Models/              # Data models and entities
│   ├── User.cs
│   ├── Restaurant.cs
│   ├── Product.cs
│   ├── Cart.cs
│   ├── Order.cs
│   └── ...
│
├── ViewModels/          # Business logic and state management
│   ├── BaseViewModel.cs
│   ├── HomeViewModel.cs
│   ├── CartViewModel.cs
│   ├── UserViewModel.cs
│   └── ...
│
├── Views/               # UI pages and components
│   ├── HomeView.xaml
│   ├── CartView.xaml
│   ├── LoginView.xaml
│   ├── Templates/       # Reusable UI templates
│   └── ...
│
├── Services/            # Data access and business services
│   ├── DatabaseService.cs
│   ├── UserService.cs
│   ├── ProductDataService.cs
│   ├── RestaurantDataService.cs
│   └── ...
│
├── Helpers/             # Utility classes
│   ├── AddCategoryData.cs
│   ├── AddProductsData.cs
│   └── ...
│
└── Resources/           # Assets
    ├── Images/
    ├── Fonts/
    ├── Raw/            # Lottie animations
    └── ...
```

### Key Design Decisions

1. **Separation of Concerns**: Each layer has a specific responsibility
2. **Testability**: ViewModels are decoupled from Views
3. **Reusability**: Services are singleton/transient registered
4. **Maintainability**: Clear project structure with logical grouping

## 🚀 Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (17.4+) with MAUI workload
  - Or [Visual Studio Code](https://code.visualstudio.com/) with C# extension
- For Android: Android SDK (API 21+)
- For iOS: Xcode 13.3+
- For Windows: Windows 10 SDK (10.0.17763.0+)

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/GrantTotinov/GrantFoodsMAUI.git
   cd GrantFoodsMAUI
   ```

2. **Restore NuGet packages**

   ```bash
   dotnet restore
   ```

3. **Configure Firebase** (if using cloud features)
   - Create a Firebase project
   - Update Firebase configuration in services
   - Add your Firebase credentials

4. **Run the application**
   ```bash
   dotnet build
   dotnet run
   ```

## 📂 Project Structure

```
GrantFoodsMAUI/
├── GrantFoods.sln              # Solution file
└── GrantFoods/
    ├── GrantFoods.csproj       # Project file
    ├── App.xaml                 # Application entry
    ├── AppShell.xaml            # Shell navigation
    ├── MauiProgram.cs           # DI configuration
    ├── Models/                  # 8 data models
    ├── ViewModels/              # 9 view models
    ├── Views/                   # 13 views + templates
    ├── Services/                # 7 services
    ├── Helpers/                 # Data seeding helpers
    ├── Platforms/               # Platform-specific code
    │   ├── Android/
    │   ├── iOS/
    │   ├── Windows/
    │   └── MacCatalyst/
    └── Resources/               # Images, fonts, animations
```

## 💾 Database

### Local Storage (SQLite)

- User data
- Cart items
- Order history
- Cached restaurant/product data

### Cloud Storage (Firebase)

- Real-time restaurant updates
- Menu synchronization
- User preferences backup

### Models

- **User** - User authentication and profile
- **Restaurant** - Restaurant information
- **Product** - Menu items
- **Category** - Food categories
- **Cart** - Shopping cart
- **CartItem** - Individual cart items
- **Order** - Order records
- **OrderDetails** - Order line items

## 📦 Dependencies

```xml
<PackageReference Include="CommunityToolkit.Maui" Version="5.2.0" />
<PackageReference Include="CommunityToolkit.Mvvm" Version="8.2.0" />
<PackageReference Include="FirebaseDatabase.net" Version="4.2.0" />
<PackageReference Include="SkiaSharp.Extended.UI.Maui" Version="2.0.0-preview.61" />
<PackageReference Include="sqlite-net-pcl" Version="1.8.116" />
<PackageReference Include="SQLitePCLRaw.bundle_green" Version="2.1.5" />
```

## 🔨 Build & Run

### For Android

```bash
dotnet build -t:Run -f net7.0-android
```

### For iOS

```bash
dotnet build -t:Run -f net7.0-ios
```

### For Windows

```bash
dotnet build -t:Run -f net7.0-windows10.0.19041.0
```

### For macOS

```bash
dotnet build -t:Run -f net7.0-maccatalyst
```

## 🎯 Key Features Implementation

### MVVM Pattern with CommunityToolkit

```csharp
[ObservableProperty]
private ObservableCollection<Product> products;

[RelayCommand]
private async Task AddToCart(Product product)
{
    // Add to cart logic
}
```

### Dependency Injection

```csharp
builder.Services.AddSingleton<DatabaseService>();
builder.Services.AddTransient<HomeViewModel>();
builder.Services.AddTransient<HomeView>();
```

### SQLite Data Access

```csharp
public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class, new()
{
    var table = await GetTableAsync<T>();
    return await table.ToListAsync();
}
```

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 Contact

**Grant Totinov**

- GitHub: [@GrantTotinov](https://github.com/GrantTotinov)
- Email: your.email@example.com
- LinkedIn: [Your LinkedIn](https://linkedin.com/in/yourprofile)

## 🙏 Acknowledgments

- [.NET MAUI Documentation](https://docs.microsoft.com/en-us/dotnet/maui/)
- [CommunityToolkit.Maui](https://github.com/CommunityToolkit/Maui)
- [Firebase Documentation](https://firebase.google.com/docs)
- [SQLite](https://www.sqlite.org/)
- [SkiaSharp](https://github.com/mono/SkiaSharp)

---

⭐ **Star this repo if you find it helpful!**

Made with ❤️ by Grant Totinov
