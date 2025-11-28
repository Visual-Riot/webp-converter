# WebpConverter

A lightweight C# console application for batch-converting image files (PNG/JPG) into efficient **WebP** format.  
Developed by **Visual Riot** as a simple internal utility for optimising assets across websites, interactive projects, and prototypes.

This tool uses **SixLabors.ImageSharp** and **ImageSharp.WebP** for fast, cross-platform image encoding.

---

## ✨ Features

- 🔄 Batch-convert `.png`, `.jpg`, `.jpeg` → `.webp`
- 📁 Uses simple `_input/` and `_output/` folders in the project directory
- ⚡ Fast and lightweight — no external dependencies or system installs
- 🎚️ Adjustable WebP quality setting
- 💻 Cross-platform (Windows, macOS, Linux)
- 🧩 Clean and minimal codebase for beginners to extend

---

## 📂 Folder Structure

```
WebpConverter/
 ├─ Program.cs
 ├─ WebpConverter.csproj
 ├─ input/      ← place PNG/JPG files here
 └─ output/     ← converted WebP files appear here
```

The app automatically creates the folders if they do not exist.

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/Visual-Riot/webp-converter.git
cd webp-converter
```

### 2. Install required packages

```
dotnet add package SixLabors.ImageSharp
dotnet add package SixLabors.ImageSharp.Webp
```

### 3. Add images to convert

Place your `.png`, `.jpg`, or `.jpeg` files inside the `_input` folder.

### 3. Run the converter

dotnet run
Converted `.webp` files will appear in the `_output` folder.

---

## 🧠 How It Works

The app scans the `_input/` directory for `PNG/JPG` images.

Each file is loaded using ImageSharp.

Images are encoded to WebP using the specified quality setting.

Output files are saved with the same filename but `.webp` extension.

Simple. Fast. Reliable.

---

## ⚙️ Customisation

Adjust WebP Quality

Inside Program.cs:

```
var encoder = new WebpEncoder
{
Quality = 80 // 0–100
};
```

Change folders

```
string inputFolder = "_input";
string outputFolder = "_output";
```

You can also add command-line arguments (`--quality`, `--in`, -`-out`) later if you want more flexibility.

### 🧰 Possible Future Upgrades

- Drag-and-drop GUI (WinUI/WPF)
- Recursive directory scanning
- Multi-threaded batch conversion
- Progress bar / file counter
- Folder watcher (auto-convert new files)
- Publish to a standalone .exe release

If you want any of these features, we can build them with you.

---

## 📄 License

MIT License — free for personal and commercial use.

---

## 🏴 Visual Riot

This tool is part of Visual Riot’s ecosystem of small creative-tech utilities supporting research, art, education, and impact-driven digital projects.

**Let us riot for you.**
