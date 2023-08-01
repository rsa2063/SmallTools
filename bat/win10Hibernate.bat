:: https://stackoverflow.com/questions/7977743/how-do-i-make-a-hibernation-batch-file
:: https://answers.microsoft.com/en-us/windows/forum/all/anyone-know-a-batchscriptprogramexe-that-can-put/741c42d6-41a4-47b2-9c64-fddbf1605637
:: https://superuser.com/questions/42039/change-windows-sound-volume-via-the-command-line
C:\Software\nircmd-x64\nircmd.exe changesysvolume -50000
C:\Software\nircmd-x64\nircmd.exe mutesysvolume 1
C:\Software\nircmd-x64\nircmd.exe setbrightness 30

cd c:\
shutdown /h