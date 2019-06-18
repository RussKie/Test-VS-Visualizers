# Test VS visualisers

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/dotnet/winforms/blob/master/LICENSE.TXT)


## How to run and test:

* Clone https://github.com/dotnet/winforms/ to you local drive (e.g. to `C:\Development\winforms\`)
* Run `.\build`
* Clone https://github.com/RussKie/Test-VS-Visualizers to you local drive (e.g. to `C:\Development\Test-VS-Visualizers\`)
* If necessary, update `Test-VS-Visualizers.csproj` to point to the WinForms Core build artifacts (default: `C:\Development\winforms\artifacts\bin\System.Windows.Forms\Debug\netcoreapp3.0\System.Windows.Forms.dll`)
* open in VS and run as-is, check the Watch window 
* close VS
* rename `C:\Program Files (x86)\Microsoft Visual Studio\2019\<_your_IDE_version_>\Common7\Packages\Debugger\Visualizers\Original\autoexp.dll`
* open in VS again
* uncomment `DebuggerDisplayAttribute` declarations, re-run and check the Watch window 
