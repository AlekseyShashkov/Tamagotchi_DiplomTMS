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
    <img src="https://github.com/user-attachments/assets/b6084051-18a7-48bb-aba1-d32e8558ecc9" width="40%" alt="Gameplay screenshot">
    <br/>
    <figcaption>Gameplay screenshot</figcaption>
</figure>
</div>

## Introduction
The game is a classic Tamagotchi with clicker elements.

## Description
The player's goal is to monitor the virtual pet's state and maintain it by clicking to restore various indicators, such as Hunger, Dirty, Fatigue, and Sick, which are displayed at the bottom of the screen. Players can also earn coins by clicking on the pet's image. The pet's overall state is measured by the happiness indicator. During the game, the pet automatically gains experience points, leading to level-ups. The higher the pet's happiness level, the faster it gains experience. With each new level, the number of coins earned per click increases.

## Gameplay
<div align="left">
    <kbd >
        <video src="https://github.com/user-attachments/assets/14beed7f-69f4-4745-9c70-9533ed241a2e" ></video>
    </kbd>
</div>

## Features
<div align="left">
    <table border="1">
        <tr align="center">
            <th><b>Scene 0. Menu</b></th>
            <th><b>Scene 1. Game</b></th>
        </tr>
        <tr>
            <td width="50%">
                Main menu, allowing the player to choose their next action:
                <h5>
                    <img src="https://github.com/user-attachments/assets/a3779dd6-d657-4857-86b6-935182559216" height="400px" align="left"/>
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
                    <img src="https://github.com/user-attachments/assets/bef4ba09-6c89-4345-9082-08f8381ea012" height="400px" align="left"/>
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

## Architecture
<div align="center">
    <figure>
        <img src="https://github.com/user-attachments/assets/72a25ee9-59c4-4538-a45a-ffbab491f0e3" alt="UML Class diagram">
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
                        <td><code><img src="https://github.com/user-attachments/assets/7c34ce7c-c195-4c61-93c1-d3ca33ab8520" height="11px" alt="#00ced1"> #00ced1</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game">_Scripts/Game</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/fd845195-db58-4846-ad33-69d547b9c18a" height="11px" alt="#ffd700"> #ffd700</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Coin">_Scripts/Game/Coin</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/c3e60ed4-7849-4755-9b7a-a3218f8f05e6" height="11px" alt="#5f9ea0"> #5f9ea0</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Tamagotchi">_Scripts/Game/Tamagotchi</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/164b69f0-af95-4819-900b-e48c324b7fbf" height="11px" alt="#f6f6f4"> #f6f6f4</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Tamagotchi/State">_Scripts/Game/Tamagotchi/State</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/5abd644c-5012-437a-8aa3-bfda59f7d221" height="11px" alt="#9370db"> #9370db</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Repository/View">_Scripts/Game/Repository/View</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/00dc2ade-9a98-4b2e-bf5d-d3a01a2f4fae" height="11px" alt="#d8bfd8"> #d8bfd8</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Game/Repository/Button">_Scripts/Game/Repository/Button</a></kbd></td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="left">
                <table>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/103a6929-4a90-4bde-9410-25fb8cf83e1d" height="11px" alt="#f0e68c"> #f0e68c</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Misc">_Scripts/Misc</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/4a09706a-3695-49e7-94b0-9d42e27367db" height="11px" alt="#ff6f61"> #ff6f61</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/Misc/SaveLoadSystem">_Scripts/Misc/SaveLoadSystem</a></kbd></td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="left">
                <table>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/bc577ba6-a627-4c39-ba65-2ae58465859e" height="11px" alt="#f5f5dc"> #f5f5dc</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/View">_Scripts/View</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/04e570e2-2995-417a-9524-753aa117e89e" height="11px" alt="#ffdab9"> #ffdab9</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/View/Screen">_Scripts/View/Screen</a></kbd></td>
                    </tr>
                    <tr>
                        <td><code><img src="https://github.com/user-attachments/assets/c27e103c-616d-4877-aa0f-76ba51020ecc" height="11px" alt="#8fd5a6"> #8fd5a6</code></td>
                        <td><kbd><a href="Assets/_Project/_Scripts/View/Button">_Scripts/View/Button</a></kbd></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</div>

## Requirements
- `2021.3.41f1 or later`

## Licensed under the [MIT License](LICENSE)
