   M S B A M L   `   `   `  ���� 
  Tetris    Tetris.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Tetris��$	��500��$	��400��.��� .+��� $��Score��$
��Left=�$��252,101,0,0q�$	��Top=��� $��Level��$
��Left=�$��252,132,0,0q�$	��Top=��� $
��Rows��$
��Left=�$��252,163,0,0q�$	��Top=��� -    ��Name$ scoreBox��$�� ��{�.  $
��Left=�$��23��$��295,104,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��50���� -   $ levelBox��$�� ��{�.  $
��Left=�$��23��$��295,132,0,0q�$
 Wrap=�$	��Top=�$��50���� -   $ rowsBox��$�� ��{�.  $
��Left=�$��23��$��295,166,0,0q�$
 Wrap=�$	��Top=�$��50���� -    ��Name$ 
gameCanvas��
���   �$
��Left=�$	��400��$��	10,60,0,0q�$	��Top=�$	��200���� -    ��Name$ 
pauseLabel��$�� ��$��24(�$��Center=�$	��Top=�$
��Left=�
���  ��$	��200��$��
10,183,0,0q��� -   $ 	lossLabel��$�� ��$��Center=�$	��Top=�$��Center=�$��24(�
���  ��$	��160��$	��160��$��222,308,10,0q��� -   $ nextBlockCanvas��
�������$
��Left=�$	��100��$��252,225,0,0q�$	��Top=�$	��100���� $��Next Block:��$
��Left=�$��252,194,0,0q�$	��Top=�$��93��o� -	    o�Name$ TopMenu��$��25��$	��Top=�$��Right=�$	��392��.@�m� -
    m�Name$ FileMenuItem��$��  _File��.@�m� -   $ NewGameMenuItem��$��	_New Game��m� -   $ ExitMenuItem��$��_Exit��m� -   $ HelpMenuItem��$��_Help��.@�m� -   $ ControlsMenuItem��$��	_Controls��m� -   $ AboutMenuItem��$��_About��