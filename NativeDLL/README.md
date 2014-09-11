Register the DLL
=======

To use the DLL will need to register it. For this we use the RegAsm.exe application. 
I have made available a .bat script,  which must be run as administrator, solves the problem. 
Remembering that RegAsm.exe should be in the same directory as the DLL.

```
pushd %~dp0
regasm Facture_e.dll
```
