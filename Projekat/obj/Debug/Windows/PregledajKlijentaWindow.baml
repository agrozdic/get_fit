   M S B A M L   `   `   `  ����C  ?Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Projekat.WindowsProjekat.Windows  5   	   .    (Projekat.Windows.PregledajKlijentaWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Projekat.Windows     5   	     � Title$  PregledajKlijentaWindow��5   	   $	��450��6)   $	��800��66    � Left$	 360��5	   	   
 � Top$	 150��6   .��5
      � .+�5   
   �� $��/Images/pozadina.jpg��6   $
��Fill=�6.   �� 5   
   $��10,10,439,0q�6   .+�5      �� -   5        $��lblIme��5      $
��Ime:��6"   $��0��61   $��0��6A   $��Center=�6N   ���#ffd60a6k   �� 5      -   5         ��Name$ txtIme��5   ^   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6n   ��6I   �� *Ime+6n   �� 5      -   5         ��Name$ 
lblPrezime��5      $��Prezime:��6(   $��0��6;   $��0��6K   $��Center=�6X   ���#ffd60a6u   �� 5      -   5        $ 
txtPrezime��5   b   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6v   ��6I   �� *	Prezime+6v   �� 5      -   5        $ lblEmail��5      $��Email:��6&   $��0��67   $��0��6G   $��Center=�6T   ���#ffd60a6q   �� 5      -   5        $ txtEmail��5      $
��Lato)�6(   $��Light"�6:   $��16(�6d   $	��150��6r   ��6M   �� *Email+6r   �� 5      -   5        $ 
lblLozinka��5      $��Lozinka:��6(   $��0��6;   $��0��6K   $��Center=�6X   ���#ffd60a6u   �� 5      -   5        $ 
txtLozinka��5   b   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6w   ��6I   �� *	Lozinka+6w   �� 5      -	   5        $ 
lblTelefon��5      $��Broj telefona:��6(   $��0��6A   $��0��6Q   $��Center=�6^   ���#ffd60a6{   �� 5      -
   5        $ 
txtTelefon��5   b   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6w   ��6I   �� *	Telefon+6w   �� 5      -   5        $ 	lblAdresa��5      $��Adresa:��6'   $��0��69   $��0��6I   $��Center=�6V   ���#ffd60a6s   �� 5      -   5        $ 	txtAdresa��5   a   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6u   ��6I   �� *Adresa+6u   �� 5      -   5        $ 
lblKartica��5      $��Broj platne kartice:��6(   $��0��6G   $��0��6W   $��Center=�6d   ���#ffd60a6�   �� 5       -   5        $ 
txtKartica��5    d   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6y   ��6I   �� *	BrKartice+6y   5!      �� 5"   
   $��	400,0,0,0q�6   .+�5#      �� -   5        $ lblOsnovniJezik��5#      $��Osnovni jezik:��6-   $��0��6F   $��0��6V   $��Center=�6c   ���#ffd60a6�   �� 5$      -   5        $ txtOsnovniJezik��5$   g   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6�   ��6I   �� *OsnovniJezik+6�   �� 5&      -   5        $ lblDodatniJezik��5&      $��Dodatni jezik:��6-   $��0��6F   $��0��6V   $��Center=�6c   ���#ffd60a6�   �� 5'      -   5        $ txtDodatniJezik��5'   g   $
��Lato)�6   $��Light"�6(   $��16(�6;   $	��150��6�   ��6I   �� *DodatniJezik+6�   �� 5)      -   5        $ lblTipKorisnika��5)      $��Tip korisnika:��6-   $��0��6F   $��0��6V   $��Center=�6c   ���#ffd60a6�   �� 5*      -   5        $��cmbTipKorisnika��5*   )   $
��Lato)�6   $��Light"�6@   $��16(�6S   $	��150��6�    �� Text 6a   ��  �� Path$ TipKorisnika�6�   5+      �� 5.   
   -   5        $��Nazad��5.      $
��Left=�6!   $��553,217,0,0q�6<   $	��Top=�6Q   $��94��6i   $��55��6t   ���#ffd60a6�   50      51      