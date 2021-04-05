# CreateCSVFromUSFM
Create a CSV from a set of USFM files

## Building
Standard .net build process. Either build from CLI with `dotnet build` or via Visual Studio

## Usage

There are two different ways you can use this too. Via the command line toool or via the Graphical App.

Either way you'll get a CSV with the following columns

- Book
- Chapter
- Verse
- Text

This is only the text inside of a verse, anything inside of a footnote is ignored.

### CLI

Usage (On Windows) goes as follows
`CreateCSVFromUSFM.ConsoleApp.exe --input "../en_ulb/" --output "output.csv"`

### App

Currently not implemented