## English
### Installation and configuration
To do this, you need to install "wine" and "winetricks".

`sudo apt-get update && sudo apt-get install wine winetricks`

_The command is only for Debian/Ubuntu. For other distributions - search in a search engine._

**This is important**: if you already have Wine installed and you do not want to delete the folder with it, run the command:

`sudo mv ~/.wine ~/.wine_old`

Configure Wine with a command

`WINEPREFIX=~/.wine WINEARCH=win32 winecfg`

and run the Microsoft .NET Framework 3.5 installation (_it may take a while_)

`winetricks dotnet35`

Several .NET Framework versions will be installed for normal operation, this is normal. Continue the installation by following the on-screen instructions.

Well, then you can run VeNote. But this window will appear:

![fdheqh3xm7e](https://user-images.githubusercontent.com/21980972/36094739-00004a26-1022-11e8-9f3c-fd0766986efe.jpg)

click "Continue", thereby ignoring the error. And VeNote, with some bugs, will work.

![k5spckkq3ks](https://user-images.githubusercontent.com/21980972/36095048-2198bfe6-1023-11e8-97c2-6c0d5f609ff9.jpg)

![z6m2ubeddx4](https://user-images.githubusercontent.com/21980972/36095057-27a97ec0-1023-11e8-8107-b7edf7b91a87.jpg)

## Русский
### Установка и настройка
Для это надо установить "wine" и "winetricks".

`sudo apt-get update && sudo apt-get install wine winetricks`

_Команду выполнять только для Debian/Ubuntu. Для других дистрибутивов - ищите в поисковике._

**Это важно**: если у вас уже был установлен Wine и вы не хотите удалять папку с ним, выполните команду:

`sudo mv ~/.wine ~/.wine_old`

Настройте Wine командой

`WINEPREFIX=~/.wine WINEARCH=win32 winecfg`

и запустите установку Microsoft .NET Framework 3.5 (_может занять некоторое время_)

`winetricks dotnet35`

Будет установлено несколько версий .NET Framework для нормальной работоспособности, это нормально. Продолжайте установку, следуя инструкциям на экране.

Ну и потом вы можете запустить VeNote. Но появится это окно:

![fdheqh3xm7e](https://user-images.githubusercontent.com/21980972/36094739-00004a26-1022-11e8-9f3c-fd0766986efe.jpg)

нажмите "Continue", тем самым игнорируя ошибку. И VeNote, с некоторыми багами, заработает.

![k5spckkq3ks](https://user-images.githubusercontent.com/21980972/36095048-2198bfe6-1023-11e8-97c2-6c0d5f609ff9.jpg)

![z6m2ubeddx4](https://user-images.githubusercontent.com/21980972/36095057-27a97ec0-1023-11e8-8107-b7edf7b91a87.jpg)