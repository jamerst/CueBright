# CueBright
This application allows the colour and brightness of a CUE supported Corsair keyboard to be set using simple command-line arguments.

Please note that the only colour mode supported currently is the entire keyboard being the same colour and brightness. Unfortunately the CUE-SDK does not support fetching or modifying the current configuration, so it can only be overridden.

## Syntax
CueBright.exe [colour] [brightness]

The colour should be in the form of a hex code (#xxxxxx) and the brightness between 0.0 and 1.0 inclusive.

## Attributions
- CUE-SDK functionality implemented through [CUE.NET](https://github.com/DarthAffe/CUE.NET)
