[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Minjoo Shin, she/her


Write about how the plan you wrote in the MG1 break-down activity connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


In my group's class activity, we decided to use WASD and the arrow keys to move the player character. We decided to use the Update() method in the Player class so that the player's movement can be calculated by each frame. I applied the transform instead of Input.GetKey, since I thought it would make an error if I added all 8 keys in the code. The transform allowed the player character to move without using repetitive code.


On the other hand, I used Input.GetKey to plant seeds as I planned in the document. I instantiated the seed prefab in the Player class, calculating the number of seeds (planted seeds & left seeds). I connected the PlantUI code to Canvas in a hierarchy to display the calculation results as the player plants a seed on the ground. I was able to easily show the number of seeds in text, but I had difficulty with the limit on seeds. My game allowed infinite seeds to be planted, so I added an if statement in the Update method to eventually show only five seeds on the screen.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
