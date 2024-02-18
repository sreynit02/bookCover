# BookCover

## Book Title: Animal Farm
You should have a github page with your code, images of the front and back cover of the book, and a (link to a) video of your code running. The readme.md file should contain a brief description of your code, and how to interact with it. Describe any limitations that your code has. Describe how someone could download your code and get it running.

## Code Description and Interaction 
In this project, I created two target images; one for the front cover of the book and one for the back cover of the book. The target image are linked to the target images that I created in Vuforia Developer Portal. I added 3D models from Unity Asset Store for the front page to show the characters involved in book. For the Title and the Author's name, I created 3D texts and placed them perpendicular to the surface of the book. Foe the back page, I created two TextMeshPro; one for the general information of the book (author, date published, number of pages) and another one for my review of the book. I also created a white plane to cover the letters on the book so those TMP can be seen. For the user interface, I tried the Virtual Button but it was deprecated and that made the button to be unstable (it clicks itself when the application is runnnin) so I decided to not use it (it is grayed out). Then I decided to create two buttons with Render Mode: Screen Space - Overlay which means that it static and stick to a specific place of the screen. One button is for viewing my review of the book and one button is for displaying the general information. A script called "UIController" is called when each of the button is clicked; the script enables or disables the TMP of the Review or general information.

## Limitation 
The limitation of this code is that the virtual button did not work due to the depracation of the package. It would have been cool to be able to interact with a virtual button. There was not animation in the 3D models as the ones I could find were non animated. Having animation would make the visuals much more interesting. 

## Instruction for Usage
1. Clone the repository and open the project in Unity.
2. In Asseet/Scenes, select the scene BookCoverwithUI.
3. Press run.
4. Hold the picture of the front page of the book infront your web camera. The 3D models of the animals, title and the author's name should show up.
5. Hold the picture of the back page of the book in front of your camera. The general information (author, date published, number of pages) should show up. To read the review, click on "Read Review" button located on the bottom left corner of the screen. To display the general information again, click the "BackToInfo" button.
   
## Video Demonstration 
Link: https://drive.google.com/drive/folders/1yN9y_yfrnNYqaz6k7NSu-AXnFOgR3qI0?usp=sharing

## Images 
Link: https://drive.google.com/drive/folders/1yN9y_yfrnNYqaz6k7NSu-AXnFOgR3qI0?usp=sharing

1. Front Cover: Front.JPG
2. Back Cover: Back.JPG

