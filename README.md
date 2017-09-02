# CueBright
### Set colour and brightness of CUE supported keyboards with command line arguments
This application allows the colour and brightness of a CUE supported Corsair keyboard to be set using simple command-line arguments.

Please note that the only colour mode supported currently is the entire keyboard being the same colour and brightness. Unfortunately the CUE-SDK does not support fetching or modifying the current configuration, so it can only be overridden.

## Syntax
CueBright.exe [colour] [brightness]

The colour should be in the form of a hex code (#xxxxxx) and the brightness between 0.0 and 1.0 inclusive.

## Download
Downloads can be found [here](https://github.com/jamerst/CueBright/releases).

## Attributions
- CUE-SDK functionality implemented through [CUE.NET](https://github.com/DarthAffe/CUE.NET)
- Lock state detection provided by Werner van Deventer. See [here](https://brutaldev.com/post/checking-if-the-workstation-is-locked)
