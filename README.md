# YOLO-TO-AUTOML
 - GUI for converting YOLO annotations to Google AutoML(Google Cloud Vision) CSV File
 - In short, txt Annotations -> csv Table
# Instructions Video
 [![Instructions Video](http://img.youtube.com/vi/kJFPEXG1ZqE/0.jpg)](https://youtu.be/kJFPEXG1ZqE)
 (CLICK TO SEE IT ON YOUTUBE)
# System Requirements
 - Windows >= Vista
 
# How-to-Use
 - Run .exe File
 - Set Parameters on TextBox
   - Check for pre-examples
   - Click link to open file/folder open dialog
 - Click Convert
 
# Parameters Explained
 - Cloud Storage Path
   - *gs://* URI linked to your uploaded image bucket
 - Append for filename
   - Sometimes you get append shits like next thing in filename on google storage
     - The one that you uploaded : 2.jpg
     - The one that Google storage has : 2-2020-03-28T03:01:10.593Z.jpg
   - Leave it blank if you don't need it
 - Your img path
   - You would have made and dataset using LabelImg or whatever.
   - Then what you get is a folder filled with *.jpg*s and *.txt*s.
   - That is the path!
 - Output CSV path
   - Where to save CSV
 - Labelmap
   - your labelmap. this might be classes.txt, predefined_classes.txt or something else.
# Screenshots
![Screenshot#1](./ex.png)
# Download Release
 [here](https://github.com/goraegori/YOLO-TO-AUTOML/releases/download/1.0/Release.zip)
