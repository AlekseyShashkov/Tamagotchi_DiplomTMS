<div align="center">

# Tamagotchi

[![Repo Size](https://img.shields.io/github/repo-size/AlekseyShashkov/Tamagotchi_DiplomTMS.svg?style=flat&color=9370db&label=Repo%20Size)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/archive/master.zip)
[![License](https://img.shields.io/github/license/AlekseyShashkov/Tamagotchi_DiplomTMS.svg?style=flat&label=License)](LICENSE)
[![Unity Version](https://img.shields.io/badge/unity-2021.3.41f1-blue?style=flat&label=Unity)](https://unity.com/releases/editor/whats-new/2021.3.41#notes)
[![CodeFactor](https://img.shields.io/codefactor/grade/github/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat&color=0cac6c&label=Code%20Quality)](https://www.codefactor.io/repository/github/AlekseyShashkov/Tamagotchi_DiplomTMS)
[![Contributors](https://img.shields.io/github/contributors/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat&color=ffaaf2&label=Contributors)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/graphs/contributors)
[![Watchers](https://img.shields.io/github/watchers/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat&color=f5d08b&label=Watchers)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/watchers)
[![Last Commit](https://img.shields.io/github/last-commit/AlekseyShashkov/Tamagotchi_DiplomTMS?style=flat&color=00D1C2&label=Last%20Commit)](https://github.com/AlekseyShashkov/Tamagotchi_DiplomTMS/pulse)

<figure>
    <img alt="Gameplay screenshot" src="img/screenshot/gameplay.jpg" width="40%"/>
    <br/>
    <figcaption>Gameplay screenshot</figcaption>
</figure>
</div>

## 🚀 Introduction

The game is a classic Tamagotchi with clicker elements.

## 📚 Description

The player's goal is to monitor the virtual pet's state and maintain it by clicking to restore various indicators, such as Hunger, Dirty, Fatigue, and Sick, which are displayed at the bottom of the screen. Players can also earn coins by clicking on the pet's image. The pet's overall state is measured by the happiness indicator. During the game, the pet automatically gains experience points, leading to level-ups. The higher the pet's happiness level, the faster it gains experience. With each new level, the number of coins earned per click increases.

## 🎬 Gameplay

<div align="left">
    <kbd>
        <video src="https://github.com/user-attachments/assets/f4204bbc-9ecf-4127-9b6c-be5f9eb332d4"></video>
    </kbd>
</div>

## ✨ Game features

<div align="left">
    <table border="1">
        <tr align="center">
            <th><b>Scene 0.Menu</b></th>
            <th><b>Scene 1.Game</b></th>
        </tr>
        <tr>
            <td width="50%">
                Main menu, allowing the player to choose their next action:
                <h5>
                    <img alt="Menu screenshot" src="img/screenshot/menu.jpg" height="400px" align="left"/>
                    <ul>
                        <li>Start - starts a new game session. Clicking this button transitions the player to the game scene;</li>
                        <li>Settings - opens the settings window. Here, the user can adjust the volume of background music and sound effects using a slider for fine-tuning the audio experience;</li>
                        <li>Exit - closes the game. Clicking this button exits the game entirely.</li>
                    </ul>
                </h5>
            </td>
            <td width="50%">
                Gameplay area where players interact with their virtual pet:
                <h5>
                    <img alt="Game screenshot" src="img/screenshot/game.jpg" height="400px" align="left"/>
                    <ul>
                        <li>Manage pet's state - monitor and maintain the pet's various states, such as Hunger, Dirty, Fatigue, and Sick by clicking to restore them;</li>
                        <li>Interact and earn coins - click on the pet to interact and earn coins. The amount of coins earned per click increases with the pet’s level;</li>
                        <li>Save and Load - save your progress and resume the game from the last saved point.</li>
                    </ul>
                </h5>
            </td>
        </tr>
    </table>
</div>

## 🔥 Project features

- [x] User interface
    - [x] Main menu screen with options to start the game, access settings, and exit the application
    - [x] Settings screen with an option to return to the previous screen
    - [x] Main gameplay screen displaying the game state
- [x] Gameplay mechanics
    - [x] Managing Tamagotchi's state (hunger, dirtiness, fatigue, sickness)
    - [x] Increasing levels and accumulating experience
    - [x] Spawning and managing coins (using an object pool for resource efficiency)
- [x] Audio
    - [x] Volume control via a slider
    - [x] Playing sound effects when interacting with buttons
- [x] Scene management
    - [x] Loading and switching between scenes with a delay for smoother transitions
- [x] Buttons
    - [x] Custom buttons with visual and sound effects on press
    - [x] Animation of scaling and color change on press
- [x] Saving and Loading
    - [x] Saving game state to a file
    - [x] Loading saved game state from a file

## 🧱 Architecture

### 🧩 System structure

<div align="center">
    <figure>
        <img alt="UML Class diagram" src="img/UML/class diagram.jpg"/>
        <br/>
        <figcaption>UML Class diagram</figcaption>
    </figure>
</div>

>[!NOTE]
>Different directives are indicated using colors.

<div align="center">
    <table border="1">
        <tr>
            <th><a href="Assets/_Project/_Scripts/Game">Game</a></th>
            <th><a href="Assets/_Project/_Scripts/Misc">Misc</a></th>
            <th><a href="Assets/_Project/_Scripts/View">View</a></th>
        </tr>
        <tr>
            <td valign="top" align="left">
                <table>
                    <tr>
                        <td><code><img alt="#00ced1" src="img/UML/game/%2300ced1.png" height="14px"/> #00ced1</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game">_Scripts/Game</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#ffd700" src="img/UML/game/%23ffd700.png" height="14px"/> #ffd700</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Coin">_Scripts/Game/Coin</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#5f9ea0" src="img/UML/game/%235f9ea0.png" height="14px"/> #5f9ea0</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Tamagotchi">_Scripts/Game/Tamagotchi</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#f6f6f4" src="img/UML/game/%23f6f6f4.png" height="14px"/> #f6f6f4</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Tamagotchi/State">_Scripts/Game/Tamagotchi/State</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#9370db" src="img/UML/game/%239370db.png" height="14px"/> #9370db</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Repository/View">_Scripts/Game/Repository/View</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#d8bfd8" src="img/UML/game/%23d8bfd8.png" height="14px"/> #d8bfd8</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Repository/Button">_Scripts/Game/Repository/Button</a></kbd></td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="left">
                <table>
                    <tr>
                        <td><code><img alt="#f0e68c" src="img/UML/misc/%23f0e68c.png" height="14px"/> #f0e68c</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Misc">_Scripts/Misc</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#ff6f61" src="img/UML/misc/%23ff6f61.png" height="14px"/> #ff6f61</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Misc/SaveLoadSystem">_Scripts/Misc/SaveLoadSystem</a></kbd></td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="left">
                <table>
                    <tr>
                        <td><code><img alt="#5f9fff" src="img/UML/view/%235f9fff.png" height="14px"/> #5f9fff</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/View">_Scripts/View</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#ffdab9" src="img/UML/view/%23ffdab9.png" height="14px"/> #ffdab9</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/View/Screen">_Scripts/View/Screen</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img alt="#8fd5a6" src="img/UML/view/%238fd5a6.png" height="14px"/> #8fd5a6</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/View/Button">_Scripts/View/Button</a></kbd></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</div>

### 🗃️ Project hierarchy

<table border="1">
    <tr>
        <th><b>Scene 0.Menu</b></th>
        <th><b>Scene 1.Game</b></th>
    </tr>
    <tr>
        <td valign="top"><img alt="Menu hierarchy" src="img/hierarchy/menu.jpg"/></td>
        <td valign="top"><img alt="Game hierarchy" src="img/hierarchy/game.jpg"/></td>
    </tr>
</table>

## 🏆 Achieved goals

- [x] Intuitive user interface
    - [x] Screens for managing the game and settings have been created and configured
    - [x] Buttons with feedback have been implemented for convenient interaction
- [x] Well-designed gameplay mechanics
    - [x] A system for managing Tamagotchi's states and their effects has been developed
    - [x] An object pool has been integrated for efficient coin management
- [x] Flexible audio control
    - [x] Volume adjustment and sound effect playback features have been added
    - [x] Integration with the audio system for smooth sound management
- [x] Smooth scene management
    - [x] A system for scene loading with asynchronous progress and debugging messages has been implemented
- [x] Interactive buttons
    - [x] Custom buttons with animation and sound effects have been created
- [x] Effective saving and loading
    - [x] A system for saving and loading game state data in JSON format has been developed

## ⚙️ Requirements

- `2021.3.41f1 or later`

## ⚖️ Licensed under the [MIT License](LICENSE)
