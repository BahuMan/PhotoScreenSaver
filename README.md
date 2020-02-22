# PhotoScreenSaver
C# windows screensaves that tries to fill the screen with a few pictures while respecting the aspect ration of each picture

## unfinished.

### Done so far:
* settings form to choose folder with pictures
* loads first 3 pictures from folder
* displays 3 pictures in vertical layout with no regard to aspect ration of pictures :)

### To Do:
* change screen layout based on aspect ratio of pictures to show
* decide on algorithm to fill out screen more-or-less decently
** e.g. don't add a landscape picture when first 2 pictures were already portrait (3 portraits next to each other fill out a 16:9 more or less nicely)
