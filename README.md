# MultiLinkRunner

A simple C# console application that reads a text file, finds all valid HTTP/HTTPS links, opens each link in the default web browser (each in its own tab), and appends found links to a log file (`SavedLinks.txt`).  

---

## Table of Contents

- [Features](#features)  
- [Requirements](#requirements)  
- [Installation](#installation)  
- [Usage](#usage)  
- [Behaviour](#behaviour)  
- [Configuration](#configuration)  
- [License](#license)  

---

## Features

- Reads lines from a `.txt` file.  
- Detects links (starting with `http://` or `https://`).  
- Opens each valid link in your default browser in a new tab.  
- Appends all found links to `SavedLinks.txt` (so previous logs are preserved).  
- Allows repeating runs without restarting the application manually.  

---

## Requirements

- .NET SDK (version 6.0 or newer recommended, or whatever version the solution is built with).  
- Works on Windows (with `Process.Start` using `UseShellExecute = true`).  
- Basic permissions to read files, write files, and open browser windows.  

---

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/it2121/MultiLinkRunner.git
   cd MultiLinkRunner
   ```

2. Open in your preferred C# IDE (Visual Studio, Visual Studio Code, Rider, etc.), or compile from command line.

3. Build the application:

   ```bash
   dotnet build
   ```

---

## Usage

1. Run the application:

   ```bash
   dotnet run
   ```

2. When prompted, enter the path to your text file containing links. If the file isn’t found, you’ll be asked again.

3. The application will process each line:

   - If it begins with `http://` or `https://`, it is considered a valid link.  
   - Each valid link is opened in the default browser (one new tab per link).  
   - Valid links are collected and appended to `SavedLinks.txt`.

4. After it finishes, you can choose to run again, or type `exit` (or similar command) to quit.

---

## Behaviour / Flow

- The app loops continuously so you can provide different files without restarting.  
- Duplicate links will be appended repeatedly unless you implement deduplication.  
- If `SavedLinks.txt` does not exist, it will be created.  
- Errors in opening a link or reading a file are caught and reported, but the app continues processing the rest.  

---

## Configuration

You may modify the code to:

- Use more sophisticated link detection (e.g. regex to find links anywhere in a line, or validate further).  
- Skip duplicate links when appending to `SavedLinks.txt`.  
- Add delays between opening tabs (to avoid overwhelming the browser).  
- Customize the name/location/path of `SavedLinks.txt`.  

---

## Example

Input file `links.txt`:

```
https://www.google.com
hello world
http://example.com/page
not a link
https://github.com
```

When you run the app:

- It opens `https://www.google.com`, `http://example.com/page`, `https://github.com` in browser tabs.  
- Creates or appends those links into `SavedLinks.txt`.

---

## License

Specify your license here, e.g.:

MIT License © YYYY [Your Name]

---

## Contributing

Feel free to open pull requests, submit issues, or suggest improvements.  

---

## Author

Mohammed Talib   
phpmoon21@gmail.com
