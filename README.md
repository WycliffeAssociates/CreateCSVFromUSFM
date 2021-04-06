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

Open the app and fill in the source directory and output file in the fields, or click on the buttons to the right of the fields to select the file manually.

Click Convert to convert the files