[![Repo Size](https://img.shields.io/github/languages/code-size/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/archive/master.zip)
[![License](https://img.shields.io/github/license/AlekseyShashkov/Tamagotchi_DiplomTMS.svg)](LICENSE) 
[![People](https://img.shields.io/github/contributors/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat&color=ffaaf2&label=People)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/graphs/contributors) 
[![Watches](https://img.shields.io/github/watchers/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat&color=f5d08b&label=Watches)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/watchers) 
[![Last Updated](https://img.shields.io/github/last-commit/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat&color=e06c75&label=)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/pulse) 

<h1 align="center">Tamagotchi</h1>

&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/859a580b-af03-4239-a848-eed610b7db73" height="20px"/>
Классический <i>тамагочи</i> с модификацией в виде <i>кликера</i>.<br/> 
&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/859a580b-af03-4239-a848-eed610b7db73" height="20px"/>
Цель игры проста: необходимо следить за изменениями состояний нашего "питомца" и, 
посредством взаимодействия (ЛКМ) с индикаторами, возвращать их на исходный уровень, а также зарабатывать монеты "закликивая" изображение "питомца". Общий уровень состояний отображается с помощью индикатора <i>счастья</i> (Happy).
В процессе игры "питомец" непрерывно набирает <i>очки опыта</i> (индикатор Exp) и повышает уровень (lvl). На скорость изменения опыта влияет индикатор <i>счастья</i>: чем счастливее "питомец",
тем быстрее он прокачивается. Получаемые уровни влияют на скорость заработка монет: чем выше уровень, тем больше количество монет получаемых за клик.

## 🎬Игровой процесс:
<div align="left">
    <kbd >
        <video src="https://github.com/user-attachments/assets/14beed7f-69f4-4745-9c70-9533ed241a2e" ></video>
    </kbd>
</div>

## 🔧Логика проекта:

<div align="left">
<table>
    <tr align="center">
        <th> <b>0.Menu</b> </th>
        <th> <b>1.Game</b> </th>
    </tr>
    <tr>
        <td> 
<h5> <img src="https://github.com/user-attachments/assets/a3779dd6-d657-4857-86b6-935182559216" height="400px" align="left"/>
<img src="https://github.com/user-attachments/assets/859a580b-af03-4239-a848-eed610b7db73" height="20px"/>
Сцена <b>0.Menu</b> - меню, на котором распалагаются кнопки:

 - Start - начало игры;
 - Settings - окно с настройками громкости фоновой музыки и игровых эффектов;
 - Exit - выход из игры. </h5>          
        </td>
        <td>
<h5> <img src="https://github.com/user-attachments/assets/bef4ba09-6c89-4345-9082-08f8381ea012" height="400px" align="left"/> 
<img src="https://github.com/user-attachments/assets/859a580b-af03-4239-a848-eed610b7db73" height="20px"/>
Сцена <b>1.Game</b> - наше игровое пространство, позволяющее:

 - Контролировать состояния Tamagotchi;
 - Взаимодействовать с Tamagotchi и зарабатывать монеты;
 - Сохранять свой результат и продолжать с уже имеющегося сохранения. </h5>        
        </td>
    </tr>
</table>
</div>

<br clear="both">

## 📊UML-диаграмма классов:
<img src="https://github.com/user-attachments/assets/a70d764c-8220-4d0a-abd5-b382593241d3"/>

## 📝Иерархия проекта:
<img src="https://github.com/user-attachments/assets/fe80d7ef-f16f-4d16-b165-0baee4dcc182"/>
<hr/>

<p align="center">
  <img src="https://github.com/user-attachments/assets/62b70946-6e11-4fce-af0d-993278eb098e"/>
</p>
