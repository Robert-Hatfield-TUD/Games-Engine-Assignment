# Games-Engine-Assignment

Name: Robert Hatfield

Student Number: C18475892

Class Group: TU857

# Decription of the Project
The goal of this project is to create a proceduarally generated system in Unity. This project has two scenes one being a menu which displays a name for the game and two buttons one to start the game and the other to end it, the other scene is a procedurally generated terrain which is a green terrain that has flowers appear randomly infront of the controlled player. As the terrain is procedurally generated it will be different each time the game is played and the terrain offset is changed to make it appear as though the player is moving forward. As the game goes further and you gain more points less flowers begin to appear and the flowers completely stop spawning after a while, this aspect is more a point towards the real life situation in which more and more land is developed and slowly kills of the bees who need that land to survive. 


Link to YouTube video,
https://youtu.be/n4Sp3sTEOlM

If the above does not work: https://www.youtube.com/watch?v=n4Sp3sTEOlM 

If both links do not work the video will be in the repository.

# Instructions for use
To run this Unity project you must first run the project in the Unity Editor which will display the main menu where you can click the PLAY button to play the game. The game will then change the scene to the actual game scene where you will be behind the bee/player and from there you can use the left and right arrow keys to move the bee from side to side to collect the oncoming flowers. The primary aim of the game is just to collect as many flowers which will take longer further into the game as they spawn less frequently the higher score you have and once you reach the score of 65 the game comes to an end where it will display that there are no more flowers for the bee to collect which leaves it wandering with no more flowers to gather.

# How it works
In this section I will go through each section of the game and explain how each works.
The first section to explain is the main menu which is the first thing to see when running the game. Once that is done I will go through how the terrain, bee, audio, flowers and score are handled. Scripts and assets for each section will also be explained for each section to show what they include and how they work.

The Main Menu has two options which are placed below the title "PLAY" and "EXIT". The Main Menu UI is created using a canvas and then adding a panel object to the canvas which will allow for a background to be added. An empty object is then added to the canvas so that the buttons can be grouped up for a cleaner look and so that a single script can be added to the object to control both buttons.

Below is the code for the Main Menu to allow for the buttons to work as intended.

![image](screenshots/MainMenuSC.png)

The next image shows the Main Menu as it is in the unity editor with use of TextMeshPro, honeycomb image, bee image and a material called sunshine gradient to give it the appearance of a colour gradient.

![image](screenshots/MainMenuSCUnityEditor.png)

The next scene is the main game in which the first part to go over is the terrain itself and how it is generated. The terrain uses one script to generate procedurally which is based of the same script done in the module with a modification which makes it so that the terrain has its offest changed to make it appear as though the player is moving forward however th player is stationary. The script used to generate the terrain is also based of perlin nosie. Below is a snippet of the code where the offset is changed.

![image](screenshots/offsetChange.png)

Below is a screenshot of the terrain after it has been generated.

![image](screenshots/terrainSC.png)

Next to disscus is the bee which is the player and is made up of a capsule, two cubes and two spheres with a box collider surrounding it instead of a mesh renderer to save a small amount of processing power. The bee is also covered in a material created from a sprite photo which acts as a shader to mimic the colours of a bee. Below is a screenshot of teh materials including the material used for the bee body which is called bStripes.

![image](screenshots/materials.png)

Besides the materials the bee is controlled by a single script which is called beeMove. This script allows for the bee to move side to side within a certain range using the left and right arrow keys which are preset in most versions in unity.

















